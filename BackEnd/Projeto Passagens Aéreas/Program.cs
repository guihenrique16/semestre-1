// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

//Declaração das variáveis
string senha;
int opcao;
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];
int i = 0;
string SouN;
string sair;

//_______________________________________________________________________________________________________________________________________________//
//Funções 

//Função Opçoes

static void Opcoes()
{
    Console.WriteLine(@$"
1- Cadastrar passagem
2- Listar Passagens
0- Sair
");
}

do
{
    Console.WriteLine($"Informe seu usuário: ");
    Console.ReadLine();

    Console.WriteLine($"Informe sua senha: ");
    senha = Console.ReadLine()!;

} while (senha != "123456");

do
{
    
Opcoes();
opcao = int.Parse(Console.ReadLine()!);

while (opcao != 1 && opcao != 2 && opcao != 0)
{
    Console.WriteLine($"Opção inválida. Por favor, digite novamente!!");
    opcao = int.Parse(Console.ReadLine()!);
}


switch (opcao)
{
    case 1:
        do
        {
                Console.WriteLine();

                Console.WriteLine("CADASTRO DE PASSAGENS");

                Console.WriteLine();

                Console.WriteLine($"Informe o nome: ");
                nome[i] = Console.ReadLine()!;

                Console.WriteLine($"Informe a origem: ");
                origem[i] = Console.ReadLine()!;

                Console.WriteLine($"Informe o destino: ");
                destino[i] = Console.ReadLine()!;

                Console.WriteLine($"Informe a data: ");
                data[i] = Console.ReadLine()!;

                Console.WriteLine($"Cadastrado com sucesso!!");


            Console.WriteLine($"Deseja cadastar mais alguma passagem? S/N");
            SouN = Console.ReadLine()!.ToUpper();

            if(SouN == "S")
            {
                i++;
            }

        } while (SouN == "S");


        break;
    case 2:

        for ( i = 0; i < nome.Length; i++)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Nome: {nome[i]}");
            Console.WriteLine($"Origem: {origem[i]}");
            Console.WriteLine($"Destino: {destino[i]}");
            Console.WriteLine($"Data: {data[i]}");
        }

        break;
    case 0:

        Console.WriteLine($"Quer mesmo sair? S/N");
        sair = Console.ReadLine()!.ToUpper();

        if (sair == "N")
        {

        }
        else
        {
            Environment.Exit(0);
        }


        break;

}
} while (opcao != 0);


