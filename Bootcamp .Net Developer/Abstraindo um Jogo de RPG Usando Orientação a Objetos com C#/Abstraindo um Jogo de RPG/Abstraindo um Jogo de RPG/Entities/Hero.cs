using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.Entities
{
    public abstract class Hero
    {
        public string name;
        public int level;
        public string heroType;
        public int hp;
        public int mp;

        public Hero(string name, int level, string heroType, int hp, int mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
            this.mp = mp;

        }
        public virtual string Attack()
        {
            return this.name + " Atacou com uma espada ";

        }

        public override string ToString()
        {
            return $"Nome: {name}, Level: {level}, Tipo: {heroType}, HP: {hp}, MP: {mp}";
        }
    }
}
