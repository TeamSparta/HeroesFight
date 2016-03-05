namespace HeroesFight.Interfaces
{
    using System;

    using HeroesFight.Enum;

    public interface IHeroFactory
    {
        // TODO: don't think that heroType should be of type Type, string or enum is fine in my opinion
        // Will fix that.
        IHero CreateHero(ClassHeroEnum heroType, string heroName);
    }
}
