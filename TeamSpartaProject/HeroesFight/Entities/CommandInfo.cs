namespace HeroesFight.Entities
{
    public class CommandInfo
    {
        public CommandInfo(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; private set; }

        public object[] CommandParameters { get; private set; }
    }
}