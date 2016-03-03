namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    using HeroesFight.Interfaces;

    public abstract class Hero : GameObject, IHero
    {
        protected Hero(Image image, string name, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.ShieldPower = shieldPower;
        }

        public string Name { get; }

        public int AttackPoints { get; set; }

        public int HealthPoints { get; set; }

        public int ManaPoints { get; set; }

        public int ShieldPower { get; set; }

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