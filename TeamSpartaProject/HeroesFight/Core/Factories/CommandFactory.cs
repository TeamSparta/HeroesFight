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
        public virtual ICommand CreateCommand(string commandName)
        {
            ICommand command;
            switch (commandName)
            {
                case Constants.StartGameCommandName:
                    command = new StartGameCommand();
                    break;
                case Constants.EndGameCommandName:
                    command = new ExitGameCommand();
                    break;
                case Constants.LogUserNameCommandName:
                    command = new LogUserNameCommand();
                    break;
                case Constants.CreatePlayerCommandName:
                    command = new CreatePlayerCommand();
                    break;
                case Constants.InitializeLevelCommandName:
                    command = new InitializeCommand();
                    break;
                case Constants.AttackCommandName:
                    command = new AttackCommand();
                    break;
                case Constants.UpdateCommandName:
                    command = new UpdateCommand();
                    break;
                case Constants.EnemyAttackCommandName:
                    command = new EnemyAttackCommand();
                    break;
                default:
                    throw new ArgumentException("Command not supported!");
            }

            return command;
        }
    }
}