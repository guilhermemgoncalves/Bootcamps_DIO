package exerciciosLoop;

import java.util.Scanner;

// Faça um programa que peça um numero inteiro positivo e em seguida mostre este numero invertido.
//Exemplo:
//  12376489
//  => 98467321
public class exercicioQuarentaEOito {
    public static void main(String[] args) {

        String numeroDigitado;
        Scanner scanner = new Scanner(System.in);
        int i;

        numeroDigitado=scanner.next();

        for (i=numeroDigitado.length();i>0;i-- )
        {
            System.out.print(numeroDigitado.charAt(i-1));
        }

    }
}
