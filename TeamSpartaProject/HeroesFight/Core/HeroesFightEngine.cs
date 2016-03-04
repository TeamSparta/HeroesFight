namespace HeroesFight.Core
{
    using System.Windows.Forms;

    using HeroesFight.Interfaces;
    using HeroesFight.States;

    public class HeroesFightEngine : IRunnable
    {
        public HeroesFightEngine(StateManager stateManager)
        {
            this.StateManager = stateManager;
        }

        public StateManager StateManager { get; private set; }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(StateManager.InitialState);

            // Application.Run(new State());
            // How a usual game engine state goes:
            // 1. Read a input.
            // 2. Parse the input and transform it to command.
            // 3. Execute the command.
            // 4. Update information.
            // 5. Repeat.
        }
    }
}
