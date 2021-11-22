package exerciciosLoop;

import java.util.Scanner;

/*Um funcionário de uma empresa recebe aumento salarial anualmente: Sabe-se que:
        Esse funcionário foi contratado em 1995, com salário inicial de R$ 1.000,00;
        Em 1996 recebeu aumento de 1,5% sobre seu salário inicial;
        A partir de 1997 (inclusive), os aumentos salariais sempre correspondem ao dobro do percentual do ano anterior. Faça um programa que determine o salário atual desse funcionário. Após concluir isto, altere o programa permitindo que o usuário digite o salário inicial do funcionário.*/
public class exercicioTrintaEOito {


    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double salario=1000,juros= 0.015;
        int i;

        for(i=0; i<=24; i++)
        {
            salario = (salario*juros) + salario;

            juros = juros * 2;
        }
        System.out.println("O salário atual é: " + salario +" e a taxa de juros atual é: "+ juros*100);
    }
}
