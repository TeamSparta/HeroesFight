using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight.Interfaces
{
    public interface IHero
    {
        int AttackPoints { get; set; }

        int HealthPoints { get; set; }

        int ManaPoints { get; set; }

        int ShieldPower { get; set; }

        void Attack(IHero enemy);

        void UseMagic(IHero enemy);
    }
}
