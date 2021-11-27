//Programa em portugol para calculo de média realizando alterações
//alterações realizadas: menu seletor no programa o usuário escolher se quer ou não realmente executar o programa
//Deixei inseri a opção de tirar o programa da opção de looping para ele ser utilizado uma unica vez
//conceitos aprendidos: conceito de loop, como se representa um caractere, como usar o caso condicional caso e casocontrario.



programa
{
	real nota1,nota2,nota3,nota4, media
	cadeia nome
	caracter decisao1

	
	funcao inicio()
	{ 	
		escreva("Digite seu nome: ")//introdução do programa
		leia(nome)

		escreva("Olá " + nome + "!") //recebe o nome do usuário do programa
		escreva(" Seja bem vindo ao programa de calculo de média:")		
		escreva("Gostaria de iniciar o programa? (s/n): ") //pergunta se o usuário gostaria de utilizar o programa pela primeira vez
	//se não quiser fazer essa primeira verificação por redundancia é só remover as linhas de codigo de 21 até 35
		leia(decisao1)
		
		escolha(decisao1)
		{
		caso 's':
		escreva("Muito bem: \n") //Valida a escolha e envia a conta
		pare
		caso 'n':
		escreva("Muito Obrigado por utilizar o programa, Volte quando necessário.")//encerra o programa sem realizar a conta
		pare
		caso contrario:
		escreva("Você digitou um valor diferente de s/n, por segurança o programa será encerrado!")//mensagemd e erro!
		}
		enquanto (decisao1 == 's')// loop para que o programa não se encerre enquanto o usuário não solicite!
		{
		escreva ("Por favor digite a primeira nota: ")// inicia a coleta de informações da nota
		leia(nota1)
		escreva("Por favor digite a segunda nota: ")
		leia(nota2)
		escreva("Por favor digite a terceira nota: ")
		leia(nota3)
		escreva("Por favor digite a quarta nota: ")
		leia(nota4)		
		
		media = (nota1+nota2+nota3+nota4)/4 // Calculo da média das notas!
		escreva("A média entre as notas é: " + media)//divulgado o resultado da operação
		se (media>=6.6)//Explica se foi aprovado ou reprovado
			
			escreva("\nParabens, você foi aprovado!\n")
			senao 
			escreva("\nInfelizmente você foi reprovado!\n")

		escreva("Gostaria de calcular a média novamente? (s/n?): ") //rotina de decisão se o programa continua ou não funcionando em loop
		leia(decisao1) //para remover rotina de verificação alterar transformar essa linha e a de cima em comentario e retirar o comentário da linha abaixo 
		//decisao1 = 'n'
		escolha(decisao1)
		{
		caso 's':
		escreva("Muito bem: \n")//Valida a escolha e envia a conta
		pare
		caso 'n':
		escreva("Muito Obrigado por utilizar o programa, Volte quando necessário.")//encerra o programa após a realização da conta
		pare
		caso contrario:
		escreva("Você digitou um valor diferente de s/n, por segurança o programa será encerrado!")//mensagem de erro!
		}
		}
	
	
	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 407; 
 * @DOBRAMENTO-CODIGO = [58];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */