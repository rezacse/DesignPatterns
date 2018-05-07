using System;

namespace Prototype.BuiltIn
{
    public class BuiltInWebPageReader : ICloneable
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }


        public BuiltInWebPageReader(string url)
        {
            //var client = new WebClient();
            //var pageContent = client.DownloadString(url);
            var pageContent = "";
            ReadCopntent(pageContent);
        }

        private void ReadCopntent(string pageContent)
        {
            Title = "Read Title";
            Header = "Read Header";
            Body = "Read Body Content";
        }

        public void PrintPageInfo()
        {
            Console.WriteLine($"Title: {Title}, Header: {Header}, Body: {Body}");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
