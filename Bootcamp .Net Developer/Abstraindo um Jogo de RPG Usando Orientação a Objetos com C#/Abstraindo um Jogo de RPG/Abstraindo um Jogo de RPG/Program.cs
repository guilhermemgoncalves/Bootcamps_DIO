// See https://aka.ms/new-console-template for more information
using Abstraindo_um_Jogo_de_RPG.Entities;


Knight Arus = new("Arus",23, "Knight", 469,72);
Ninja Wedge = new("Arus",23, "Knight", 292,89);
Wizzard Jenica = new ("Jenica", 23, "White Wizard", 325,474);
Black_Wizzard Topapa = new("Topapa", 42, "Black Wizzard", 106, 641);


Console.WriteLine(Arus);
Console.WriteLine(Wedge);
Console.WriteLine(Topapa);
Console.WriteLine(Jenica);

Console.WriteLine(Arus.Attack());
Console.WriteLine(Wedge.Attack() );
Console.WriteLine(Topapa.Attack(6));
Console.WriteLine(Jenica.Attack(20));