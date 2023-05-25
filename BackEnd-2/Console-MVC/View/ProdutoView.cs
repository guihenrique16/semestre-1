using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        // metodo para exibir os dados da lista no console
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
                Console.WriteLine($"************************");
            }
        }

        public Produto cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine($"Informe o Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o Preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }             

        
    }
}