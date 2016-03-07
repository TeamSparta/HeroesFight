namespace HeroesFight.States
{
    #region

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    #endregion

    public class StateManager
    {
        private static State initialState;

        public StateManager(ICommandDispatcher commandDispatcher)
        {
            CommandDispatcher = commandDispatcher;
        }

        public static ICommandDispatcher CommandDispatcher { get; private set; }

        public static State CurrentState { get; private set; }

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
                case StateEnum.FirstLevelRoundTwoState:
                    CurrentState.Hide();
                    CurrentState.Show();
                    break;
                case StateEnum.ExitGameState:
                    CurrentState.Hide();
                    CurrentState = new ExitGameState(CommandDispatcher);
                    CurrentState.Show();
                    break;
            }
        }
    }
}