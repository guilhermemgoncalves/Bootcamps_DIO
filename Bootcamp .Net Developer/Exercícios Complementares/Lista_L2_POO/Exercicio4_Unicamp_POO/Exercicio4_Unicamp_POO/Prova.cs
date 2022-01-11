using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Unicamp_POO
{
    public class Prova
    {
        private Gabarito gabarito = new Gabarito();
        public char[] respostaQuestao = new char[15];
        private int numeroQuestao = 0;
        private double nota;
        private int acertos;

        
        public Prova(Gabarito gabarito)
        {
            
        }

        public int Acertos()
        {
            acertos = 0;
            
            for (numeroQuestao = 0; numeroQuestao < respostaQuestao.Length; numeroQuestao++)
            {
                if (gabarito.respostaQuestaoG[numeroQuestao] == respostaQuestao[numeroQuestao])
                    acertos++;
            }

            
            return acertos;
        }
        public double Nota()
        {


            nota = 0;
            for (numeroQuestao = 0; numeroQuestao < respostaQuestao.Length; numeroQuestao++)
            {   
                if (gabarito.respostaQuestaoG[numeroQuestao] == respostaQuestao[numeroQuestao])
                {
                    if (numeroQuestao < 10)
                    {
                        nota += 0.5;
                    }
                    else
                    {
                        nota += 1;
                    }
                }
              
            }


            return nota;
        }

        public void respostaAluno(char entradaRespostaQuestao)
        {   if (numeroQuestao == 15)
            {
                numeroQuestao = 0;
            }
            respostaQuestao[numeroQuestao] = entradaRespostaQuestao;
            this.numeroQuestao++;
          
        }


        public override string ToString()
        {
            string retorno = "Prova: ";
            foreach (var questao in respostaQuestao)
            {
                retorno += questao + " ";
            }
            return retorno;
        }

    }
}
