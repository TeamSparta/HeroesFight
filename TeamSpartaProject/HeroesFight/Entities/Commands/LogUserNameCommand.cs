namespace HeroesFight.Entities.Commands
{
    #region

    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;
    using HeroesFight.Utilities;

    #endregion

    public class LogUserNameCommand : ICommand
    {
        public LogUserNameCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; private set; }

        public object[] CommandParameters { get; private set; }

        public void Execute(IDatabase database, State currentState)
        {
            currentState = currentState as StartGameState;
            if (currentState == null)
            {
                throw new InvalidStateException();
            }

            string playerName = this.CommandParameters[0].ToString();
            database.AddPlayerName(playerName);
            StateManager.ChangeCurrentState(StateEnum.PickCharacterState);
        }
    }
}