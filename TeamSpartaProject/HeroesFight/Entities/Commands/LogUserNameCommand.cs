namespace HeroesFight.Entities.Commands
{
    #region

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;
    using HeroesFight.Utilities;

    #endregion

    public class LogUserNameCommand : ICommand
    {
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            currentState = currentState as StartGameState;
            if (currentState == null)
            {
                throw new InvalidStateException();
            }

            string playerName = commandInfo.CommandParameters[0].ToString();
            database.AddPlayerName(playerName);
            StateManager.ChangeCurrentState(StateEnum.PickCharacterState);
        }
    }
}