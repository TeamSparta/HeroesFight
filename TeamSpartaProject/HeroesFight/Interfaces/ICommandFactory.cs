namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Entities;

    #endregion

    public interface ICommandFactory
    {
        ICommand CreateCommand(CommandInfo commandInfo);
    }
}