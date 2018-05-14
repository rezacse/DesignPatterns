using Proxy.LazyLoad.Entities;
using System;

namespace Proxy.LazyLoad.Repositories
{
    public class OrderRepository : Repository<OrderEntity>
    {
        public override OrderEntity GetById(int id)
        {
            Console.WriteLine("--> Fetching Order " + id);
            return new OrderEntity
            {
                Id = id,
                CustomerId = 1,
                OrderDetails = new[] { 1, 2, 3 },
                OrderDate = DateTime.Now
            };
        }
    }
}