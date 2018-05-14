using Proxy.LazyLoad.Repositories;

namespace Proxy.LazyLoad.Models
{
    public class OrderDetails
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public OrderDetails()
        {

        }
        public OrderDetails(int id)
        {
            var orderDetailsEntity = new OrderDetailsRepository().GetById(id);
            Name = orderDetailsEntity.Name;
            Price = orderDetailsEntity.Price;
        }
    }
}