using Iterator.Aggregate;
using Iterator.Iterator;
using System;

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            INewspaper nyp = new NyTimesPaper();
            INewspaper lap = new LaPaper();

            INewspaperIterator nypIterator = nyp.CreateNewspaperIterator();
            INewspaperIterator lapIterator = lap.CreateNewspaperIterator();

            Console.WriteLine("--------   NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        static void PrintReporters(INewspaperIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
