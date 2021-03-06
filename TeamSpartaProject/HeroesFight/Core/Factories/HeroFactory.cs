﻿namespace HeroesFight.Core.Factories
{
    #region

    using System;

    using HeroesFight.Enums;
    using HeroesFight.GameObjects.Heroes;
    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    #endregion

    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(HeroClass heroType, string heroName)
        {
            IHero hero;
            switch (heroType)
            {
                case HeroClass.Warrior:
                    hero = new Warrior(heroName);
                    break;
                case HeroClass.Archer:
                    hero = new Archer(heroName);
                    break;
                case HeroClass.Enemy:
                    hero = this.CreateEnemy(heroName);
                    break;
                default:
                    throw new ArgumentException("Unknown type of hero.");
            }

            return hero;
        }

        private IEnemy CreateEnemy(string heroName)
        {
            IEnemy enemy;
            switch (heroName)
            {
                case "UnholyWarrior":
                    enemy = new Enemy(
                        Resources.UnholyWarrior, 
                        heroName, 
                        100, 
                        500, 
                        100, 
                        70, 
                        StateEnum.FirstLevelRoundOneState);
                    break;
                case "FireArcher":
                    enemy = new Enemy(
                        Resources.FireArcher, 
                        heroName, 
                        140, 
                        500, 
                        140, 
                        50, 
                        StateEnum.FirstLevelRoundTwoState);
                    break;
                case "BloodLineMagician":
                    enemy = new Enemy(
                        Resources.BloodlineMagician, 
                        heroName, 
                        140, 
                        550, 
                        500, 
                        50, 
                        StateEnum.FirstLevelRoundThreeState);
                    break;
                default:
                    throw new ArgumentException("Unknown type of hero.");
            }

            return enemy;
        }
    }
}