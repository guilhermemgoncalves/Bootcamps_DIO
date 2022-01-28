
using Exercicio4_Unicamp_POO;

Gabarito gabarito = new Gabarito();
Prova prova = new Prova(gabarito);
string menu = "";
AlunoRepositorio repositorio = new();
Aluno alunoAtual = new (0.0, 0, "", 0, prova);



while (menu !="x")
{
    Console.WriteLine("Questão 4 Menu");
    Console.WriteLine("1) Inserir nova prova");
    Console.WriteLine("2) Consultar todas as provas");
    Console.WriteLine("3) Consultar maior prova");
    Console.WriteLine("4) Consultar nota da prova");
    Console.WriteLine("5) Consultar acertos da prova");
    menu = Console.ReadLine().ToLower();
    Console.Clear();
    switch (menu)
    {
        case "1":
            Console.WriteLine("1 - Inserir prova: ");
            InserirProva();
            break;
        case "2":
            Console.WriteLine("2 - Listar alunos e notas: ");
            ListaAlunos();
            break;
        case "3":
            Console.WriteLine("3 - Maior prova");
            Maior(alunoAtual);
            break;    
            case "4":
            Console.WriteLine("4 - Consultar nota da prova: ");
            ConsultaNota(alunoAtual);
            break;
        case "5":
            Console.WriteLine("5 - Consultar acertos da prova: ");
            ConsultaAcertos(alunoAtual);
            break;
        default:
            Console.WriteLine("Opção Invalida!");
            break;

    }
}

void ConsultaAcertos(Aluno alunoAtual)
{
    Console.WriteLine(alunoAtual.RetornaAcertos());
}

void ConsultaNota(Aluno alunoAtual)
{
    Console.WriteLine(alunoAtual.RetornaNota());
}

Console.WriteLine(gabarito);

void InserirProva()


{
    Console.WriteLine("Digite o nome do aluno");
    string nomeAluno = Console.ReadLine();
    Console.WriteLine("Digite o numero da chamada: ");
    int numeroDaChamada = int.Parse(Console.ReadLine());
    for (int i = 0; i < prova.respostaQuestao.Length; i++)
    {

        char entradaRespostaAluno;
        do
        {
            Console.WriteLine($"Por favor digite resposta da questão {(i + 1)} (A/B/C/D/E) ");
            entradaRespostaAluno = char.Parse(Console.ReadLine().ToLower());

            if (entradaRespostaAluno != 'a' ^ entradaRespostaAluno != 'b' ^ entradaRespostaAluno != 'c' ^ entradaRespostaAluno != 'd' ^ entradaRespostaAluno != 'e')
            {
                Console.Write("Resposta Incorreta, Digite novamente\n");
            }
            else
            {
                Console.Write($"Resposta resgistrada\n");
            }

        }
        
        while (entradaRespostaAluno != 'a' ^ entradaRespostaAluno != 'b' ^ entradaRespostaAluno != 'c' ^ entradaRespostaAluno != 'd' ^ entradaRespostaAluno != 'e');
        prova.respostaAluno(entradaRespostaAluno);
    }
    Console.Clear();


    Aluno aluno = new(prova.Nota(), prova.Acertos(), nome: nomeAluno, numeroDeChamada: numeroDaChamada, prova);

    Console.WriteLine(aluno);
    repositorio.Insere(aluno);
    alunoAtual = aluno;
   
    
}


void ListaAlunos()
{
    foreach (var alunos in repositorio.Lista())
    {
        Console.WriteLine($"Nº:{alunos.RetornaId()}. {alunos.RetornaNome()} -  Nota: {alunos.RetornaNota()}, Acertos: {alunos.RetornaAcertos()}" );
    }

}


void Maior(Aluno alunoAtual)
{
    var alunoMaior  = alunoAtual;   

    foreach (var alunos in repositorio.Lista())
    {
       
        if (alunos.RetornaNota() > alunoMaior.RetornaNota())
        {
             alunoMaior = alunos;
        }        
    }

    Console.WriteLine($"O Alunor com maior nota é: {alunoMaior}");

}

