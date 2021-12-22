# Anotações .NET

# O que é o .NET

É uma framework que da suporte a alguns tipos de linguagem com: C# F# e VB
Para se programar atravéz do VScode com .NET, precisamos instalar sua SDK separadamente
Para utiliza-lo com o Visual Studio podemos instalar o pacote dentro do próprio aplicativo do VS.
Lembrando: Visual Studio é uma IDE com vários recursos para a programação em C# e o VS code é apenas um editor de código, que possui vários recursos de conexão, porem não auxilia automáticamente na produção do código.

# O que é e como funciona o C#
Assim como Java é uma linguagem fortemente tipada (o que permite detectar erros em tempo de compilação), é elegante, e orientada a objetos.
Possui sintaxe de alto nível similar a C, C++ e Java
Suporta os conceitos de orientação ao objetos.

Programas em C# são desenvolvidos em .NET

O .NET já possui uma infinidade de classe pré implementadas que facilitam a execução de programas e soluções.

### Conversão do código fonte

O Codigo fonte possui o seguinte fluxo de conversão:
*  O arquivo é gerado em linguagem de alto nível através de Editor de texto(ou IDE) Arquivo C# (cs) 
* O arquivo é Compilado por Roslyn (IL - Intermediary language)
* O Código IL  são armazenados em um arquivo intermediário chamado assembly (.exe ou .dll)
*  Quando o programa C# é executado o assembly é carregado no CLR (common language Runtimme)
*  Depois de carregado a compilação e executada em método Just in time (JIT) ou seja, convertido em código no momento da aplicação, transformando a linguagem compliada em linguagem de maquina(no caso das aulas no console).

![image-20211126151628305](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Fluxograma Funcionamento .NET e C#)

### Outras Funções do CLR

Garbage Collector:  Ele monitora as variáveis em espaço de memória, quando essas variáveis se tornam obsoletas para o programa, o CLR limpa essa variável no espaço de memória que estava alocado (Ideial para metodos remove em estruturas de dados).
Exception Handler: Recebe e controla as excessões de erros em código
Resouces Manager: Gerencia os recursos do .NET

## Estrutura de Programa em C#

### Programa 

Podem ser formados por um ou mais arquivos e declaram tipos, membros e podem ser organizados em namespaces.

### Tipos

Classes e interefaces são exemplos de tipos

### Membros

Metodos, campos e propriedades das classes

### namespace

Organizações de classes dentro de um programa



## Estruturas de repetição (Loops) C#

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

return com valor `return valor;

## Coleções em C#

### Arrays

Para se criar uma variável que armazene diversos valores utilizamos a técnica de arrays (Vetores e Matrizes).

As variáveis arrays tem características bem solidas:

#### Sequencia

Uma variável array tem seu endereçamento de forma sequencial, ou seja, podemos saber a ordem que esses dados são guardados no endereço de memória.

#### Finito e Fixo

Os arrays tem valores finito e fixo, ou seja, quando uma variável array é declarada, ela deve ser instanciada com a quantidade de endereços que serão utilizadas pelo usuário, ou ao longo do programa, mas nunca é um valor indefinido onde podemos colocar variáveis.

#### Homogêneo

A variável array não admite sua construção com dados de primitivos e/ou objetos diferentes, ou seja, não podemos criar um array com dados int e double, os dados precisam ser convertidos para ser armazenado no array.

#### Indexado

A vaiável array é indexada, sendo assim, sua organização e seu sequenciamento pode ser garantido e o acesso a estas informações ficam mais coerentes.

#### Elemento 

O elemento do array é exatamente o dado que está dentro do endereço do array

#### Tamanho 

O tamanho do array é definido pela quantidade de elementos dentro do array, contados de 0-n.

#### Índice

O Índice do array é o lugar exato onde o elemento do array está alocado.

### Ordenando Arrays

Existem diversos tipos de algoritmos, a ideia é entender diversos tipos de algoritmos para saber como eles funcionam mas o pró´rioi .NET faz essa ordenação automaticamente

#### Algoritmo de ordenação Bubble Sort

O Algoritmo Bubble Sort é um metodo de ordenação de arrays que funciona com a comparação
Se o dado atual for maior que o dado anterior, trocamos os elementos de posição, assim os elementos maiores são colocados nas posições mais adiante

```C#


using colecoes.Helper;

OperacoesArray  op = new OperacoesArray();

int[] array = new int[5] { 4, 9, 1, 3, 2 };

Console.WriteLine("Array original");
op.ImprimirArray(array);

op.OrdenarBubblueSort(ref array);

Console.WriteLine("Array ordenado");
op.ImprimirArray(array);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubblueSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
````




#### Selection Sort

O algoritmo Selction Sort marca a posição do array e procura o menor elemento a partir dele.


### Classe Array

O C# Possui uma classe própria para trabalhar com array, chamada Array.

#### Copiar um Array


```C#
OperacoesArray  op = new OperacoesArray();

int[] array = new int[5] { 4, 9, 1, 3, 2 };
int[] array2 = new int[10];


  public void Copiar(ref int[] array, ref int[] arrayNovo)
            {
            Array.Copy(array, arrayNovo, array.Length);
            }
Console.WriteLine("Array original");
op.ImprimirArray(array);

op.Copiar(ref array,ref array2);

Console.WriteLine("Array copiado");
op.ImprimirArray(array2);
````

#### Verificar se um elemento existe dentro de um array

```C#
using colecoes.Helper;

OperacoesArray  op = new OperacoesArray();

int[] array = new int[5] { 4, 9, 1, 3, 2 };
int[] array2 = new int[10];

int valorProcurado = 3;
bool existe = op.Existe(array, valorProcurado);

if(existe)
    Console.WriteLine($"O valor {valorProcurado} existe!");
else
    Console.WriteLine($"O valor {valorProcurado} não existe!");

     public bool Existe(int[]array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }
```

#### Verificar se todos elementos do array satisfazem uma determinada condição


Utilizar metodo do array true for all, conforme código

```#C
public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
```
#### Encontrar um elemento no array.

Quando manipulamos array temos em mente que o valor default do array é zero
Caso não acharmos nenhum valor o metodo retorna zero
```C#
 public int ObterValor(int[] array, int valor)// retorna um valor numérico que tem o valor do elemento passado na classe main
        {
            return Array.Find(array, element => element == valor);
        }
```

#### Obter indice de um elemento o array
``` C#
  public int ObterIndice(int[]array, int valor)
        {
            return Array.IndexOf(array,valor);
        }
```
Utilizando o metodo indexof o array retorna -1 quando não possui valor atribuido.

#### Redimensionar o Array em tempo de execução
Enviar o Array por referencia pois estamos manipulando o array.
Lembrar sempre que o array é tem seu tamanho imutável ou seja essa função faz uma cópia do array em outra variável e mantem o nome
```C#
public void RedmensionarArray(ref int[] array, int novoTamanho )
        {
            Array.Resize(ref array,novoTamanho);
        }
```
#### Convertendo um Array
Faz a conversão completa de elemento a elemento 
```C#
public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());//no Caso aqui é  a linha de conversão
	}
