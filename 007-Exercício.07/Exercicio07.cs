using System;

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine(); 

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());  

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");