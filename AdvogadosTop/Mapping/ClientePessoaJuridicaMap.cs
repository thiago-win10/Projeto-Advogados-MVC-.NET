using Microsoft.EntityFrameworkCore;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvogadosTop.Mapping
{

    public class ClientePessoaJuridicaMap : IEntityTypeConfiguration<ClientePessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<ClientePessoaJuridica> builder)
        {
            builder.ToTable("ClientePessoaJuridica");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NomeEmpresa)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.CNPJ)
                .HasColumnType("varchar(20)");
            builder.HasIndex(x => x.CNPJ)
                .IsUnique(true);
        }
    }
}