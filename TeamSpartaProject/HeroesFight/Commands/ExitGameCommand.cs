namespace HeroesFight.Commands
{
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    public class ExitGameCommand : ICommand
    {
        public void Execute(IDataBase database, State currentState)
        {
            Application.Exit();
        }
    }
}
