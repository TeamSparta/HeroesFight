namespace HeroesFight.Core.Factories
{
    using System;
    using System.Drawing;

    using HeroesFight.GameObjects.Heroes;
    using HeroesFight.Interfaces;

    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(Type heroType, string heroName)
        {
            IHero hero;
            switch (heroType.Name)
            {
                case "Warrior":
                    hero = new Warrior(heroName);
                    break;
                case "Archer":
                    hero = new Archer(heroName);
                    break;
                case "Enemy":
                    hero = CreateEnemy(heroName);
                    break;
                default:
                    throw new ArgumentException("Unknown type of hero.");
            }

            return hero;
        }

        private IEnemy CreateEnemy(string heroName)
        {
            // ToDo: Fulfill switch case here.
            IEnemy enemy;
            switch (heroName)
            {
                case "UnholyWarrior":
                    enemy = new Enemy(Image.FromFile("UnholyWarrior"), "Unholy Warrior", 100, 600, 50, 70);
                    break;

                default:
                    throw new ArgumentException("Unknown type of hero.");
            }

            return enemy;
        }
    }
}
