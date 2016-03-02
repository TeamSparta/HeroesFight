namespace HeroesFight.Interfaces
{
    /// <summary>
    /// Base interface for all hero units.
    /// </summary>
    public interface IHero
    {
        /// <summary>
        /// Attack power of the hero.
        /// </summary>
        int AttackPoints { get; set; }

        /// <summary>
        /// Health points of the hero.
        /// </summary>
        int HealthPoints { get; set; }

        /// <summary>
        /// Mana points of the hero.
        /// </summary>
        int ManaPoints { get; set; }

        /// <summary>
        /// Shield to reduce every attack power.
        /// </summary>
        int ShieldPower { get; set; }

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