using Decorator.BookDecorate.Common;

namespace Decorator.BookDecorate
{
    public class BookDecorator : IBook
    {
        public BookDecorator(IBook book)
        {
            Target = book;
        }

        public string Title => Target.Title;
        private IBook Target { get; }

        public virtual Size GetDimensions(Size propaganda)
            => Target.GetDimensions(propaganda);
    }
}
