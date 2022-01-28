using AdvogadosTop.DTO;
using AdvogadosTop.Models;
using AutoMapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Funcionario, FuncionarioDTO>()
            .ForMember(dest => dest.NomeCompleto,
                map => map.MapFrom(src => $"{src.Nome} {src.SobreNome}"));
        

        CreateMap<Funcionario, FuncionarioDTO>();
    }
}
