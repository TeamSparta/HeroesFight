namespace HeroesFight.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Base interface for all hero units.
    /// </summary>
    public interface IHero
    {
        /// <summary>
        /// Name used inside the game
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Attack power of the hero.
        /// </summary>
        int AttackPoints { get; }

        /// <summary>
        /// Health points of the hero.
        /// </summary>
        int HealthPoints { get; set; }

        /// <summary>
        /// Mana points of the hero.
        /// </summary>
        int ManaPoints { get; }

        /// <summary>
        /// Shield to reduce every attack power.
        /// </summary>
        int ShieldPower { get; }

        /// <summary>
        /// Contains all magics for the current hero.
        /// </summary>
        IEnumerable<IMagic> Magics { get; }

        /// <summary>
        /// Method used to add magic to current hero champion pool.
        /// </summary>
        /// <param name="magic">Magic to be added.</param>
        void AddMagic(IMagic magic);

        /// <summary>
        /// Performs attack logic on given enemy.
        /// </summary>
        /// <param name="enemy">Enemy to be attacked.</param>
        void PerformAttack(IHero enemy);

        /// <summary>
        /// Performs magic attack logic on given enemy.
        /// </summary>
        /// <param name="enemy">Enemy to be attacked.</param>
        /// <param name="magic">Magic to be performed.</param>
        void PerformMagic(IHero enemy, IMagic magic);
    }
}