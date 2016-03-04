namespace HeroesFight.Entities.Commands
{
    using System.Windows.Forms;

    using HeroesFight.Interfaces;
    using HeroesFight.States;

    public class ExitGameCommand : ICommand
    {
        public ExitGameCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDatabase database, State currentState)
        {
            Application.Exit();
        }
    }
}
