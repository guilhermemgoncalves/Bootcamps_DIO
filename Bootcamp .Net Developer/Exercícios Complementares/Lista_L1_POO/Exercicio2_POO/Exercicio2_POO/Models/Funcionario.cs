using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_POO.Models
{
    public class Funcionario
    {
        private string nome;
        private double salario;
        private double salarioReajustado;
        private double somaAtuais;
        private double somaReajustados;
        private double ajuste;

        public void PegarDados(string nome, string salario)
        {
            this.nome = nome;
            this.salario = Convert.ToDouble(salario);
        }
        private void Ajustar()
        {
            if (salario < 0)
            {
                ajuste = 0;
                Console.WriteLine("Valor Inválido");
            }
            else if (salario < 150)
            {
                { ajuste = 1.25; }
            }
            else if (salario < 300)
            {
                ajuste = 1.20;
            }
            else if (salario < 600)
            { ajuste = 1.15; }
            else
            { ajuste = 1.10; }
            salarioReajustado = salario * ajuste;
        }
        private void Totalizar()
        {
            somaAtuais += salario;
            somaReajustados += salarioReajustado;
        }

        public void ImprimirDados()
        {
            Ajustar();
            Totalizar();
            Console.WriteLine($"Funcionário {nome} \nSalário: {salario}\nSalario reajustado: {salarioReajustado} ");
        }
        public void ImprimirTotal()
        {
            Console.WriteLine($" A soma dos salários atuais é: {somaAtuais}\nA soma dos salários com reajuste é: {somaReajustados}");
        }

    }
}
