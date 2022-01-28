using AdvogadosTop.Models;
using FluentValidation;
using System;

namespace Advocacia.Validators
{
    public class FuncionarioValidation : AbstractValidator<Funcionario>
    {
        public FuncionarioValidation()
        {
            RuleFor(m => m.Nome).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.SobreNome).NotEmpty().WithMessage("Preecnha este campo");
            RuleFor(m => m.CPF).NotNull().NotEmpty().WithMessage("Preencha seu CPF").
                Must(IsCpf).WithMessage("CPF inválido");
            RuleFor(m => m.Endereco).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.Cidade).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.Estado).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.Email).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.DataNascimento).LessThan(DateTime.Now.Date).WithMessage("Data incorreta");

        }
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

    }
}

