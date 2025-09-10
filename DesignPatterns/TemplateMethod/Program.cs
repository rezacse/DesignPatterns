using System;
using TemplateMethod.Abstract;
using TemplateMethod.Concrete;

namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Process PDF");
            Console.WriteLine("------------------");
            DocumentReader reader = new PdfDocument();
            reader.OpenDocument();


            Console.WriteLine("\nProcess RTF");
            Console.WriteLine("------------------");
            reader = new RtfDocument();
            reader.OpenDocument();


            Console.ReadKey();
        }
    }
}
