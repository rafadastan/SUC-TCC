using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Informacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class InformacaoMap : IEntityTypeConfiguration<Informacao>
    {
        public void Configure(EntityTypeBuilder<Informacao> builder)
        {
            builder.ToTable("Informacao");

            builder.HasKey(i => i.IdInformacao);

            builder.Property(i => i.IdInformacao)
                .HasColumnName("IdInformacao")
                .IsRequired();

            builder.Property(i => i.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(250);

            builder.Property(i => i.NomeSolicitacaoInformacao)
                .HasColumnName("NomeSolicitacaoInformacao");

            #region Relacionamento

            #endregion
        }
    }
}
