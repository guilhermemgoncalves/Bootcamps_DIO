package com.company;

import java.text.DecimalFormat;
import java.text.MessageFormat;
import java.util.Scanner;

public class Experiencias {

    public static void main(String[] args) {


        Scanner input = new Scanner(System.in);
        int b;
        char c;
        int d = 0, e = 0, f = 0, i, t = 0;
        int a = input.nextInt();

        for (i = 0; i < a; i++) {
            b = input.nextInt();// Valor estático de cobaias recebido
            c = input.next().toUpperCase().charAt(0);

            if (c == 'C') {
                d += b;  // d= coelhos
            }
            else if (c == 'R') {
                e += b;  // e = ratos
            }
            else {
                f += b;  // f = sapo
            }

            t = d + e+ f; // total de cobaias

        }

        String message = MessageFormat.format("Total: {0} cobaias",t);
        System.out.println(message);
        message = MessageFormat.format("Total de coelhos: {0}",d);
        System.out.println(message);
        message = MessageFormat.format("Total de ratos: {0}",e);
        System.out.println(message);
        message = MessageFormat.format("Total de sapos: {0}",f);
        System.out.println(message);


        message = MessageFormat.format("Percentual de coelhos: {0} %", ((d*1.0)/(t*1.0)*100));
        System.out.println(message);

        message = MessageFormat.format("Percentual de ratos: {0} %", ((e*1.0)/(t*1.0)*100));
        System.out.println(message);

        message = MessageFormat.format("Percentual de sapos: {0} %", ((f*1.0)/(t*1.0)*100));
        System.out.println(message);

        message = String.format("Total: %s cobaias",t);
        System.out.println(message);
        message = String.format("Total de coelhos: %s",d);
        System.out.println(message);
        message = String.format("Total de ratos: %s",e);
        System.out.println(message);
        message = String.format("Total de sapos: %s",f);
        System.out.println(message);

        DecimalFormat  fmt = new DecimalFormat("0.00");

        double pct = ((d*1.0)/(t*1.0)*100);
        String novapct = fmt.format(pct);

        message = String.format("Percentual de coelhos: %s %%", (novapct));
        System.out.println(message);

        pct = ((e*1.0)/(t*1.0)*100);
        novapct = fmt.format(pct);

        message = String.format("Percentual de ratos: %s %%", (novapct));
        System.out.println(message);

        pct = ((f*1.0)/(t*1.0)*100);
        novapct = fmt.format(pct);

        message = String.format("Percentual de sapos: %s %%", (novapct));
        System.out.println(message);



    }
}
