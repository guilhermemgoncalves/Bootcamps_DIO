
//Ler dois numeros e exibir a sua soma. Antes do resultado, deverá aparecer a mensagem. SOMA:

package exercicio.algoritmos;

import java.util.Scanner;

public class N37 {
    public static void main(String[] args) {
        Integer num1;
        Integer num2;
        Scanner ler = new Scanner(System.in);

        System.out.println("Entre com o primeiro numero: ");
        num1 = ler.nextInt();

        System.out.println("Entre com o segundo numero: ");
        num2 = ler.nextInt();

        System.out.println("SOMA:" + (num1+num2));

    }
}
