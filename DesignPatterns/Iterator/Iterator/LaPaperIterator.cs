namespace Iterator.Iterator
{
    public class LaPaperIterator : INewspaperIterator
    {
        private readonly string[] _reporters;
        private int _current;

        public LaPaperIterator(string[] reporters)
        {
            _reporters = reporters;
            _current = 0;

        }

        public bool IsDone()
        {
            return _current >= _reporters.Length;
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
