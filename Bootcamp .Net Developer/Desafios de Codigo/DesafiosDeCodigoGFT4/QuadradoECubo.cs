using System;
using System.Collections.Generic;
using System.Text;

namespace DesafiosDeCodigoGFT4
{
    internal class QuadradoECubo
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j<=3; j++)
                {
                    Console.Write(i*i);
                    
                }
                Console.WriteLine();
            }

        }


    }
}
