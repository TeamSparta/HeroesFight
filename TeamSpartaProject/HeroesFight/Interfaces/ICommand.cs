namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Entities;
    using HeroesFight.States;

    #endregion

    public interface ICommand
    {
        void Execute(IDatabase database, State currentState, CommandInfo command);
    }
}