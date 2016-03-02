namespace HeroesFight.Interfaces
{
    /// <summary>
    /// Interface implements logic for Magic
    /// </summary>
    public interface IMagic
    {
        /// <summary>
        /// Damage the magic will deal to the opponent.
        /// </summary>
        int AttackDamage { get; }

        /// <summary>
        /// Cost to perform the chosen magic in mana points.
        /// </summary>
        int ManaCost { get; }

        /// <summary>
        /// Cost to perform the chosen magic in health points.
        /// </summary>
        int HealthCost { get; }
    }
}