//Entrar com 15 numeros e imprimir a raiz quadrada de cada numero

package exercicio.algoritmos;

import java.util.Scanner;

public class N185 {

    public static void main(String[] args) {
        Scanner ler = new Scanner(System.in);
        Double numero, raiz;
        Integer i;

        for (i=0; i<=15; i++)
        {
            System.out.println("Por Favor, Digite um numero: ");
            numero = ler.nextDouble();
            if (numero<=0) {
                System.out.println("Não faço raiz negativa nem igual a zero");
            }
            else {

                System.out.println("A raiz de " + numero + " é :" + Math.sqrt(numero));
            }


        }

    }
}
