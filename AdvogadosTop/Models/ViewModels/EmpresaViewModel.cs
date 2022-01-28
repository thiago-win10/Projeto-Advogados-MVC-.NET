using System.Collections.Generic;

namespace AdvogadosTop.Models.ViewModels
{
    public class EmpresaViewModel
    {
        public Empresa Empresas { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<ClientePessoaFisica> clientePessoaFisicas { get; set; }
        public ICollection<ClientePessoaJuridica> ClientePessoaJuridicas { get; set; }

    }
}
