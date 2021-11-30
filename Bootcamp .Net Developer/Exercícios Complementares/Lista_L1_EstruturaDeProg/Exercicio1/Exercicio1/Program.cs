// See https://aka.ms/new-console-template for more information

using Exercicio1;

ImprimeInteiros calc1 = new ImprimeInteiros();
int termo1;
int termo2; 

Console.WriteLine("Digite um valor para A: ");
termo1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para B: ");
termo2 = int.Parse(Console.ReadLine());

calc1.RecebeMedidas(termo1, termo2);

calc1.CalculaTermo();

