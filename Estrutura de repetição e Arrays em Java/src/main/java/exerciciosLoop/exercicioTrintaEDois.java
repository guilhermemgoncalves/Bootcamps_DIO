package exerciciosLoop;
/*
Faça um programa que calcule o fatorial de um número inteiro fornecido pelo usuário. Ex.: 5!=5.4.3.2.1=120. A saída deve ser conforme o exemplo abaixo:
        Fatorial de: 5
        5! =  5 . 4 . 3 . 2 . 1 = 120
*/

import java.util.Scanner;

public class exercicioTrintaEDois {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n, fatorial=1;



        System.out.println("Calculadora de Fatorial");
        System.out.println("Digite o numero do fatorial a ser calculado:");
        n =  scanner.nextInt();
        System.out.println("Fatorial de: " +n);
        System.out.print(n+"! = " );

        while(n>1)
        {
            System.out.print(n+" . ");
            fatorial=fatorial*n;
            n--;

        }
        System.out.print("1 = "+ fatorial);



    }




}
