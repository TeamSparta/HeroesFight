namespace HeroesFight.Interfaces
{
    using System;

    using HeroesFight.Enum;

    public interface IHeroFactory
    {
        IHero CreateHero(ClassHeroEnum heroType, string heroName);
    }
}