```
### Coleções Genéricas

Agrupam valores padronizados de vários tipos de dados, Objetos, String, Arrays, Etc.
Algumas outras característcas:
Facil de ser ordenado.
Obtem valor por indice.
Valores dinamicos.

Basicamente é uma abstração de arrays, pois a lista trabalho com arrays internamente.

Classes `System.Collection.Generic`

Uma lista contem o identificador T que é genérico onde podemos colocar valores como String, Int, Object, etc.
Podemos manipular os itens da lista utilizando métodos internos da estrutra de dados da coleção correspondente


#### LIST - LISTA ()
```C#
List<string> estados = new List<string>();//inserindo elementos na lista

### Adicionando Elementos

estados.Add("SP");
estados.Add("MG");
estados.Add("BA");
```

##### Contando elementos e consultando lista
```
Console.WriteLine($"Quantidades de elementos na lista{estados.Count}");//Contando elementos da lista

foreach(var item in estados)
{
    Console.WriteLine(item);//Consultando elementos da lista com foreach
}


estados.Remove("MG"); //removendo elemento da lista

for (int i = 0;i<estados.Count; i++ )
{
    Console.WriteLine($"Indice {i}, Valor: {estados[i]}");// consultando elementos da lista com for
}
```
----------------------
Refatorando o Código podemos Criar uma classe

para as operações da lista

```C#

    public class OperacoesLista
    {

        public void ImprimirListaString(List<string> lista)
        {

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Indice {i}, Valor: {lista[i]}");// consultando elementos da lista com for
            }
        }
    }
```

//na main:

`opLista.ImprimirListaString(estados);`

##### Removendo elementos da lista

Ao remover um item de uma lista, lembrar que a lista irá rearranjar seus indices, ou seja, se removido um item do meio
todos os itens após tem seu indice decrementados de 1.
```C#
Console.WriteLine("Removendo elemento");
estados.Remove("Mg");

opLista.ImprimirListaString(estados);
```

##### Adicionar coleções na lista

OperacoesLista opLista = new OperacoesLista();
``` C#
string[] EstadosArray = new string[2] { "SC", "MT" };

List<string> estados = new List<string> { "SP", "MG", "BA" };//inserindo elementos na lista

estados.AddRange(EstadosArray);  // Adciona os elementos do Array na Lista

opLista.ImprimirListaString(estados);
```

Tendo uma coleção do mesmo tipo, podemos mesclar os elementos para a coleção lista.

##### Adicionando elemento por índice.

```
estados.Insert(1, "RJ");
```

A linha de código coloca o valor RJ exatamente no Indice 1, depois de SP, antes de MG.


### Coleções Específicas
Possui um ordenamento na manipulação dos seus dados

#### Queue - Fila (FIFO - FIRST IN FIRST OUT)

Obedece a ordem de entrada, sempre o primeiro que entrou será o primeiro a sair, comparando com uma fila de mercado.

![Fila](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Fila.png)

##### Declaração da Fila

`Queue<string> fila = new Queue<string>();`

##### Adicionando um elemento na fila

`fila.Enqueue("");`

##### Removendo elemento da fila

`fila.Dequeue("");`

##### Metodo PEEK
`fila.Peek()`
Retorna um valor da frente da fila mas não remove

##### Contando elementos da fila
`fila.Count`

##### Atendendo uma fila na prática.

```C#
Queue<string> fila = new Queue<string>();

