/*Criar um algoritmo que leia vários numeros terminados por 0 e imprima o maior, menor e a madia aritmética dos numero.
* o Numero 0 não pode fazer parte da sequência.
* */


package exercicio.algoritmos;

import java.util.Scanner;

public class N292 {
    public static void main(String[] args) {
        Scanner ler = new Scanner(System.in);

        double numero, maior=0, menor, soma=0, conta=0;

      //Primeira leitura inicia outras variáveis por isso fica de fora do do/while

        System.out.printf("Digite o numero, quando quizer finalizar digite 0: ");
        numero = ler.nextInt();
        maior = numero;
        menor = numero;
        do {

            if (numero!= 0)
            {
                soma=soma+numero;
                if (numero>maior)
                    maior =numero;
                if (numero<menor)
                    menor = numero;
            }
            System.out.printf("Digite o numero, quando quiser finalizar digite 0: ");
            numero = ler.nextInt();
            conta++;
        }
        while (numero!=0);

        System.out.println("Maior: " + maior +" Menor: " + menor +" Media: " +  soma/conta );
    }
}
