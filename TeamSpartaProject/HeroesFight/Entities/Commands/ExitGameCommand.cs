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

        public string CommandName { get; private set; }

        public object[] CommandParameters { get; private set; }

        public void Execute(IDatabase database, State currentState)
        {
            Application.Exit();
        }
    }
}
