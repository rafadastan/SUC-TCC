using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //nome da tabela
            builder.ToTable("endereco");

            builder.Ignore(e => e.Usuario);

            //chave primária
            builder.HasKey(u => u.IdEndereco);

            //mapeamento dos campos
            builder.Property(u => u.IdEndereco)
                .HasColumnName("IdEndereco")
                .IsRequired();

            builder.Property(u => u.Cidade)
                .HasColumnName("Cidade")
                .IsRequired();

            builder.Property(u => u.Estado)
                .HasColumnName("Estado")
                .IsRequired();

            builder.Property(u => u.Bairro)
                .HasColumnName("Bairro")
                .IsRequired();

            builder.Property(u => u.CEP)
                .HasColumnName("CEP")
                .IsRequired();

            builder.Property(u => u.EnderecoNome)
                .HasColumnName("EnderecoNome")
                .IsRequired();

            builder.Property(u => u.CreatorUserId)
                .HasColumnName("CreatorUserId");

            builder.Property(u => u.CreationDate)
                .HasColumnName("CreationDate");

            builder.Property(u => u.LastModificationDate)
                .HasColumnName("LastModificationDate");

            builder.Property(u => u.LastModifierUserId)
                .HasColumnName("LastModifierUserId");
        }
    }
}
