namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    using HeroesFight.Interfaces;

    public class Enemy : Hero, IEnemy
    {
        public Enemy(Image image, string name, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, name, attackPoints, healthPoints, manaPoints, shieldPower)
        {
        }
    }
}