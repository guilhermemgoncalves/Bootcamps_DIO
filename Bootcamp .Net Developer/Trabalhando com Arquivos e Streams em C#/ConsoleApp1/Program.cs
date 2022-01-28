using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, avg, e;

            a = 0.0;
            b = 9.9;
            c = 10.0;
            d = 0.0;

            avg = ((2 * a + 3 * b + 4 * c + 1 * d) / 10);
            avg = 5;
            Console.WriteLine("Media: " + avg.ToString("0.0"));
            e = 4.7;
            

            if (avg >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            if(avg<5)
            {
                Console.WriteLine("Aluno reprovado");
            }
            if(avg >= 5 && avg <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                //double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + e.ToString("0.0"));
                avg = (e + avg) / 2;
                if(avg>=5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if(avg<=4.9)
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + avg.ToString("0.0"));
            }


           
            
            
            
            
            
            
            
            
            
            
            
            //Console.WriteLine("Media final: " + avg.ToString("0.0"));


        }
        
    }
}

