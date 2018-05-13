namespace Iterator.Iterator
{
    public interface INewspaperIterator
    {
        bool IsDone();
        void First();
        string Next();
        string CurrentItem();
    }
}
