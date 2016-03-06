namespace HeroesFight.Core.Factories
{
    #region

    using System;

    using HeroesFight.Enum;
    using HeroesFight.GameObjects.Heroes;
    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    #endregion

    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(ClassHeroEnum heroType, string heroName)
        {
            IHero hero;
            switch (heroType)
            {
                case ClassHeroEnum.Warrior:
                    hero = new Warrior(heroName);
                    break;
                case ClassHeroEnum.Archer:
                    hero = new Archer(heroName);
                    break;
                case ClassHeroEnum.Enemy:
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

                    // enemy = new Enemy(Resources.UnholyWarrior, "Unholy Warrior", 100, 600, 50, 70, StateEnum.FirstLevelRoundOneState);
                    enemy = new Enemy(
                        Resources.UnholyWarrior, 
                        heroName, 
                        100, 
                        600, 
                        50, 
                        70, 
                        StateEnum.FirstLevelRoundOneState);
                    break;
                case "FireArcher":

                    // enemy = new Enemy(Resources.FireArcher, "Unholy Warrior", 140, 550, 140, 50, StateEnum.FirstLevelRoundTwoState);
                    enemy = new Enemy(
                        Resources.FireArcher, 
                        heroName, 
                        140, 
                        550, 
                        140, 
                        50, 
                        StateEnum.FirstLevelRoundTwoState);
                    break;
                case "BloodLineMagician":

                    // enemy = new Enemy(Resources.BloodlineMagician, "Unholy Warrior", 140, 550, 140, 50, StateEnum.FirstLevelRoundTwoState);
                    enemy = new Enemy(
                        Resources.BloodlineMagician, 
                        heroName, 
                        140, 
                        550, 
                        140, 
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