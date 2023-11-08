using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        Marca marca = new Marca();
        public Usuario CadastroPor { get; set; }

        List<Produto> listProdutos = new List<Produto>();

        //metodos
        public Produto()
        {
        }
        public Produto(int codigo, string nomeProduto, float preco, string marca, DateTime dataCadastro)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            DataCadastro = dataCadastro;
            this.marca.NomeMarca = marca;
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Informe o produto: ");
            this.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o preço: ");
            this.Preco = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe a marca: ");
            marca.NomeMarca = Console.ReadLine()!;

            Console.WriteLine($"Informe o código: ");
            this.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Produto cadastrado!!");
            
            listProdutos.Add(new(Codigo, NomeProduto, Preco, marca.NomeMarca, DataCadastro));

        }
        public void Listar()
        {
            foreach (var p in listProdutos)
            {   
                Console.WriteLine(@$"
                ++++++++++++++++++++++++++++++++
                - Produto: {p.NomeProduto}  
                - Preço: {p.Preco : C2}        
                - Marca: {p.marca.NomeMarca}
                - Código: {p.Codigo}
                - {p.DataCadastro}
                ++++++++++++++++++++++++++++++++
                ");
            }
        }
        public void Deletar(int _codigo)
        {
            Produto p = listProdutos.Find(x => x.Codigo == Codigo)!;
            listProdutos.Remove(p);

            Console.WriteLine($"Produto removido com sucesso.");
        }
    }
}
    