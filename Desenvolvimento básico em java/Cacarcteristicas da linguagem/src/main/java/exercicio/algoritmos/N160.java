/*Entrar com valor de x e imprimir y
    | 1, SE <=1
y =  | 2, SE 1<X<=2
      |  X^2, SE 2<X<=3
       | X^3, SE X>3
  */


package exercicio.algoritmos;

import java.util.Scanner;

public class N160 {
    public static void main(String[] args) {

        System.out.println("Digite o Valor de X");
        Scanner ler = new Scanner(System.in);
        Double x, y=0.;

        x = ler.nextDouble();

        if (x <= 1)
        {   y= 1.;

        } else if ( x <= 2)
        {   y = 2.;

        }else if ( x <= 3)
        {   y = x*x;

        }else if ( x > 3)
        {   y = x*x*x;

        }
        System.out.println("O Valore de Y é: " + y );


    }

}
