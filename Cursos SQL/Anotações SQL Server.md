# SQL Server

Os sistemas de bancos de dados servem para concentrar informações e dados de forma estruturada e em tempo real.

## Instalação do SQL Server

Procurar por SQL server e no site da Microsoft, instalar a versão Express, quando no ato da instalação selecionar a opção basic.

Assim que instalado o programa fornecerá uma informação importante chamada cadeia de conexão.

Esta cadeia de conexão é o caminho para que se possa conectar no nosso servidor e fazer consulta no nosso banco de dados.

`Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;`

## Instalação do SSMS( SQL Server Management Studio)

Na própria tela clicar Baixar SSMS que irá redirecionar para o site da Microsoft

o SSMS é uma interface para o usuário manipular o banco de dados. 

Utilizando o menu iniciar acessar o SSMS

Haverá um servidor default setado, clicar em conectar

clicar em nova consulta

## Criando um banco de dados

Para criar um novo banco de dados basta clicar com o botão direito em banco de dados -> Criar novo banco de dados. 

Para excluir banco de dados é só clicar com o direito no banco, excluir, fechar conexões e excluir.

Também é possível criar um banco de dados via linha de comando. Criar nova consulta -> `creat database nomedobanco`

Para entrar dentro do banco de dados criado digitar: `use nomedobanco`

## Criando uma tabela

Para criar uma tabela no SQL devemos digitar o código: 

```

create table Teste // Criando tabela teste
(
Descicao varchar(50) null, //Criando colunaque recebe dados do tipo varchar 50 ATÉ caracteres
Complemento char(10) not null // Criando coluna que recebe dados do tipo var 10 caracteres
)
```

Para criar um banco de dados para a aula criar um banco de dados chamado Ecommerce, com as tabalas/ colunas:

Cliente: <span style="color:red">Codigo int notnull,</span> Nome varchar(200) not null, TipoPessoa char(1) nolnull

Pedido: Codigo int not null, DataSolicitacao datetime not null, FlagPago bit notnull, TotalPedido float notnull, <span style="color:red">CodigoCliente</span> int notnull

PedidoItem: CodigoPedido int notnull, <span style="color:blue"> CodigoProduto int not null</span>, Preco float notnull, Quantidade int notnull

Produtos:<span style="color:blue">  Codigo int notnull</span>, Nome varchar(100) notnull, Descricao varchar(200), Preco float notnull.



## Tipos de dados

Bancos relacionais são extremamente tipados.

varchar - Recebe apenas informações alfanuméricas (limite 4000) - como varchar é uma variável modular ocupa mais espaço de memória, se atentar para modelar o banco conforme a necessidade 

int - números inteiros  positivos e negativos

bigint - numero inteiros maior

char - Recebe caracteres alfanuméricos o tipo char guarda informação no exato tamanho entre parênteses (serve para dados de tamanho fixo)

bit - aceita 0 ou 1.

null e not null - são declarações para variáveis que dizem se elas aceitam valores nulos ou não. 



## Inserindo dados na tabela



Tipos de sintaxe

```sql
insert into clientes (codigo, nome, TipoPessoa) Values (1, 'Guilherme ' , 'F');

insert clientes (codigo, nome, TipoPessoa) values (1, 'Guilherme', 'F'); // insere  de forma endereçada cada variável par campoXValor

insert clientes (TipoPessoa, codigo, nome) values ('f', 1, 'Guilherme' );

insert clientes values ("1, 'guilherme' 'F'); //Insere na ordem que a tabela se apresenta, só funciona quando todos os dados estão disponíveis
```

## Método Select

```sql
Select* from Clientes // Exibe todos os clientes da tabela
```

```sql
Select nome from clientes// Permite que eu mostre somente os nomes dos clientes da tabela clientes
Select nome, TipoPessoa from Clientes // Exibe todos os nomes de e tipos de pessoas da tabela
```

Podemos passar métodos dentro de uma consulta

```sql
Insert Pedido values (1, gatedate(), 0,3, 7)// Puxa o horário da consulta para dentro da tabela.
```

existem vários tipos de formas que podemos tratar nossos dados, no getdate() podemos tratar de forma interessantes

