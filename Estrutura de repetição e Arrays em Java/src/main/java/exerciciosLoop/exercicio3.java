/*
Faça um programa que leia e valide as seguintes informações:
        Nome: maior que 3 caracteres;
        Idade: entre 0 e 150;
        Salário: maior que zero;
        Sexo: 'f' ou 'm';
        Estado Civil: 's', 'c', 'v', 'd';
*/


package exerciciosLoop;

import java.util.Scanner;

public class exercicio3 {
    public static void main(String[] args) {

        String nome;
        int idade;
        int salario;
        String sexo, estadoCivil;


        Scanner scanner = new Scanner(System.in);

        do {
            System.out.print("Por favor digite seu nome(Minimo três caracteres): ");
            nome = scanner.next();
            if (nome.length() < 3) {
                System.out.println("Nome Inválido.");
            }

        } while (nome.length() < 3);
        System.out.println("Nome: " + nome);

        do {
            System.out.print("Por favor digite sua idade (0 a 150): ");
            idade = scanner.nextInt();

            if (idade > 150 || idade < 0)
            {
                System.out.println("Valor invalido.");
            }
            else
            {
                System.out.println("idade: " + idade);
            }

        } while (idade > 150 || idade < 0);


        do {
            System.out.print("Por favor digite seu salário (>0): ");
            salario = scanner.nextInt();
            if (salario < 0)
            {
                System.out.println("Valor invalido.");
            }
            else
            {
                System.out.println("Salário: " + salario);
            }

        } while (salario < 0);


        System.out.print("Por favor digite seu Sexo(f/m): ");



    }
}