﻿namespace HeroesFight.Interfaces
{
    /// <summary>
    /// Used to collect all the game information.
    /// </summary>
    public interface IDatabase : IPlayerDatabase, IEnemyDatabase
    {
        /// <summary>
        /// Factory used to initialize all magic instances.
        /// </summary>
        IMagicFactory MagicFactory { get; }
        
        ICommandFactory CommandFactory { get; }

        IHeroFactory HeroFactory { get; }

        /// <summary>
        /// Method used to update database.
        /// </summary>
        void Update();

        void Initialize();
    }
}
