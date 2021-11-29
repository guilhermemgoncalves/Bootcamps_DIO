// See https://aka.ms/new-console-template for more information

using HerancaNaPratica.Models;

Aluno a1 = new Aluno();

a1.nome = "José";
a1.idade = 15;
a1.nota = 9.5;

Console.WriteLine($"O aluno {a1.nome} de idade {a1.idade}. tirou a nota : {a1.nota} ");

Professor p1 = new Professor();

p1.nome = "Luiz";
p1.idade = 45;
p1.salario = 5000;

Console.WriteLine($"O Professor {p1.nome} de idade {p1.idade}. recebe o salário de : {p1.salario} ");