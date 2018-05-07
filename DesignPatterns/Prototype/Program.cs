using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main()
        {
            const string webUrl = "http://www.google.com";
            var reader = new WebPageReader(webUrl);
            reader.PrintPageInfo();


            if (reader.Clone() is WebPageReader cloneReader)
                cloneReader.PrintPageInfo();

            Console.ReadKey();
        }
    }
}
