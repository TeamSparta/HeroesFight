using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight.Interfaces
{
    public interface IPlayer : IHero
    {
        int Experience { get; set; }
    }
}
