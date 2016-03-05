namespace HeroesFight.Entities.Commands
{
    using System;

    using HeroesFight.Interfaces;
    using HeroesFight.States;

    public class StartGameCommand : ICommand
    {
        public StartGameCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; private set; }

        public object[] CommandParameters { get; private set; }

        public void Execute(IDatabase database, State currentState)
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
