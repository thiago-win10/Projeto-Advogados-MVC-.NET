using AdvogadosTop.Models;
using FluentValidation;

namespace Advocacia.Validators
{
    public class EmpresaValidation : AbstractValidator<Empresa>
    {
        public EmpresaValidation()
        {
            //Fluent Validation

            RuleFor(m => m.NomeFantasia).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.RazaoSocial).NotEmpty().WithMessage("Preencha este campo");
			RuleFor(m => m.CNPJ).NotEmpty().WithMessage("Preencha este campo")
				.Must(IsCnpj).WithMessage("CNPJ inválido");
            RuleFor(m => m.Endereco).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.Cidade).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.Estado).NotEmpty().WithMessage("Preencha este campo");
            RuleFor(m => m.Email).NotEmpty().WithMessage("Preencha este campo");
            
        }
		public static bool IsCnpj(string cnpj)
		{
			int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
				return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for (int i = 0; i < 12; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
		}
	}
}

