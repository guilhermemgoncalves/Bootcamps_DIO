package exercicio.string;

public class testeif {
    public static void main(String[] args) {
       var teste = true;


       if (teste)
           System.out.println("Verdadeiro");
       else {
           System.out.println("Falso");
       }
       var outra = teste ? "verdade": "Falso";
        System.out.println(outra);
    }
}

