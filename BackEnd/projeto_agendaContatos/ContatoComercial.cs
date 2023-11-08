
namespace projeto_agendaContatos
{
    public class ContatoComercial : Contato, IcontatoComercial
    {
        public string cnpj { get; set; } = "";

        public bool ValidarCNPJ(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}