
//Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

//Algoritmo
//Declarar as variaveis
//string nome(nome dos items)
//float preco(preco dos produtos)
//bool promocao(true ou false a promoção)

//2- Fazer um menu com as opções 
//      1 - Cadastrar produto
//      2 - Listar produtos
//      0 - Sair

string[] nomes = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];
string opcoes = "";
string cadastrarMais;
int i = 0;
string promocaoSN;
string sair;

static string MenuOpcoes(string opcao)
{
    Console.WriteLine(@$"
1 - Cadastrar produto
2 - Listar produtos
0 - Sair
");
    opcao = Console.ReadLine()!;
    return opcao;
}


do
{
    opcoes = MenuOpcoes(opcoes);


    switch (opcoes)
    {
        case "1":
            do
            {
                Console.WriteLine($"CADASTRO DE PRODUTOS");
                Console.WriteLine();

                Console.WriteLine($"Infome o nome do produto: ");
                nomes[i] = Console.ReadLine()!;

                Console.WriteLine($"Informe o preço do produto: ");
                preco[i] = float.Parse(Console.ReadLine()!);

                Console.WriteLine($"Esse produto está em promoção? S/N");
                promocaoSN = Console.ReadLine()!.ToUpper();

                while (promocaoSN != "S" && promocaoSN != "N")
                {
                    Console.WriteLine($"Opcão inválida. Por favor, digite novamente.");

                    promocaoSN = Console.ReadLine()!.ToUpper();
                }

                if (promocaoSN == "S")
                {
                    promocao[i] = true;
                }

                Console.WriteLine($"Produto cadastrado com sucesso.");
                Console.WriteLine();

                Console.WriteLine($"Deseja cadastrar mais algo? S/N");
                cadastrarMais = Console.ReadLine()!.ToUpper();

                if (cadastrarMais == "S")
                {
                    i++;
                }

            } while (cadastrarMais == "S");

            break;

        case "2":

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine($"Produto: {nomes[i]}.");
                Console.WriteLine($"Preço: {preco[i]}.");
                if (promocao[i] == true)
                {
                    Console.WriteLine($"O produto está em promocão.");
                }
                else if (promocao[i] == false)
                {
                    Console.WriteLine($"O produto não está em promoção.");
                }
                Console.WriteLine("******************************");
                
            }

            break;

        case "0":

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

} while (opcoes != "0");
