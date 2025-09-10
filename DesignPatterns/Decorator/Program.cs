// See https://aka.ms/new-console-template for more information


using Decorator;
using Decorator.Common;

var mm = Length.Millimeter;
IBook bareBook = new Book("Design Patterns", new Size(188M * mm, 239M * mm, 28M * mm));
IBook book = new TwoPack(bareBook);

BookHandler buyer = new BookHandler();
buyer.Handle(book);


IBook wrappedBook = new WrappedBook(book);
BookHandler dispatcher = new BookHandler();
dispatcher.Handle(wrappedBook);

wrappedBook = new WrappedBook(book);
dispatcher.Handle(wrappedBook);


