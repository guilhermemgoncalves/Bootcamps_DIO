package exerciciosLoop;

import java.util.Scanner;

// Faça um programa que calcule o valor total investido por um colecionador em sua coleção de CDs e o valor médio gasto em cada um deles. O usuário deverá informar a quantidade de CDs e o valor para em cada um.
public class exercicioVinteEOito {
    public static void main(String[] args) {
        double valorTotal = 0, valorCd;
        int quantidade,i;
        Scanner scanner = new Scanner(System.in);

        System.out.println("Calculo de CD's");
        System.out.println("Digite qual a quantidade de CD's: ");
        quantidade = scanner.nextInt();

        for (i=0; i< quantidade; i++)
        {
            System.out.println("Digite o valor do "+ (i+1) +"o CD:");
            valorCd = scanner.nextDouble();
            valorTotal= valorCd+valorTotal;

        }
        System.out.println("Valor médio Gasto: "+ valorTotal/quantidade);
        System.out.println("Valor total: "+ valorTotal);

    }
}
