
namespace projeto_produto_interface
{
    public interface ICarrinho
    {
        //regras do "contrato" 
        //métodos que deveram ser apenas aqui declarados

        //CRUD: creat, read, update, delete

        //padrao de chamada de metodo
        //Tipo Nome(parametros)

        //create
        void adicionar(Produto _produto);

        //read
        void listar();

        //update
        void atualizar(int _codigo, Produto _produto);

        //delete
        void remover(Produto _produto);
    }
}