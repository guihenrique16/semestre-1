
Console.WriteLine($"Informe seu salário: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o valor gasto: ");
float valorGasto = float.Parse(Console.ReadLine()!);


if (salario > valorGasto) 
{
    Console.WriteLine($"Os gastos foram {valorGasto}. Gastos dentro do orçamento.");   
}
else
{
    Console.WriteLine($"Os gastos foram {valorGasto}. Orçamento estourado.");
}

