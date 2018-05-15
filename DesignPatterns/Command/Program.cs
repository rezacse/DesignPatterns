using Command.Client;
using System;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commandHandler = new CommandHandler();

            args = new[] { "UpdateQuantity", "20" };
            commandHandler.Run(args);


            args = new[] { "NotMatch", "20" };
            commandHandler.Run(args);


            Console.ReadKey();
        }
    }
}
