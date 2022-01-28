using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvogadosTop.Data;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvogadosTop.Services
{
    public class ClientePessoaFisicaService
    {
        private readonly AdvogadosTopContext _context;
        public ClientePessoaFisicaService(AdvogadosTopContext context)
        {
            _context = context;
        }
        public async Task<List<ClientePessoaFisica>> FindAllAsync()
        {
            return await _context.ClientesPF.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}
