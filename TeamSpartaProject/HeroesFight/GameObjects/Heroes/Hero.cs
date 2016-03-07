namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;

    #endregion

    public abstract class Hero : GameObject, IHero
    {
        private int healthPoints;

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
            this.IsAlive = true;
        }

        public int AttackPoints { get; set; }

        public ClassHeroEnum ClassHero { get; }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value <= 0)
                {
                    this.IsAlive = false;
                    this.healthPoints = 0;
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }

        public IEnumerable<IMagic> Magics
        {
            get
            {
                return this.magics;
            }
        }

        public int ManaPoints { get; set; }

        public string Name { get; private set; }

        public int ShieldPower { get; set; }

        public bool IsAlive { get; set; }

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
            enemy.HealthPoints -= this.AttackPoints - (enemy.ShieldPower / 2);
        }

        public virtual void PerformMagic(IHero enemy, IMagic magic)
        {
            enemy.HealthPoints -= magic.AttackDamage - enemy.ShieldPower;
            this.HealthPoints -= magic.HealthCost;
            this.ManaPoints -= magic.ManaCost;
        }
    }
}