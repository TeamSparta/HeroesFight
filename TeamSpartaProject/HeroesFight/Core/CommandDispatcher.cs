namespace HeroesFight.Core
{
    using HeroesFight.Interfaces;

    public class CommandDispatcher : ICommandDispatcher
    {
        public CommandDispatcher(IDataBase dataBase, ICommandFactory commandFactory)
        {
            this.CommandFactory = commandFactory;
            this.DataBase = dataBase;
        }

        public IDataBase DataBase { get; private set; }

        public ICommandFactory CommandFactory { get; private set; }

        public void ProcessCommand(string commandName, object[] commandParameters, State currentState)
        {
            var commandInfo = new CommandInfo(commandName, commandParameters);

            // Parses the input and transforms it into a command.
            var command = this.CommandFactory.CreateCommand(commandInfo);

            // Executes command and updates the database.
            command.Execute(this.DataBase, currentState);
        }
    }
}
