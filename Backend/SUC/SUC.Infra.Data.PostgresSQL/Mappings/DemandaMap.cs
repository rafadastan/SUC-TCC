using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class DemandaMap : IEntityTypeConfiguration<Demanda>
    {
        public void Configure(EntityTypeBuilder<Demanda> builder)
        {
            builder.ToTable("Demanda");

            builder.HasKey(d => d.IdDemanda);

            builder.Property(d => d.IdDemanda)
                .HasColumnName("IdDemanda")
                .IsRequired();

            builder.Property(d => d.Protocolo)
                .HasColumnName("Protocolo");

            builder.Property(d => d.Status)
                .HasColumnName("Status")
                .IsRequired();

            builder.Property(d => d.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(250)
                .IsRequired();

            #region Relacionamento

            #endregion
        }
    }
}
