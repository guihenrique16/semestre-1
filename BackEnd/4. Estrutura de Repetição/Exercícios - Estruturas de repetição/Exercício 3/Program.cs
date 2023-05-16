
Console.WriteLine(@$"
_________________
|----Tabuada----|
|---------------|
");


Console.WriteLine($"Digite um número: ");
int numero = int.Parse(Console.ReadLine()!);

for (int contador = 1; contador <= 10; ++contador)
{
    int formula = numero * contador;
    Console.WriteLine(numero + " X " + contador + " = " + formula);

}

