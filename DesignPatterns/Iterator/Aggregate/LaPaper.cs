using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public class LaPaper : INewspaper
    {
        private readonly string[] _reporters;
        public LaPaper()
        {
            _reporters = new[] { "Ronald Smith - LA",
                "Danny Glover - LA",
                "Yolanda Adams - LA",
                "Jerry Straight - LA",
                "Rhonda Lime - LA",
            };
        }

        public INewspaperIterator CreateNewspaperIterator()
        {
            return new LaPaperIterator(_reporters);
        }
    }
}
