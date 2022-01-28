using System;
using System.Collections.Generic;

namespace AdvogadosTop.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public double Salario { get; set; }
        public Empresa Empresa { get; set; }

        public Funcionario()
        {
            
        }
    }
}
