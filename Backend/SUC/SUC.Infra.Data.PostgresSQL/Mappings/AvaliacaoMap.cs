using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");

            builder.HasKey(a => a.IdAvaliacao);

            builder.Property(a => a.IdAvaliacao)
                .HasColumnName("IdAvaliacao")
                .IsRequired();

            builder.Property(a => a.NumeroAvalicao)
                .HasColumnName("NumeroAvaliacao")
                .HasMaxLength(100);

            builder.Property(a => a.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(150);

            #region Relacionamento

            #endregion
        }
    }
}
