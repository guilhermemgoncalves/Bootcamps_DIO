//Programa exemplo Aula linguagem de programação professor Denilson Bonatti
//O Programa permite aprender estruturas de repetição (loop)
//O programa faz automaticamente a tabuada do 9 usando o faca/enquanto


programa
{	
	
	funcao inicio()
	{	
		inteiro mult,resultado,limite
		limite= 10
		mult = 0
		escreva("Tabuada do 9:")
		faca{
			resultado= 9*mult
			escreva("\n9 x " + mult + " = " + resultado)
			mult = mult+1
		}enquanto (mult<=limite)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 207; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */