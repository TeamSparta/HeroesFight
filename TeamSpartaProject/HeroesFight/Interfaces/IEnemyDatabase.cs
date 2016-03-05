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
        /// Contains all enemies magics.
        /// </summary>
        IEnumerable<IMagic> EnemyMagics { get; }


        /// <summary>
        /// Gets an enemy magic by name.
        /// </summary>
        /// <param name="magicName">The name of the magic which has to be found.</param>
        /// <returns></returns>
        IMagic GetEnemyMagic(string magicName);
    }
}
