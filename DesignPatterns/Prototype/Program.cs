using System;

namespace PrototypeWithoutBuiltIn
{
    class Program
    {
        static void Main(string[] args)
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
