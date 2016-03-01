namespace HeroesFight.GameObjects
{
    using System.Drawing;

    using HeroesFight.GameObjects;
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
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int AttackCost
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