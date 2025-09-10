using System;

namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var originator = new Originator();

            var state = "ON";
            originator.SetState(state);

            var caretaker = new Caretaker();
            caretaker.SetMemento(originator.CreateMemento());

            state = "OFF";
            originator.SetState(state);
            originator.RestoreMemento(caretaker.Memento);


            Console.ReadKey();
        }
    }
}
