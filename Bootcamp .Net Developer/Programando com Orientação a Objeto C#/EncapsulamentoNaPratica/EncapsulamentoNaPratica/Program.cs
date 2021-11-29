// See https://aka.ms/new-console-template for more information

using EncapsulamentoNaPratica;

Retangulo r = new Retangulo();
Retangulo r2 = new Retangulo();

r.DefinirMerdidas(30, 30);
Console.WriteLine($"Area: {r.ObterArea()}");

r2.DefinirMerdidas(0, 30);
Console.WriteLine($"Area: {r2.ObterArea()}");