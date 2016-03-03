namespace HeroesFight.Commands
{
    using System;

    using Interfaces;
    using States;

    public class StartGameCommand : ICommand
    {
        public StartGameCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

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
