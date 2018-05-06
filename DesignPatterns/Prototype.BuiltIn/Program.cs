using System;

namespace Prototype.BuiltIn
{
    internal class Program
    {
        private static void Main()
        {
            const string webUrl = "http://www.google.com";
            var reader = new BuiltInWebPageReader(webUrl);
            reader.PrintPageInfo();


            if (reader.Clone() is BuiltInWebPageReader cloneReader)
                cloneReader.PrintPageInfo();

            Console.ReadKey();
        }
    }
}
