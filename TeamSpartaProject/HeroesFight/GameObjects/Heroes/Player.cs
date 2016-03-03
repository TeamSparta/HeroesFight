namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    using HeroesFight.Interfaces;

    public abstract class Player : Hero, IPlayer
    {
        protected Player(Image image, string name, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, name, attackPoints, healthPoints, manaPoints, shieldPower)
        {
        }
    }
}