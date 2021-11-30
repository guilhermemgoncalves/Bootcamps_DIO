// See https://aka.ms/new-console-template for more information
using Exercicio2_POO.Models;

string nome, salario;
Funcionario funcionario = new Funcionario();

while (true)
{
    Console.WriteLine("Por favor Digite o seu nome: ");
    nome = Console.ReadLine();
    if (nome.ToLower().Equals("fim"))
    {
        break;
    }
    Console.WriteLine("Por favor Digite o seu salário: ");
    salario = Console.ReadLine();
    
    funcionario.PegarDados(nome, salario);
    funcionario.ImprimirDados();

}
funcionario.ImprimirTotal();