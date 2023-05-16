
Console.WriteLine($"Digite a quantidade de maças que você vai comparar: ");
float macas = float.Parse(Console.ReadLine()!);

float macas3 = macas * 0.30f;
float macas2 = macas * 0.25f;


if (macas <= 11)
{
        Console.WriteLine($"O valor foi {macas3}");
}
else 
{
        Console.WriteLine($"O valor foi {macas2}");
}
