//Programa exemplo Aula linguagem de programação professor Denilson Bonatti
//O Programa permite aprender estruturas de repetição (loop)
//O programa faz automaticamente a tabuada do 9 usando o faca/enquanto
//Melhoria sugerida pelo professor para que o valor da tabuada seja fornecida pelo usuário


programa
{	
	
	funcao inicio()
	{	
		inteiro mult1,mult2,resultado,limite
		limite= 10
		mult1 = 0
		
		escreva("Programa tabuada \"N\", Digite o numero que deseja calcular a tabuada de 0 a 10: ")
		leia(mult2) //Colhendo o valor da variável
		escreva("Tabuada do" +mult2 +" :") 
		faca{// Realiza o calculo em loop da tabuada 
			resultado= mult2*mult1
			escreva("\n" + mult2 + " X " + mult1 + " = " + resultado) // String que exibe o valor na tela
			mult1 ++ //Estrutura de contagem 
		}enquanto (mult1<=limite)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 351; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {mult2, 12, 16, 5}-{mult1, 12, 10, 5};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */