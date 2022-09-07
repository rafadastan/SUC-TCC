using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class AtendimentoMap : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.ToTable("Atendimento");

            builder.HasKey(a => a.IdAtendimento);

            builder.Property(a => a.IdAtendimento)
                .HasColumnName("IdAtendimento")
                .IsRequired();

            builder.Property(a => a.NomeAtendimento)
                .HasColumnType("varchar")
                .HasColumnName("NomeAtendimento")
                .IsRequired();

            builder.Property(a => a.Status)
                .HasColumnName("Status");

            builder.Property(a => a.TipoServico)
                .HasColumnName("TipoServico");

            builder.Property(a => a.Descricao)
                .HasColumnName("Descricao");

            #region Mapeamento

            #endregion
        }
    }
}
