namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.States;

    #endregion

    public interface ICommand
    {
        string CommandName { get; }

        object[] CommandParameters { get; }

        void Execute(IDatabase database, State currentState);
    }
}