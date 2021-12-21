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
        private bool[] idCadeira = new bool[100];

        

        public Voo(Horario horario, Data data,  int idVoo)
        {
            this.data = data;
            this.horario = horario;
            this.numPassageiros=0;
            this.idVoo = idVoo;
            
         

        }
        public int ProximoLivre(int numCadeira)
        {
            int i;
            int proximoLivre = 0;
            for (i=0; i >=  idCadeira.Length; i++)
            {
                if (idCadeira[i] == false)
                {
                    proximoLivre = i + 1;
                }                
            }
            return proximoLivre;

        }

        public bool Verifica (int numCadeira)
        {
            if (idCadeira[numCadeira] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
        public bool Ocupa (int numCadeira)
        {
            if (idCadeira[numCadeira] == true)
            {
                return true;
            }
            else
            {
                idCadeira[numCadeira] = true;
                numPassageiros++; 
                return false;
            }
        }
        public int Vagas()
        {

            return 100-numPassageiros;

        }
        public Data GetData()
        {
            return data;
        }
        public int GetVoo()
        {
            return this.idVoo;
        }
        public Voo Clone(Voo voo)
        {
            Voo vooClone = voo;
            return vooClone;
        }

        public override string ToString()
        {

            return $"Voo #{idVoo} |Data: {data}, {horario} | Nº de Passageiros: {numPassageiros}\n";

        }

       
        



    }
}
