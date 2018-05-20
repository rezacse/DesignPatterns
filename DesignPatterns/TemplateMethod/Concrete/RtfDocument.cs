using System;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    public class RtfDocument : DocumentReader
    {
        public override void GetDocumentFormat()
        {
            Console.WriteLine("Process RTF document here with interpreter");
        }
    }
}
