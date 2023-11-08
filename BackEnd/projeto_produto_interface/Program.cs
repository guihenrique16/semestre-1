using projeto_produto_interface;

//instancia do objeto carrinho
Carrinho carrinho = new Carrinho();

//instanciar objetos da classe Produto
Produto p1 = new Produto(1,"GTA V", 52.90f);
Produto p2 = new Produto(2,"fifa", 120.90f);
Produto p3 = new Produto(3,"forza", 100f);

carrinho.adicionar(p1);
carrinho.adicionar(p2);
carrinho.adicionar(p3);
carrinho.listar();
carrinho.TotalCarrinho();

carrinho.remover(p2);
Console.WriteLine($"após a remocão de itens:");

carrinho.listar();
carrinho.TotalCarrinho();

carrinho.remover(p2);
carrinho.remover(p3);
Console.WriteLine($"após a remocão de itens:");

carrinho.listar();
carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto:");

//criar um objeto com os dados att
Produto _novoProduto = new Produto();
_novoProduto.Nome = "fifa";
_novoProduto.Preco = 300f;

carrinho.atualizar(1,_novoProduto);
carrinho.listar();
carrinho.TotalCarrinho();

