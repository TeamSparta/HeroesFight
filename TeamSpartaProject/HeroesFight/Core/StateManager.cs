namespace HeroesFight.Core
{
    using HeroesFight.Enum;

    public class StateManager
    {
        public StateManager()
        {
            this.InitialState = new State(new GameDatabase());
        }

        public State InitialState { get; private set; }

        public State CurrentState { get; private set; }

        public void ChangeCurrentState(StateEnum state)
        {
            switch (state)
            {
                case StateEnum.PickNameState:
                    this.CurrentState = new State(new GameDatabase());
                    break;
            }
        }
    }
}
