using System;

namespace Memento
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Set State: state = {state}");
            _state = state;
        }

        public Memento CreateMemento()
        {
            Console.WriteLine($"Create Memento: state = {_state}");
            return new Memento(_state);
        }

        public void RestoreMemento(Memento memento)
        {
            _state = memento.GetState;
            Console.WriteLine($"Restore Memento: state = {_state}");
        }

    }
}
