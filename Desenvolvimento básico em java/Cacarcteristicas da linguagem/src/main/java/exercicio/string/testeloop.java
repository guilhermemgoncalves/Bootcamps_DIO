package exercicio.string;

import javax.swing.*;
import java.util.Scanner;

public class testeloop {
    public static void main(String[] args) {
        System.out.println("Digite a quantidade de casas consideradas: ");
        Scanner ler = new Scanner(System.in);
        int x = ler.nextInt();



        long graosAtual ;
        long graosTotal =0;
        long aux=0;
        long aux2=0;
        long pesoKg;
        while (x>0)
            while (x>0)
            {
                graosAtual= (long) Math.pow(2, (x-1));
                System.out.println("Graos total:"+graosTotal+" x: "+ x +" Graos atual "+ graosAtual +" Aux "+ aux+" Aux2 "+ aux2);

                    graosTotal += graosAtual/12;


                    x--;

            }


        System.out.println("Peso Kg: "+((graosTotal/1000)));

    }
}
