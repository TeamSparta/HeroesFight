namespace HeroesFight.Interfaces
{
    #region

    using System.Collections.Generic;

    #endregion

    public interface IEnemyDatabase
    {
        IEnemy GetCurrentLevelEnemy();
    }
}