Console.WriteLine($"Informe o primeiro número:");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo número:");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o terceiro número>");
int num3 = int.Parse(Console.ReadLine()!);

if ((num1 > num2) && (num1 > num3) && (num2 > num3))
{
    Console.WriteLine(@$"O {num1} é o maior e {num3} é o menor!");
}

else if ((num1 > num2) && (num1 > num3) && (num3 > num2))
{
    Console.WriteLine(@$"O {num1} é o maior e {num2} é o menor!");
}

else if ((num2 > num1) && (num2 > num3) && (num1 > num3))
{
    Console.WriteLine($"O {num2} é o maior e {num3} é o menor!");
}

else if ((num2 > num1) && (num2 > num3) && (num3 > num1))
{
    Console.WriteLine($"O {num2} é o maior e {num1} é o menor!");
}

else if ((num3 > num1) && (num3 > num2) && (num2 > num1))
{
    Console.WriteLine($"O {num3} é o maior e {num1} é o menor!");
}

else if ((num3 > num1) && (num3 > num2) && (num1 > num2))
{
    Console.WriteLine($"O {num3} é o maior e {num2} é o menor!");
}