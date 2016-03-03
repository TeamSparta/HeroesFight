namespace HeroesFight.Interfaces
{
    public interface ICommandDispatcher
    {
        void ProcessCommand(string commandName, object[] commandParameters, State currentState);
    }
}
