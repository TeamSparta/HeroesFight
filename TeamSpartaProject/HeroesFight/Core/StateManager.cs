namespace HeroesFight.Core
{
    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    public class StateManager : IStateManager
    {
        private State initialState;

        public StateManager(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
        }

        public ICommandDispatcher CommandDispatcher { get; private set; }

        public State InitialState
        {
            get
            {
                if (this.initialState == null)
                {
                    this.initialState = new StartGameState(this.CommandDispatcher);
                    this.CurrentState = this.initialState;
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
                    this.CurrentState = new StartGameState(this.CommandDispatcher);
                    break;
            }
        }
    }
}
