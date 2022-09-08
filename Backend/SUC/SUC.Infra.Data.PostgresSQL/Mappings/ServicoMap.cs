using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");

            builder.HasKey(s => s.IdServico);

            builder.Property(s => s.IdServico)
                .HasColumnName("IdServico")
                .IsRequired();

            builder.Property(s => s.Ativo)
                .HasColumnName("Ativo")
                ;

            builder.Property(s => s.NomeServico)
                .HasColumnName("NomeServico")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(s => s.TipoServico)
                .HasColumnName("TipoServico");

            #region Relacionamento

            #endregion
        }
    }
}
