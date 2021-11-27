programa
{
	real nota1,nota2,nota3,nota4, media
	cadeia nome
	
	funcao inicio()
	{ 	escreva("Digite seu nome: ")
		leia(nome)
		
		escreva("Olá! " + nome + ", Seja bem vindo ao programa de calculo de média: \nPor Favor digite a primeira nota: ") 
		leia(nota1)
		escreva("Por favor digite a segunda nota: ")
		leia(nota2)
		escreva("Por favor digite a terceira nota: ")
		leia(nota3)
		escreva("Por favor digite a quarta nota: ")
		leia(nota4)

		media = (nota1+nota2+nota3+nota4)/4

		escreva("A média entre as notas é: " + media)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 427; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */