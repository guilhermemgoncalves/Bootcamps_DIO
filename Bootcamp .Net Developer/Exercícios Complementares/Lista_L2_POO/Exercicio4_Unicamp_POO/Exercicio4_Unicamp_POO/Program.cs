
using Exercicio4_Unicamp_POO;

Gabarito gabarito = new Gabarito();
Prova prova = new Prova(gabarito);
string menu = "";
AlunoRepositorio repositorio = new();


while (menu !="x")
{
    Console.WriteLine("Questão 4 Menu");
    menu = Console.ReadLine().ToLower();
    Console.Clear();
    switch (menu)
    {
        case "1":
            Console.WriteLine("1 - Inserir prova");
            InserirProva();
            break;
        case "2":
            Console.WriteLine("2 - Lista: ");
            repositorio.Lista();
            break;
        case "3":
            Console.WriteLine("3 - Avaliação por aluno");
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;

    }
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


    Aluno aluno = new(prova.Nota(), prova.Acertos(), nome: nomeAluno, numeroDeChamada: numeroDaChamada, prova);

    Console.WriteLine(aluno);
    repositorio.Insere(aluno);
    
}


