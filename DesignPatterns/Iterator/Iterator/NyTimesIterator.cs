using System.Collections.Generic;

namespace Iterator.Iterator
{
    public class NyTimesIterator : INewspaperIterator
    {
        private readonly List<string> _reporters;
        private int _current;

        public NyTimesIterator(List<string> reporters)
        {
            _reporters = reporters;
            _current = 0;

        }

        public bool IsDone()
        {
            return _current >= _reporters.Count;
        }

        public void First()
        {
            _current = 0;
        }

        public string Next()
        {
            return _reporters[_current++];
        }

        public string CurrentItem()
        {
            return _reporters[_current];
        }
    }
}
