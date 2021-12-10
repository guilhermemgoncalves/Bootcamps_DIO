using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecoes.Helper
{
    public class OperacoesLista
    {

        public void ImprimirListaString(List<string> lista)
        {

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Indice {i}, Valor: {lista[i]}");// consultando elementos da lista com for
            }
        }
    }
}
