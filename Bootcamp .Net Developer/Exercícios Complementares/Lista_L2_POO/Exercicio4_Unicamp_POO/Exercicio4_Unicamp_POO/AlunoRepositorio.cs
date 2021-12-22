using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Unicamp_POO
{
    public class AlunoRepositorio
    {
        private List<Aluno> listaAluno = new List<Aluno>();

        public void Insere(Aluno entidade)
        {
            listaAluno.Add(entidade);
        }
        public List<Aluno> Lista()
        {
            return listaAluno;
        }
    }
}
