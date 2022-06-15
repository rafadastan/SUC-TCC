using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            //nome da tabela
            builder.ToTable("contato");

            //chave primária
            builder.HasKey(u => u.IdContato);

            //mapeamento dos campos
            builder.Property(u => u.IdContato)
                .HasColumnName("IdContato")
                .IsRequired();

            builder.Property(u => u.Numero)
                .HasColumnName("Numero")
                .IsRequired();

            builder.Property(u => u.DDDNumero)
                .HasColumnName("DDDNumero");

            builder.Property(u => u.CreationDate)
                .HasColumnName("CreationDate");

            builder.Property(u => u.CreatorUserId)
                .HasColumnName("CreatorUserId");

            builder.Property(u => u.LastModificationDate)
                .HasColumnName("LastModificationDate");

            builder.Property(u => u.LastModifierUserId)
                .HasColumnName("LastModifierUserId");
        }
    }
}
