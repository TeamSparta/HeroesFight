namespace HeroesFight.Interfaces
{
    public interface ICommandDispatcher
    {
        IDatabase Database { get; }

        void ProcessCommand(string commandName, object[] commandParameters);
    }
}