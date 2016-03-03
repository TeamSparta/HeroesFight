namespace HeroesFight.Core
{
    using System.Windows.Forms;

    using HeroesFight.Core.Factories;
    using HeroesFight.Interfaces;

    public class HeroesFightEngine : IRunnable
    {
        public HeroesFightEngine(IDataBase gameData, IStateManager stateManager, ICommandFactory commandFactory)
        {
            this.DataBase = gameData;
            this.StateManager = stateManager;
            this.CommandFactory = commandFactory;
        }

        public IDataBase DataBase { get; private set; }

        public IStateManager StateManager { get; private set; }

        public ICommandFactory CommandFactory { get; private set; }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(this.StateManager.InitialState);

            //while (true)
            //{
            //    // Returns the input.
            //    var commandInfo = this.StateManager.CurrentState.CommandInfo; 
            //    if (commandInfo == null)
            //    {
            //        continue;
            //    }

            //    // Parses the input and transforms it into a command.
            //    var command = this.CommandFactory.CreateCommand(commandInfo);

            //    // Executes command and updates the database.
            //    command.Execute(this.DataBase, this.StateManager.CurrentState);
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
