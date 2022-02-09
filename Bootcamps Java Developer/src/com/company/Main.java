package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int numero = scan.nextInt();



        for(int i =2; numero >= i; i+=2)
        {
            System.out.println(i);
        }
    }
}
