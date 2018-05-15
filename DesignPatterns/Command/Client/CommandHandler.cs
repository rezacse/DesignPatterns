using Command.Command;
using Command.ConcreteCommand;
using System;
using System.Collections.Generic;

namespace Command.Client
{
    public class CommandHandler
    {
        public void Run(string[] args)
        {
            var availabeCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                PrintUsage(availabeCommands);
                return;
            }

            var parser = new CommandParser(availabeCommands);
            var command = parser.ParseCommand(args);

            command?.Execute();
        }

        private IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                new UpdateQuantityCommand(),
                new ShipOrderCommand()
            };
        }

        private void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: Command Name Arguments");
            Console.WriteLine("Commands:");
            foreach (var availableCommand in availableCommands)
            {
                Console.WriteLine($" {availableCommand.Description}");
            }
        }
    }
}