fila.Enqueue("Guilherme");
fila.Enqueue("Priscila");
fila.Enqueue("Edna");

while (fila.Count > 0)
{
    Console.WriteLine($"Vez de: {fila.Peek()}");
    Console.WriteLine( fila.Dequeue()+ " Atendido");
}
```




#### Stack - Pillha (LIFO - LAST IN FIRST OUT) 

Obedece a ordem de empilhamento, empre o ultimo a chegar será o primeiro a sair, comparado a uma pilha de livros.

![Pilha](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Pilha.png)



##### Empilhamento

`pilhaLivros.Push(".NET")`

Coloca livro na Pilha

##### Consulta Quantidade da pilha

`Console.WriteLine($"Quantidade de livros para leitura {pilhaLivros.Count}");`

##### Remove o livro da pilha
`Console.WriteLine($" {pilhaLivros.Pop()}, lido com sucesso.");`


### Dictionary - Dicionários
Dicionário é uma cocleção de chave e valor, que é um indice único que é armazenado em hash.
Para acessarmos um dado daquela coleção usamos um código unico para aquele elemento.

#### Declarando Dicionários

`Dictionary<string, string> estados = new Dictionary<string, string>();`
par de tipos de dados para acesso do dado

#### Adcionando Dicionário

`estados.Add("SP", "São Paulo"); `

Para adicionar um dicionários temos que fornecer uma Chave e Um valor.
Não podemos criar chaves repetidas.

#### Lendo Dicionário
```
foreach (KeyValuePair<string, string> item in estados )
{

    Console.WriteLine($"Chave: {item.Key}, Valor:{item.Value}"); 


}
```

#### Acessando valor 

Para acessar um valor sempre temos que acessar pela chave.
```
string valorProcurado = "BA";
Console.WriteLine(estados[valorProcurado]);
```
Sempre que passarmos a chave o algoritmo irá nos retornar o value.

### Atualizando um valor

Para alterar o valor precisamos passar a chave
```
string valorProcurado = "BA";
estados[valorProcurado] = ("Atualização");
Console.WriteLine(estados[valorProcurado]);
```
Trocou Bahia pela palavra Atualizaçao.

#### Removendo um valor

estados.Remove(valorProcurado); // A chave que remove o valor.

#### Saber se uma chave existe antes de tentar acessa-la

Para que não haja bug em tempo compilação temos o metodo TryGetValue, para confirmar se existe a chave do valor que eu estou tentando acessar.

```
if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))// Chave definida durante o programa
{
    Console.WriteLine(estadoEncontrado);
}else
{
    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário! ");
}
```
O metodo TryGetValue permite que se haja erro na chave o programa não gere erro em tempo de compilação.


### Operações LINQ - Assistir aulas novamente e refazer anotações

Language-Interated Query







​    


## Construtores

Construtores são métodos da classe que permitem o instanciamento da classe.

Por default quando não criamos o construtor de uma classe o C# cria a classe com um construtor vazio

Para montar  um construtor devemos fazer o metodo com exatamente o nome a classe

### Construtor Padrão

O Construtor padrão obedece as regras de código conforme a seguir:

```C#
public NomeDaClasse()
(
)


```

 a Classe é construída sem parâmetros para que caso desejamos colocar os atributos depois, seja possível.



### Construtor de classe

O construtor tem a função de exigir valores default para a classe instanciada

```c#
private string nome;
private int idade
    
    Public Pessoa(string nome, int idade)// Quando na main um objeto for instanciado programa permitirá utilizar esses parametros para iniciar o objeto;
    (
		this.nome = nome; // this. siginifca que a string de dentro do programa recebe o valor que vem da main.prg
    	this.idade = idade;
	)


```

Caso queiramos limitar o instanciamento da classe para que seja feito somente já passando os valores é só deletar o construtor padrão.

### Getters e Setters

Os metodos gets e sets são formas controladas de adquirir ou enviar valores a um objeto.

Usando métodos Set, podemos impedir que valores não permitidos sejam armazenados dentro de uma variável, por exemplo, uma variável int receber valores somente se o valor que entrar via método seja inteiro.

```C#
public class Data
    
    
    private int mes;
    public int GetMes()
	{
    return this.mes; //Retorna sempre o mês da variável interna da classe
    }
	
	public void SetMes(int mes)
    {
        if (mes>0 && mes<= )
            this.mes=mes; // recebe valor somente se dentro do intervalo válido para numero de meses por ano
    }
```

### Propriedades

Para que possamos acessar os atributos dos métodos o C# tem a função propriedade( atalho prop), essa função permite que sejam gerados getters e setters automaticamente.

```c#
"prop" Propriedade;
public int Propriedade { get; set;};

