//Exercicio de criação de Vetores para cadastro de Nome, Telefone e endereço
//Exercicio proposto por Prof Denilson Bonnati
//Funcionalidades
//1- O Programa coleta informações para cadastro
//2- O Programa selciona se você quer saber as informações de um cliente específico ou muitos
//3- Divulgando a informação o programa se encerra



programa
{
	
	funcao inicio()
	{	
		inteiro Ncliente 
		
		cadeia cadastro[3][3]

		Ncliente = 0

		escreva("Cadastre os clientes:\n")
		faca{
		escreva("O nome do cliente: ")
		leia(cadastro[Ncliente][0])
		escreva("Digite o numero de telefone: ")
		leia(cadastro[Ncliente][1])
		escreva("Digite a cidade: ")
		leia(cadastro[Ncliente][2])
		Ncliente ++
		
		}enquanto (Ncliente<3)

		escreva("Consulte o clinte pelo numero de 1 a 3, caso deseje a lista completa digite 0:\n")
		escreva("Digite o numero do cliente que queira consultar: ")
		leia(Ncliente)

		escolha(Ncliente)
		{
		caso 0:
		escreva("Cliente #1")
		escreva("\nNome: " + cadastro[0][0])
		escreva("\nTelefone: " + cadastro[0][1])
		escreva("\nCidade: " + cadastro[0][2])

		escreva("Cliente #2")
		escreva("\nNome: " + cadastro[1][0])
		escreva("\nTelefone: " + cadastro[1][1])
		escreva("\nCidade: " + cadastro[1][2])
		
		escreva("Cliente #3")
		escreva("\nNome: " + cadastro[2][0])
		escreva("\nTelefone: " + cadastro[2][1])
		escreva("\nCidade: " + cadastro[2][2])
		pare
		
		caso 1:
		escreva("\nNome: " + cadastro[Ncliente-1][0])
		escreva("\nTelefone: " + cadastro[Ncliente-1][1])
		escreva("\nCidade: " + cadastro[Ncliente-1][2])
		pare
		caso 2:
		escreva("\nNome: " + cadastro[Ncliente-1][0])
		escreva("\nTelefone: " + cadastro[Ncliente-1][1])
		escreva("\nCidade: " + cadastro[Ncliente-1][2])
		pare
		caso 3:
		escreva("\n\nNome: " + cadastro[Ncliente-1][0])
		escreva("\n\nTelefone: " + cadastro[Ncliente-1][1])
		escreva("\n\nCidade: " + cadastro[Ncliente-1][2])
		pare
		caso contrario:
		escreva("Cliente não localizado")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 335; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */