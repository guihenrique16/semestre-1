//Calculo de idade

var data = DateTime.Now;
Console.WriteLine($"{data}");


Console.WriteLine(@$"
|----------------------|
|---Calculo de idade---|
|----------------------|
");

Console.WriteLine($"Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

int idadeMeses = idade*12;
int idadeDias = idade*365;
int idadeHoras = idadeDias*24;
int idadeMin = idadeHoras*60;

Console.WriteLine($"{idadeMeses} meses, {idadeDias} dias, {idadeHoras} horas e {idadeMin} minutos.");



