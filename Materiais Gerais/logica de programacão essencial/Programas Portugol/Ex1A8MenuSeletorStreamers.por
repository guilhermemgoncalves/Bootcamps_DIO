//exmplo da aula de logica de programação em portugol, Prof Edilson Bonnati
//Programa realiza a seleção de um menu de "streamers de vídeo"

programa
{
	inteiro menu=0
	
	
	
	funcao inicio()
	{	
		escreva("Menu seletor de streamers: ")
		escreva("Escolha uma das opções: \n (1) - Abrir Netflix\n (2) - Abrir Amazon Prime \n (3) - Abrir HBO -GO \n (4) - Sair \n") 
		
		leia(menu)
		escolha(menu)
		{
		caso 1: // testa valor 1
		escreva("Ok! Abrir Netflix")
		pare
		caso 2: // testa valor 2
		escreva("Ok! Abrir Amazon Prime")
		pare
		caso 3: // testa valor 3
		escreva("Ok! Abrir HBO -GO")
		pare
		caso 4:
		escreva("Menu finalizado")
		pare
		caso contrario :
		escreva("Escolha as opções 1, 2 ou 3")
		
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 645; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */