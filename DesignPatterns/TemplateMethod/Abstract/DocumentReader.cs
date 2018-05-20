using System;

namespace TemplateMethod.Abstract
{
    public abstract class DocumentReader
    {
        public void Load()
        {
            Console.WriteLine("Load Document from path");
        }

        public abstract void GetDocumentFormat();

        public void Open()
        {
            Console.WriteLine("Open Document");
        }


        /// <summary>
        /// Template Method
        /// </summary>
        public void OpenDocument()
        {
            Load();
            GetDocumentFormat();
            Open();
        }
    }
}
