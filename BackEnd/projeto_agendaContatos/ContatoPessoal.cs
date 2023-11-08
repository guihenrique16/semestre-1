
namespace projeto_agendaContatos
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string cpf { get; set; } = "";

        public bool ValidarCPF(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}