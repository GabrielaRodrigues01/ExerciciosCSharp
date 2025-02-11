using System;

double numero1 = 7.25;
double numero2 = 5.10;
double numero3 = 8.45;

double maior = Math.Max(numero1, numero2);

double menor = Math.Min(numero1, numero2);

double arredondado = Math.Round(numero3);

double arredondadoCima = Math.Ceiling(numero3);

Console.WriteLine($"Maior número: {maior}");
Console.WriteLine($"Menor número: {menor}");
Console.WriteLine($"Número arredondado: {arredondado}");
Console.WriteLine($"Número arredondado para cima: {arredondadoCima}");