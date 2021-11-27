package exercicios;
//No tabuleiro de xadrez, a casa na linha 1, coluna 1 (canto superior esquerdo) é sempre branca e as cores das casas se alternam entre branca e preta, formando o formato tão conhecido como xadrez. Dessa forma, como o tabuleiro tradicional tem oito linhas e oito colunas, a casa na linha 8, coluna 8 (canto inferior direito) será também branca. Porém, neste problema, queremos ser capazes de predizer a cor independente do número de linhas e colunas, sendo: L linhas e C colunas. No exemplo da figura, para L = 6 e C = 9, a casa no canto inferior direito será preta, uma simples previsão matemática, não?
import java.util.Scanner;

public class xadrez {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int L = sc.nextInt();
        int C = sc.nextInt();
        boolean testL=false;
        boolean testC=false;

        if (L%2 == 0){
            testL = false;} //Testa se a varável é par
        if (C%2 == 0){
            testC = false;} //Testa se a variável é par

        if (testL != testC|| L ==1 & C==1)  //Verifica se a varável da coluna e linha são par ou impar, caso as variáveis sejam iguais a casa é preta e diferentes a casa é branca (lógica do NOU)
            System.out.println(" 1  ");
        else
            System.out.println(" 0  ");
        sc.close();


    }
}
