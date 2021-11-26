# Anotações Java

Para utilizar a plataforma Java são necessário várias instalações:

*  [JDK (Java Developer Kit)](https://www.azul.com/downloads/#download-openjdk)

Sempre procurar versão LTS pois é uma versão definitiva, corre menos riscos de bug

* Java IDE - no meu caso gostei mais da [IntelliJ](https://www.jetbrains.com/pt-br/idea/download/#section=windows), Porem pode-se usar o [VSCode](https://code.visualstudio.com/)

* Builder, Existe o [Maven](https://maven.apache.org/download.cgi), porem o mais atual é o [Gradle](https://gradle.org/releases/) (verificar Vídeos no youtube)

  

É necessário fazer Warppers, para se programar em time para que o gradle não sofra incompatibilidade de versão utilizando o comando no terminal  `gradle wrapper`

Springbot Entra no site start.spring.io

# Variáveis Java.

Definição: Um espaço na memória de computador onde se pode guardar valores.

padrão de definição de uma variável

<Visibilidade?>,<Modificador?> ,tipo , nome, <=valorinicial?>

o que está entre parentes é opcional para a variável

##### Visibilidade

public protected e private , Ligado a orientação a objeto

##### Modificador

stactic e final, final é uma variável constante, depois que esse valor é definido na variável não pode ser alterado

##### Tipo de dado

Sempre deve ser definido, ou seja, a linguagem Java é fortemente tipada, para se utilizar o dado é necessário que ele seja classificado antes.

##### Nome

Nome dado a variável para conseguir usar e entender para que a variável serve.

##### Valorincial

é o valor que a variável vai ser setada no início do programa.

#### Criação de variável 

##### Convenções e regras

* Não deve começar com números

* Evitar usar "$" e "_ "

* Case-sensitive: o Java diferencia letras maiúsculas e minúsculas no seu código, ou seja, `setNome` é diferente de `setnome`;
* Não utilizar espaços na variáveis
* Não utilizar palavras reservadas e caracteres especiais

##### Boas Práticas

* Sempre iniciar com letras minúsculas 
* Nomes expressivos: de fácil observação para o que a variável serve
* Notação Camelo: primeira letra minúscula e demais iniciais maiúscula. `nomeDaVariável;`
* Quando uma variável é final utilizar todas as letras maiúsculas e separadas por _. `final NOME_DA_VARIÁVEL = 0;` 

#### Tipificação de variável

Existem dois tipos de tipificação de variáveis dependendo da linguagem, a utilização desse tipo depende se linguagem utilizada é compilada ou interpretadas.
Linguagens Compiladas -> Forte

Linguagens Interpretadas -> Fraca

##### Tipificação forte

As variáveis são estáticas, ou seja, não podem mudar seu nome durante o programa (Linguagem Java)

##### Tipificação fraca

As varáveis são dinâmicas, podem ser alteradas durante a execução do programa dependendo das instruções dadas pelo programadores

##### Primitivo

O tipo do dado primitivo geralmente tem relação ligação com o espaço de memória onde o dado é guardado int, double, etc. 

Este tipo de dado geralmente é declarado com letra minúscula.

##### Composto

Pode ser composto por múltiplos dados de vários formatos

##### Opções de tipos

* Textual: char: carcteres de 16-bit unicode, representados por aspas simples ; String: um tipo especial (warpper) que carrega uma cadeia de caracteres, representados por aspas duplas
* Numeral: byte (-128 a 127)inteiro;  short (-32.768 até 32.767)inteiro; long (9*10^18) inteiro, long sempre recebe um l no final; float(é um real com tamanho de long), sempre recebe um f no final.; double numero real
* Lógico: boolean: true e false
* Objeto.: será explorado mais a frente...

### Operadores Aritméticos 

São símbolos especiais que permitem alterações e iterações entre variáveis do mesmo tipo

### Conversões (Casting)

#### Definição: 

é a transformação de uma determinável de tipo menos específico para um mais específico e vice-versa.

#### Tipos

##### Upcast (implicito)

A alteração de uma variável para um tipo superior, ou seja, que possui mais capacidade de armazenamento, casting do tipo upcast geralmente não precisa necessariamente dizer qual tipo da variável que se deseja aumentar pois ela é superior e possui mais capacidade.

Ex. `int i = 10; long l = i;`

##### Downcast(explícito)

A alteração de uma variável para um nível inferior, ou seja, que possui menos capacidade de armazenamento. No caso do Downcast, deve-se sempre informar qual o tipo de variável destino do rebaixamento, pois essa variável pode não comportar o dado armazenado.

Ex. `long l = 10; int i = (long) l`

##### Tabela de Casting

![Screenshot_2](C:\Users\guilh\OneDrive\Imagens\Saved Pictures\Screenshot_2.png)

`

## Estruturas de repetição (Loops)

São estruturas de código que permitem realizar varias iterações até que uma determinada condição seja satisfeita

### For

A estrutura for é conhecida por ser um tipo de contador que realizar iterações finitas (pré-definidas) com um contador incremental ou decremental.

Ex: `for (i=0; i<=x; i++ )`

Explicação: 

`i=0;`a variável contadora i é inicializada com zero (pode ser inicializada com qualquer numero desejado)

`i>=x` é uma condição definida que deverá ser satisfeita para finalizar o loop

`i++`é a forma de iteração, no caso incremento de 1 na variável i

### For each

for each é um for usado em arrays que simplifica a sintaxe, funciona da seguinte forma;

Para um array com 5 posições e elementos já setados temos:

`int[] x = new int[]{a, b, c, d, e}`

`for (int y: x) { códigos, y } // for each`

`for(int i=0; i<x.lenght(); i++) {códigos, int y = x [i] } //for clássico`

no caso a diferença é que no for each, a variável y automaticamente irá setar valores em y correspondente ao array de x no loop. Já no caso do for clássico é necessário criar uma linha de código que recebe aquele valor instantâneo para manipulação no programa.

No caso do for each, o looping será executado enquanto aos elementos das variáveis forem todos varridos, já no for clássico, precisamos setar o .length de forma manual para que a variável execute essa varredura, ou atribuir um valor numérico;

### While

Existem algumas formas de utiliizar o while

`while (true){}` é uma estrutura de repetição infinita, que realiza o código dentro do colchete indefinidamente.

`while (x...y){} ` Assim como no for, o while seu loop até que uma operação booleana retorne o dado false para a condição pré estabelecida entre x e y;

`do{} while();` A estrutura do-while é interessante, pois a iteração realizada conta com pelo uma passagem dentro da estrutura antes verificar se a condição dentro do código é verdadeira ou falsa

## Interruptores de código

Os interruptores de códigos são elementos que realizam funções dentro de loops. A utilização desse recurso tem como função principal quando um laço é muito grande e conta como muitas condições de inicialização, podemos trazer essas condições dentro do laço e criar um laço infinito do tipo: `while(true){}`

### Break

O Interruptor break para o loop caso uma condição seja satisfeita 

### Continue

O interruptor continue interrompe somente a interação do loop atual

### Return

Return é um interruptor utilizado em métodos.

Existem dois tipos de return 

return sem valor `return;`

return com valor `return valor;`

-------------------------

Existem dois tipos de interruptores Unlabelled(Sem etiqueta) e Labelled(com etiqueta).

Os interruptores comuns são os unlabelled.

O interruptores labelled são utilizados com a palavra reservada out, ou seja, interrompe a um determinado ponto do programa pré estabelecido pelo label.

## Arrays

Para se criar uma variável que armazene diversos valores utilizamos a técnica de arrays (Vetores e Matrizes).

As variáveis arrays tem características bem solidas:

### Sequencia

Uma variável array tem seu endereçamento de forma sequencial, ou seja, podemos saber a ordem que esses dados são guardados no endereço de memória.

### Finito e Fixo

Os arrays tem valores finito e fixo, ou seja, quando uma variável array é declarada, ela deve ser instanciada com a quantidade de endereços que serão utilizadas pelo usuário, ou ao longo do programa, mas nunca é um valor indefinido onde podemos colocar variáveis.

### Homogêneo

A variável array não admite sua construção com dados de primitivos e/ou objetos diferentes, ou seja, não podemos criar um array com dados int e double, os dados precisam ser convertidos para ser armazenado no array.

### Indexado

A vaiável array é indexada, sendo assim, sua organização e seu sequenciamento pode ser garantido e o acesso a estas informações ficam mais coerentes.

### Elemento 

O elemento do array é exatamente o dado que está dentro do endereço do array

### Tamanho 

O tamanho do array é definido pela quantidade de elementos dentro do array, contados de 0-n.

### Índice

O Indice do array é o lugar exato onde o elemento do array está alocado.

### Criação

Para se instanciar uma array no java é comum utilizarmos a terminologia:

 `<tipo>[] nome<?=valorinicial?>;` //Mais comum em java

`<tipo> nome[]<?=valorinicial?>;`





## Primeiros comandos e atalhos Intellij

`Sout` = Atalho pra `System.out.println("");`

main = `Cria o main static void`

#### Recebendo uma variável pela leitura de console:

-------------------------

Importar biblioteca Scanner: `import java.util.Scanner;`

Iniciar variável de leitura: `Scanner ler = new Scanner(System.in);`

ler variável "x" através da variável de leitura instanciada: `x = ler.nextDouble();`

#### Principais comandos de String:

Encontra o caractere da String x na posição y =`x.charAt(y)` Contagem iniciando de 0

Mostra os caracteres x a partir da posição y =  `x.substring(y)` 

Devolve um Inteiro com o tamanho máximo de caracteres da String x = `x.lenght`

* Estudar conceitos da biblioteca `java.util.Date

## Elementos da POO

### Classe: 

Elemento abstrato que se pode atribuir um ser classificável, Exemplo: Carros. Motos, casas.

#### Características de uma classe: 

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

 

# Estrutura de dados Java



## Conceitos preliminares

### Nota sobre Atribuição e referência

Atribuição é quando colocamos um valor em uma variável decorrente de outro valor primitivo. exe:  ` int a = int b` , caso o valor de memória seja alterado tanto em int a ou int b, os valores continuarão os mesmos

Quando se trata de objetos trabalhamos com referência, não é o valor de memória que é copiado, sim o endereço de memória do objeto `objA  = objb` 

logo quando uma das variáveis do objeto é alterada os dois objetos mudam o seu valor.

### Conceito de nó

O nó é um espaço de memória para uma variável que possui além da capacidade de armazenar um dado + um endereço de referencia para outro nó.



<img src="C:\Users\guilh\OneDrive\Imagens\Saved Pictures\Screenshot_3.png" style="zoom:67%;" />

### Conceito de encadeamento de nó

Os dados de objetos podem ser relacionado entre com outras variáveis através de apontamentos entre referencias. apontando um pra outro.

![](C:\Users\guilh\OneDrive\Imagens\Saved Pictures\Screenshot_4.png)



### Generics em Java

Para se criar uma lista podemos escrever 

`Lista<String> minhaLista = new Lista();`

onde Lista é o tipo da variável lista

<String> é o tipo de dado que haverá dentro da lista

minhaLista é o nome da variável

## Pilha

Lembrar do conceito de pilha de livros.

O elemento que entra por ultimo sai primeiro. LIFO: Last In, First Out; 

Utilizar o conceito de encadeamento de nó, o conceito de pilha significa que o primeiro nó gerado será o ultimo a sair ou seja, o próximo nó sempre faz referência ao nó anterior.

null<-no1<-no2<-no3<-no4<-topo

### Método de manipulação de pilha

#### Método top

O método referencia e consulta o ultimo item da pilha.

no meuNo = pilha.top();

o meuNo recebe a referencia do topo da lista, ou seja o ultimo dado inserido

Int numero = meuNo.getInt();  recebe o valor do ultimo nó

![](C:\Users\guilh\OneDrive\Imagens\Saved Pictures\Screenshot_5.png)

### Método pop

Remove o ultimo item da pilha de fato.

No meuNo = pilha.pop();

No meuNó = recebe o item da pilha na variável e exclui da pilha.

int numero = meuNo.getInt(); recebe a referencia para o item abaixo.

int numero = int;

![](C:\Users\guilh\OneDrive\Imagens\Saved Pictures\Screenshot_6.png)

### Método Push

Método que adiciona um item ao topo da pilha

No meuNo = mew no(); Cria novo nó

meuNO.setInt(1); // Adiciona um novo valor dentro do nó.

meuNo fica com a referencia Null

a referencia de topo é adicionada ao nó e somente após isso é criado uma nova referência de topo.

### Método isEmpity

Retorna se sua pilha ou estrutura de dados é = Null, ou seja a estrutura de dado está vazia.

o método retorna true caso esteja vazia.

