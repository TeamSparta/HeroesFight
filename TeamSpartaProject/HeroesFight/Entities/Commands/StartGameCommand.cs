namespace HeroesFight.Entities.Commands
{
    #region

    using System;

    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class StartGameCommand : ICommand
    {
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            var startGameState = currentState as StartGameState;
            if (startGameState == null)
            {
                throw new ArgumentException("Not expected state was passed!");
            }

            startGameState.StartGameButton.Visible = false;
            startGameState.ExitGameButton.Visible = false;

            startGameState.EnterYourNameLabel.Visible = true;
            startGameState.PlayerNameTextBox.Visible = true;
            startGameState.ContinueButton.Visible = true;
        }
    }
}