using System;

for (int i = 10; i > 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Caiu no continue");
        continue; // Pula para a próxima iteração
    }
    Console.WriteLine(i);
}