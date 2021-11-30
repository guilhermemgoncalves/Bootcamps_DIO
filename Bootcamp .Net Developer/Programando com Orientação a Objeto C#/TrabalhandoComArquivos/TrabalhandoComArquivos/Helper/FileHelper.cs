using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(String caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivos(string caminho)
        {
            var retornaArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
            foreach (var retorno in retornaArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);

        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
                File.WriteAllText(caminho, conteudo);
        }


        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
         public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }

        }
        public void LerArquivo(String caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha);
            }

        }
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine())!= null)
                {
                    Console.WriteLine(linha);
                }
            }

        }
        public void MoverArquivo(string caminho, string novocaminho)
        {
            File.Move(caminho, novocaminho);
        }
        public void CopiarArquivo(string caminho, string novocaminho, bool sobrescrever)
        {
            File.Copy(caminho, novocaminho, sobrescrever);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}
