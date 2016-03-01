using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight.Interfaces
{
    public interface IMagic
    {
        int AttackDamage { get; set; }

        int AttackCost { get; set; }
    }
}
