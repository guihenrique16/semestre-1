
Console.WriteLine($"Informe seu nome: ");
string nome = Console.ReadLine()!;

while (nome == "")
{
    Console.WriteLine($"Nome inválido. Por favor, digite novamente.");
    nome = Console.ReadLine()!;
}

Console.WriteLine($"Informe sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

while ((idade < 1) || (idade > 100))
{
    Console.WriteLine($"Idade inválida. Por favor, digite novamente.");
    idade = int.Parse(Console.ReadLine()!);
    
}

Console.WriteLine($"Informe seu salário: ");
float salario = float.Parse(Console.ReadLine()!);

while (salario <= 0)
{
    Console.WriteLine($"Salário inválido. Por favor, digite novamente.");
    salario = float.Parse(Console.ReadLine()!);
}

Console.WriteLine(@$"
Informe seu estado civil: 
(s) Solteiro
(c) Casado
(v) Viúvo
(d) Divorciado
");
char estadoCivil = char.Parse(Console.ReadLine()!);

while ((estadoCivil != 's') && (estadoCivil != 'c') && (estadoCivil != 'v') && (estadoCivil != 'd'))
{
    Console.WriteLine($"Nenhuma das opções são válidas. Por favor, digite novamente.");
    estadoCivil = char.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Suas informações são válidas. Você se chama {nome}, tem {idade}, recebe {salario} e seu estado civil é ({estadoCivil}).");



