using Microsoft.EntityFrameworkCore;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvogadosTop.Mapping
{

    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //Enitity Configuration

            builder.ToTable("Funcionario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.SobreNome)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.CPF)
                .HasColumnType("varchar(20)");
            builder.Property(c => c.DataNascimento)
                .HasColumnType("date");
            builder.Property(c => c.Endereco)
                .HasColumnType("varchar(100)");
         
            builder.Property(c => c.Estado)
                .HasColumnType("char(2)");
            
            builder.Property(c => c.Cidade)
                .HasColumnType("varchar(100)");
            
            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)");

            builder.HasIndex(x => x.CPF)
                .IsUnique(true);
            
        }
    }
}