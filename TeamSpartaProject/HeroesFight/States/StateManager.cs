namespace HeroesFight.States
{
    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

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
                case StateEnum.PickCharacterState:
                    CurrentState.Hide();
                    CurrentState = new SelectCharacterState(CommandDispatcher);
                    CurrentState.Show();
                    break;
                case StateEnum.FirstLevelRoundOneState:
                    CurrentState.Hide();
                    CurrentState = new FirstLevelRoundOneState(CommandDispatcher);
                    CurrentState.Show();
                    break;
            }
        }
    }
}
