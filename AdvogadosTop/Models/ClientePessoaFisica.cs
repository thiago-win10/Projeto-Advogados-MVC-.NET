
namespace AdvogadosTop.Models
{
    public class ClientePessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public Empresa Empresa { get; set; }

        public ClientePessoaFisica()
        {
           
        }

    }
}
