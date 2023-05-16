using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListContatos
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }
    }
}