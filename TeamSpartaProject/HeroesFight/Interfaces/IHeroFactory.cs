namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Enum;

    #endregion

    public interface IHeroFactory
    {
        IHero CreateHero(ClassHeroEnum heroType, string heroName);
    }
}