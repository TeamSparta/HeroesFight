namespace HeroesFight.Entities.Commands
{
    #region

    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;
    using HeroesFight.Utilities;

    #endregion

    public class UpdateCommand : ICommand
    {
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            if (!database.Player.IsAlive)
            {
                StateManager.ChangeCurrentState(StateEnum.ExitGameState);
            }
            else if (!database.GetCurrentLevelEnemy().IsAlive && database.CurrentState != StateEnum.FirstLevelRoundThreeState)
            {
                database.Update();
                StateManager.ChangeCurrentState(database.CurrentState);
            }
            else if (!database.GetCurrentLevelEnemy().IsAlive && database.CurrentState == StateEnum.FirstLevelRoundThreeState)
            {
                StateManager.ChangeCurrentState(StateEnum.ExitGameState);
            }
            else
            {
                currentState.Draw();
            }
        }
    }
}