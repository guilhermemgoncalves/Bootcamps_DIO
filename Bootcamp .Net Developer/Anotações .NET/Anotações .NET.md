# Anotações .NET

## O que é o .NET

É uma framework que da suporte a alguns tipos de linguagem com: C# F# e VB
Para se programar atravéz do VScode com .NET, precisamos instalar sua SDK separadamente
Para utiliza-lo com o Visual Studio podemos instalar o pacote dentro do próprio aplicativo do VS.
Lembrando: Visual Studio é uma IDE com vários recursos para a programação em C# e o VS code é apenas um editor de código, que possui vários recursos de conexão, porem não auxilia automáticamente na produção do código.

## O que é e como funciona o C#
Assim como Java é uma linguagem fortemente tipada (o que permite detectar erros em tempo de compilação), é elegante, e orientada a objetos.
Possui sintaxe de alto nível similar a C, C++ e Java
Suporta os conceitos de orientação ao objetos.

Programas em C# são desenvolvidos em .NET

O .NET já possui uma infinidade de classe pré implementadas que facilitam a execução de programas e soluções.

### Conversão do código fonte

O Cogido fonte possui o seguinte fluxo de conversão:
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

O Indice do array é o lugar exato onde o elemento do array está alocado.
