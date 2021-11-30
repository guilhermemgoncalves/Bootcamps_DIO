// See https://aka.ms/new-console-template for more informatio
using TrabalhandoComArquivos.Helper;
using System.IO;

var caminho = "C:\\PastaTeste";
var novocaminho = Path.Combine(caminho, "PastaTeste3");
FileHelper helper = new FileHelper();
helper.ListarDiretorios(caminho);
helper.ListarArquivos(caminho);
helper.CriarDiretorio(Path.Combine(caminho, "PastaTeste3", "Subpasta Teste3"));
helper.ApagarDiretorio(Path.Combine(caminho, "PastaTeste1"), false);

helper.CriarArquivoTexto(Path.Combine(caminho,"arquivo teste.txt"),  "teste de escrita de arquivo");
var listaString = new List<string> { "linha1", "Linha2", "linha3" };
var listaString2 = new List<string> { "linha4", "Linha5", "linha6" };
helper.CriarArquivoTextoStream(Path.Combine(caminho, "arquivo teste-stream.txt"), listaString);
helper.AdicionarTextoStream(Path.Combine(caminho, "arquivo teste-stream.txt"), listaString2);

helper.LerArquivoStream(Path.Combine(caminho, "arquivo teste-stream.txt"));
helper.MoverArquivo(Path.Combine(caminho, "arquivo teste.txt"), Path.Combine(novocaminho, "arquivo teste.txt"));
helper.CopiarArquivo(Path.Combine(novocaminho, "arquivo teste.txt"), Path.Combine(caminho, "arquivo teste.txt"), false);

helper.DeletarArquivo(Path.Combine(novocaminho, "arquivo teste.txt"));