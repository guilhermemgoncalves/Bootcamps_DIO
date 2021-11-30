// See https://aka.ms/new-console-template for more information

int numDecimal = 10;
string numBinario;

int estouro = numDecimal % 2; 
numDecimal = numDecimal / 2;

numBinario = Convert.ToString(estouro);
Console.WriteLine(numBinario);

estouro = numDecimal % 2;
numDecimal = numDecimal / 2;
numBinario = Convert.ToString(estouro) + numBinario;
Console.WriteLine(numBinario);
estouro = numDecimal % 2;
numDecimal = numDecimal / 2;
numBinario = Convert.ToString(estouro) + numBinario;
Console.WriteLine(numBinario);
estouro = numDecimal % 2;
numDecimal = numDecimal / 2;
numBinario = Convert.ToString(estouro) + numBinario;
Console.WriteLine(numBinario);