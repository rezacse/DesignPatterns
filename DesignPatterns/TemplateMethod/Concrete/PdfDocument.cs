using System;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    public class PdfDocument : DocumentReader
    {
        public override void GetDocumentFormat()
        {
            Console.WriteLine("Process PDF document here with interpreter");
        }
    }
}
