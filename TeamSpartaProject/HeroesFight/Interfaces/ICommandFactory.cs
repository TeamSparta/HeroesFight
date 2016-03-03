namespace HeroesFight.Interfaces
{
    using HeroesFight.Core;

    public interface ICommandFactory
    {
        ICommand CreateCommand(CommandInfo commandInfo);
    }
}
