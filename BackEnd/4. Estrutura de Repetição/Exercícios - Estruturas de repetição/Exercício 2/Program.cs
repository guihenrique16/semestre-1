
Console.WriteLine($"Informe um nome de usuário: ");
string nomeUsuario = Console.ReadLine()!;

Console.WriteLine($"Informe uma senha: ");
string senha = Console.ReadLine()!;

while (senha == nomeUsuario)
{
    Console.WriteLine($"Senha inválida. Por favor digite outra.");
    senha = Console.ReadLine()!;
}


