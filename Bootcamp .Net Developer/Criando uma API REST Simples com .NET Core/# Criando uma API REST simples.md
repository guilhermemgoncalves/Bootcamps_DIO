# Criando uma API REST simples

 Conceito do que é REST

 https://www.alura.com.br/artigos/rest-conceito-e-fundamentos?gclid=Cj0KCQiA8ICOBhDmARIsAEGI6o05ttRoqUnlI4-_qyHPO6DFXmuNXJPksoOq2Q1sE8OBQPjbppG6_kIaAhYZEALw_wcB

https://www.redhat.com/pt-br/topics/api/what-is-a-rest-api
Utilzar o app de séries do outro projeto.

1.  Separar os projetos
Criar um novo projeto clicando com o botão direito na solution e escrever o nome do projeto.Console isso significa que o projeto agora tera seu console (view) será desacoplado da camada de model (ou regras de negócio) 
Copiamos a classe program da classes dio.Series e colamos e Dio.Series.Console, em seguida deletamos a classe program de DIO.series e clicamos com o botão direito e DIO.Series e transformamos em Library.
Clicamos com o botão direito em dependencies de DIO.Series.Console Add referencia de projeto e selecionar Dio.Series
2.  Criar um Web API .NetCore 

