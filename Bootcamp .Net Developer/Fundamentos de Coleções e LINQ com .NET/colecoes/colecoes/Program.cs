
using colecoes.Helper;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (KeyValuePair<string, string> item in estados )
{

    Console.WriteLine($"Chave: {item.Key}, Valor:{item.Value}");


}


string valorProcurado = "BA";
estados.Remove(valorProcurado);


if(estados.TryGetValue(valorProcurado, out string estadoEnconstrado))
{
    Console.WriteLine(estadoEnconstrado);
}else
{
    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário! ");
}

//estados[valorProcurado] = ("Atualização");
//Console.WriteLine(estados[valorProcurado]);


//Stack<String> pilhaLivros = new Stack<String>();

//pilhaLivros.Push(".NET");
//pilhaLivros.Push("JS");
//pilhaLivros.Push("Clean Code");

//Console.WriteLine(pilhaLivros);
//Console.WriteLine($"Quantidade de livros para leitura {pilhaLivros.Count}");

//while(pilhaLivros.Count > 0)
//{
//    Console.WriteLine($"Proximo livro para a leitura; {pilhaLivros.Peek()}");
//    Console.WriteLine($" {pilhaLivros.Pop()}, lido com sucesso.");
//}



//Queue<string> fila = new Queue<string>();

//fila.Enqueue("Guilherme");
//fila.Enqueue("Priscila");
//fila.Enqueue("Edna");

//while (fila.Count > 0)
//{
//    Console.WriteLine($"Vez de: {fila.Peek()}");
//    Console.WriteLine( fila.Dequeue()+ " Atendido");
//}










//OperacoesArray  op = new OperacoesArray();

//int[] array = new int[5] { 4, 9, 1, 3, 2 };
//int[] array2 = new int[10];

//System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
//op.RedmensionarArray(ref array, array.Length * 2);
//System.Console.WriteLine($"A nova capacidade do array: {array.Length}");
//OperacoesLista opLista = new OperacoesLista();

//string[] EstadosArray = new string[2] { "SC", "MT" };

//List<string> estados = new List<string> { "SP", "MG", "BA" };//inserindo elementos na lista


//opLista.ImprimirListaString(estados);
//Console.WriteLine("Removendo elemento");
//estados.Remove("MG");
//estados.AddRange(EstadosArray);  
//estados.Insert(1, "RJ");

//opLista.ImprimirListaString(estados);







//int valorProcurado = 2;

//bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

//int valorAchado = op.ObterValor(array, valorProcurado);

//int indice = op.ObterIndice(array, valorProcurado);

//Console.WriteLine(indice);

//Console.WriteLine(valorAchado);



//if (todosMaiorQue)
//{
//    Console.WriteLine($"Todos os valores são maior que {valorProcurado}");
//}
//else{
//    Console.WriteLine($"Existe valores menores que {valorProcurado}");
//}


//bool existe = op.Existe(array, valorProcurado);

//if(existe)
//Console.WriteLine($"O valor {valorProcurado} existe!");
//else
//Console.WriteLine($"O valor {valorProcurado} não existe!");

//Console.WriteLine("Array original");
//op.ImprimirArray(array);
////op.OrdenarBubblueSort(array);
////op.Ordenar(ref array);
//op.Copiar(ref array,ref array2);

////Console.WriteLine("Array ordenado");
////op.ImprimirArray(array);

//Console.WriteLine("Array copiado");
//op.ImprimirArray(array2);