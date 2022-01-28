using Microsoft.EntityFrameworkCore;
using AdvogadosTop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvogadosTop.Mapping
{

    public class ClientePessoaFisicaMap : IEntityTypeConfiguration<ClientePessoaFisica>
    {
        public void Configure(EntityTypeBuilder<ClientePessoaFisica> builder)
        {
            //Entity Configuration

            builder.ToTable("ClientePessoaFisica");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome)
                .HasColumnType("varchar(100)");
            builder.Property(c => c.CPF)
                .HasColumnType("varchar(20)");
            builder.HasIndex(x => x.CPF)
                .IsUnique(true);
                
        }
    }
}