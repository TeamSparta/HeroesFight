namespace HeroesFight.GameObjects
{
    using System;
    using System.Drawing;

    using global::HeroesFight.Interfaces;

    public class Magic : GameObject, IMagic
    {
        public Magic(Image image, int attacKDamage, int manaCost, int healthCost)
            : base(image)
        {
            this.AttackDamage = attacKDamage;
            this.ManaCost = manaCost;
            this.HealthCost = healthCost;
        }

        public int AttackDamage
        {
            get
            {
                throw new NotImplementedException();
            }

            private set
            {
                throw new NotImplementedException();
            }
        }

        public int ManaCost
        {
            get
            {
                throw new NotImplementedException();
            }

            private set
            {
                throw new NotImplementedException();
            }
        }

        public int HealthCost
        {
            get
            {
                throw new NotImplementedException();
            }

            private set
            {
                throw new NotImplementedException();
            }
        }
    }
}