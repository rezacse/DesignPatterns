using Observer.Subject;

namespace Observer.Observer
{
    public interface IStockObserver
    {
        void Update(IStockTracker stockTracker);
    }
}
