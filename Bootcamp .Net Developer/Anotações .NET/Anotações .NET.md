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

## Arrays em C#

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

O Índice do array é o lugar exato onde o elemento do array está alocado.



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

### Polismorfismo

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





