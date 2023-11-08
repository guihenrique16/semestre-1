using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Projeto_loja_virtual
{
    public class CartaoCredito : Cartao
    {
        // Atributos
        private float Limite = 1000;
        public float ValorParcela;
        public double ValorFinal;
        public int Parcelas;

        // Métodos

        // Método para exibir o limite do cartão de crédito
        public void ExibirLimite()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Limite atual do cartão: {Limite.ToString("C", new CultureInfo("pt-br"))}");
            Console.ResetColor();
        }
        public override void Pagar(bool cartaoCardastrado){}
        public override void Pagar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Informe em quantas parcelas deseja pagar o produto: (máximo de 12 parcelas)");
            this.Parcelas = int.Parse(Console.ReadLine()!);

            while (this.Parcelas > 12 || this.Parcelas <= 0)
            {
                Console.WriteLine($"Número de parcelas inválido. Digite entre 1 ou 12 parcelas");
                this.Parcelas = int.Parse(Console.ReadLine()!);
            }

            this.ValorParcela = this.ValorInicial / this.Parcelas;


            do
            {
                if (this.ValorParcela > this.Limite)
                {
                    Console.WriteLine($"\nLimite do cartão excedido");
                    Console.WriteLine($"\nSelecione um número de parcelas pensando em valores que não excedam o limte de seu cartão:");
                    this.Parcelas = int.Parse(Console.ReadLine()!);
                    this.ValorParcela = this.ValorInicial / this.Parcelas;
                    this.ValorFinal = this.ValorParcela;
                }
                else if (this.Parcelas == 1)
                {
                    ValorFinal = this.ValorParcela;

                }
                else if (this.Parcelas <= 6)
                {
                    this.ValorFinal = this.ValorParcela * 1.05d;

                }
                else if(this.Parcelas > 6)
                {
                    this.ValorFinal = this.ValorParcela * 1.08d;

                } else{
                    while (this.Parcelas > 12 || this.Parcelas <= 0)
                    {
                        Console.WriteLine($"Número de parcelas inválido. Digite entre 1 ou 12 parcelas");
                        this.Parcelas = int.Parse(Console.ReadLine()!);
                    }
                }
            } while (this.ValorFinal > this.Limite);


            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();

            if (this.Parcelas > 1)
            {
                Console.WriteLine($"\nTotal: {Math.Round(ValorFinal, 2).ToString("C", new CultureInfo("pt-br"))} de {this.Parcelas}x com juros.");
            }
            else
            {
                Console.WriteLine($"\nTotal: {Math.Round(ValorFinal, 2).ToString("C", new CultureInfo("pt-br"))} de {this.Parcelas}x sem juros.");
            }

            Console.ResetColor();
        }
    }
}
