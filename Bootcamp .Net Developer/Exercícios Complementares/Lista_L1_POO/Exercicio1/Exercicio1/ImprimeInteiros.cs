using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class ImprimeInteiros
    {
        private int termo1;
        private int termo2;

        public void RecebeMedidas(int termo1, int termo2)
        {
            this.termo1 = termo1;
            this.termo2 = termo2;


        }

        public void CalculaTermo()
        {
            if (termo1<0||termo2 <0)
               Console.WriteLine("Valores invalidos"); 
            else if (termo1 < termo2)
            {
                while (termo1 <= termo2)
                {
                    if (termo1 % 2 == 1)
                        Console.WriteLine(termo1);
                    termo1++;
                }

            }
            else
            {
                while (termo1 >= termo2)
                {
                    if (termo2 % 2 == 1)
                        Console.WriteLine(termo2);
                    termo2++;
                }

            }
        }
    }
}