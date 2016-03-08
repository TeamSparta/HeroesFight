namespace HeroesFight.Entities.Commands
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class InitializeCommand : ICommand
    {
        public InitializeCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDatabase database, State currentState)
        {
            currentState.Initialize();
        }
    }
}