
using cadastro_aluno_correcao;

Aluno novoAluno = new Aluno();

Console.WriteLine($"Informe o  do aluno: ");
novoAluno.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe o curso do aluno: ");
novoAluno.Curso = Console.ReadLine()!;

Console.WriteLine($"Informe a idade do aluno: ");
novoAluno.Idade = Console.ReadLine()!;

Console.WriteLine($"Informe o RG do aluno: ");
novoAluno.Rg = Console.ReadLine()!;

Console.WriteLine($"Informe a média final do aluno: ");
novoAluno.MediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o valor da mensalidade: ");
novoAluno.ValorMensalidade = float.Parse(Console.ReadLine()!);

Console.WriteLine($"O aluno é bolsista? s/n: ");
string resposta = Console.ReadLine()!;

novoAluno.Bolsista = resposta == "s" ? true : false;

 