Main
{
    objeto.propriedade = valor ; // na main quando passamos valor para uma propriedade essa propriedade aplica um get automáticamente.
    Console.WriteLine(objeto.propriedade); //Quando a propriedade tem um perfil de saída ela gera um valor de saída automáticamente.
   
}


    
    
```



```C# 
//Podemos gerar validações para esses getters e setters automáticos.

get
{
    return this.mes =value; //Onde value é o valor enviado pela main depois do sinal de igual
}
set/// valida o set.
    if(value>0&&value<)
    {
        this.mes= value;
        this.mesValido= true;
    }
```







# Programação com Orientação a Objetos

## O Que é a POO

É um paradigma, método ou técnica de programação. 

Outros paradigmas de programação: estruturada, imperativa, procedural, orientada a eventos, etc.

A POO procura aproximar o mundo real ao mundo virtual, utilizando as características como Abstração, Encapsulamento, Herança e Polimorfismo.

### Classe 

É um molde para um objeto. *Pessoa tem, idade, nome, altura, peso.*

### Objeto 

É um item único pertencente a uma classe.  *Guilherme é uma pessoa, que tem 29 anos, Altura 1,90m, 110kg*

## Pilares POO

### Abstração

Abstração é colocar somente os atributos de interesse para ser utilizado no problema em questão.

 passos para criar uma classe e implementar num objeto.

Alt+shift+C - Atalho para criar classe 

Colocar num pacote (pasta) -> Models

Criar classe

`public class Pessoa`
    `{`

Métodos, atributos, etc.

​	  `}`

Criar métodos setter e getters para atributos da classe

`public string nome { get; set; }`

 `public int  idade { get; set; }`

Criar método de apresentação para ser método de saída



       `public void Apresentar()`
            `{`
                `Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos");`
                }



No programa main

`Pessoa p1 = new Pessoa();` //Instanciamento da Classe
`p1.nome = "bob";`// setando atributo nome no objeto pessoa p1
`p1.idade = 20;` // setando atributo idade no objeto pessoa p1
`p1.Apresentar();`// Realizando metodo apresentar.  que imprime na tela:

Olá meu nome é bob e tenho 20 anos.

### Encapsulamento

Serve para proteger uma classe e definir limites para alteração das suas propriedades.

Expor seu comportamento e expor somente o necessário.

![Captura de tela 2021-11-29 102307](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\TabelaEncapsulamento.png)

Implementar classe retângulo onde:

comprimento: double é uma atributo privado

largura: double é uma atributo privado

definirMedidas: é um método publico

Na prática:

`private double comprimento;`

`private double largura;`

`private bool valido;` // São Atributos internos da classe que não podem ser manipulados diretamente externo da classe





       public void DefinirMerdidas(double comprimento, double largura)
       {
            if (comprimento > 0 && largura>0)
                {
                this.comprimento = comprimento; // essa linha especificamente, passa o valor de fora para dentro
                podemos chamar de metodo construtor da classe
                this.largura = largura;
                valido = true;
            } else
            {
                Console.WriteLine("Valores Invalidos");
            }
    
        }

// É um método permite receber valores de medidas externamente da classe.



        public double ObterArea()
            {
                if (valido)
                    return comprimento * largura;
                else
                { Console.WriteLine("Preencha valores validos");
                    return 0;
                }}

// é um método que executa o equacionamento utilizando valores privados da classe.

### Herança

Permite herdar atributos, métodos e comportamentos em outras classes.

Serve para agrupar objetos que são do mesmo tipo porém com características diferentes.

Replicar métodos e atributos de outra classe para reaproveitamento de código e ajuda na abstração das classes.

Ex:

![Herança](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Herança.png)

A classe pessoa tem: Atributos nome, idade, apresentar

A classe aluno tem: Atributos: nome, idade, nota e o método apresentar()

A classe aluno tem: Atributos: nome, idade, salário e o método apresentar()

Na prática  a classe que herda, precisa conter o nome da classe pai

`Public class Aluno : Pessoa`

### Polimorfismo

Sobrescrever métodos das classes filhas para que se comportem de uma maneira diferente e ter sua própria implementação

![image-20211129132107106](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Polimorfismo)

Quando o método apresentar() não atende o método da classe pai, podemos sobescrever o método da classe filha.

#### Em tempo de compilação

Podemos sobrescrever o método pai utilizando um método com assinatura igual, porem a quantidade de parâmetros diferentes

public int metod(int num1, int num2){}

public int metod(int num1, int num2, int num3){}

#### Em tempo de execução

Podemos sobrescrever o método pai, utilizando uma sintaxe simultaneamente

Na classe pai: 

`public virtual void Metod(){}`

Na classe filho

`public override void Metod(){}`

Sim



 ### Classe Abstrata

A classe abstrata é uma classe molde, ou seja, não pode ser instanciada, é apenas um modelo, e só pode ser usada se for herdada

Também é possível gerar métodos abstratos que não tem implementação na classe e pode ser utilizada por quem herdou

![image-20211129142431002](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\CLasse Abstrata)

