using Proxy.LazyLoad.Proxy;
using Proxy.LazyLoad.Repositories;
using System;

namespace Proxy.LazyLoad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myOrder = new OrderProxy(1);
            ConsoleReporting.PrintOrderDetails(myOrder);

            Console.WriteLine("Again: " + myOrder.Customer.Name);
            foreach (var item in myOrder.Items)
            {
                Console.WriteLine("Item: " + item.Name);
            }


            var orderEntity1 = new CachedOrderRepository().GetById(1);
            var orderEntity2 = new CachedOrderRepository().GetById(1);
            var orderEntity3 = new CachedOrderRepository().GetById(1);


            Console.ReadKey();
        }
    }
}
