namespace Memento
{
    public class Caretaker
    {
        //List<Memento> savedStatements = new List<Memento>();

        //public void AddMemento(Memento memento)
        //{
        //    savedStatements.Add(memento);
        //}

        //public Memento GetMemento(int index)
        //{
        //    if (index > -1 && savedStatements.Count < index)
        //    {
        //        return savedStatements[index];
        //    }
        //    return new Memento(string.Empty);
        //}

        public Memento Memento { get; private set; }
        public void SetMemento(Memento memento)
        {
            Memento = memento;
        }

    }
}
