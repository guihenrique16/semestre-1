using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public interface ICarrinho
    {
        // Regras do "contrato"
        // Métodos que deverão aqui ser declarado apenas

        // CRUD : Create, read, Update, Delete

        // Padrão de chamada de métodos
        // tipo Nome(parametros)

        // Create
        void Adicionar(Produto _produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int _codigo, Produto _produto);

        // Delete
        void Remover(Produto _produto);

    }
}