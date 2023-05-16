
Console.WriteLine($"Informe o número correspondente ao dia da semana: ");
int diaSemana = int.Parse(Console.ReadLine()!);

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"Hoje é domingo !!");
        break;
    case 2:
        Console.WriteLine($"Hoje é segunda !!");
        break;
    case 3:
        Console.WriteLine($"Hoje é terça !!");
        break;
    case 4:
        Console.WriteLine($"Hoje é quarta !!");
        break;
    case 5:
        Console.WriteLine($"Hoje é quinta !!");
        break;
    case 6:
        Console.WriteLine($"Hoje SEXTOOOU !!!!!!");
        break;
    case 7:
        Console.WriteLine($"Hoje é sabado !!");
        break;
    default:
        Console.WriteLine($"O dia informado não corresponde com nenhum dia da semana.");
        
        break;
}

