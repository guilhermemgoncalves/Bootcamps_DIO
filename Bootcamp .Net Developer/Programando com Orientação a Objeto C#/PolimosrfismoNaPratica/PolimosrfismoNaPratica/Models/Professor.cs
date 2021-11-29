using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolimorfismoNaPratica.Models

{
    public class Professor : Pessoa
    {
        public int salario { get; set; }

        public override void Apresentar() // Polimorfismo late binding.
        {
            Console.WriteLine($"Olá, meu nome é {nome} e meu salário é: {salario}");

        }

    }
}
