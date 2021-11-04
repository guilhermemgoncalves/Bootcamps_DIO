/*Exercício 49
Entrar com um nome e imprimir os dados:
Todo o nome
Primeiro caractere
Ultimo Carcatere
Do primeiro ao terceiro caractere
quarto caractere
todos menos o primeiro
os dois ultimos

 */

package exercicio.algoritmos;

import java.util.Scanner;

public class N49 {

    public static void main(String[] args) {

        Scanner ler = new Scanner(System.in);
        String nome;

        System.out.println("Informe um nome:");
        nome = ler.nextLine();

        System.out.println("Primeiro caractere: "+ nome.charAt(0));
        System.out.println("Ultimo caractere: "+ nome.charAt(nome.length()-1));
        System.out.println("Do primeiro ao terceiro: " + nome.substring(0,3));
        System.out.println("Quarto caractere: " + nome.charAt(3));
        System.out.println("menos o primeiro: " + nome.substring(1));
        System.out.println("Os dois ultimos: " + nome.substring(nome.length()-2));





    }

}
