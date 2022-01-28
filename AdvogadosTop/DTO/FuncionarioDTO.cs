using System.ComponentModel.DataAnnotations;

namespace AdvogadosTop.DTO
{
    public class FuncionarioDTO
    {
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

    }

}
