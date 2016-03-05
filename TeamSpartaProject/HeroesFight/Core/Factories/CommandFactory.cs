namespace HeroesFight.Core.Factories
{
    using System;

    using HeroesFight.Entities;
    using HeroesFight.Entities.Commands;

    using Interfaces;
    using Utilities;

    public class CommandFactory : ICommandFactory
    {
        public virtual ICommand CreateCommand(CommandInfo commandInfo)
        {
            ICommand command;
            switch (commandInfo.CommandName)
            {
                case Constants.StartGameCommandName:
                    command = new StartGameCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                case Constants.EndGameCommandName:
                    command = new ExitGameCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                case Constants.LogUserNameCommandName:
                    command = new LogUserNameCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                case Constants.CreatePlayerCommandName:
                    command = new CreatePlayerCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                default:
                    throw new ArgumentException("Command not supported!");
            }

            return command;
        }
    }
}
