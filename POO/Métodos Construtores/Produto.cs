using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Métodos_Construtores
{
    public class Produto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        
        public Produto(string Email, string Senha, string Cpf)
        {
            
        }
    }
}