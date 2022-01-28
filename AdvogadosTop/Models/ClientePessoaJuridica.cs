
namespace AdvogadosTop.Models
{
    public class ClientePessoaJuridica
    {
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public Empresa Empresa { get; set; }

        public ClientePessoaJuridica()
        {

        }
    }
}
