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
            // ToDo: Should add another field which shows the current hero's class.
            // ToDo: Perform validation on casting magics.
            // ToDo: Improve magics and mana costs.
            // ToDo: Set level transition logic (aka load next level/state).
            // ToDo: Get an endgame screen.
            IRunnable engine = new HeroesFightEngine(stateManager);
            engine.Run();
        }
    }
}