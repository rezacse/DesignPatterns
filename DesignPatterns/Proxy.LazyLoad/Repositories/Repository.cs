namespace Proxy.LazyLoad.Repositories
{
    public abstract class Repository<T>
    {
        public abstract T GetById(int id);
    }
}
