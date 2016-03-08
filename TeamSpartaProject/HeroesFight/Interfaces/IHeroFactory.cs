namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Enum;

    #endregion

    public interface IHeroFactory
    {
        IHero CreateHero(HeroClass heroType, string heroName);
    }
}