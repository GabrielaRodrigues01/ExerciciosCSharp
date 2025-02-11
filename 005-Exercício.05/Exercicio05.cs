using System;

double numero1 = 0;
double numero2 = 0;
double resultado = numero1 / numero2;  

Console.WriteLine($"Resultado: {resultado}");

if (double.IsNaN(resultado))
{
    Console.WriteLine("O resultado é NaN (Not-A-Number).");
}