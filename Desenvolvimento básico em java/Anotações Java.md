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







