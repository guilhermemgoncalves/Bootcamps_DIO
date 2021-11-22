package exerciciosLoop;

import java.util.Scanner;

//O Departamento Estadual de Meteorologia lhe contratou para desenvolver um programa que leia as um conjunto indeterminado de temperaturas, e informe ao final a menor e a maior temperaturas informadas, bem como a média das temperaturas.
public class exercicioTrintaETres {
    public static void main(String[] args) {
        double temperatura,totaliza = 0, menor=0, maior=0;
        int i,n;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Digite a quantidade de temperaturas a serem lidas: ");
        n = scanner.nextInt();
        for (i=0; i<n;i++)
        {
                    System.out.println("Digite a " + (i+1) +"a temperatura: ");
                    temperatura = scanner.nextDouble();

                    totaliza = totaliza+ temperatura;

                    if (maior<temperatura)
                        maior = temperatura;
                    if (menor==0)
                        menor =temperatura;
                    if (menor>temperatura)
                        menor = temperatura;



        }
        System.out.println("Média de temperatura: " + totaliza/n);
        System.out.println("Maior temperatura: "+ maior);
        System.out.println("Menor temperatura: "+ menor);
    }
}
