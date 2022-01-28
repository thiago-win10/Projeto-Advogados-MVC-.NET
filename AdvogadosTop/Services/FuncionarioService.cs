using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvogadosTop.Data;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvogadosTop.Services
{
    public class FuncionarioService
    {
        private readonly AdvogadosTopContext _context;
        public FuncionarioService(AdvogadosTopContext context)
        {
            _context = context;
        }
        public async Task<List<Funcionario>> FindAllAsync()
        {
            return await _context.Funcionario.OrderBy(x => x.Nome).ToListAsync();
        }
       
    }
}
