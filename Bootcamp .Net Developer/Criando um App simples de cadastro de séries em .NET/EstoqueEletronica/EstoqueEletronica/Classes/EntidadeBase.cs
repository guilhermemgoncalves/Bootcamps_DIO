namespace EstoqueEletronica
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }//Criando um Id para o componentes, para que o objeto nunca mude de lugar.

    }
}