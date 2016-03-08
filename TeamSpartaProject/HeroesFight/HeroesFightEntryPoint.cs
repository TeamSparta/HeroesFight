namespace HeroesFight
{
    #region

    using System;

    using HeroesFight.Core;
    using HeroesFight.Core.Factories;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    internal static class HeroesFightEntryPoint
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IMagicFactory magicFactory = new MagicFactory();
            IHeroFactory heroFactory = new HeroFactory();
            ICommandFactory commandFactory = new CommandFactory();
            IDatabase gameData = new GameDatabase(commandFactory, heroFactory, magicFactory);
            ICommandDispatcher commandDispatcher = new CommandDispatcher(gameData);
            StateManager stateManager = new StateManager(commandDispatcher);

            // ToDo: find better relationship here: the StateManager class is static which means our engine runs only on static class. :/
            // ToDo: Improve magics and mana costs.
            IRunnable engine = new HeroesFightEngine(stateManager);
            engine.Run();

            // BUG: Player bars do not update correctly when current state's digit are decreasing e.g. 100 -> 80
            // BUG: Player bars do not initialize correctly when initializing new state.
            // BUG: If we are about to die by the enemy and we kill it with next magic we end up losing the game.
        }
    }
}