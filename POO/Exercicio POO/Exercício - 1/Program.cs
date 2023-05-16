
using Exercício___1;

Elevador elevador = new Elevador();

string opcao;
string opcaoSuDe;

do
{
    Console.WriteLine(@$"
    [1] - Entrar
    [2] - Sair

    [0] - Desligar
    ");
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            // do
            // {

            // } while (opcaoSuDe == "3");
            elevador.Entrar();
            Console.WriteLine(@$"
            [1] - Subir
            [2] - Descer
            [3] - Sair


            ");
            opcaoSuDe = Console.ReadLine()!;

            switch (opcaoSuDe)
            {
                case "1":
                    elevador.Subir();
                    break;

                case "2":
                    elevador.Descer();
                    break;
            }
            break;

        case "2":
            elevador.Sair();
            break;
        default:
            break;
    }



} while (opcao != "0");
