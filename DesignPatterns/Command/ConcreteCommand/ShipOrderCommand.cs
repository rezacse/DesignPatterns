using Command.Command;
using System;

namespace Command.ConcreteCommand
{
    public class ShipOrderCommand : ICustomCommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("");
        }

        public string CommandName => "ShipOrder";
        public string Description => "ShipOrder Description";

        public ICustomCommand MakeCommand(string value)
        {
            return new ShipOrderCommand();
        }
    }
}
