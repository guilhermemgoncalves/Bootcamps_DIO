using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Unicamp_POO
{
    public class Aluno
    {

        private double nota;
        private int acertos;
        private string nome;
        private int numeroDeChamada;
        private Prova prova;

        public Aluno(double nota, int acertos, string nome, int numeroDeChamada, Prova prova)
        {
            this.nota = nota;
            this.acertos = acertos;
            this.nome = nome;
            this.numeroDeChamada = numeroDeChamada;
            this.prova = prova;
        }

        public int RetornaId()
        {
            return this.numeroDeChamada;
        }
        public string RetornaNome()
        {
            return this.nome;
        }
        public double RetornaNota()
        {
            return this.nota;
        }
        public int RetornaAcertos()
        {
            return this.acertos;
        }

        public override string ToString()
        {
            return $"Numero da chamada: {numeroDeChamada} | nome: {nome} | acertos: {acertos}| Nota: {nota}\nProva: {prova}";
        }
    }
}
