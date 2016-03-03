namespace HeroesFight.Core.Factories
{
    using HeroesFight.Interfaces;

    public class CommandFactory : ICommandFactory
    {
        public virtual ICommand CreateCommand(CommandInfo commandInfo)
        {
            ICommand command = null;
            switch (commandInfo.CommandName)
            {
                    // ToDo: Create commands.
            }

            return command;
        }
    }
}
