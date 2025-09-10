// See https://aka.ms/new-console-template for more information


using Decorator.BookDecorate;
using Decorator.BookDecorate.Common;

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


// ﻿using Decorator.Component;
// using Decorator.ConcreteComponent;
// using Decorator.ConcreteDecorator;
// using System;

// namespace Decorator
// {
//     public class Program
//     {
//         private static void Main()
//         {

//             Pizza largePizza = new LargePizza();
//             largePizza = new Cheese(largePizza);
//             largePizza = new Ham(largePizza);
//             largePizza = new Peppers(largePizza);


//             Console.WriteLine($"Pizza Description: {largePizza.GetDescription()}");
//             Console.WriteLine($"Pizza Price: {largePizza.GetPrice()}");

//             Console.ReadKey();
//         }
//     }
// }
