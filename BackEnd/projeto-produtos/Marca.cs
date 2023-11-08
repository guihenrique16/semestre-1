using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
     public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> listMarca = new List<Marca>();

        public Marca()
        {
            
        }
        public Marca(string nomeMarca)
        {
            NomeMarca = nomeMarca;
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Informe uma marca: ");
            this.NomeMarca = Console.ReadLine()!;
            Console.WriteLine($"Informe o código da marca: ");
            this.Codigo = int.Parse(Console.ReadLine()!);
            
            listMarca.Add(new(NomeMarca));
        }
        public void Listar()
        {
            foreach (var m in listMarca)
            {
                Console.WriteLine(@$"
                ++++++++++++++++++++++++++
                - Marca: {m.NomeMarca}
                - codigo: {m.Codigo}
                - {m.DataCadastro}
                ++++++++++++++++++++++++++
                
                ");

            }
        }
        public void Remover()
        {
            Marca m = listMarca.Find(x => x.NomeMarca == NomeMarca)!;
            listMarca.Remove(m);

            Console.WriteLine($"Marca removida com sucesso.");
            
        }
        
    }
}
   