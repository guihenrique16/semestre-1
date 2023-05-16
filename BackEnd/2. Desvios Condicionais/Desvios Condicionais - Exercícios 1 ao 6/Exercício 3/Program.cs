
Console.WriteLine($"Digite o lado do triangulo: ");
float lado1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o lado do triangulo: ");
float lado2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o lado do triangulo: ");
float lado3 = float.Parse(Console.ReadLine()!);

if ((lado1 == lado2) && (lado2 == lado3) && (lado1 == lado3))
{
    Console.WriteLine($"É um triangulo equilátero.");
}
else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
{
    Console.WriteLine($"É um triangulo isóseles.");
}
else 
{
    Console.WriteLine($"É um triangulo escaleno.");
    
}