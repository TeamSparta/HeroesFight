﻿namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using HeroesFight.Enums;
    using HeroesFight.Interfaces;

    #endregion

    public abstract class Hero : GameObject, IHero
    {
        private readonly IList<IMagic> magics;

        private int healthPoints;

        protected Hero(
            Bitmap image, 
            string name, 
            int attackPoints, 
            int healthPoints, 
            int manaPoints, 
            int shieldPower, 
            HeroClass heroClass)
            : base(image)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.ShieldPower = shieldPower;
            this.magics = new List<IMagic>();
            this.IsAlive = true;
            this.ClassHero = heroClass;
        }

        public int AttackPoints { get; set; }

        public HeroClass ClassHero { get; }

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

        public bool IsAlive { get; set; }

        public IEnumerable<IMagic> Magics
        {
            get
            {
                return this.magics;
            }
        }

        public int ManaPoints { get; set; }

        public string Name { get; }

        public int ShieldPower { get; set; }

        public void AddMagic(IMagic magic)
        {
            if (magic == null)
            {
                throw new ArgumentNullException("Cannot add magic which is null.");
            }

            if (!this.magics.Contains(magic))
            {
                this.magics.Add(magic);
            }
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

        public override string ToString()
        {
            string heroInfo = string.Format(
                "{0}\nAttack power: {1}\nHealth points: {2}\nMana points: {3}\nShield power: {4}",
                this.Name,
                this.AttackPoints,
                this.HealthPoints,
                this.ManaPoints,
                this.ShieldPower);

            return heroInfo;
        }
    }
}