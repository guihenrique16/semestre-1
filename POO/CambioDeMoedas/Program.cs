using System.Globalization;
using CambioDeMoedas;

string opcao;
float valor;

do
{
    Console.WriteLine(@$"
CÂMBIO DE MOEDAS
Digite a opção desejada:
[1] - Real para Dólar
[2] - Dólar para Real
[0] - Sair
");
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Digite o valor: ");
            valor = float.Parse(Console.ReadLine()!);
            valor = Conversao.RealToDolar(valor);
            Console.WriteLine($"Esse valor em dólar é:{valor.ToString("C", new CultureInfo("en-US"))}");
            break;
        case "2":
            Console.WriteLine($"Digite o valor: ");
            valor = float.Parse(Console.ReadLine()!);
            valor = Conversao.DolarToReal(valor);
            Console.WriteLine($"Esse valor em real é: {valor:C2}");
            break;
            ;
    }

} while (opcao != "0");


