namespace HeroesFight.GameObjects
{
    #region

    using System;
    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    #endregion

    public class Magic : GameObject, IMagic, IEquatable<IMagic>
    {
        private int attackDamage;

        private int healthCost;

        private int manaCost;

        private string name;

        public Magic(
            Bitmap image, 
            string name, 
            int attackDamage, 
            int manaCost, 
            int healthCost, 
            StateEnum magicLevelWanted, 
            HeroClass classHeroWanted)
            : base(image)
        {
            this.Name = name;
            this.AttackDamage = attackDamage;
            this.ManaCost = manaCost;
            this.HealthCost = healthCost;
            this.LevelWanted = magicLevelWanted;
            this.ClassHeroWanted = classHeroWanted;
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

        public HeroClass ClassHeroWanted { get; }

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

        public StateEnum LevelWanted { get; }

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

        public bool Equals(IMagic other)
        {
            return this.name == other.Name;
        }
    }
}