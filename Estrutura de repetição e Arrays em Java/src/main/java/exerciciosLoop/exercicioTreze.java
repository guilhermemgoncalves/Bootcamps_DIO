package exerciciosLoop;

import java.util.Scanner;

// Faça um programa que peça dois números, base e expoente, calcule e mostre o primeiro número elevado ao segundo número. Não utilize a função de potência da linguagem.
public class exercicioTreze {

    public static void main(String[] args) {

        int base, expoente,potencia = 1;
        Scanner scanner= new Scanner(System.in);

        System.out.println("Calculadora de potencia");
        System.out.println("Digite o valor da base: ");
        base = scanner.nextInt();
        System.out.println("Digite o valor do expoente: ");
        expoente = scanner.nextInt();

        while (expoente>0)
        {
            potencia = base*potencia;
            expoente--;
        }
        System.out.println("O resultado da potencia é: "+potencia);
    }
}
