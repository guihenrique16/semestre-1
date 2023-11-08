
using System.Globalization;

namespace Projeto_loja_virtual
{
    public class MenuClass
    {
        public void MenuInicial(float valorInformado, bool cartaoCardastrado) {
            string resposta = "";
            string input = "";
            bool sair = false;
            // INICIO


            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"            === Bem-vindo ===");
            Console.ResetColor();
            Console.WriteLine($"\nValor da compra: {valorInformado.ToString("C", new CultureInfo("pt-br"))}\n");
            Thread.Sleep(1000);

            do {
                Console.WriteLine(@$"Escolha a forma de pagamento da compra:
                
            [1] Boleto
            [2] Cartão 
            [3] Sair");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ResetColor();

            resposta = Console.ReadLine()!;
            switch(resposta){

                case"1":
                Console.WriteLine($"\nValor da compra: {valorInformado}");
                Boleto pagamentoBoleto = new Boleto();
                Console.Clear();
                //Boleto
                
                do {
                    pagamentoBoleto.ValorInicial = valorInformado;
                    pagamentoBoleto.Registrar();
                    Console.WriteLine(@$"
            [1] Finalizar compra
            [2] Cancelar Operação
                    ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Insira a opção desejado:");
                    Console.ResetColor();
                    input = Console.ReadLine()!;
                    switch(input) {
                        case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nCompra Finalizada... Seu boleto vence no dia {pagamentoBoleto.GerarData()}");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;

                        case"2":
                        pagamentoBoleto.Cancelar();
                        MenuInicial(valorInformado, cartaoCardastrado);
                        Console.Clear();
                        break;

                        default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine($"Opção selecionada inválida");
                        Console.ReadLine();
                        
                        Console.ResetColor();       
                        break;
                    }
                    
                } while(input != "2");
                break;
                case"2":
                Console.Clear();
                
                MenuCartao(valorInformado, cartaoCardastrado);
                
                break;
                case"3":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nSair do programa? S/N\n");
                Console.ResetColor();
                resposta = Console.ReadLine()!.ToUpper();
                if (resposta == "S") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Finalizando o programa...");
                Thread.Sleep(3000);
                Console.ResetColor();
                    sair = true;
                    Environment.Exit(0);
                }
                else {
                    sair = false;
                    Console.Clear();
                }
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine($"Valor inválido, tente novamente...");
                Console.ResetColor();
                break;
            }
            } while (!sair);
            
            // FIM
        }

        public void MenuCartao(float valorInformado,bool cartaoCardastrado) {
            string resposta = "";
            string cadastroCartao = "";
            string outroCartao = "";
            string input = "";
            string bandeira = "";
            string numeroCartao = "";
            string titular = "";
            string cvv = "";
            Debito pagamentoDebito = new Debito();
            pagamentoDebito.ValorInicial = valorInformado;
            CartaoCredito pagamentoCredito = new CartaoCredito();
            pagamentoCredito.ValorInicial = valorInformado;

            do {
                if(cartaoCardastrado == false){
                            Console.WriteLine($"\nCadastro do cartão");
                
                            Console.WriteLine($"\nQual a bandeira do cartão:");
                            bandeira = Console.ReadLine()!;

                            while(bandeira == ""){
                                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para a bandeira do cartão:");
                                bandeira = Console.ReadLine()!;
                            }

                            Console.WriteLine($"\nQual o número do cartão:");
                            numeroCartao = Console.ReadLine()!;

                            while(numeroCartao == ""){
                                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o número do cartão:");
                                numeroCartao = Console.ReadLine()!;
                            }

                            Console.WriteLine($"\nQual o titular do cartão:");
                            titular = Console.ReadLine()!;

                            while(titular == ""){
                                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o titular do cartão:");
                                titular = Console.ReadLine()!;
                            }

                            Console.WriteLine($"\nQual o cvv do cartão:");
                            cvv = Console.ReadLine()!;

                            while(cvv == ""){
                                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o cvv do cartão:");
                                cvv = Console.ReadLine()!;
                            }

                            Console.WriteLine(pagamentoDebito.SalvarCartao(bandeira, numeroCartao, titular, cvv));
                            cartaoCardastrado = true;
                        }
                Console.Clear();
                Console.WriteLine($"\nValor da compra: {valorInformado.ToString("C", new CultureInfo("pt-br"))}\n");
                Console.WriteLine(@$"Escolha dentre as opções abaixo:

                [1] Pagar com o Cartão de Débito
                [2] Pagar com o Cartão de Crétido
                [3] Voltar ao Menu de Cartão
                ");
                resposta = Console.ReadLine()!;
                switch(resposta) {
                    case"1":
                        if(cartaoCardastrado){
                            pagamentoDebito.Pagar(cartaoCardastrado);
                                do {
                                Console.WriteLine(@$"
                                [1] Finalizar compra
                                [2] Cancelar Operação
                                ");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine($"Insira a opção desejado:");
                                    Console.ResetColor();
                                    input = Console.ReadLine()!;
                                    switch(input) {
                                        case "1":
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"\nCompra Finalizada...");
                                        Console.ResetColor();
                                        Thread.Sleep(3000);
                                        // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                                        Environment.Exit(0);
                                        break;
                                        case"2":
                                        pagamentoDebito.Cancelar();
                                        Console.Clear();
                                        MenuInicial(valorInformado, cartaoCardastrado);
                                        break;

                                        default:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine($"Valor inválido, tente novamente...");
                                        Console.ResetColor();
                                        break;
                                    }
                                    
                            } while(input != "2");
                        } else{
                            Console.WriteLine($"Não há um cartão de débito cadastrado. Pressione ENTER para voltar ao menu de cadastro:");
                            Console.ReadLine();
                            MenuCartao(valorInformado, cartaoCardastrado);
                        }

                    break;

                    case"2":

                    //Cartão de Crédito
                    if(cartaoCardastrado){
                        pagamentoCredito.Pagar();
                        do {
                        Console.WriteLine(@$"
                        [1] Finalizar compra
                        [2] Cancelar Operação
                        ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"Insira a opção desejado:");
                            Console.ResetColor();
                            input = Console.ReadLine()!;
                            switch(input) {
                                case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nCompra Finalizada...");
                                Thread.Sleep(3000);
                                Console.ResetColor();

                                // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                                Environment.Exit(0);
                                break;
                                case"2":
                                pagamentoCredito.Cancelar();
                                Console.Clear();
                                MenuInicial(valorInformado, cartaoCardastrado);
                                break;
                                default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine($"Valor inválido, tente novamente...");
                                Console.ResetColor();
                                break;
                            }
                            
                    } while(input != "2");
                    }else{
                        Console.WriteLine($"Não há um cartão de crédito cadastrado. Pressione ENTER para voltar ao menu de cartão:");
                        Console.ReadLine();
                        MenuCartao(valorInformado, cartaoCardastrado);
                    }

                    break;

                    case"3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Cancelando a operação");
                    Console.WriteLine($"Pressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.ResetColor();
                    break;

                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"Valor inválido, tente novamente...");
                    Console.ResetColor();
                    break;
                } 
            } while (resposta != "3");
            
        }
    }
}