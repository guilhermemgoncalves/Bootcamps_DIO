package exercicio.algoritmos;
//Exercício 262 - Entrar com numeros e imprimir o triplo de cada número, o algoritmo acaba quando entrar o numero -999


import java.util.Scanner;



public class N262 {
    public static void main(String[] args) {
        int numero = 0;
        while (numero != -999){
            Scanner ler = new Scanner(System.in);

            System.out.println("Digite um numero para exibir o seu triplo ou -999 para encerrar o programa: ");
            numero = ler.nextInt();
            System.out.println("O Triplo do numero " +numero +" é igual a: " +(numero*3));


        } ;
    }



}
