﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoNaPratica.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int  idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos");

        }
    }
}
