using System;

string nome = "Gabriela";
int idade = 24;

if (!string.IsNullOrEmpty(nome) && nome == "Gabs")
{
    Console.WriteLine("Nome está definido");
} 
else if (nome == "Gabriela" && nome.Length > 5 && idade == 24) 
{
    Console.WriteLine("O nome é Gabriela e a idade é 24.");
} 
else 
{
    Console.WriteLine("Não é Gabriela!");
}