/*Devido a uma situação do trabalho no IFSP, decidi criar uma simples implementação que resolva um problema real de serviço
Estou fazendo a contagem de componentes eletronicos e esses componentes são de tamanho pequeno o que dificulta a contagem em falha de concentração
O local possui uma balança de precisão, onde posso primeiro coletar o peso de uma unica unidade e fazer um calculo percentual (regra de 3) entre o peso e a quantidade de itens computados

Passos do programa 
1 - Coletar o nome do componente em questão.
2 - Coletar o peso unitário.
3 - Coletar o peso total.
4 - Calcular o numero de componentes a partir do peso unitário.
5 - demonstrar ao usuário a quantidade e nome do componente em uma string.

Extra: Verificar viabilidade do uso de arrays 
Extra: Verificar viabilidade do uso de um txt para armazenar esses dados
*/


programa
{	
	inclua biblioteca Arquivos --> arq // Inclui a biblioteca de arquivos para procesar as operações de salvamento de dados
	inteiro quantidade,total,unitario // Variaveis de operação 
	caracter = finaliza = 's' // variavel de loop para manter o programa em funcionamento ou não (fiz de forma contraria sem querer)
	cadeia nome, bufferfrase // Variavel que contem o nome do componente a ser armazenado
	const cadeia CAMINHO = "./ContComp.txt" // String que fixa o endereço onde os dados do programa serão salvo, preferencialmente na pasta onde o programa se localiza

	
	
	funcao inicio()
	
	{	
		escreva("Calculadora de quantidade de componentes por peso\n")
		

		faca {
			
			se (finaliza == 's')
			{	escreva("Este programa calcula a quantidade de componentes pela relação peso unitário x peso total\n")
				inteiro endereco = arq.abrir_arquivo(CAMINHO, arq.MODO_ACRESCENTAR) //Endereço de memória em que o arquivo está armazenado
				escreva("Digite o nome do componente: ")
				leia(nome)
				limpa()
				escreva("Digite o peso unitário do componente(mg): ")
				leia(unitario)
				limpa()
				escreva("Digite o peso total dos componentes(mg): ")
				leia(total)
				limpa()
				quantidade = total/unitario //Não fiz alteração para o modo real pois no caso de uso para o uso é interessante utilizar arredondamento sempre para baixo
				escreva("A quantidade de " +nome +" é: " + quantidade+"\n") // Realiza a regra de 3 QuantidadeTotal = (QuantidadeUnitária*MassaTotal)/MassaUnitária
				bufferfrase =(nome + " " + quantidade) //estrutura o texto a ser armazenado no relatório txt		
				
				arq.escrever_linha(bufferfrase, endereco)//escreve a linha no doc txt
				arq.fechar_arquivo(endereco)//fecha o programa
			}
			senao 
			{
				escreva("O caractere digitado é invalido\n")
			}
			
			escreva("Deseja contar mais um componente?<s/n>: ")
			leia(finaliza)
			limpa()
		}enquanto (finaliza != 'n')
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1294; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */