using ExercícioCalculadora;

// Personagem p1 = new Personagem();
Operacoes op = new Operacoes();
float resultado;

Console.WriteLine(@$"
|---Calculadora---|
|----(1) Soma-----|
|--(2) Subtração--|
|-(3) Multipliçã--|
|---(4) Divisão---|
");
string opcao = Console.ReadLine()!;
while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
{
    Console.WriteLine($"Opção inválida. Por favor, digite novamente.");
    opcao = Console.ReadLine()!;
}
Console.WriteLine($"Digite o 1º número: ");
float n1 =float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o 2º número: ");
float n2 =float.Parse(Console.ReadLine()!);

switch (opcao)
{
    case "1":
        // resultado = op.Somar(n1, n2);
        Console.WriteLine($"O resultado é: {op.Somar(n1, n2)}");
        break;
    case "2":
        resultado = op.Subtrair(n1, n2);
        Console.WriteLine($"O resultado é: {resultado}");
        break;
    case "3":
        resultado = op.Multiplicar(n1, n2);
        Console.WriteLine($"O resultado é: {resultado}");
        break;
    case "4":
        resultado = op.Dividir(n1, n2);
        Console.WriteLine($"O resultado é: {resultado}");
        break;
}


