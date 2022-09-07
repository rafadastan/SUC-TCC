using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class ChamadoMap : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("Chamado");

            builder.HasKey(c => c.IdChamado);

            builder.Property(c => c.IdChamado)
                .HasColumnName("IdChamado")
                .IsRequired();

            builder.Property(c => c.Status)
                .HasColumnName("Status");

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao");

            #region Relacionamento

            #endregion
        }
    }
}
