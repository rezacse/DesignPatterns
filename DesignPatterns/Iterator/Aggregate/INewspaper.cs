using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public interface INewspaper
    {
        INewspaperIterator CreateNewspaperIterator();
    }
}