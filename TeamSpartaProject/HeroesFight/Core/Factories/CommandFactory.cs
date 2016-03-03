namespace HeroesFight.Core.Factories
{
    using Commands;
    using Interfaces;
    using Utilities;

    public class CommandFactory : ICommandFactory
    {
        public virtual ICommand CreateCommand(CommandInfo commandInfo)
        {
            ICommand command = null;
            switch (commandInfo.CommandName)
            {
                case Constants.StartGameCommandName:
                    command = new StartGameCommand();
                    break;
                case Constants.EndGameCommandName:
                    command = new ExitGameCommand();
                    break;
            }

            return command;
        }
    }
}
