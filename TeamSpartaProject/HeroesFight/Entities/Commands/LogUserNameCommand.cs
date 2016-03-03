﻿namespace HeroesFight.Commands
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using HeroesFight.Core;
    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;
    using HeroesFight.Utilities;

    public class LogUserNameCommand : ICommand
    {
        public LogUserNameCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDataBase database, State currentState)
        {
            currentState = currentState as StartGameState;
            if (currentState == null)
            {
                throw new InvalidStateException();
            }

            Regex nameRegex = new Regex(@"([\w]+){3,20}$");
            string playerName = (currentState as StartGameState).PlayerNameTextBox.Text;
            database.PlayerName = playerName;
            if (!nameRegex.IsMatch(playerName))
            {
                MessageBox.Show(
                    @"Name should be between 3 and 20 characters long and should consist only letters and digits. Please try again!");
                    (currentState as StartGameState).PlayerNameTextBox.Clear();
            }
            else
            {
                StateManager.ChangeCurrentState(StateEnum.PickClassState);
            }
        }
    }
}