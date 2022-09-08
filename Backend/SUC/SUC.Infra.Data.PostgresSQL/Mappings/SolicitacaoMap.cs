using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class SolicitacaoMap : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder.ToTable("Solicitacao");

            builder.HasKey(s => s.IdSolicitacao);

            builder.Property(s => s.IdSolicitacao)
                .HasColumnName("IdSolicitacao")
                .IsRequired();

            builder.Property(s => s.NomeSolicitacao)
                .HasColumnName("NomeSolicitacao")
                .HasMaxLength(250);

            builder.Property(s => s.SobreNomeSolicitacao)
                .HasColumnName("SobreNomeSolicitacao")
                .HasMaxLength(250);

            builder.Property(s => s.Status)
                .HasColumnName("Status")
                .IsRequired();

            builder.Property(s => s.TipoServico)
                .HasColumnName("TipoServico")
                .IsRequired();

            builder.Property(s => s.AvaliacaoAtendimento)
                .HasColumnName("AvaliacaoAtendimento")
                .HasMaxLength(250);

            builder.Property(s => s.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(250);

            builder.Property(s => s.EmailSolicitacao)
                .HasMaxLength(250)
                .HasColumnName("EmailSolicitacao");

            #region Relacionamento

            #endregion
        }
    }
}
