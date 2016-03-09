namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System.Drawing;

    using HeroesFight.Enums;
    using HeroesFight.Interfaces;

    #endregion

    public class Enemy : Hero, IEnemy
    {
        private const HeroClass EnemyClass = HeroClass.Enemy;

        public Enemy(
            Bitmap image, 
            string name, 
            int attackPoints, 
            int healthPoints, 
            int manaPoints, 
            int shieldPower, 
            StateEnum wantedState)
            : base(image, name, attackPoints, healthPoints, manaPoints, shieldPower, EnemyClass)
        {
            this.WantedState = wantedState;
        }

        public StateEnum WantedState { get; }
    }
}