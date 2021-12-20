using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubblueSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void Copiar(ref int[] array, ref int[] arrayNovo)
            {
            Array.Copy(array, arrayNovo, array.Length);
            }
        public bool Existe(int[]array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);
        }
        public int ObterIndice(int[]array, int valor)
        {
            return Array.IndexOf(array,valor);
        }
        public void RedmensionarArray(ref int[] array, int novoTamanho )
        {
            Array.Resize(ref array,novoTamanho);
        }
        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());

        }
     }
    
}
