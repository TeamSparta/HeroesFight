namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    public abstract class Player : Hero
    {
        protected Player(Bitmap image, string name, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, name, attackPoints, healthPoints, manaPoints, shieldPower)
        {
        }
    }
}