﻿namespace HeroesFight.GameObjects
{
    using System.Drawing;

    using HeroesFight.Interfaces;

    public abstract class Hero : GameObject, IHero
    {
        protected Hero(Image image, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image)
        {
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.ShieldPower = shieldPower;
        }

        public int AttackPoints { get; set; }

        public int HealthPoints { get; set; }

        public int ManaPoints { get; set; }

        public int ShieldPower { get; set; }
        
        public void Attack(IHero enemy)
        {
            enemy.HealthPoints -= this.AttackPoints - enemy.ShieldPower;
        }

        public void UseMagic(IHero enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}