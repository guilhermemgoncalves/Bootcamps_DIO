// See https://aka.ms/new-console-template for more information


double ajuste;
double somaAtuais=0;
double somaReajustados=0;


while (true)
{
    Console.WriteLine("Digite seu nome:");
    string nome = Console.ReadLine();
    if (nome.ToLower().Equals("fim"))
    {
        break;
    }
    Console.WriteLine("Digite seu salário");
    string salarioLido = Console.ReadLine();

    double salario = Convert.ToDouble(salarioLido);

    if (salario < 0)
    {
        ajuste = 0;
        Console.WriteLine("Valor Inválido");
    }
    else if (salario < 150)
    {
        { ajuste = 1.25; }

    }
    else if (salario < 300)
    {
        ajuste = 1.20;
    }
    else if (salario < 600)
    { ajuste = 1.15; }
    else
    { ajuste = 1.10; }

    double salarioReajustado = salario * ajuste;

    Console.WriteLine($"Funcionário {nome} \nSalário: {salario}\nSalario reajustado: {salarioReajustado}");

    somaAtuais += salario;
    somaReajustados += salarioReajustado;
}


Console.WriteLine($" A soma dos salários atuais é: {somaAtuais}\nA soma dos salários com reajuste é: {somaReajustados}");



