namespace HeroesFight.GameObjects
{
    using System.Drawing;

    using HeroesFight.Interfaces;

    public class Magic : GameObject, IMagic
    {
        public Magic(Image image)
            : base(image)
        {
            
        }

        public int AttackDamage
        {
            get
            {
                throw new System.NotImplementedException();
            }

            private set
            {
                throw new System.NotImplementedException();
            }
        }

        public int ManaCost
        {
            get
            {
                throw new System.NotImplementedException();
            }

            private set
            {
                throw new System.NotImplementedException();
            }
        }

        public int HealthCost
        {
            get
            {
                throw new System.NotImplementedException();
            }

            private set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}