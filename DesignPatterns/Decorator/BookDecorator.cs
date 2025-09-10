using Decorator.Common;

namespace Decorator
{
    public class BookDecorator : IBook
    {
        public BookDecorator(IBook book)
        {
            this.Target = book;
        }

        public string Title => this.Target.Title;
        private IBook Target { get; }

        public virtual Size GetDimensions(Size propaganda)
            => Target.GetDimensions(propaganda);
    }
}
