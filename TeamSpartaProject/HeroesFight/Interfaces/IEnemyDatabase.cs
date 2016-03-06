namespace HeroesFight.Interfaces
{
    #region

    using System.Collections.Generic;

    #endregion

    public interface IEnemyDatabase
    {
        /// <summary>
        ///     Information for all enemies is loaded here.
        /// </summary>
        IEnumerable<IEnemy> Enemies { get; }

        /// <summary>
        ///     Finds an enemy by level.
        /// </summary>
        /// <returns></returns>
        IEnemy GetCurrentLevelEnemy();
    }
}