using System;

namespace PrototypeWithoutBuiltIn
{
    public class WebPageReader : WebPageReaderPrototype
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }


        public WebPageReader(string url)
        {
            //var client = new WebClient();
            //var pageContent = client.DownloadString(url);
            var pageContent = "";
            ReadCopntent(pageContent);
        }

        private void ReadCopntent(string downloadString)
        {
            Title = "Read Title";
            Header = "Read Header";
            Body = "Read Body Content";
        }

        public void PrintPageInfo()
        {
            Console.WriteLine($"Title: {Title}, Header: {Header}, Body: {Body}");
        }

        public override WebPageReaderPrototype Clone()
        {
            return MemberwiseClone() as WebPageReaderPrototype;
        }
    }
}
