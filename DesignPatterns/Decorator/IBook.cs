using Decorator.Common;

namespace Decorator
{
    public interface IBook
    {
        string Title { get; }
        Size GetDimensions(Size propaganda);
    }
}
