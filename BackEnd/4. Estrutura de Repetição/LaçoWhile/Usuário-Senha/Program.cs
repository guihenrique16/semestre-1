
Console.WriteLine($"Informe um nome de usuário: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Informe uma senha: ");
string senha = Console.ReadLine()!;

while (senha.Length != 6)
{
    Console.WriteLine($"Informe a senha novamente, deve haver mais que 6 caracteres.");

    Console.WriteLine($"Informe uma senha: ");
    senha = Console.ReadLine()!;
}

Console.WriteLine($"Usuário e senha recebido com sucesso.");

