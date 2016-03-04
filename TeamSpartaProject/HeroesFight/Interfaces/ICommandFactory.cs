namespace HeroesFight.Interfaces
{
    using HeroesFight.Core;
    using HeroesFight.Entities;

    public interface ICommandFactory
    {
        ICommand CreateCommand(CommandInfo commandInfo);
    }
}
