namespace EstoqueEletronica
{
    public class Componentes : EntidadeBase
    {
        //Parametros do componente (além do Id que é herdado da entidade base)
        private string nomeComponente { get; set; }
        private Tipo tipo { get; set; }
        private string infoComplementares { get; set; }
        private int quantidade { get; set; }


        public Componentes(int Id, string nomeComponente, Tipo tipo, string infoComplementares, int quantidade) //Encapsulamento dos atributos da classe
        {
            this.Id = Id;
            this.nomeComponente = nomeComponente;
            this.tipo = tipo;
            this.infoComplementares = infoComplementares;
            this.quantidade = quantidade;
        }

        public string RetornaNome() //Metodo que retorna o nome do componente
        {
            return nomeComponente;
        }
        public int RetornaQuantidade() // Metodo que retorna a quantidade de componentes
        {
            return quantidade;
        }

        public int RetornaId() // Método que retorna Id do componente
        {
            return Id;
        }
        public Tipo RetornaTipo()
        {
            return tipo;
        }
        public string RetornaInfos()
        {
            return infoComplementares;
        }
        public int modificaQuantidade(int valor)
        {
            int valorFinal = quantidade + valor;
            return valorFinal;

        }
        public override string ToString() //Método que apresenta todos os atributos da classe e seus respectivos valores estáticos
        {
            string retorno = "";
            retorno += "Componentes: " + nomeComponente + Environment.NewLine;
            retorno += "Tipo: " + tipo + Environment.NewLine;
            retorno += "Informações complementares: " + infoComplementares + Environment.NewLine;
            retorno += "Quantidade atual: " + quantidade + Environment.NewLine;
            return retorno;

        }

    }
}
