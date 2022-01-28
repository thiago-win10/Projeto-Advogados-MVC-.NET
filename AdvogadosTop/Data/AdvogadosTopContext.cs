using Microsoft.EntityFrameworkCore;
using AdvogadosTop.Models;
using AdvogadosTop.Mapping;

namespace AdvogadosTop.Data
{
    public class AdvogadosTopContext : DbContext
    {
        public AdvogadosTopContext(DbContextOptions<AdvogadosTopContext> options)
            : base(options)
        {
        }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<ClientePessoaFisica> ClientesPF { get; set; }
        public DbSet<ClientePessoaJuridica> ClientesPJ { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity Configuration
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new ClientePessoaFisicaMap());
            modelBuilder.ApplyConfiguration(new ClientePessoaJuridicaMap());

        }


    }
}
