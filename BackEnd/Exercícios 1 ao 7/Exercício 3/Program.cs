// - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

string nome;
int quantidade = 0;
float preco = 0;
float valor = 0;
float valorDesconto = 0;

Console.WriteLine($"Informe o produto que você adquiriu: ");
nome = Console.ReadLine()!;

Console.WriteLine($"Informe a quantidade: ");
quantidade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o preço de cada produto: ");
preco = float.Parse(Console.ReadLine()!);

valor = preco * quantidade;

if (quantidade <= 5)
{
    valorDesconto = valor * 0.98f;
    Console.WriteLine(@$"
    Produto comprado: {nome}
    Quantidade: {quantidade}
    ");
    Console.WriteLine($"O valor sem desconto é {Math.Round(valor,2)}, com o desconto fica por {Math.Round(valorDesconto,2)}.");
    
}
else if ((quantidade > 5) && (quantidade <= 10))
{
    valorDesconto = valor * 0.97f;
    Console.WriteLine(@$"
    Produto comprado: {nome}
    Quantidade: {quantidade}
    ");
    Console.WriteLine($"O valor sem desconto é {Math.Round(valor,2)}, com o desconto fica por {Math.Round(valorDesconto,2)}.");
    
}
else
{
    valorDesconto = valor * 0.95f;
    Console.WriteLine(@$"
    Produto comprado: {nome}
    Quantidade: {quantidade}
    ");
    Console.WriteLine($"O valor sem desconto é {Math.Round(valor,2)}, com o desconto fica por {Math.Round(valorDesconto,2)}.");
}

