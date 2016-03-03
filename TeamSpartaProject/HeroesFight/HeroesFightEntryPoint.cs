namespace HeroesFight
{
    using System;

    using HeroesFight.Core;
    using HeroesFight.Core.Factories;
    using HeroesFight.Interfaces;

    internal static class HeroesFightEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IDataBase gameData = new GameDatabase();
            ICommandFactory commandFactory = new CommandFactory();
            ICommandDispatcher commandDispatcher = new CommandDispatcher(gameData, commandFactory);
            StateManager stateManager = new StateManager(commandDispatcher);
            IRunnable engine = new HeroesFightEngine(stateManager);
            engine.Run();
        }
    }
}