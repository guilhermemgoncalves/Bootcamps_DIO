package exercicio.algoritmos;

import java.util.Scanner;

public class N278 {

    public static void main(String[] args) {
        Scanner ler = new Scanner(System.in);

        int i, modulo, divisao ;
        boolean primo = true;

        System.out.println("Digite um numero: ");
        int numero = ler.nextInt();
        i = numero;


        System.out.println(i + " " + numero);

        while (i != 2) {
            i--;
            modulo = numero % i;
            divisao = numero / i;
            System.out.println("Contador: " + i + " Numero: " + numero + " Divisão: " + divisao + " Módulo: " + modulo);

            if (modulo == 0) {
                primo = false;

            }
        }
        if (primo == false )
            System.out.println("O numero não é primo!");
        else
            System.out.println("O numero é primo!");
    }

    }

