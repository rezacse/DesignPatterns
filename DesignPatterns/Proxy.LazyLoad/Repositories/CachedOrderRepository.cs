using Proxy.LazyLoad.Entities;
using System.Runtime.Caching;

namespace Proxy.LazyLoad.Repositories
{
    public class CachedOrderRepository : OrderRepository
    {
        public override OrderEntity GetById(int id)
        {
            var cacheKey = "OrderEntity-" + id;
            if (MemoryCache.Default[cacheKey] is OrderEntity entity)
                return entity;

            entity = base.GetById(id);
            var cacheItem = new CacheItem(cacheKey, entity);
            var policy = new CacheItemPolicy();
            MemoryCache.Default.Add(cacheItem, policy);

            return entity;
        }
    }
}
