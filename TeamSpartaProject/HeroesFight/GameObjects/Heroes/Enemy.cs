namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    #endregion

    public class Enemy : Hero, IEnemy
    {
        public Enemy(
            Bitmap image, 
            string name, 
            int attackPoints, 
            int healthPoints, 
            int manaPoints, 
            int shieldPower, 
            StateEnum wantedState)
            : base(image, name, attackPoints, healthPoints, manaPoints, shieldPower)
        {
            this.WantedState = wantedState;
        }

        public StateEnum WantedState { get; }
    }
}