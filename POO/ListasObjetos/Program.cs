// Crie uma classe Produto
// Propriedades: int Codigo, string Nome, float Preco
// Crie um construtor vazio
// Crie um contrutor completo

using ListasObjetos;

// Criar a lista de objetos
List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(28288, "Fiat Uno", 19.90f)
);

produtos.Add(
    new Produto(90099, "Chovrolet Monza", 25.50f)
);

Produto carroDeMalandro = new Produto(9876, "Dodge Ram", 200f);
produtos.Add(carroDeMalandro);


// Mostrar tudo que está na List<>

foreach (var item in produtos)
{
    Console.WriteLine($"Código {item.Codigo}, Nome e marca {item.Nome}, Preço {item.Preco:C2}, Indice {produtos.IndexOf(item)}");
}


// Procurar objeto na lista
Produto produtoBuscado = produtos.Find(x => x.Codigo == 90099)!;

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 80f;

produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado);

Console.WriteLine($"\nLista Atualizada");
Console.WriteLine($"__________________");

foreach (var item in produtos)
{
    Console.WriteLine($"Código {item.Codigo}, Nome e marca {item.Nome}, Preço {item.Preco:C2}, Indice {produtos.IndexOf(item)}");
}
