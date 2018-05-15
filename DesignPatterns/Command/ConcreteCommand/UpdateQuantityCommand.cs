using Command.Command;
using System;

namespace Command.ConcreteCommand
{
    public class UpdateQuantityCommand : ICustomCommand, ICommandFactory
    {
        public int NewQuantity { get; set; }
        public void Execute()
        {
            //fetch from database or other source
            const int oldQuantity = 5;
            Console.WriteLine("Update Database");

            //log the update by who
            Console.WriteLine($"Log: update quantity from {oldQuantity} to {NewQuantity}");
        }

        public string CommandName => "UpdateQuantity";
        public string Description => "UpdateQuantity Number";

        public ICustomCommand MakeCommand(string value)
        {
            return new UpdateQuantityCommand { NewQuantity = int.Parse(value) };
        }
    }
}
