using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(a => a.IdAgenda);

            builder.Property(a => a.IdAgenda)
                .HasColumnName("IdAgenda")
                .IsRequired();

            builder.Property(a => a.Local)
                .HasColumnName("Local");

            builder.Property(a => a.Titulo)
                .HasColumnName("Titulo");

            builder.Property(a => a.DataAgenda)
                .HasColumnType("Date")
                .HasColumnName("DataAgenda");

            builder.Property(a => a.Descricao)
                .HasColumnName("Descricao");
            
            #region Relacionamento

            #endregion
        }
    }
}
