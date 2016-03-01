namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    public abstract class Enemy : Hero
    {
        protected Enemy(Image image, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, attackPoints, healthPoints, manaPoints, shieldPower)
        {
        }
    }
}