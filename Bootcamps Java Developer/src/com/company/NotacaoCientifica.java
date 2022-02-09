package com.company;

import java.util.Scanner;

public class NotacaoCientifica {

    public static void main(String[] args)  {
        Scanner leitor = new Scanner(System.in);


        double numero = leitor.nextDouble();


        System.out.printf("%.4E", numero);


    }




}
