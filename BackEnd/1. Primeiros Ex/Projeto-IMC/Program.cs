// Programa IMC

//Faça um programa que calcule o imc de uma pessoa recebendo os dados no console, ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(@$"
------------------------------------------
|------Programa para calculo de IMC------|
------------------------------------------
");
Console.ResetColor();

Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine()!);

float imc = peso / ((float)Math.Pow(altura,2)!);


//Concatenação
// Console.WriteLine("O paciente " + nome + " tem o IMC de: " + imc);

//Interpolação
Console.WriteLine($"O paciente {nome} tem o IMC igual: {imc}");


