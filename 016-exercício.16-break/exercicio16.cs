using System;

for (int i = 0; i < 10; i++)
{
    string nome = "Gabriela";

    if (i == 3)
    {
        nome = "Gabs";
    }

    if (i == 5 && nome == "Gabs")
    {
        Console.WriteLine("O nome é Gabs, pode parar");
        break;
    }

    Console.WriteLine(i);
}