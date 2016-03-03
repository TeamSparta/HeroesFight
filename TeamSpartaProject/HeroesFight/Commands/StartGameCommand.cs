namespace HeroesFight.Commands
{
    using System;

    using Interfaces;
    using States;

    public class StartGameCommand : ICommand
    {
        public void Execute(IDataBase database, State currentState)
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
