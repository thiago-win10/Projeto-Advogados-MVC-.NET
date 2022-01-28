using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvogadosTop.Data;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvogadosTop.Services
{
    public class ClientePessoaJuridicaService
    {
        private readonly AdvogadosTopContext _context;
        public ClientePessoaJuridicaService(AdvogadosTopContext context)
        {
            _context = context;
        }
        public async Task<List<ClientePessoaJuridica>> FindAllAsync()
        {
            return await _context.ClientesPJ.OrderBy(x => x.NomeEmpresa).ToListAsync();
        }

    }
}
