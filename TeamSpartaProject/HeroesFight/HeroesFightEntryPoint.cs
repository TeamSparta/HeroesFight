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
            IStateManager stateManager = new StateManager();
            ICommandFactory commandFactory = new CommandFactory();
            IRunnable engine = new HeroesFightEngine(gameData, stateManager, commandFactory);
            engine.Run();
        }
    }
}