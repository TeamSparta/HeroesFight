namespace HeroesFight.Interfaces
{
    using HeroesFight.Enum;

    public interface IStateManager
    {
        State InitialState { get; }

        State CurrentState { get; }

        void ChangeCurrentState(StateEnum state);
    }
}
