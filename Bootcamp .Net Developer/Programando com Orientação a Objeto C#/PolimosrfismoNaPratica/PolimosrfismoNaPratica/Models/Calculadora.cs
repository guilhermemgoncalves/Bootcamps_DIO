using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoNaPratica.Models
{
    public class Calculadora
    {
        public int Soma(int num1, int num2)
            { return num1 + num2; } // Polimorfismo Early binding.

        public int Soma(int num1, int num2, int num3)
        { return num1 + num2+ num3; } // Polimorfismo Early binding.
    }
}
