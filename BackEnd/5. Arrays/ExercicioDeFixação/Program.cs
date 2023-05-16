
string[]nome = new string[5];
int[]idade = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nome[i] = Console.ReadLine()!;

    Console.WriteLine($"Informe a {i + 1}º idade: ");
    idade[i] = int.Parse(Console.ReadLine()!);   
}

for (var i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n{i+1}) Nome: {nome[i]}");
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" idade: {idade[i]} anos");
    

}