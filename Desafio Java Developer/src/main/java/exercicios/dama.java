package exercicios;

import java.util.Scanner;

public class dama {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int x1,y1,x2,y2, auxx, auxy;

        while (true)
        {
            x1= sc.nextInt();
            x2= sc.nextInt();
            y1= sc.nextInt();
            y2= sc.nextInt();
            auxx = x2-x1;//variavel para saber quantas casas foram movimentadas em x
            auxy = y2-y1;//variavel para saber quantas casas foram movimentadas em y
            if (auxx < 0)
            {
                auxx = auxx*-1;
            } //converte o numero de casas sempre para positivo em x
            if (auxy < 0)
            {
                auxx = auxx*-1;
            } //converte o numero de casas sempre para positivo em y
            if(x1 == 0 && y1 == 0 && x2 == 0 && y2 == 0) break; //condição de parada
            if(x1 == x2 & y1 == y2)
                System.out.println("0");
            else if(  x1==x2 || y1==y2 ) //movimento horizontal ou vertical
                System.out.println("1");
            else if(auxx==auxy) // movimento diagonal, consiste em o mesmo numero de variação de colunas por linhas
                System.out.println("1");
            else
                System.out.println("2");

        }

    }
}