A Classe Conta não pode ser instanciada como objeto, e carrega apenas um molde para os demais tipos de classe derivados de conta.

O método Creditar()  só pode ser escrita a partir do polimorfismo, ou seja, sobrescrevendo o método da classe nativa.

Já o método ExibirSaldo() é opcional.

### Classe selada

É uma classe final, que não pode ser pai.

Também existem métodos selados, que não podem sofrer polimorfismo.



![image-20211129151513303](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Classe selada)

![image-20211129151647609](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Metodos Selado)

Sintaxe

public class sealed Classe

public sealed override void Metod()

### Classe Object

A classe System.Object é a mãe de todas as classes do .NET. Sua função é criar prover serviços de baixo nível para o programador C#.

### Interface

É muito semelhante a uma classe Abstrata, define métodos abstratos ou não, para que sejam implementados por quem usar a interface.

O métodos da interface não podem ser instanciados.

Quando implementar uma interface podemos implementar métodos, podemos colocar retorno ou não. A interface obriga a classe que implementou a interface a implementar um método com um retorno e lógica.

O conceito de interface substitui o conceito de herança mutipla.

![image-20211129155607503](C:\Drives\Trabalho\DIO\Bootcamps_DIO\Bootcamp .Net Developer\Anotações .NET\Interface)

Para gerar em código uma interface uma boa prática é criar uma pasta chamada interface separando classes em interfaces.

Boa prática na criação da classe de interface é sempre colocar um i maiúsculo antes do nome ICalculadora.

As interfaces criadas contém a sintaxe 


    namespace Interface.Interface
    {
        public interface ICalculadora
        {
            int Somar(int num1, int num2);
            int Subtrair(int num1, int num2);
            int Multiplicar(int num1, int num2);
            int Dividir(int num1, int num2);
         }
    }

Classes de interface não possuem modificadores de acesso pois por padrão é public.

A implementação da interface no código é exatamente igual a herança

Prevalece o método da classe não o método da interface;

### Referência

Caso seja necessário podemos passar valores entre dois métodos diferentes dentro de uma mesma classe usando a palavra reservada ref

exemplo




​    
​        public class ref 
​        {
​        static void Inverter(ref int x, ref int y)
​        {
​        int temp = x
​        x= y;
​        y = temp;
​        }
​        public static void Inverter()
​        {
​        int i=1,j=2;
​        Inverter(ref i, ref j)
​        System.Console.WriteLine($"{i} e {j}")
​        
​        // com ref o console imrpimirá, 2 e 1
​        // sem ref o console imprimirá, 1 e 2
​        }
​            
​         }


Ou seja o método ref aponta para onde quero recebe a variável 

### Out

Utilizar o Out é necessário caso eu queria fixar no método construtor da classe quais valores serão de saída.

    public class out
    {
    static void Dividir(int x,int y, out resultado, out resto)
    {
    	resultado = x/y;
    	resto = x%y;
    }
    public static Dividir()
    {
    	Dividir(10,3, out int resultado, out int resto)
    
    }


​    



## Manipulação de Arquivos

Para a manipulação de arquivos usamos 3 classes principais a File, a Directory e Path, essas classes são estáticas sendo assim não precisam ser instanciadas, basta fazer o import de System i/o. 

Ao manipular essa classe, sempre prestar atenção no caminho onde é colocado os arquivos, pois as vezes o C# não tem permissão para acessa-los.

### Diretórios

#### Para localiza diretórios 

na prática temos o código:

    public class FileHelper // nome da classe de manipulação de diretório.
    {
        public void ListarDiretorios(String caminho) //método listar diretórios recebe uma string por padrão que indica o caminho (C:\\...\\destino)
        {
           var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories); 
           // a Variável retorno caminho recebe um array de strings com os caminhos existentes e armazena.
           
           //Para achar diretório somente na pasta raiz, utilizar somente parametro caminho, para achar todos os diretórios e subdiretórios utilizar "*" que significa todos, e SearchOption.AllDirectories. 


​            foreach( var retorno in retornoCaminho)
​            {
​                Console.WriteLine(retorno);
​            }
​            // a variável var retornoCaminho recebe o caminho instantâneo do valor do diretório e joga dentro do for each, cada vez que houver um diretório valido o for each realiza a impressão do caminho que está na variável retorno.
​        }
​    
​    }
​    
​    Programa Main
​    
​    {
​    
​    var caminho = "C:\\PastaTeste"; // cria um caminho base para ser examinado
​    FileHelper helper = new FileHelper();
​    helper.ListarDiretorios(caminho);// aciona o método com o caminho gerado para que o diretório faça a busca
​    
​    }





o caractere * é coringa, que varre tudo, se colocarmos qualquer coisa por exemplo * 2 * siginifica que se tiver 2 em qualquer lugar do nome o retorna arquivos irá armazenar no seu array.

#### Criar diretório e subdiretórios


