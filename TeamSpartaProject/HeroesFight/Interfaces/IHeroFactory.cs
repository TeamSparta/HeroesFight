namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Enums;

    #endregion

    public interface IHeroFactory
    {
        IHero CreateHero(HeroClass heroType, string heroName);
    }
}