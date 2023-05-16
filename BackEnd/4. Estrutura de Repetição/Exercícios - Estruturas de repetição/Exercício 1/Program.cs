
Console.WriteLine($"Informe sua nota de 0 a 10: ");
float nota = float.Parse(Console.ReadLine()!);

while ((nota > 10) || (nota < 0))
{
    Console.WriteLine($"Nota inválida. Por favor digite novamente.");
    nota = float.Parse(Console.ReadLine()!);
}
