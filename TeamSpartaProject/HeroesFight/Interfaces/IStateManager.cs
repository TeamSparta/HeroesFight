namespace HeroesFight.Interfaces
{
    using HeroesFight.Enum;
    using HeroesFight.States;

    public interface IStateManager
    {
        State InitialState { get; }

        State CurrentState { get; }

        void ChangeCurrentState(StateEnum state);
    }
}
