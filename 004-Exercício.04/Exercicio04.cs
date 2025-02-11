using System;

bool condicao1 = true;
bool condicao2 = false;

bool resultadoAnd = condicao1 && condicao2;

bool resultadoOr = condicao1 || condicao2;

bool resultadoNot = !condicao1;

Console.WriteLine($"Resultado AND: {resultadoAnd}");
Console.WriteLine($"Resultado OR: {resultadoOr}");
Console.WriteLine($"Resultado NOT: {resultadoNot}");jj