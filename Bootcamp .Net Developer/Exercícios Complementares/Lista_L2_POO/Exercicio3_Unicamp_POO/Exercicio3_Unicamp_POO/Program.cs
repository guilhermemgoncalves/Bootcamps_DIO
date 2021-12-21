// questão 3  Escreva uma classe em que cada objeto representa um vôo que acontece em determinada data e em determinado horário.Cada vôo possui no máximo 100 passageiros, e a classe permite controlar a ocupação das vagas.A classe deve ter os seguintes métodos:
/*construtor: configura os dados do vôo (recebidos como parâmetro): número do vôo, data (para
armazenar a data utilize um objeto da classe Data, criada na questão anterior);
proximoLivre: retorna o número da próxima cadeira livre
verifica: verifica se o número da cadeira recebido como parâmetro está ocupada
ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro, e retorna verdadeiro se a cadeira ainda não estiver ocupada (operação foi bem sucedida) e falso caso contrário
vagas: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo
getVoo: retorna o número do vôo
*/
using Exercicio2_Unicamp_POO;
using Exercicio3_Unicamp_POO.Datas;
using Exercicio3_Unicamp_POO.Voo;

Console.WriteLine("");
Console.WriteLine("DIO Airlines");
Console.WriteLine("");


Console.WriteLine("Digite o numero do vôo para cadastro: ");
int entradaIdVoo  = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o dia de partida do voo: ");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o mes de partida do voo: ");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a hora de partida do voo: ");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Digite os minutos de partida do voo: ");
int minuto = int.Parse(Console.ReadLine());


Data entradaData = new Data(dia: dia, mes: mes);
Horario entradaHorario = new Horario(hora, minuto);


Voo voo = new (horario: entradaHorario, data: entradaData, idVoo:entradaIdVoo);

Console.WriteLine(voo.ToString());


