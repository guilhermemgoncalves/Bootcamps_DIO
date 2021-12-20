using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Unicamp_POO
{
    public class Aluno
    {
        private int matricula;
        private string nome;
        private double notaProvaUm;
        private double notaProvaDois;
        private double notaTrabalho;
        private double media;
        private double final;

        public Aluno(int matricula, string nome, double notaProvaUm, double notaProvaDois, double notaTrabalho)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.notaProvaUm = notaProvaUm;
            this.notaProvaDois = notaProvaDois;
            this.notaTrabalho = notaTrabalho;
        }

        public double CalulaMedia()
        {
            double media = (this.notaProvaUm*2.5 + this.notaProvaDois*2.5+ this.notaTrabalho*2)/7;
            this.media = media;
            return media;
        }
        public double CalculaFinal ()
        {
            double final = (this.notaProvaUm * 2.5 + this.notaProvaDois*2.5 + this.notaTrabalho * 2)/7;
            if (final > 7)
                return 0;
            else { return 10 - final; }
            
        }

        public override string ToString()
        {
            string retorno = "Aluno: " + nome
                            + " | MAtrícula " + matricula
                            + "\nP1: " + notaProvaUm
                            + "\nP2: " + notaProvaDois
                            + "\nT1: " + notaTrabalho
                            + "\n========================"
                            + "\nMédia: " + CalulaMedia().ToString()
                            + "\nPrecisa de " + CalculaFinal().ToString() + " pontos na prova final para ser aprovado!";
            return retorno;
        }
       
    }
}
