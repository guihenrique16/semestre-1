using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class Debito : Cartao
    {
        MenuClass menuCartao = new MenuClass();
        public float Saldo {get; private set;} = 2000;


        
        public override void Pagar(){}
        public override void Pagar(bool cartaoCardastrado)
        {
            if (Saldo < ValorInicial)
            {
                Console.WriteLine($"\nSaldo insuficiente para a compra.");
                Cancelar();
                menuCartao.MenuInicial(this.ValorInicial, cartaoCardastrado);
            }
            else
            {
                this.ValorFinal = this.ValorInicial;
                Console.WriteLine($"\nO valor da compra a ser pago será de: {this.ValorFinal:C2} e será debitado em sua conta corrente.");
                Saldo = Saldo - ValorFinal;
            }

        }
    }
}