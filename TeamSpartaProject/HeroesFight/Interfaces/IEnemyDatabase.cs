namespace HeroesFight.Interfaces
{
    using System.Collections.Generic;

    public interface IEnemyDatabase
    {
        /// <summary>
        /// Information for all enemies is loaded here.
        /// </summary>
        IEnumerable<IEnemy> Enemies { get; }

        /// <summary>
        /// Finds an enemy by level.
        /// </summary>
        /// <returns></returns>
        IEnemy GetCurrentLevelEnemy();
    }
}
