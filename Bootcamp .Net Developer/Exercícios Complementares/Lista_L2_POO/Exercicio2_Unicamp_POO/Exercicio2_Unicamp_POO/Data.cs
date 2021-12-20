using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Unicamp_POO
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;

            if (dia > 31 || mes > 12 || ano > 2050)
            {
                this.dia = 01;
                this.mes = 01;
                this.ano = 01;
            }

        }

        public int compara(Data dataCompara) // pensar melhor a função de comparação
        {
            var atributosData = dataCompara;
            if (atributosData.dia == this.dia && atributosData.mes == this.mes && atributosData.ano == this.ano)
            { return 0; }
            else if( atributosData.dia == this.dia && atributosData.mes == this.mes && atributosData.ano >= this.ano)
                { return -1; }
            else if (atributosData.dia == this.dia && atributosData.mes >= this.mes && atributosData.ano >= this.ano)
            { return -1; }
            else if (atributosData.dia >= this.dia && atributosData.mes >= this.mes && atributosData.ano >= this.ano)
            { return -1; }
            else if (atributosData.dia >= this.dia && atributosData.mes >= this.mes && atributosData.ano == this.ano)
            { return -1; } 
            else if (atributosData.dia >= this.dia && atributosData.mes == this.mes && atributosData.ano == this.ano)
            { return -1; }
            else if (atributosData.dia == this.dia && atributosData.mes >= this.mes && atributosData.ano == this.ano)
            { return -1; }
            else
            { return 1; }
            
        }
       
        public int getDia()
        {
            return this.dia;
        }
        public int getMes()
        {
            return this.mes;
        }
        public int getAno()
        {
            return this.ano;
        }
        



        public override string  ToString()
            {

            return $"Data: {this.dia}/{this.mes}/{this.ano}";
             
            }

       
    }
}
