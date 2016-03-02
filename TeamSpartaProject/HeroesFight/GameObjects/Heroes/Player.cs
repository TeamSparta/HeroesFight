namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    using HeroesFight.Interfaces;

    public abstract class Player : Hero, IPlayer
    {
        protected Player(Image image, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, attackPoints, healthPoints, manaPoints, shieldPower)
        {
        }
    }
}