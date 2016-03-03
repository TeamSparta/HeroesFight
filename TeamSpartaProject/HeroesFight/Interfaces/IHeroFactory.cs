namespace HeroesFight.Interfaces
{
    using System;

    public interface IHeroFactory
    {
        IHero CreateHero(Type heroType, string heroName);
    }
}
