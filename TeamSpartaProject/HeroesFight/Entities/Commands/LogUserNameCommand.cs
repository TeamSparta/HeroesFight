namespace HeroesFight.Entities.Commands
{
    #region

    using HeroesFight.Enums;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class LogUserNameCommand : ICommand
    {
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            string playerName = commandInfo.CommandParameters[0].ToString();
            database.AddPlayerName(playerName);
            StateManager.ChangeCurrentState(StateEnum.PickCharacterState);
        }
    }
}