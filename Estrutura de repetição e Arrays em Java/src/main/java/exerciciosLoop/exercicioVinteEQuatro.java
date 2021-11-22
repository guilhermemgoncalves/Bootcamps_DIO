package exerciciosLoop;

import java.util.Scanner;

//Faça um programa que calcule o mostre a média aritmética de N notas.
public class exercicioVinteEQuatro {

    public static void main(String[] args) {
        double nota, acumulador = 0;
        int n, i;
        Scanner scanner = new Scanner(System.in);


        System.out.println("***Programa média aritimetica***");
        System.out.println("Digite o numero de notas para o calculo da média: ");
        n = scanner.nextInt();

        for (i=0;i<n;i++)
        {
            System.out.println("Por favor Digite a " +(i+1) + "a nota");
            nota = scanner.nextInt();
            acumulador = nota + acumulador;

        }
        System.out.println("A média é : "+(acumulador/n));
    }
}
