namespace HeroesFight.Interfaces
{
    using HeroesFight.States;

    public interface ICommand
    {
        string CommandName { get; }

        object[] CommandParameters { get; }

        void Execute(IDatabase database, State currentState);
    }
}
