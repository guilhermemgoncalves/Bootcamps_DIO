using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.Entities
{
    public class Black_Wizzard : Wizzard
    {
        public Black_Wizzard(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
        }

       
        public override string Attack()
        {
            return this.name + " Lançou Magia ";
        }
        public string Attack(int bonus)

        {

            if (bonus > 6)
            {
                return this.name + " Lançou Magia super efetiva com " + bonus + " de bonus de ataque!";
            }
            else
            {
                return this.name + "  Lançou Magia fraca  com " + bonus + " de bonus de ataque!";
            }

        }
    }
}
