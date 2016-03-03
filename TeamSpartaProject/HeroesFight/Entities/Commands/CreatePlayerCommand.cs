namespace HeroesFight.Entities.Commands
{
    using Interfaces;
    using States;

    public class CreatePlayerCommand : ICommand
    {
        public CreatePlayerCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDataBase database, State currentState)
        {
            // ToDo: Implement create player logic.
        }
    }
}
