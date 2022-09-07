using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class CatalagoMap : IEntityTypeConfiguration<Catalago>
    {
        public void Configure(EntityTypeBuilder<Catalago> builder)
        {
            builder.ToTable("Catalago");

            builder.HasKey(a => a.IdCatalogo);

            builder.Property(a => a.IdCatalogo)
                .HasColumnName("IdCatalago")
                .IsRequired();

            builder.Property(a => a.Image)
                .HasColumnName("Image")
                .HasColumnType("varchar");

            builder.Property(a => a.NomeCatalogo)
                .HasColumnName("NomeCatalago")
                .HasMaxLength(150);

            builder.Property(a => a.Descricao)
                .HasMaxLength(150)
                .HasColumnName("Descricao");

            builder.Property(a => a.Endereco)
                .HasColumnName("Endereco")
                .HasMaxLength(250);

            #region Relacionamento

            #endregion
        }
    }
}
