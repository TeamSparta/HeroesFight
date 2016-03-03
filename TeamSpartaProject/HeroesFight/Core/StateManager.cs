namespace HeroesFight.Core
{
    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    public class StateManager : IStateManager
    {
        private State initialState;

        public State InitialState
        {
            get
            {
                if (this.initialState == null)
                {
                    this.initialState = new StartGameState();
                }

                return this.initialState;
            }
        }

        public State CurrentState { get; private set; }

        public void ChangeCurrentState(StateEnum state)
        {
            switch (state)
            {
                case StateEnum.PickNameState:
                    this.CurrentState = new StartGameState();
                    break;
            }
        }
    }
}
