package exercicios;

import java.util.Scanner;

public class exercicioParOuImpar {
    public static void main(String[] args) {
        System.out.println("Digite a quantidade de numeros para a leitura: ");
        Scanner leitor = new Scanner(System.in);
        int N = leitor.nextInt();
        for (int i = 0; i<N; i++)
        {
            System.out.println("Digíte um número entre 107 e -107: ");
            int x = leitor.nextInt();

            System.out.println(x);


            if (x==0) //verifica se o numero é zero
            {
                System.out.println("NULL");
            }
            else if (x > 0) {
                 if ((x % 2) == 1) {
                    System.out.println("ODD POSITIVE");
                } //Verifica se o numero é impar
                 else  {
                    System.out.println("EVEN POSITIVE");
                }
            } // Verifíca se o numero é positívo.
            else
            {
                x=x*-1; //Inversão de Sinal para poder fazer a divisão
                if ((x % 2) == 1) {
                    System.out.println("ODD NEGATIVE");
                } //Verifica se o numero é pár ou ímpar.
                else  {
                    System.out.println("EVEN NEGATIVE");
                }
            } // Age caso o numero seja negatívo.

        }

    }

}
