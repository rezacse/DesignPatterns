using Observer.Observer;
using Observer.Subject;
using System;

namespace Observer.ConcreteObserver
{
    public class StockObserver : IStockObserver
    {
        public void Update(IStockTracker stockTracker)
        {
            Console.WriteLine($"Observer of {stockTracker.Symbol} has been notified for price of {stockTracker.Price}");
        }
    }
}