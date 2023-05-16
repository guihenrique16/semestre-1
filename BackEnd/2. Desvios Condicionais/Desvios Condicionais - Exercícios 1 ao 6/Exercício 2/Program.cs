
Console.WriteLine($"Informe a quantidade de gols do primeiro time: ");
int primeiroTime = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a quantidade de gols do segundo time: ");
int segundoTime = int.Parse(Console.ReadLine()!);

if (primeiroTime > segundoTime)
{
    Console.WriteLine($"O primeiro time ganhou a partida.");
}
else if (primeiroTime == segundoTime)
{
    Console.WriteLine($"A partida terminou em empate.");
}
else 
{
    Console.WriteLine($"O segundo time ganhou a partida.");
}