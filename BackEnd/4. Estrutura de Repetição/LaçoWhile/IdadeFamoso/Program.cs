
bool idadeCerta = false;

do
{
    Console.WriteLine($"Informe a idade do CR7: ");
    int idade = int.Parse(Console.ReadLine()!);

    if (idade == 38)
    {
        idadeCerta = true;
    }
    else 
    {
        Console.WriteLine($"Putss, você errou!!");
    }
    
    
} while (idadeCerta == false);

Console.WriteLine($"Parabens, você acertou!!!");

