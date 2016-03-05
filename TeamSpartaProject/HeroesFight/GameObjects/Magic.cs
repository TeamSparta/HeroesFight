namespace HeroesFight.GameObjects
{
    using System;
    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    public class Magic : GameObject, IMagic
    {
        private int attackDamage;
        private int manaCost;
        private int healthCost;
        private string name;

        public Magic(Bitmap image, string name, int attackDamage, int manaCost, int healthCost, StateEnum magicLevelWanted, ClassHeroEnum classHeroWanted)
            : base(image)
        {
            this.Name = name;
            this.AttackDamage = attackDamage;
            this.ManaCost = manaCost;
            this.HealthCost = healthCost;
            this.LevelWanted = magicLevelWanted;
            this.ClassHeroWanted = classHeroWanted;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name of magic cannot be null or whitespace.");
                }

                this.name = value;
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("attack damage", "Attack damage cannot be less than 0.");
                }

                this.attackDamage = value;
            }
        }

        public int ManaCost
        {
            get
            {
                return this.manaCost;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("mana cost", "Mana cost cannot be less than 0.");
                }

                this.manaCost = value;
            }
        }

        public int HealthCost
        {
            get
            {
                return this.healthCost;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("health cost", "Health cost cannot be less than 0.");
                }

                this.healthCost = value;
            }
        }

        public StateEnum LevelWanted { get; private set; }

        public ClassHeroEnum ClassHeroWanted { get; private set; }
    }
}