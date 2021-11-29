using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoNaPratica.Models
{
    public class Aluno : Pessoa
    {
        public double nota { get; set; }

        public override void Apresentar() // Polimorfismo late binding.
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tirei a nota: {nota}");

        }




    }
}
