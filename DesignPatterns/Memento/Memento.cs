namespace Memento
{
    public class Memento
    {
        public string GetState { get; }
        public Memento(string state)
        {
            GetState = state;
        }
    }
}
