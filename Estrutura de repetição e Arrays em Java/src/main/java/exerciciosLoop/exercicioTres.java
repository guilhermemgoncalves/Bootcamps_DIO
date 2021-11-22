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

public class exercicioTres {
    public static void main(String[] args) {

        String nome;
        int idade;
        int salario;
        String sexo, estadoCivil;
        boolean auxsex = false, auxest=false;


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

        while(!auxsex) {
            System.out.print("Por favor digite seu Sexo(f/m): ");
            sexo = scanner.next();


            if (sexo.equalsIgnoreCase("f")) {
                System.out.println("Sexo feminino");
                auxsex = true;

            } else if (sexo.equalsIgnoreCase("m")) {
                System.out.println("Sexo Masculino");
                auxsex = true;
            } else
                System.out.println("Sexo Inválido.");

        }while(!auxest) {
            System.out.print("Por favor digite seu estado civil: (s, c, v, d) ");
            estadoCivil = scanner.next();


            if (estadoCivil.equalsIgnoreCase("s")) {
                System.out.println("Solteiro");
                auxest = true;

            } else if (estadoCivil.equalsIgnoreCase("c")) {
                System.out.println("Casado");
                auxest = true;
            }
               else if (estadoCivil.equalsIgnoreCase("v")) {
                System.out.println("Viúvo");
                auxest = true;

            } else if (estadoCivil.equalsIgnoreCase("d")) {
                System.out.println("Divorciado");
                auxest = true;
            } else
                System.out.println("Estado Inválido.");
        }





    }
}