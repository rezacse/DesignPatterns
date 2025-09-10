using Proxy.LazyLoad.Models;
using System;
using System.Collections.Generic;

namespace Proxy.LazyLoad.Proxy
{
    public class LazyOrder : Order
    {
        private readonly Lazy<Customer> _customer;
        private readonly Lazy<List<OrderDetails>> _items;

        public LazyOrder(int id)
        {
            GetEntity();
            OrderDate = OrderEntity.OrderDate;
            //_customer = new Lazy<Customer>(GetCustomer);
            _customer = new Lazy<Customer>(() => new Customer(OrderEntity.CustomerId));
            _items = new Lazy<List<OrderDetails>>(GetItems);
        }

        public override Customer Customer => _customer.Value;

        public override List<OrderDetails> Items => _items.Value;
    }
}