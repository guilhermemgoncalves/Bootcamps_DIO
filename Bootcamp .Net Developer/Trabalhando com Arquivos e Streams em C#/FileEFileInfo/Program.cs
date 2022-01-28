using System;
using System.IO;

namespace FileEFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva o nome do arquivo.");
            var nome = Console.ReadLine(); //Usuário escreve o nome do arquivo no console

            nome = LimparNome(nome); // chamada do metodo limpa nome, que limpa nome do arquivo

            var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");// cria o caminho de salvar o arquivo em txt.

            CriarArquivo(path); // Criar o arquivo de fato.

            Console.WriteLine("Digite enter para finalizar...");
            Console.ReadLine();


            static string LimparNome(string nome)
            {

                foreach (var @char in Path.GetInvalidFileNameChars())// @ permite que usemos o nome de um primitivo, cria um array de caracteres que são valores invalidos para Path
                {
                    nome = nome.Replace(@char, '-'); // caso haja um caractére inválido para nome de arquivo, será substituido por um traço

                }
                return nome;
            }

        }

        static void CriarArquivo(string path)// metodo de criação de arquivo
        {
            try // exceção para caso o nome que entre for invalido ele irá retornar uma mensagem em vez de criar o arquivo.
            {
                using var sw = File.CreateText(path);

                sw.WriteLine("Linha1");
                sw.WriteLine("Linha2");
                sw.WriteLine("Linha3");
            }
            catch
            {
                Console.WriteLine("O nome do arquivo está inválido!");
            }
        }
    
        
    }
}
