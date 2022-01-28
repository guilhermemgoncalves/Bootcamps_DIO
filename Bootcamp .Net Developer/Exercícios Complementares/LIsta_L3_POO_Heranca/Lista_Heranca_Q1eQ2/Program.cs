using System;

namespace Lista_Heranca_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nEquipamentos = 4;
            Equipamento equipamento = new Equipamento(nEquipamentos);

            equipamento.SetValor(0, 1.5);
            Console.WriteLine(equipamento.GetValor(0)); 
            equipamento.SetValor(1, 2.5);
            Console.WriteLine(equipamento.GetValor(1)); 
            equipamento.SetValor(2, 3.5);
            Console.WriteLine(equipamento.GetValor(2)); 
            equipamento.SetValor(3, 4.5);
            Console.WriteLine(equipamento.GetValor(3)); 



        }
    }
}