​       
​       public  void CriarDiretorio(string caminho)
​        {
​           var retorno = Directory.CreateDirectory(caminho);
​            Console.WriteLine(retorno.FullName);
​        }
​      ----------------------------  
​           using System.IO;
​       
​       //Para utilizar a biblioteca Path é necessário sempre importar o system.Io;
​        main{
​        
​        helper.CriarDiretorio(Path.Combine(caminho, "PastaTeste3", "Subpasta Teste3"));
​        
​        //Path combine é uma forma de concatenar endereços de diretório, caso um diretório não exista (caso "PastaTest3") o programa irá cria-lo para criar o subdiretório.
​        
​        // helper.CriarDiretorio  é o metodo de criação de diretório, onde caminho é o caminho utilizado é o caminho normal onde se quer criar as pastas e depois da virgula são as pastas criadas (neste contexto)
​        
​        }

#### Apagar Diretório

Para apagar diretório temos:
       

       main
       {
       helper.ApagarDiretorio(Path.Combine(caminho, "PastaTeste1"), true);
       }


​       
​        public void ApagarDiretorio(string caminho, bool apagarArquivos)
​            {
​                Directory.Delete(caminho, apagarArquivos);
​             }
​             
​            // o Metodo delete apaga diretório, mas é necessário uma confirmção Booleana no metodo para que seja dada a permissão para apagar o arquivo de fato.


Observação: quando algo é apagado no C# ele é excluído permanentemente, então é necessário cuidado extremo para apagar pastar e diretório no C#

### Arquivos

<u>**Todas as operações com caminho devemos lembrar que o nome do arquivo faz parte do caminho!**</u>

#### Localizar arquivos

Dentro dos diretórios segue o mesmo padrão





     public void ListarArquivos(string caminho)
            {
                var retornaArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);
                foreach(var retorno in retornaArquivos)
                {
                    Console.WriteLine(retorno);
                }
            }


Para filtrar a busca por tipo de arquivo utilizamos "*.extensão". 

#### Criar arquivo .txt


​       
​       main
​       {
​       helper.CriarArquivoTexto(Path.Combine(caminho,"arquivo teste.txt"),  "teste de escrita de arquivo"); // teste de escrita vai no corpo to texto.
​       }
​       
​       public void CriarArquivoTexto(string caminho, string conteudo)
​            {
​                if(!File.Exists(caminho))// if assegura que o testo não será sobreescrito.
​                 File.WriteAllText(caminho, conteudo);
​                 }
​        }


#### Criar texto com Stream

Obs: O uso da stream é necessário para que não escrevamos tudo de uma vez no arquivo txt, pois fazer isso consome muita memória do computador.


       using System.Collections.Generic;// para utilizar a função list temos que importar System Collections.


​       
​       main
​       {
​       var listaString = new List<string> { "linha1", "Linha2", "linha3" }; // Criar conteudo na lista de strings
​       helper.CriarArquivoTextoStream(Path.Combine(caminho, "arquivo teste-stream.txt"), listaString); // cria um arquivo stream para receber texto.
​       }
​       
​      public void CriarArquivoTextoStream(string caminho, List<string> conteudo)// O conteúdo da stream deve ser uma lista de Strings
​            {
​                using (var stream = File.CreateText(caminho)) //using permite que o arquivo seja inicializado somente quando usado, poupando espaço de memória.
​                
​                {
​                    foreach (var linha in conteudo)
​                    {
​                        stream.WriteLine(linha); //escreve stream linha a linha.
​                    }
​                }
​    
​    		}

#### Adicionar texto e texto Stream

Para adicionar texto em arquivos basta alterar as propriedades de Creat para Append.



        public void AdicionarTexto(string caminho, string conteudo)
            {
                File.AppendAllText(caminho, conteudo);
            }
             public void AdicionarTextoStream(string caminho, List<string> conteudo)
            {
                using (var stream = File.AppendText(caminho))
                {
                    foreach (var linha in conteudo)
                    {
                        stream.WriteLine(linha);
                    }
                }
             }


#### Lendo arquivos

     public void LerArquivo(String caminho)
            {
                var conteudo = File.ReadAllLines(caminho);
                foreach (var linha in conteudo)
                {
                    Console.WriteLine(linha);
                }

#### Lendo arquivos Stream

        main
        {
        helper.LerArquivoStream(Path.Combine(caminho, "arquivo teste-stream.txt"));
        }
        
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine())!= null) // faz com que a leitura seja feita de forma sequencial até que seja nulo e o programa encerre
                {
                    Console.WriteLine(linha);
                }
            }
    
        }

#### Movendo arquivos


        main
        {	 var caminho = "C:\\PastaTeste";
       		 var novocaminho = Path.Combine(caminho, "PastaTeste3");
       		 helper.MoverArquivo(Path.Combine(caminho, "arquivo teste.txt"), Path.Combine(novocaminho, "arquivo teste.txt"));
    
        }


​        
​        public void MoverArquivo(string caminho, string novocaminho)
​        {
​            File.Move(caminho, novocaminho);
​        }

#### Copiar arquivo

    public void CopiarArquivo(string caminho, string novocaminho)
        {
            File.Copy(caminho, novocaminho);
        }



