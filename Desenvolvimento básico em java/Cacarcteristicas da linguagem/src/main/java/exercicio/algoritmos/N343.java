/*
Algoritmo 342 - Criar um algoritmo que funcione com o seguinte menu:
|A - Imprime o nome que tiver maior numero de caractere entre 20 nomes
|B - Brinca com a palavra (Imprimir somando cada letra de uma palavra de cada vez ex: FILA, F->  FI -> FIL -> FILA
|C - Calcula e imprime a raiz quarta de um numero
|F - FInaliza o programa
 */

package exercicio.algoritmos;

import java.util.Locale;
import java.util.Scanner;

public class N343 {
    public static void main(String[] args){

        System.out.println("Menu");
        System.out.println("A - Imprime o nome que tiver maior numero de caractere entre 20 nomes");
        System.out.println("B  - Brinca com a palavra");
        System.out.println("C - Calcula e imprime a raiz quarta de um numero");
        System.out.println("F - FInaliza o programa");
        System.out.println("Digite uma opção acima: ");

        String leitura;
        int lernumero;

        Scanner ler = new Scanner(System.in);
        int i, maiornstr = 0;
        String maiorn = "";

        leitura = ler.next();
        leitura = leitura.toLowerCase();
        switch (leitura) {
            case "a":{
                System.out.println("A - Imprime o nome que tiver maior numero de caractere entre 20 nomes");

               for (i=1; i<=20; i++)
               {
                   leitura = ler.next();
                   System.out.println("Escreva o " +i +"º nome: " );
                if (maiornstr <= leitura.length())
                {
                    maiorn = leitura;
                    maiornstr = leitura.length();
                }


               }
                System.out.println("O maior nome é: " + maiorn);
                break;
            }
            case "b":{
                System.out.println("B  - Brinca com uma palavra");
                System.out.println("Digite a palavra desejada");
                leitura = ler.next();

                /*for (i=leitura.length(); i>0; i--)
                {
                    System.out.println(leitura.substring(0, i).toUpperCase());

                }*/
                for (i=0; i<=leitura.length(); i++)
                {
                    System.out.println(leitura.substring(0, i).toUpperCase());

                }


                break;
            }
            case "c":{
                System.out.println("C - Calcula e imprime a raiz quarta de um numero\nPor favor insira o numero desejado: ");
                lernumero = ler.nextInt();
                System.out.println("A raiz quarta de " +lernumero+ " é: " + Math.pow(lernumero, 0.25));

                break;
            }
            case "f": {

                System.out.println("F - Programa Finalizado");
                break;
            }
             default:
                 System.out.println("Opção Inválida");

            }
        }


    }




