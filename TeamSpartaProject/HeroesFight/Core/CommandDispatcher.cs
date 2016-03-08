namespace HeroesFight.Core
{
    #region

    using HeroesFight.Entities;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class CommandDispatcher : ICommandDispatcher
    {
        public CommandDispatcher(IDatabase database)
        {
            this.Database = database;
        }

        public IDatabase Database { get; }

        public void ProcessCommand(string commandName, object[] commandParameters)
        {
            var commandInfo = new CommandInfo(commandName, commandParameters);

            // TODO: may be unnecessary to create a new command every time, especially for attack commands for example, that repeat multiple times.
            // Parses the input and transforms it into a command.
            var command = this.Database.CommandFactory.CreateCommand(commandInfo);

            // Executes command and updates the database.
            command.Execute(this.Database, StateManager.CurrentState);
        }
    }
}