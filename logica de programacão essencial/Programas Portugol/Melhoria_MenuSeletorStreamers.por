//Programa para praticar implementação de funções
//Insight meu da madrugada olhando exemplos do portugol studio para celular
//Usar temática do seletor de streamers, tentando colocar em loop com utilizando condicionais e funções


programa
{
	inteiro = menu = 0
	funcao inicio()
	{	
		funcao mensageminicial()
		
		
		faca
		{	funcao mensagemseletor()
			leia(menu)
			escolha(menu)
			{
			
			caso 1:
			escreva(" O Netflix foi selecionado")
			menu=4
			pare
			caso 2:
			escreva(" HBOMax foi selecionado")
			menu=4
			pare
			caso 3:
			escreva(" Amazon Primve Vídeo foi selecionado")
			menu=4
			pare
			caso 4:
			escreva(" A aplicação foi encerrada")
			menu=4
			pare
			caso contrario:
			escreva("O numero foi digitado incorretamente\n")
			pare
			
			}
		}enquanto (menu!=4)
		
	}
	funcao mensageminicial()
	{
		escreva("Olá, bem vindo ao menu de streamers")
	
	}
	funcao mensagemseletor()
	{
		escreva("Por favor, escolha uma das opções a seguir: \n (1) - Netflix.\n (2) - HBOMax.\n (3) - Amazon Prime Video\n (4) - Sair\n")
		
	}
	
	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 352; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */