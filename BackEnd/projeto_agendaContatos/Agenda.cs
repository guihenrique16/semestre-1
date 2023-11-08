
namespace projeto_agendaContatos
{
    public class Agenda : Contato, IAgenda
    {
        List<Contato> _contatos = new List<Contato>();

        public void adicionar(Contato _contato)
        {
            throw new NotImplementedException();
        }

        public void listar()
        {
            throw new NotImplementedException();
        }
    }
}