Por padrão o método copy não sobrescreve o arquivo caso seu nome seja duplicado. Caso desejar sobrescrever o método copy tem sobrecarga com valor booleano:


        public void CopiarArquivo(string caminho, string novocaminho bool sobrescrever)
        {
            File.Copy(caminho, novocaminho, sobrescrever);
        }

#### Deletar arquivos 


        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

# Criando um App Simples de cadastro de séries em .NET



1. Criar uma classe abstrata chamada EntidadeBase (Essa classe carrega  um Id)

```
namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
    }
}
```



2. Criar classe Serie que herda de EntidadeBase e possui atributos como Genero, Titulo, Descrição e Ano.

```
namespace DIO.Series
{
    public class Serie : EntidadeBase
    {

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string  Descrição { get; set; }
        private int Ano { get; set; }   

    }
}
```

3. Criar um Enum com os respectivos generos que serão utilizados.

```
namespace DIO.Series
{
    public enum Genero
    {
        Acao =1,
        Aventura = 2,   
        Comedia = 3,    
        Documentario  = 4,  
        Drama = 5,  
        Espionagem = 6, 
        Faroeste = 7,   
        Fantasia = 8,   
        Ficcao_Cientifica = 9,
        Musical = 10,   
        Romance = 11,
        Suspense = 12,

    }
}
```

4. Criar construtores da classe Serie

``` 
public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
```

5. Criar método de retorno ToString() na classe série.

   ````
    public override string ToString()
           {
               string retorno = "";
               retorno += "Genero: " + this.Genero + Environment.NewLine;
               retorno +=  "Titulo: " + this.Titulo + Environment.NewLine;
               retorno += "Descrição: " + this.Descricao + Environment.NewLine;
               retorno += "Ano de Início: " + this.Descricao + Environment.NewLine; 
               return retorno;
               // usar o metodo Environme.Newline perimite que qualquer sistema operacional que esteja lendo o programa pule a linha corretamente.
           }
   ````

   6. Criar método de retorno para a consulta de parâmetros de titulo e id

      ````
      
              public  string retornaTitulo()
              {
                  return this.Titulo;
              }
              public int RetornaId()
              {
                  return this.Id;
              }
      ````

7. Criar Interface IRepostiorio e criar métodos usando System Collections Generic

   ```
   namespace DIO.Series.Interfaces
   {
       public interface IRepositorio<T> // Lista genérica de repositórios, ou seja, posso criar varios repostirósio a partir dessa interface
       {
           List<T> Lista();
           T RetornaPorId(int id);
           void Insere(T entidade);
           void Exclui(int id);
           void Atualiza(int id);
           int ProximoId();
       }
   ```

   //Lembrando que ao criar uma interface, eu obrigo que a classe que herda a interface implemente os códigos da interface.

8. Criar SerieRepositório para implementar a interface e criar um repositório para armazenar os dados da Serie
```
public class SerieRepositorio : IRepositorio<Serie> // Irá gerar um erro, autocompletar com alt+enter ja vai gerar os construtores do repositório, porem com uma exceção implementada dentro.  

     ex: public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }


```

8. Criar instanciador para a lista

   ```   
      private List<Serie> listaSerie = new List<Serie>();
     
   ```
9. Criar um metodo que faz a leitura da série (Atualiza)
``` 
public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto; // Pega o elemento indexado no vetor.
        }
```
10. Implemtnar metodo exclui

Para implementação deste metodo devemos nos atentar para um problema ao usar o metodo de lista.
A lista recria um indice quando algum elemento central é realmente removido em espaço de memória, sendo assim, devemos fazer com que o programa faça apensar um "Asterisco" no objeto quando ele é removido, ou seja, o objeto permanecerá ná memória, mas não poderá ser acessado pelo usuário.

para isso criamos um variável/campo na classe Serie que é um booleano que controla se a série foi ou não excluída.
```
private bool Excluido  { get; set; }
```

Devemos adicionar no construtor da classe a variável excluido
```
this.Excluido = false;
```
Devemos tambem criar um novo metodo na classe que "Exclui o vetor"
```
 public void Excluir()
        {
            this.Excluido = true;
        }
```
Na classe SerieRepositiorio criar o metodo Excluir para excluir o objeto

```
 public void Exclui(int id)
        {
            listaSerie[id].Excluir(); // este método só marca que o registro foi excluido. E não remove o objeto em memória.
        }
```
11. Para inserir um item na coleção podemos utilizar o metodos padrão add da serie List.

```
 public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }
```
12. Para lista a série:

```
public List<Serie> Lista()
        {
            return listaSerie;
        }
```
13. Para saber o próximo id disponível:

```
  public int ProximoId()
        {
            return listaSerie.Count;
        }
```
14. Para saber qual é a série utilizando apenas o id dela:

```
  public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
        
```

Visão geral da classe de repositório.

```
namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}

```

15. Criar programa principal com informações de console para o usuário.

