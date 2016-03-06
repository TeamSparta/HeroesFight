namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Enum;

    #endregion

    /// <summary>
    ///     Interface implements logic for Magic
    /// </summary>
    public interface IMagic
    {
        /// <summary>
        ///     Damage the magic will deal to the opponent.
        /// </summary>
        int AttackDamage { get; }

        /// <summary>
        ///     The specified class the current hero has to be in order to train this magic.
        /// </summary>
        ClassHeroEnum ClassHeroWanted { get; }

        /// <summary>
        ///     Cost to perform the chosen magic in health points.
        /// </summary>
        int HealthCost { get; }

        /// <summary>
        ///     State which indicates when the current magic can be trained by the hero.
        /// </summary>
        /// <returns></returns>
        StateEnum LevelWanted { get; }

        /// <summary>
        ///     Cost to perform the chosen magic in mana points.
        /// </summary>
        int ManaCost { get; }

        string Name { get; }
    }
}