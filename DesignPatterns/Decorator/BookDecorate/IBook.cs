using Decorator.BookDecorate.Common;

namespace Decorator.BookDecorate
{
    public interface IBook
    {
        string Title { get; }
        Size GetDimensions(Size propaganda);
    }
}
