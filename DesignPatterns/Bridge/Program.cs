using Bridge.ConcreteComponents;
using Bridge.RefinedAbstractions;
using System;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var standardFormmater = new StandardFormatter();

            var book = new Book(standardFormmater)
            {
                Title = "Book Title",
                Author = "Book Author",
                Text = "Book text ..."
            };


            var termPaper = new TermPaper(standardFormmater)
            {
                Class = "Class Name",
                Student = "Student Name",
                Text = "Book text ...",
                References = "Paper References"
            };


            Console.WriteLine("----------------STANDARD FORMMATER----------------------------");
            book.Print();
            termPaper.Print();


            Console.WriteLine("----------------STANDARD FORMMATER----------------------------");
            var reverseFormmater = new ReverseFormatter();
            book.SetFormatter(reverseFormmater);
            book.Print();

            termPaper.SetFormatter(reverseFormmater);
            termPaper.Print();

            Console.ReadKey();
        }
    }
}
