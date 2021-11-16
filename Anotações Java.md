# Anotações Java

Para utilizar a plataforma Java são necessário várias instalações:

*  [JDK (Java Developer Kit)](https://www.azul.com/downloads/#download-openjdk)

Sempre procurar versão LTS pois é uma versão definitiva, corre menos riscos de bug

* Java IDE - no meu caso gostei mais da [IntelliJ](https://www.jetbrains.com/pt-br/idea/download/#section=windows), Porem pode-se usar o [VSCode](https://code.visualstudio.com/)

* Builder, Existe o [Maven](https://maven.apache.org/download.cgi), porem o mais atual é o [Gradle](https://gradle.org/releases/) (verificar Vídeos no youtube)

  

É necessário fazer Warppers, para se programar em time para que o gradle não sofra incompatibilidade de versão utilizando o comando no terminal  `gradle wrapper`

Springbot Entra no site start.spring.io



## Primeiros comandos e atalhos Intellij

`Sout` = Atalho pra `System.out.println("");`

main = `Cria o main static void`

##### Recebendo uma variável pela leitura de console:

-------------------------

Importar biblioteca Scanner: `import java.util.Scanner;`

Iniciar variável de leitura: `Scanner ler = new Scanner(System.in);`

ler variável "x" através da variável de leitura instanciada: `x = ler.nextDouble();`

##### Principais comandos de String:

Encontra o caractere da String x na posição y =`x.charAt(y)` Contagem iniciando de 0

Mostra os caracteres x a partir da posição y =  `x.substring(y)` 

Devolve um Inteiro com o tamanho máximo de caracteres da String x = `x.lenght`

## Estudar conceitos da biblioteca `java.util.Date`



## Elementos da POO

### Classe: 

Elemento abstrato que se pode atribuir um ser classificável, Exemplo: Carros. Motos, casas.

#### Caracteristicas de uma classe: 

Possui um nome; Possuem visibilidade (publico, private, protected); Possuem membros como: características e ações;

Para criar um classe digitar `Visibilidade  + Nome da Classe + {atributos, propriedades e metodos}`

exemplo de classe:

`public class Caes` // Modificador publico ; Classe = class; nome da classe  Caes(sempre com letra maiúscula)

`public String nome;` // String não possui um primitivo, logo deve ser sempre instanciado com letra maiúscula, nome é um atributo da classe

`public int peso;` // Primitivo do tipo inteiro,  peso é um atributo da classe

`public String corOlhos;` corOlhos é escrito dessa forma, toda variável primeira letra é minúscula e demais iniciais maiúscula.

`public int quantPatas;` mesma lógica das anteriores

`public void falar(){metodo andar} ` é um método da classe que possui função conforme recebe valores,  uma classe pode conter n métodos correspondentes as funções que classe realiza.

![Demonstração da classe Cães](https://arquivo.devmedia.com.br/artigos/Thiago_Varallo/Introducao_POO_Java/Introducao_POO_Java2.jpg)

### Objetos:

Diferente da Classe que é uma ideia mais abstrata o objeto é um elemento mais detalhado da classe de forma que ele tenha algumas características intrinssecas.

Ex: 

![POO: o que é programação orientada a objetos? | Alura Cursos Online](https://www.alura.com.br/artigos/assets/poo-programacao-orientada-a-objetos/class-analogy.png)

Classe carro

Objeto: Carro que possui características como cor, modelo, tamanho, etc.

### Atributos:

São as propriedades de um objeto, conhecidos como variáveis ou campos.

Ex:

```java
public class Cachorro{

	public String nome;
	public int peso;
	public String corOlhos;
	public int quantPatas;
}
```

Posicionamento do instanciamento da classe:

`x y = new x ();` onde:  x= Objeto da classe cachorro, y= Classe cachorro; ou seja Y (objeto da classe) recebe todas as características da classe X e importa suas funcionalidades.

### Métodos:

São funções ou ações que são desempenhados pela classe do objeto, ou seja, quando um objeto de uma classe herda suas características também realiza todas as funções (dependendo do modificador de acesso)

Métodos das classes sempre tem nome de verbos: andar, correr, saltar, ir, voltar, pesquisar, etc. Logo as sentenças tem uma logica interessante, um objeto faz alguma coisa. Ex: um cachorro da classe Cães, late. Um polo amarelo da classe Carros corre. 

Ex. de uma classe completa:

```java
class Cachorro{
	int tamanho;
	String nome;


	void latir(){
		if(tamanho > 60)
			System.out.println("Wooof, Wooof!");
		else if(tamanho > 14)
			System.out.println("Ruff!, Ruff!");
		else
			System.out.println("Yip!, Yip!");
	}
}
```

Ex. de um programa com objetos utilizando a classe anterior

```Java
public class Testa_Cachorro {

	public static void main(String[] args) {

		Cachorro bob = new Cachorro();
		bob.tamanho = 70;
		Cachorro rex = new Cachorro();
		rex.tamanho = 8;
		Cachorro scooby = new Cachorro();
		scooby.tamanho = 35;

		bob.latir();
		rex.latir();
		scooby.latir();

	}
}
```

Então o objeto bob e instanciado(`new`) numa classe cachorro, cujo os atributos são  `nome = bob` e recebe o `tamanho = 70`, os demais cachorros recebem as mesmos atributos pois são da mesma classe, porém o valor do atributo é diferente devido a particularidade de cada objeto. Todos os cachorros também compartilham do mesmo método, mesmo que o comportamento da saída seja diferente. Por exemplo: todos os cachorros vão latir, mas devido seu tamanho bob irá latir "Woof Woof", rex irá latir: "Yip, Yip" e scooby irá latir"Ruff Ruff".

Então podemos notar que os elementos dentro das linhas de código no código anterior são: **Classe**: Cachorro, (Testa_Cachorro é uma classe do tipo **main** que já pode ser interpretado como o programa em sí). tamanho e nome são **atributos** da classe que poderão ser herdados pelos objetos da classe. latir é o **método** da classe que processa os dados. **Objeto** é cada cachorro instanciado no programa (bob, rex e scooby, mas poderiam ser outros n objetos)

### Construtores:

São atributos de inicialização do objeto, quando um objeto é instanciado com `new "Classe" ()` o objeto reserva um endereço na memória e esse endereço não é vazio, geralmente o que acontece é que por Default o java cria um construtor vazio:

Exemplo cachorro de construtor vazío:

`main`

`Cachorro bob = new Cachorro ();`

`class Cachorro`

`Cachorro (){}`

O Construtor é um método especial que recebe o mesmo nome da classe. Além do default ele é utilizado quando queremos colocar pré-requisitos para o objeto. quando eu quero receber valores Default assim quando a classe for instanciada.

`main`

`Cachorro bob = new Cachorro (x , y);`

`class Cachorro`

`String x;`

`int y `

`Cachorro (String x, int y){`

`this.x = x;` // Essa linha de código "cobra" do programa principal que o objeto  seja instanciado com um atributo do tipo String, o this. assegura que somente o objeto instanciado usando este construtor irá receber essa inicialização do construtor

`this.y = y;`// Essa linha de código "cobra" do programa principal que o objeto  seja instanciado com um atributo do tipo int

`}`

Caso eu queria utilizar um construtor vazio para não engessar o programa é só construir um construtor igual o default dentro da classe

Caso eu queria ter mais de um construtor é possível desde que a sua assinatura seja diferente, no caso, a sequência dos tipos das variáveis dentro do construtor tem que ser diferente. `Construtor (String, Int) e  Construtor (int, String)`

## Modificadores de acesso:

Responsável por tornar visível (ou não) um objeto, classe, etc. Os atributos da classe que o tornam mais perto de ser um objeto.

### Public: 

Pode ser acessado por qualquer *lugar, entidade ou classe de projeto*.

### Private

É um modificador que só vale para *atributos* e *métodos* mas **NUNCA UMA CLASSE**.

Só pode ser visto internamente na classe.

### Protected 

Pode ser acessível no pacote da Classe que está trabalhando ou através de herança.

 







