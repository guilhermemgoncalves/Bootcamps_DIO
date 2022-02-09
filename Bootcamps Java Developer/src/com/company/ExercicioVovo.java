package com.company;

import java.util.Scanner;

public class ExercicioVovo {


    public static void main(String[] args)  {
        Scanner leitor = new Scanner(System.in);
        double A = leitor.nextDouble();
        double B = leitor.nextDouble();


        double porcentagem = (B/A - 1)*100;
        String porcentagemValor = String.format("%.2f", porcentagem);

        System.out.println(porcentagemValor + "%");
    }
}
