package exercicios;
import java.util.Scanner;
public class trigoNoTabuleiro {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        long graosAtual;
        long graosTotal = 0;


        for (int i = 0; i < n; i++) {
            int x = sc.nextInt();
            while (x > 0) {
                graosAtual = (long) Math.pow(2, (x - 1));
                graosTotal += graosAtual / 12; // quantidade de grãos para uma grama
                x--;
            }


            System.out.println(graosTotal / 1000 + " kg");   //imprime na tela a quantidade em Kg
            graosTotal = 0;
        } //loop de quantas vezes a contagem é executada

    }
}