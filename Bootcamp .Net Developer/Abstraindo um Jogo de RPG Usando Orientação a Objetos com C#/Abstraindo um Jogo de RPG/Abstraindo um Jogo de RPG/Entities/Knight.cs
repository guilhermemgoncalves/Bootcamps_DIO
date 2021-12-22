using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
        }
    }
}
