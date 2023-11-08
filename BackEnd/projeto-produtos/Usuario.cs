using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
     public class Usuario
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; } = "guilherme@";
        public string Senha { get; set; } = "123";
        public DateTime DataCadastro { get; set; }
        List<Usuario> listuser = new List<Usuario>();

        //metodos
        public Usuario()
        {   
        }
        public Usuario(string email, string nome, string senha, DateTime dataCadastro)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = dataCadastro;
        }

        public void Cadastrar(string novoUsuario)
        {
            Console.WriteLine($"CADASTRO");
            
            Console.WriteLine($"Informe seu nome: ");
            this.Nome = Console.ReadLine()!;
            Console.WriteLine($"Informe seu email: ");
            this.Email = Console.ReadLine()!;
            Console.WriteLine($"Informe sua senha: ");
            this.Senha = Console.ReadLine()!;
            this.DataCadastro = DateTime.Now;

            listuser.Add(new Usuario(Email, Nome, Senha, DataCadastro));
        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }


    }
}
   