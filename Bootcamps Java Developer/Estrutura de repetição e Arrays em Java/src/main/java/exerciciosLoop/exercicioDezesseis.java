package exerciciosLoop;
// A série de Fibonacci é formada pela seqüência 0,1,1,2,3,5,8,13,21,34,55,... Faça um programa que gere a série até que o valor seja maior que 500.
public class exercicioDezesseis {
    public static void main(String[] args) {

        int termo1 = 0,termo2 = 1, resultado;
        System.out.println("Sequencia Fibonnaci: ");
        while (termo2<500)
        {

            System.out.println(termo1+", ");
            resultado = termo1 +termo2;
            termo1 = termo2;
            termo2 = resultado;



        }

    }
}
