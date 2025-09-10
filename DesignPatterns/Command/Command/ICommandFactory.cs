namespace Command.Command
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Description { get; }

        ICustomCommand MakeCommand(string value);
    }
}
