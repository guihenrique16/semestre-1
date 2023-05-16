
// instanciar objeto carrinho
using Projeto_Produto_Interface;

Carrinho carrinho = new Carrinho();

// instanciar objetos da classe produto
Produto p1 = new Produto(1, "Video Game", 90.90f);
Produto p2 = new Produto(2, "Camiseta", 50f);
Produto p3 = new Produto(3, "Monza", 1000f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Após a remoção do item");

carrinho.Remover(p2);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"_____________________________");
Console.WriteLine($"Agora vamos att um projeto");

//Criar um objeto com os dados att
Produto _novoProduto = new Produto();
_novoProduto.Nome = "Xbox";
_novoProduto.Preco = 2500f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();
