namespace HeroesFight.GameObjects
{
    using System;
    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    public class Magic : GameObject, IMagic
    {
        public Magic(Image image, string name, int attackDamage, int manaCost, int healthCost, StateEnum magicLevelWanted, ClassHeroEnum classHeroWanted)
            : base(image)
        {
            this.Name = name;
            this.AttackDamage = attackDamage;
            this.ManaCost = manaCost;
            this.HealthCost = healthCost;
            this.LevelWanted = magicLevelWanted;
            this.ClassHeroWanted = classHeroWanted;
        }

        public string Name { get; }

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

        public StateEnum LevelWanted { get; private set; }

        public ClassHeroEnum ClassHeroWanted { get; private set; }
    }
}