using Microsoft.EntityFrameworkCore;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvogadosTop.Mapping
{

    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NomeFantasia)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.RazaoSocial)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.Endereco)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.Cidade)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.Estado)
                .HasColumnType("char(2)");
            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.Data)
                .HasColumnType("date");

            //Relacionamentos
            builder.HasMany(c => c.Funcionarios)
                .WithOne(c => c.Empresa);
            builder.HasMany(x => x.clientePessoaFisicas)
                .WithOne(c => c.Empresa);
            builder.HasMany(x => x.clientePessoaJuridicas)
                .WithOne(c => c.Empresa);

        }
    }
}