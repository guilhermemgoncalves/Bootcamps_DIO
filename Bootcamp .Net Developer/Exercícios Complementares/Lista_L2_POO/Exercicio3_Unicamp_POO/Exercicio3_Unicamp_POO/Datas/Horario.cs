using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Unicamp_POO.Datas
{
    public class Horario
    {
        private int horas { get ; set;}
        private int minutos { get ; set;}
        private int segundos { get ; set;}

    
        public Horario(int horas, int minutos)
        {   if (horas<24)
            this.horas = horas;
            else
            { this.horas = 0; }
            if (minutos < 60)
                this.minutos = minutos;
            else
                minutos = 0;
            
                this.segundos = 10;
                
        }

        public override string ToString()
        {

            return $"Horário: {this.horas}:{this.minutos}:{this.segundos}";

        }



    }
}
