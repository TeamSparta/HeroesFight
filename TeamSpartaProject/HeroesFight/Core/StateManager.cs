namespace HeroesFight.Core
{
    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    public class StateManager
    {
        private static State initialState;

        public StateManager(ICommandDispatcher commandDispatcher)
        {
            CommandDispatcher = commandDispatcher;
        }

        public static ICommandDispatcher CommandDispatcher { get; private set; }

        public static State InitialState
        {
            get
            {
                if (initialState == null)
                {
                    initialState = new StartGameState(CommandDispatcher);
                    CurrentState = initialState;
                }

                return initialState;
            }
        }

        public static State CurrentState { get; private set; }

        public static void ChangeCurrentState(StateEnum state)
        {
            switch (state)
            {
                case StateEnum.PickNameState:
                    CurrentState.Hide();
                    CurrentState = new StartGameState(CommandDispatcher);
                    CurrentState.Show();
                    break;
                case StateEnum.PickClassState:
                    CurrentState.Hide();
                    CurrentState = new SelectCharacterState();
                    CurrentState.Show();
                    break;
            }
        }
    }
}
