using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Projeto_Gamer_MVC.Models
{
    public class Equipes
    {
        [Key]
        public int IdEquipes { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public ICollection<Jogador> Jogador {get;set;}
        
        
        
        
        
        
    }
}