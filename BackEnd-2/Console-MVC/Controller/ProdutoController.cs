using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //
            List<Produto> produtos = produto.Ler();

            //
            produtoView.Listar(produtos);
        }

        public void CaminhoCadastro()
        {
            Produto novoProduto = produtoView.cadastrar();

            produto.Inserir(novoProduto);

        }
    }
}