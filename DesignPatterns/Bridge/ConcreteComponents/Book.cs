using Bridge.Abstraction;
using Bridge.Implementor;
using System;

namespace Bridge.ConcreteComponents
{
    public class Book : Manuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public Book(IFormatter formatter)
            : base(formatter)
        {
        }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format("Title", Title));
            Console.WriteLine(Formatter.Format("Author", Author));
            Console.WriteLine(Formatter.Format("Text", Text));

            Console.WriteLine("---------------------------------");
        }
    }
}
