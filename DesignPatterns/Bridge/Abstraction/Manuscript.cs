using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class Manuscript
    {
        protected IFormatter Formatter;
        protected Manuscript(IFormatter formatter)
        {
            Formatter = formatter;
        }

        public void SetFormatter(IFormatter formatter)
        {
            Formatter = formatter;
        }

        public abstract void Print();
    }
}
