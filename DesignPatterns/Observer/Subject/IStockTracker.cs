using Observer.Observer;

namespace Observer.Subject
{
    public interface IStockTracker
    {
        string Symbol { get; }
        double Price { get; set; }
        void Register(IStockObserver stockObserver);
        void Unregister(IStockObserver stockObserver);
        void Notify();
    }
}
