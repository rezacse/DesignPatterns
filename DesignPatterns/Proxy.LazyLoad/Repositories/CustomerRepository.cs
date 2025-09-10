using Proxy.LazyLoad.Entities;
using System;

namespace Proxy.LazyLoad.Repositories
{
    public class CustomerRepository : Repository<CustomerEntity>
    {
        public override CustomerEntity GetById(int id)
        {
            Console.WriteLine("--> Fetching Customer " + id);
            return new CustomerEntity
            {
                Id = id,
                Name = "Customer " + id
            };
        }
    }
}
