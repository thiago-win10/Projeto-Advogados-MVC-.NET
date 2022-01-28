using System;
using System.Collections.Generic;

namespace AdvogadosTop.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Email { get; set; }
        public DateTime Data { get; set; }        
        public List<Funcionario> Funcionarios { get; set; }
        public List<ClientePessoaFisica> clientePessoaFisicas { get; set; }
        public List<ClientePessoaJuridica> clientePessoaJuridicas { get; set; }

        public Empresa()
        {
            Funcionarios = new List<Funcionario>();
            clientePessoaFisicas = new List<ClientePessoaFisica>();
            clientePessoaJuridicas = new List<ClientePessoaJuridica>();
        }
    }
}
