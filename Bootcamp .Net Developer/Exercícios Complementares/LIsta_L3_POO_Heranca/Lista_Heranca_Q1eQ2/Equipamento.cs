using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Heranca_Q2
{
    public class Equipamento
    {
        
        protected int numeroEquipamentos;
        protected double[] valor;
     
        public Equipamento(int numeroEquipamentos)
        {
            this.numeroEquipamentos = numeroEquipamentos;
            this.valor = new double [numeroEquipamentos];
        }

        public int GetNumeroEquipamentos()
        {
            return numeroEquipamentos;
        }

        public double GetValor(int numero)
        {
            return this.valor[numero];
        }   
        public void SetValor(int numero, double valor)
        {
            this.valor[numero] = valor;
        }



    }
}
