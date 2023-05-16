
Console.WriteLine($"Informe sua média: ");
float media = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe sua frequencia: ");
float frequencia = float.Parse(Console.ReadLine()!);

if ( ( frequencia >= 75 ) && ( media >= 3 ) && ( media <= 6 ) )
{
    Console.WriteLine($"O aluno está de recuperação.");
    
}
else if ( ( frequencia >= 75 ) && ( media >= 7 ) )
{
    Console.WriteLine($"O aluno foi aprovado.");
}
else 
{
    Console.WriteLine($"O aluno foi reprovado.");
}