using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Unicamp_POO
{
    public class Gabarito
    {
        public char[] respostaQuestaoG = new char[15]  {'a', 'b', 'd', 'e', 'c','a','c','e','d','a','b','e','c','b','b' };
        
        
        public char RespostaQuestao(int numeroQuestao)
        {

            return respostaQuestaoG[numeroQuestao];
        }

        public override string ToString()
        {

            string retorno = "Gabarito: ";
            foreach (var questao in respostaQuestaoG)
            {
                retorno += questao + " ";
            }
            return retorno;
        }
    }
}
