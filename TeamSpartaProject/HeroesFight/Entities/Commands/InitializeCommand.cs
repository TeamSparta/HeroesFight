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
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            currentState.Initialize();
        }
    }
}