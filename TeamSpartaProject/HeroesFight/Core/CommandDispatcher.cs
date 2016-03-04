namespace HeroesFight.Core
{
    using HeroesFight.Entities;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    public class CommandDispatcher : ICommandDispatcher
    {
        public CommandDispatcher(IDatabase database, ICommandFactory commandFactory)
        {
            this.CommandFactory = commandFactory;
            this.Database = database;
        }

        public IDatabase Database { get; private set; }

        public ICommandFactory CommandFactory { get; private set; }

        public void ProcessCommand(string commandName, object[] commandParameters)
        {
            var commandInfo = new CommandInfo(commandName, commandParameters);

            // Parses the input and transforms it into a command.
            var command = this.CommandFactory.CreateCommand(commandInfo);

            // Executes command and updates the database.
            command.Execute(this.Database, StateManager.CurrentState);
        }
    }
}
