namespace HeroesFight
{
    using System;

    using HeroesFight.Core;
    using HeroesFight.Core.Factories;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    internal static class HeroesFightEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IDatabase gameData = new GameDatabase();
            IHeroFactory heroFactory = new HeroFactory();
            ICommandFactory commandFactory = new CommandFactory(heroFactory);
            ICommandDispatcher commandDispatcher = new CommandDispatcher(gameData, commandFactory);
            StateManager stateManager = new StateManager(commandDispatcher);
            IRunnable engine = new HeroesFightEngine(stateManager);
            engine.Run();
        }
    }
}