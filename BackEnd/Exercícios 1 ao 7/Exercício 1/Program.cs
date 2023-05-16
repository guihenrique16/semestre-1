
// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

DateTime data = DateTime.Now;
int anoNascimento = 0;
int resultado = 0;

Console.WriteLine($"Informe seu ano de nascimento: ");
anoNascimento = int.Parse(Console.ReadLine()!);

resultado = data.Year - anoNascimento;

if (resultado >= 16)
{
    Console.WriteLine($"Você está apto a votar nas próximas eleições.");
}
else
{
    Console.WriteLine($"Você ainda não atingiu a idade necessária.");
    
}