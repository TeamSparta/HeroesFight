namespace HeroesFight.GameObjects
{
    using System.Drawing;

    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;

    public abstract class Player : Hero, IPlayer
    {
        protected Player(Image image, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, attackPoints, healthPoints, manaPoints, shieldPower)
        {
            this.Experience = 0;
        }

        public int Experience
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}