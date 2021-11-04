package exercicio.string;
/*
Utilizar os comandos toCharArray, Split, .concat, .replace all e ver seus efeitos no programa

*/


public class ExercicioString {
    public static void main(String[] args) {
        System.out.println("A B C D E F G".toCharArray());
        System.out.println("Aula de Java!".split(""));
        System.out.println("Aula".concat(" de Java"));
        System.out.println("1234 asda qw".replaceAll("[0-9]", "#"));
    }
}
