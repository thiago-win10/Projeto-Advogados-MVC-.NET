using AdvogadosTop.DTO;
using AdvogadosTop.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AdvogadosTop.Services;
using System.Threading.Tasks;

namespace AdvogadosTop.Controllers
{
    public class FuncionariosController : Controller
    {
        //private readonly IMapper _mapper;
        private readonly FuncionarioService _funcionarioService;

        public FuncionariosController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
        
        public async Task<IActionResult> Index()
        {
            var list = await _funcionarioService.FindAllAsync();
            return View(list);
        }
        //public FuncionariosController(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}
        //[HttpGet]
        //public IActionResult Get(Funcionario funcionario)
        //{
        //    var funcDTO = _mapper.Map<FuncionarioDTO>(funcionario);
        //    return Ok(funcDTO);
        //}
    }
}
