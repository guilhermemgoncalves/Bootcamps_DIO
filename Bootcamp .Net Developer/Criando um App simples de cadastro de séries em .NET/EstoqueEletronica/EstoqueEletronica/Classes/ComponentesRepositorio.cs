using EstoqueEletronica.Interface;

namespace EstoqueEletronica
{
    public class ComponentesRepositorio : IRepositorio<Componentes>
    {
        private List<Componentes> listaComponentes = new List<Componentes> { };

        public List<Componentes> ListaComponentes { get => listaComponentes; set => listaComponentes = value; }

        public void Atualiza(int id, Componentes entidade)
        {
            ListaComponentes[id] = entidade;
        }

        public void Exclui(int id)
        {
            //_listaComponentes[id].Excluir();
        }

        public void Insere(Componentes entidade)
        {
            ListaComponentes.Add(entidade);
        }

        public List<Componentes> Lista()
        {
            return ListaComponentes;
        }

        public int ProximoId()
        {
            return ListaComponentes.Count;
        }

        public Componentes RetornaPorId(int id)
        {
            return ListaComponentes[id];
        }
    }
}
