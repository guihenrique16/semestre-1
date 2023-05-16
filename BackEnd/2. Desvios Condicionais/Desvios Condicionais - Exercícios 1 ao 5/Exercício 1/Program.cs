
Console.WriteLine($"Informe o dia do seu nascimento: ");
int dia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o mes do seu nascimento: ");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o ano do seu nascimento: ");
int ano = int.Parse(Console.ReadLine()!);

if ( ( dia >= 1 ) && ( dia <= 31 ) && ( mes >= 1 ) && ( mes <= 12 ) && ( ano < 2023 ) )
{
    Console.WriteLine($"Essa data de nascimento é válida!");
}
else 
{
    Console.WriteLine($"Data inválida!");   
}