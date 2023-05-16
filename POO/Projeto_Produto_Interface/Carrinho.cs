using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // criar uma lista para manipular os nossos objetos
        List<Produto> carrinho = new List<Produto>();
        
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Listar()
        {
            if ( carrinho.Count > 0 )
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"
                    Código: {p.Codigo}
                    Nome: {p.Nome}
                    Preço: {p.Preco:C2}
                    ");
                    
                }
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo)!.Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo)!.Preco = _novoProduto.Preco;
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"O total da sua compra é: {Valor:C}");
                
            }
        }
    }
}