``` sql
select *, convert(varchar, DataSolicitacao, 103)
from pedido
// Siginifca que o programa converte a solicitação de data e hora conforme a formatação 103 que está na documentação da microsoft, no caso em apenas data na formatação BR DD/MM/AA
```





## Método Where

O metodo Where Funciona como uma espécie de filtro para uma consulta

```sql
select * 
from Clientes
where TipoPessoa = 'J';
// Este método faz com que o programa procure em o contexto quais são os Clientes que são do TipoPessoa = J
```



## Método Update

É um método que substitui ou atualiza um ou mais campos dentro do banco de dados

```sql
update clientes
set codigo '99',
	nome: 'José'
where TipoPessoa ='J';

//Essa consulta faz com que o banco de dados procure em toda a classe quais pessoas possuem o tipo 'J' e substitui o numero do código para '99' e altera o nome para josé

```

## Método Delete

Para se deletar alguma linha do banco, podemos fazer a mesma where utilizando a sintaxe apropriada

```sql
delete 
from clientes
where TipoPessoa ='J';

//Essa consulta faz com que o banco de dados procure em todas as pessoas possuem o tipo 'J' e deletam
```

## Chaves Primarias e Chaves Estrangeiras

### Chave Primária (Primary Key)

A Chave primária é única e tem a função de indexar todos os registros, melhorando sua performance na hora de realizar uma consulta

Ex: CPF é um número único que não é igual para duas pessoas

Em banco de dados é comum criar uma coluna que possui um registro imutável que se relaciona diretamente com uma linha do banco de dados

Para cria uma chave primária devemos implementar um código a seguir

```sql
select * 
from clientes

alter table Clientes add constraint pk_cliente primary key (codigo)

// o código acima define que a variável código se tornou uma chave primária, se alguem quiser alterar o código ou inserir um código igual ao da primary key em alguma outra linha, o programa não irá permitir
```

Para a automatização da nossa chave primária, podemos criar nossa identidade, Identity, que permite que campos do time inteiro sejam gerados de forma incremental.

Tabela Clientes-> Design->Codigo-> Propriedades da coluna->Especificação de identidade = sim ->Incremento 1.

Quando fazemos essa especificação de identidade, não podemos fornecer mais este dado no Insert.

### Chaves Estrangeiras (Foreign Key)

Quando a identificação de um item se relaciona com uma informação de outra tabela do banco de dados, a chave criada não deixa de ser primária, porem devemos torna-la um foreign key, para que ela passe como referência a outro item de outra tabela

Uma foreign Key só pode existir se apontar para uma primary key

```sql
select * 
from clientes

alter table Clientes add constraint fk_cliente foreign key (codigoPedido)reference Pedido(codigo)

// o código acima define que a variável código se tornou uma chave primária, se alguem quiser alterar o código ou inserir um código igual ao da primary key em alguma outra linha, o programa não irá permitir
```

Uma chave estrangeira só pode ser criada se tiver o mesmo numero de colunas que a chave primária 

Uma chave estrangeira só pode se relacionar com a chave primária se elas forem do mesmo tipo de variável, int != bigint

 ## Normalização dos Dados - Boas Práticas

Devemos segmentar os dados o máximo possível que nossa regra de negócio permite, para que os dados sejam relacionados da melhor forma dentro do banco de dados. Lembrar do conceito de microserviços.

Não duplicar a informação de um item cujo uma chave estrangeira se relacione com a chave primária do mesmo produto.

Para criar uma informação devemos tentar padroniza-la ao máximo para que ela seja automatizada, podemos até criar dentro do banco de dados um dicionário de status por exemplo

Ideia de Design no banco de dados.



![image-20211215140026790](C:\Drives\Trabalho\DIO\Desafios Dio\Criando um App simples de cadastro de séries em .NET\Ideia de Design)

No modelamento do banco de dados entidade que costuma ter N possibilidades é que fica com a chave primária

# Modelando um banco de dados na prática com SQL SERVER

Criar um banco de dados baseado na api do star wars disponibilizada em: https://swapi.dev/ **Site offline em 15/12/2021** 

