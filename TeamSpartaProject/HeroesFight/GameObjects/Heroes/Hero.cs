namespace HeroesFight.GameObjects.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    public abstract class Hero : GameObject, IHero
    {
        private readonly IList<IMagic> magics; 

        protected Hero(Bitmap image, string name, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.ShieldPower = shieldPower;
            this.magics = new List<IMagic>();
        }

        public string Name { get; }

        public int AttackPoints { get; set; }

        public int HealthPoints { get; set; }

        public int ManaPoints { get; set; }

        public int ShieldPower { get; set; }

        public ClassHeroEnum ClassHero { get; }

        public IEnumerable<IMagic> Magics
        {
            get
            {
                return this.magics;
            }
        }

        public void AddMagic(IMagic magic)
        {
            if (magic == null)
            {
                throw new ArgumentNullException("Cannot add magic which is null.");
            }

            this.magics.Add(magic);
        }

        public virtual void PerformAttack(IHero enemy)
        {
            enemy.HealthPoints -= this.AttackPoints - enemy.ShieldPower;
        }

        public virtual void PerformMagic(IHero enemy, IMagic magic)
        {
            enemy.HealthPoints -= magic.AttackDamage - enemy.ShieldPower;
            this.HealthPoints -= magic.HealthCost;
            this.ManaPoints -= magic.ManaCost;
        }
    }
}