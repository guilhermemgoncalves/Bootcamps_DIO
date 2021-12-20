//Escreva uma classe Data cuja instância (objeto) represente uma data. Esta classe deverá dispor dos seguintes métodos:
//construtor : define a data que determinado objeto (através de parâmetro), este método verifica se a data está correta, caso não esteja a data é configurada como 01/01/0001
//compara: recebe como parâmetro um outro objeto da Classe data, compare com a data corrente e retorne: 0 se as datas forem iguais; 1 se a data corrente for maior que a do parâmetro; -1 se a data do parâmetro for maior que a corrente.
//getDia: retorna o dia da data
//getMes: retorna o mês da data
//getMesExtenso: retorna o mês da data corrente por extenso
//getAno: retorna o ano da data
//isBissexto: retorna verdadeiro se o ano da data corrente for bissexto e falso caso contrário
// clone o objeto clona a si próprio, para isto, ele cria um novo objeto da classe Data com os mesmos valores de atributos e retorna sua referência pelo método

using Exercicio2_Unicamp_POO;

Data dataValida = new Data(16, 12, 2021 );
Data dataIgual = new Data(16, 12, 2021 );
Data dataInvalida = new Data(32, 12, 2021);
Data dataMaior = new(17, 12, 2021);
Data dataMenor = new(16, 11, 2021);

Console.WriteLine(dataValida.ToString());
Console.WriteLine(dataInvalida.ToString());


Console.WriteLine(dataValida.compara(dataMenor));
Console.WriteLine(dataValida.getDia());
Console.WriteLine(dataValida.getMes());
//get mes extenso existem duas formas de fazer, irei fazer as duas, com switch case normal, e switch case com enum
Console.WriteLine(dataValida.getAno());

//Não implementar classes bissesto pois é complicada demais para o propósito que é somente movimentar classes


