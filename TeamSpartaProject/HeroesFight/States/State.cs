namespace HeroesFight
{
    using System.Windows.Forms;

    using HeroesFight.Core;

    public class State : Form
    {
        private CommandInfo commandInfo;

        public CommandInfo CommandInfo
        {
            get
            {
                if (this.IsInputInserted)
                {
                    return this.commandInfo;
                }

                return null;
            }

            protected set
            {
                this.IsInputInserted = true;
                this.commandInfo = value;
            }
        }

        public bool IsInputInserted { get; private set; }

        protected void SetCommandInfo(string commandName, object[] commandParameters)
        {
            this.CommandInfo = new CommandInfo(commandName, commandParameters);
        }
    }
}
