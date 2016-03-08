namespace HeroesFight.Entities.Commands
{
    #region

    using System.Windows.Forms;

    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class ExitGameCommand : ICommand
    {
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            Application.Exit();
        }
    }
}