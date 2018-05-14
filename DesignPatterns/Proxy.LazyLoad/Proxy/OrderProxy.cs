using Proxy.LazyLoad.Models;
using System;
using System.Collections.Generic;

namespace Proxy.LazyLoad.Proxy
{
    public class OrderProxy : Order
    {
        public OrderProxy(int id)
        {
            ID = id;
        }
        private bool _customerLoaded;
        private bool _entityLoaded;
        private bool _itemsLoaded;
        private Customer _customer;
        private List<OrderDetails> _orderDetails;


        public override DateTime OrderDate
        {
            get
            {
                GetEntity();
                return OrderEntity.OrderDate;
            }
        }

        public override Customer Customer => GetCustomer();

        public override List<OrderDetails> Items => GetItems();

        protected override void GetEntity()
        {
            if (_entityLoaded) return;

            base.GetEntity();
            _entityLoaded = true;
        }

        protected override Customer GetCustomer()
        {
            if (_customerLoaded) return _customer;

            GetEntity();
            _customer = base.GetCustomer();
            _customerLoaded = true;
            return _customer;
        }

        protected override List<OrderDetails> GetItems()
        {
            if (_itemsLoaded) return _orderDetails;

            GetEntity();
            _orderDetails = base.GetItems();
            _itemsLoaded = true;
            return _orderDetails;
        }
    }
}
