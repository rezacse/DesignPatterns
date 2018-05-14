using Proxy.LazyLoad.Repositories;
using System.Collections.Generic;

namespace Proxy.LazyLoad.Models
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int id)
        {
            var customerEntity = new CustomerRepository().GetById(id);
            Name = customerEntity.Name;
        }

        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