```
string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("Dio Series ao seu dispor");
    Console.WriteLine("Informe a opção desejada: ");

    Console.WriteLine("1- Listar séries");
    Console.WriteLine("2- Inserir nova séries");
    Console.WriteLine("3- Atualizar série");
    Console.WriteLine("4- Excluir série");
    Console.WriteLine("5- Visualizar série:");
    Console.WriteLine("C- Limpar tela");
    Console.WriteLine("X- Sair");
    Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;
}
```

Conforme o botão aperta o usuário selecionará uma das opções

16. Chamar o Menu no programa principal
```
string opcaoUsuario = ObterOpcaoUsuario();
```
17. Inserir a classe repositório para manipular guardar os arquivos e manipula-los
```
SerieRepositorio repositorio = new SerieRepositorio();
```
18. Criar um menu seletor com Switch/Case no menu principal.

```
switch (opcaoUsuario)
{
    case "1":
        ListarSeries();
        break;  
    case "2":
        InserirSerie();
        break;  
    case "3":
        AtualizarSerie();
        break;   
    case "4":
        ExcluirSerie();
        break;
    case "5":
        VisualizarSerie();
        break;
    case "C":
        Console.Clear();


    default:
        throw new ArgumentOutOfRangeException;   
        break;
```
19. Implementar Metodos do Switch Case

20. Metodo Listar Séries

    ```
    void ListarSeries()
    {
    Console.WriteLine("Listar Séries: ");
    var lista = repositorio.Lista();
    if (lista.Count==0)
    {
        Console.WriteLine("Nenhuma Lista Cadastrada");
        return;
    }
    foreach (var serie in lista)
    {
        Console.WriteLine($"#Id {serie.RetornaId}: {serie.RetornaTitulo}");
    }
    }
```
21. Metodo Inserir Serie
```
Console.WriteLine("Inserir Nova Série: ");

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
    Console.WriteLine($"{i} -{Enum.GetNames(typeof(Genero))} ");
    }
```
//Faz a Varredura do Enum e mostra as opções para o usuário.

```
Console.WriteLine("Considerando as opções acima digite um gênero: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o título da Série: ");
    string entradaTitulo = Console.ReadLine();
    
    Console.WriteLine("Digite o ano de inicio da série: ");
    int entradaAno = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a descrição da série: ");
    string entradaDescricao = Console.ReadLine();
```
// recebe os atributos do objeto série

22. Método Atualiza Serie

Segue o mesmo padrão do insere serie, porem ele usa o Id passado pelo usuário para inserir a série e seus parametros de repositório tambem são alterados

```
void AtualizarSerie()
{
    Console.WriteLine("Atualizar Série: ");
    Console.WriteLine("Digite o Ide da Serie que deseja atualizar: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine($"{i} -{Enum.GetName(typeof(Genero), i)} ");
    }
    Console.WriteLine("Considerando as opções acima digite um gênero: ");
    int entradaGenero = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o título da Série: ");
    string entradaTitulo = Console.ReadLine();
    
    Console.WriteLine("Digite o ano de inicio da série: ");
    int entradaAno = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a descrição da série: ");
    string entradaDescricao = Console.ReadLine();
    
    Serie atualizaSerie = new Serie(id: indiceSerie, genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
    
    repositorio.Atualiza(indiceSerie, atualizaSerie);

}

23. Excluir Série
```
void ExcluirSerie()
{
    Console.WriteLine("Por faovr Digite o ID da série a ser excluida: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    repositorio.Exclui(indiceSerie);

}
```
no toString da classe série podemos concatenar uma String para indicar que a série está Excluida
```
retorno += "Exluido: " + this.Excluido + Environment.NewLine;
```


24. Atualizar Série

```
void VisualizarSerie()
{
    int indiceSerie = int.Parse(Console.ReadLine());
    var serie = repositorio.RetornaPorId(indiceSerie);
    Console.WriteLine(serie);
    
}
```
25. Retorna Excluido
Para melhoria do programa podemos realizar um metodo que diz se a série está excluida ou não e com base nisso fazer modificações na main
```
public bool RetornaExcluido()
        {
            return this.Excluido;
        }
```
Complementar na main no metodo de ListarSeries uma condicional que quando o item estiver excluído ele não é listado

```
void ListarSeries()
{
    Console.WriteLine("Listar Séries: ");
    var lista = repositorio.Lista();
    if (lista.Count == 0)
    {
        Console.WriteLine("Nenhuma Lista Cadastrada");
        return;
    }
    foreach (var serie in lista)
    {
        var excluido = serie.RetornaExcluido();
        if (!excluido)
        {
            Console.WriteLine($"#Id {serie.RetornaId()}: {serie.RetornaTitulo()}");
        }
    }
}
```

# Introdução a API e métodos HTTPs - REST



## Http Metods

### Get

Sempre obtém dados

EndPoint: /api/dev/user

### Post

Cria um novo registro ou recurso

EndPoint: /api/dev/user

### Put

Atualiza um registro existente

EndPoint: /api/dev/user/{id}

### Delete

Remove um registro existente

EndPoint: /api/dev/user/{id}



### Status comuns 

200 = Ok

401= Unauthroized

403 = Forbidden

404 = Not Found

500 = Internal Server Error

504 = Gateway Timeout