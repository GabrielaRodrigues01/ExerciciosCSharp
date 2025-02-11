using System;

bool passaporte = true;
int idade = 19;
string nome = "Gabriela";

if (idade == 19)
{
    Console.WriteLine("A idade é = 19");
}

if (idade > 25)
{
    Console.WriteLine("A idade é maior que 25");
}

if (nome == "Gabriela" && idade > 10)
{
    Console.WriteLine("Liberado!");
}

if ((nome == "Gabriela" && idade > 10) || passaporte == true)
{
    Console.WriteLine("Liberado 2!");
}