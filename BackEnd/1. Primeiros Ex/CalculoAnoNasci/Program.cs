// Calculo do dia de nascimento

var data = DateTime.Now;
Console.WriteLine($"{data}");


Console.WriteLine($"Digite o ano do seu nascimento");
int Ano = int.Parse(Console.ReadLine()!);


int calcIdade = data.Year-Ano;
int calcSem = calcIdade*52;

Console.WriteLine(@$"{calcIdade} anos e {calcSem} semanas.");


