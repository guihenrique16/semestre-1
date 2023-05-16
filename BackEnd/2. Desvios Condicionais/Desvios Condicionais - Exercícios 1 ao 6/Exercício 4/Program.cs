
Console.WriteLine($"Informe sua senha: ");
int senha = int.Parse(Console.ReadLine()!);

if (senha == 1234)
{
    Console.WriteLine($"Senha correta.");
}
else 
{
    Console.WriteLine($"Senha incorreta. Tente novamente.");  
}