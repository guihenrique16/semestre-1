int par = 0;
int impar = 0;


int[] numeros = new int[6]; 

for (var i = 0; i < 6; i++)
{
    Console.WriteLine($"Digite um numero");
    numeros[i] = int.Parse(Console.ReadLine()!);

    if ((numeros[i] % 2 == 0) && (numeros[i] > 0))
    {
        par++;
    }
    else
    {
        impar++;
    }
}

foreach (var item in numeros)
{
    if (item % 2 == 0)
    {
        Console.WriteLine($"{item} par");
    }
    else
    {
        Console.WriteLine($"{item} impar");
        
    }
}

Console.WriteLine($"Há {par} pares e {impar} impares");
