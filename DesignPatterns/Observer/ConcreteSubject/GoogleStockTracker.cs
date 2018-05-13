using Observer.Observer;
using Observer.Subject;
using System.Collections.Generic;

namespace Observer.ConcreteObserver
{
    public class GoogleStockTracker : IStockTracker
    {
        private readonly List<IStockObserver> _stockObservers = new List<IStockObserver>();

        public GoogleStockTracker(double price)
        {
            Price = price;
        }

        public string Symbol => "Google";
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                Notify();
            }
        }

        public void Register(IStockObserver stockObserver)
        {
            if (!_stockObservers.Contains(stockObserver))
                _stockObservers.Add(stockObserver);
        }

        public void Unregister(IStockObserver stockObserver)
        {
            if (_stockObservers.Contains(stockObserver))
                _stockObservers.Remove(stockObserver);
        }

        public void Notify()
        {
            foreach (var stockObserber in _stockObservers)
            {
                stockObserber.Update(this);
            }
        }
    }
}
