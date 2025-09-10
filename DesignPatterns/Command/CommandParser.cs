using Command.Command;
using Command.ConcreteCommand;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _availableCommands;
        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            _availableCommands = availableCommands;
        }

        internal ICustomCommand ParseCommand(string[] args)
        {
            var requestCommandName = args[0];
            var command = FindRequestedCommand(requestCommandName);

            return command == null ? new NotFoundCommand { Name = requestCommandName } : command.MakeCommand(args[1]);
        }

        private ICommandFactory FindRequestedCommand(string commandName)
        {
            return _availableCommands.FirstOrDefault(cmd => cmd.CommandName == commandName);
        }
    }
}
