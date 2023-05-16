// - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

char combustivel;
double litros = 0;
double preco = 0;

Console.WriteLine($"Informe qual combustível você quer: (a)Álcool (g)Gasolina");
combustivel = char.Parse(Console.ReadLine()!.ToLower());

while ((combustivel != 'a') && (combustivel != 'g'))
{   
    Console.WriteLine($"Opção inválida. Informe o combustível que deseja: (a)Álcool (g)Gasolina");
    
    combustivel = char.Parse(Console.ReadLine()!.ToLower());
}

Console.WriteLine($"Informe quantos litros de combutível você comprou: ");
litros = double.Parse(Console.ReadLine()!);

    switch (combustivel)
{
    case 'a':
    preco = litros * 4.90f;

    if (litros <= 20)
    {
        preco = preco - (preco * 0.03);
        Console.WriteLine($"Você ganhou um desconto de 3%, e vai pagar: {Math.Round(preco,2)}");
    }
    else
    {
        preco = preco - (preco * 0.05);
        Console.WriteLine($"Você ganhou um desconto de 5%, e vai pagar: {Math.Round(preco,2)}");
    }
        break;
    
    case 'g':
    preco = litros * 5.30f;

    if (litros <= 20)
    {
        preco = preco - (preco * 0.04);
        Console.WriteLine($"Você ganhou um desconto de 4%, e vai pagar: {Math.Round(preco,2)}");
    }
    else
    {
        preco = preco - (preco * 0.06);
        Console.WriteLine($"Você ganhou um desconto de 6%, e vai pagar: {Math.Round(preco,2)}");
    }
        break;
    
    default:
        break;
}


