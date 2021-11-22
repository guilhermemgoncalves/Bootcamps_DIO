package exerciciosLoop;

import java.util.Scanner;

/*Faça um programa que leia uma quantidade indeterminada de números positivos e conte quantos deles estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [76-100]. A entrada de dados deverá terminar quando for lido um número negativo.*/
public class exercicioQuarentaEDois {
    public static void main(String[] args) {
        int numeroLido;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Digite o numero para saber seu intervalo: ");
        numeroLido = scanner.nextInt();

        while (numeroLido>=0)
        {
            System.out.print("Intervalo ");
            if (numeroLido<=25&&numeroLido>0)
            {
                System.out.println("[0-25]");
            }
            else if (numeroLido>=26&&numeroLido<=50)
            {
                System.out.println("[26-50]");
            }else if (numeroLido>=51&&numeroLido<=75)
            {
                System.out.println("[51-75]");
            }else if (numeroLido>=76&&numeroLido<=100)
            {
                System.out.println("[76-100]");
            } else
                System.out.println("não disponível");
            System.out.println("Digite o numero para saber seu intervalo: ");
            numeroLido = scanner.nextInt();

        }




    }
}
