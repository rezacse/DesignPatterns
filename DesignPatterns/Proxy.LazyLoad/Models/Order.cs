using Proxy.LazyLoad.Entities;
using Proxy.LazyLoad.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy.LazyLoad.Models
{
    public class Order
    {
        public virtual DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        protected OrderEntity OrderEntity;
        public virtual List<OrderDetails> Items { get; set; }

        protected int ID;
        public int Id => ID;

        public Order()
        {
        }

        public Order(int id)
        {
            ID = id;
            GetEntity();
            OrderDate = OrderEntity.OrderDate;
            Customer = GetCustomer();
            Items = GetItems();
        }

        protected virtual void GetEntity()
        {
            OrderEntity = new OrderRepository().GetById(Id);
        }

        protected virtual Customer GetCustomer()
        {
            return new Customer(OrderEntity.CustomerId);
        }

        protected virtual List<OrderDetails> GetItems()
        {
            return OrderEntity.OrderDetails.
                Select(orderDetailId => new OrderDetails(orderDetailId))
                .ToList();
        }
    }
}
