
// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

using cadastro_de_aluno;
using System.Globalization;


Aluno aluno = new Aluno();
string opcao;

//Cadastro do aluno--------------------------------------------------
Console.WriteLine($"Informe seu nome: ");
aluno.nome = Console.ReadLine()!;

Console.WriteLine($"Informe seu curso: ");
aluno.curso = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade: ");
aluno.idade = Console.ReadLine()!;

Console.WriteLine($"Informe seu RG: ");
aluno.rg = Console.ReadLine()!;

Console.WriteLine($"Informe caso seja bolsista: s/n");
string bolsa = Console.ReadLine()!.ToLower();
while (bolsa != "s" && bolsa != "n")
{
    Console.WriteLine($"Opção inválida. Por favor digite novamente: ");
    bolsa = Console.ReadLine()!.ToLower();
}

Console.WriteLine($"Informe sua média final: ");
aluno.mediaFinal = float.Parse(Console.ReadLine()!);
while (aluno.mediaFinal < 0 && aluno.mediaFinal > 10)
{
    Console.WriteLine($"Média incorreta. Por favor, digite novamente: ");
    aluno.mediaFinal = float.Parse(Console.ReadLine()!);
}


Console.WriteLine($"Informe sua mensalidade: ");
aluno.valorMensalidade = float.Parse(Console.ReadLine()!);
//Cadastro do aluno--------------------------------------------------

do
{
    Console.WriteLine(@$"
    O que deseja
    (1) Ver média 
    (2) ver mensalidade
    (0) Sair
    ");
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"A média é: {aluno.VerMediaFinal}");

            break;

        case "2":
            if (bolsa == "s")
            {
                float valorMensalidadeFinal = aluno.VerMensalidade(aluno.mediaFinal);
                if (aluno.mediaFinal >= 8)
                {
                    Console.WriteLine($"Você ganhou desconto de 50%, sua mensalidade é: {valorMensalidadeFinal.ToString("C", new CultureInfo("pt-br"))}");
                }
                else if (aluno.mediaFinal >= 6 && aluno.mediaFinal < 8)
                {
                    Console.WriteLine($"Você ganhou desconto de 30%, sua mensalidade é: {valorMensalidadeFinal.ToString("C", new CultureInfo("pt-br"))}");
                }
                else
                {
                    Console.WriteLine($"Sua nota não foi suficiente para a bolsa.");
                    
                }
            }
            else
            {
                Console.WriteLine($"O valor da mensalidade é: {aluno.valorMensalidade.ToString("C", new CultureInfo("pt-br"))}");
            }
            break;
        default:
            break;
    }


} while (opcao != "0");












