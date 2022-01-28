using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Heranca_Q2
{
    public class EquipamentoCorrigido : Equipamento

    {
        private int numeroEquipamentosCorrigidos;
        private int[] mesCompra;
        private int mesCorrente=1;

        public EquipamentoCorrigido(int numeroEquipamentos , int mesCorrente) : base(numeroEquipamentos)
        {
             
            this.mesCompra = new int[numeroEquipamentos];

        }

      

        public int SetMesCompra(int numero)
        {
            return mesCompra[numero];
        }
        public void SetMesCompra(int numero, int mesCompra)
        {
            this.mesCompra[numero] = mesCompra;
        }

        public int Corrige(int percentual)
        {

            foreach (var item in mesCompra)
            {
                if (item == mesCorrente)
                {
                    valor[1] = valor[1] * percentual;
                }

            }


            mesCorrente++;
            if(mesCorrente>=13)
            {
                mesCorrente = 1;
            }
            return this.mesCorrente;
        }
    }
}
