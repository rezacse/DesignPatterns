using Observer.ConcreteObserver;
using Observer.ConcreteSubject;
using System;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mircosObserver = new MicrosoftStockTracker(120);
            var googleObserver = new GoogleStockTracker(130);

            var firstObserver = new StockObserver();
            var secondObserver = new StockObserver();

            mircosObserver.Register(firstObserver);
            googleObserver.Register(secondObserver);

            mircosObserver.Price = 140;
            googleObserver.Price = 150;

            Console.Read();
        }
    }
}
