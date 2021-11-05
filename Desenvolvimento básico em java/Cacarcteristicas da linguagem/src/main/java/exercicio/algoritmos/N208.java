//Crie um aloritmo que imprima os 10 primeiro termos da serie fibonnaci. o primeiros termos da serie são 1 e 1
package exercicio.algoritmos;

public class N208 {

    public static void main(String[] args) {
        int t1=1, t2=1, i, aux;

        for (i=1;i<=10;i++) {
            System.out.println("O " + i + "º Termo da Série Fibonnaci é: " + t1);
            aux = t1;
            t1 = t2 + t1;
            t2 = aux;
        }

    }
}
