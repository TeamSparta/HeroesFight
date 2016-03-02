namespace HeroesFight
{
    using System;

    using HeroesFight.Core;
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
            IRunnable engine = new HeroesFightEngine(gameData);
            engine.Run();
        }
    }
}