namespace HeroesFight.Core
{
    using System.Windows.Forms;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    public class HeroesFightEngine : IRunnable
    {
        public HeroesFightEngine(IDataBase gameData)
        {
            this.DataBase = gameData;
        }

        public IDataBase DataBase { get; private set; }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new State(new GameDatabase()));

            //while (true)
            //{
            //    var commandInfo = StateManager.CurrentState.GetCurrentCommandInfo;
            //    var command = CommandFactory(commandInfo);
            //    command.Execute(this.DataBase, StateManager.CurrentState);
            //}

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
