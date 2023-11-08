
namespace projeto_produto_interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // criar uma lista para manipulafr os nossos objetivos
        List<Produto> carrinho = new List<Produto>();

        public void adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo)!.Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo)!.Preco = _novoProduto.Preco;
        }

        public void listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"
                 Código: {p.Codigo}
                 nome: {p.Nome}
                 Preço: {p.Preco:C2}
                 
                 ");

                }
            }
        }

        public void remover(Produto _produto)
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
                Console.WriteLine($"total do carrinho é: {Valor:C}");
            }
            else
            {
                Console.WriteLine($"carrinho vazio");

            }
        }     
    }
}