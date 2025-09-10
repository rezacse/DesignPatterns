using Iterator.Iterator;
using System.Collections.Generic;

namespace Iterator.Aggregate
{
    public class NyTimesPaper : INewspaper
    {
        private readonly List<string> _reporters;
        public NyTimesPaper()
        {
            _reporters = new List<string>
            {"John Mesh - NY",
                "Susanna Lee - NY",
                "Paul Randy - NY",
                "Kim Fields - NY",
                "Sky Taylor - NY"
            };
        }

        public INewspaperIterator CreateNewspaperIterator()
        {
            return new NyTimesIterator(_reporters);
        }
    }
}