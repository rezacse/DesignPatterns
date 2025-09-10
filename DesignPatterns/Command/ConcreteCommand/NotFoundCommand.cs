using Command.Command;
using System;

namespace Command.ConcreteCommand
{
    public class NotFoundCommand : ICustomCommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("Couldn't find command: " + Name);
        }
    }
}