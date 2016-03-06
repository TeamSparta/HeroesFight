namespace HeroesFight.Core.Factories
{
    #region

    using System;

    using HeroesFight.Entities;
    using HeroesFight.Entities.Commands;
    using HeroesFight.Interfaces;
    using HeroesFight.Utilities;

    #endregion

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
                case Constants.InitializeLevelOneCommandName:
                    command = new InitializeLevelOneCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                case Constants.AttackCommandName:
                    command = new AttackCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                case Constants.UpdateCommandName:
                    command = new UpdateCommand(commandInfo.CommandName, commandInfo.CommandParameters);
                    break;
                default:
                    throw new ArgumentException("Command not supported!");
            }

            return command;
        }
    }
}