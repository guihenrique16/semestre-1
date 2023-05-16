// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variáveis

// Declarando variáveis
// Nome = Valor
// string nome = "Pedro Felix";
// nome = "Enzo";

// Console.WriteLine(nome);


// int idade = 18;

// Console.WriteLine(idade);

// Console.WriteLine("A idade do " + nome + " é " + idade + " anos");


// Tipo de dados 

// int quantidade = 10;
// double preco = 4.99D;
// float alturan= 1.80f;
// bool careca = true;
// string texto = "Olá, mundo";
// char letra = 'C';




// Crie um programa para calcular o imc de uma pessoa

// entradas
string nome = "Pedro";
float peso = 89.9f;
float altura = 1.80f;

// processamento
float imc = peso / (altura * altura);

Console.WriteLine($"O IMC do " + nome + " é de :" + Math.Round(imc,2));


