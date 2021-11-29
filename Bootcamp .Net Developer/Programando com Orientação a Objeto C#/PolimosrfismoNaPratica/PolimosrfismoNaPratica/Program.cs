// See https://aka.ms/new-console-template for more information


using PolimorfismoNaPratica.Models;
 



Pessoa p1 = new Pessoa();
p1.idade = 18;
p1.nome = "bob";


Aluno a1 = new Aluno();

a1.nome = "José";
a1.idade = 15;
a1.nota = 9.5;

Professor pr1 = new Professor();

pr1.nome = "Luiz";
pr1.idade = 45;
pr1.salario = 5000;

a1.Apresentar(); // Polimorfismo late binding.
p1.Apresentar(); // Polimorfismo late binding.
pr1.Apresentar();// Polimorfismo late binding.

Calculadora somar = new Calculadora();

Console.WriteLine($"O resultado da soma é {somar.Soma(10,20)}");
Console.WriteLine($"O resultado da soma é {somar.Soma(10,20,30)}");

