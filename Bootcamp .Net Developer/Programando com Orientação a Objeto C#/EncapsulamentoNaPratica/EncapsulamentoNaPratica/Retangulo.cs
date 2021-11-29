using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoNaPratica
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMerdidas(double comprimento, double largura)

        {
            if (comprimento > 0 && largura>0)
                {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            } else
            {
                Console.WriteLine("Valores Invalidos");
            }

        }
        public double ObterArea()
        {
            if (valido)
                return comprimento * largura;
            else
            { Console.WriteLine("Preencha valores validos");
                return 0;
            }

        }
    }
}
