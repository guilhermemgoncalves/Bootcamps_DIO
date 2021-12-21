using Exercicio2_Unicamp_POO;
using Exercicio3_Unicamp_POO.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Unicamp_POO.Voo
{
    public class Voo

    {

        private Data data;
        private Horario horario;
        private int numPassageiros = 0 ;
        private int idVoo;
        

        public Voo(Horario horario, Data data,  int idVoo)
        {
            this.data = data;
            this.horario = horario;
            this.numPassageiros=0;
            this.idVoo = idVoo;
            
         

        }

        public override string ToString()
        {

            return $"Voo #{idVoo} |Data: {data}, {horario} | Nº de Passageiros: {numPassageiros}\n";

        }

        public int GetVoo()
        {
            return this.idVoo;
        }

        



    }
}
