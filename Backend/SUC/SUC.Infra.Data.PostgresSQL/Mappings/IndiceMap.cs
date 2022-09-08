using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class IndiceMap : IEntityTypeConfiguration<Indice>
    {
        public void Configure(EntityTypeBuilder<Indice> builder)
        {
            builder.ToTable("Indice");

            builder.HasKey(i => i.IdIndice);

            builder.Property(i => i.IdIndice)
                .HasColumnName("IdIndice")
                .IsRequired();

            builder.Property(i => i.Media)
                .HasColumnName("Media")
                ;

            builder.Property(i => i.Percentual)
                .HasColumnName("Percentual");

            #region Relacionamento

            #endregion
        }
    }
}
