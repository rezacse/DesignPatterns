using Decorator.BookDecorate.Common;

namespace Decorator.BookDecorate
{
    public class Book : IBook
    {
        public Book(string title, Size dimensions)
        {
            Title = title;
            Dimensions = dimensions;
        }

        protected Book(Book book) : this(book.Title, book.Dimensions)
        {
        }

        public string Title { get; }
        public Size Dimensions { get; }

        public Size GetDimensions(Size propaganda)
            => Dimensions.AddToTop(propaganda);

        public override string ToString()
            => $"{Title} ({Dimensions})";
    }
}