![image-20211215144852812](C:\Drives\Trabalho\DIO\Desafios Dio\Criando um App simples de cadastro de séries em .NET\Modelamento Banco de dados StarWars)

Pilotos carrega chaves de planetas

Como o relacionamento entre pilotos e naves são múltiplos na duas direções, devemos criar uma chave intermediária 

![image-20211215145154649](C:\Drives\Trabalho\DIO\Desafios Dio\Criando um App simples de cadastro de séries em .NET\Relacionamento api starwars)

**Código extraído  do repositório da aula**

```sql


USE EstrelaDaMorte

--****** PLANETAS ************************************************************************************************
CREATE TABLE Planetas(
	IdPlaneta int NOT NULL,
	Nome varchar(50) NOT NULL,
	Rotacao float NOT NULL,
	Orbita float NOT NULL,
	Diametro float NOT NULL,
	Clima varchar(50) NOT NULL,
	Populacao int NOT NULL,
)
GO
ALTER TABLE Planetas ADD CONSTRAINT PK_Planetas PRIMARY KEY (IdPlaneta); //Cria um cahve primaria 
GO
--****************************************************************************************************************
--****** NAVES ***************************************************************************************************
CREATE TABLE Naves(
	IdNave int NOT NULL,
	Nome varchar(100) NOT NULL,
	Modelo varchar(150) NOT NULL,
	Passageiros int NOT NULL,
	Carga float NOT NULL,
	Classe varchar(100) NOT NULL,
)
GO
ALTER TABLE Naves ADD CONSTRAINT PK_Naves PRIMARY KEY (IdNave); //Define como chave primária
GO
--****** PILOTOS *************************************************************************************************
--****************************************************************************************************************
CREATE TABLE Pilotos(
	IdPiloto int NOT NULL,
	Nome varchar(200) NOT NULL,
	AnoNascimento varchar(10) NOT NULL,
	IdPlaneta int NOT NULL,
)
GO
ALTER TABLE Pilotos ADD CONSTRAINT PK_Pilotos PRIMARY KEY (IdPiloto); //define como chave primária pilotos
GO
ALTER TABLE Pilotos  ADD  CONSTRAINT FK_Pilotos_Planetas FOREIGN KEY(IdPlaneta)
REFERENCES Planetas (IdPlaneta) // referencia a chave primária piloto como estrangeira de idPlaneta
GO
ALTER TABLE Pilotos CHECK CONSTRAINT FK_Pilotos_Planetas
GO
--****************************************************************************************************************
--****** PILOTOS NAVES *******************************************************************************************
CREATE TABLE PilotosNaves(
	IdPiloto int NOT NULL,
	IdNave int NOT NULL,
	FlagAutorizado bit NOT NULL,
)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT PK_PilotosNaves PRIMARY KEY (IdPiloto, IdNave);
GO // Impede registros duplicados
ALTER TABLE PilotosNaves  ADD CONSTRAINT FK_PilotosNaves_Pilotos FOREIGN KEY(IdPiloto)
REFERENCES Pilotos (IdPiloto) 
GO
ALTER TABLE PilotosNaves  ADD CONSTRAINT FK_PilotosNaves_Naves FOREIGN KEY(IdNave)
REFERENCES Naves (IdNave)
GO
ALTER TABLE PilotosNaves  ADD CONSTRAINT DF_PilotosNaves_FlagAutorizado  DEFAULT (1) FOR FlagAutorizado // Define o padrão default caso não seja passado nenhum valor
GO
--****************************************************************************************************************
--****** HISTÓRICO DE VIAGENS ************************************************************************************
CREATE TABLE HistoricoViagens(
	IdNave int NOT NULL,
	IdPiloto int NOT NULL,
	DtSaida datetime NOT NULL,
	DtChegada datetime NULL
)
GO

ALTER TABLE HistoricoViagens  ADD  CONSTRAINT FK_HistoricoViagens_PilotosNaves FOREIGN KEY(IdPiloto, IdNave)
REFERENCES PilotosNaves (IdPiloto, IdNave)
GO

ALTER TABLE HistoricoViagens CHECK CONSTRAINT FK_HistoricoViagens_PilotosNaves
GO
--****************************************************************************************************************
```

