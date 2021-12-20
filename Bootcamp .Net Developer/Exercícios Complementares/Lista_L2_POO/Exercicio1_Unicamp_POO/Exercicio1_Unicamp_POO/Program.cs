//Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina
//Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho.
//Escreva os seguintes métodos para esta classe:
//Media: Calcula a média final do aluno (cada prvoa tem peso 2.5 e o trabalho tem peso 2)
//final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for para a final).

using Exercicio1_Unicamp_POO;

Console.WriteLine("---------------------");
Console.WriteLine("Calculadora de médias");
Console.WriteLine("---------------------");

Console.WriteLine("");

Console.WriteLine("Digite seu nome: ");
string entradaNome = Console.ReadLine();
Console.WriteLine("Digite sua matrícula: ");
int entradaMatricula = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota da P1: ");
double entradaProvaUm =  double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da P2: ");
double entradaProvaDois =  double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do trabalho: ");
double entradaTrabalho =  double.Parse(Console.ReadLine());


Aluno aluno1 = new(matricula: entradaMatricula,
    nome: entradaNome,
    notaProvaUm: entradaProvaUm,
    notaProvaDois:  entradaProvaDois,
    notaTrabalho: entradaTrabalho);


Console.WriteLine(aluno1.ToString());