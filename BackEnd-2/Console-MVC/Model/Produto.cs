
namespace Console_MVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //Caminho da pasta e do arquivo CSV
        private const string PATH/* PATH = caminho */ = "Database/Produto.csv";

        public Produto()
        {
            /* Criar logica para gerar pasta e o arquivo */
            //----------------------------------------------------------------------           
            // Obter o caminho da pasta
            string Pasta = PATH.Split("/")[0];
            //-----------------------------------------------------------------------
            // Verificar se no caminho ja existe pasta
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
            //------------------------------------------------------------------------
            // Verificar se no caminho ja existe pasta 
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        // Metodo para ler os dados do arquivo CSV
        public List<Produto> Ler()
        {
            // instancia da lista de produtos
            List<Produto> produtos = new List<Produto>();

            // Array de strings armazenando todas as linhas do CSV
            string[] Linhas = File.ReadAllLines(PATH);

            // leitura das linhas
            foreach (var item in Linhas)
            {
                // separaçao de atributos de cada linha
                string[] atributos = item.Split(";");

                // instancia de produto
                Produto p = new Produto();

                // atribuiçao de valores dentro do objeto
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = (atributos[1]);
                p.Preco = float.Parse(atributos[2]);

                // adicioma objeto dentro da lista
                produtos.Add(p);
            }

            // adicioma objeto dentro da lista
            return produtos;
        }
        //
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        //
        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }

    }  
}