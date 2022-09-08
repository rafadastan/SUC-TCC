using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class OrgaoMap : IEntityTypeConfiguration<Orgao>
    {
        public void Configure(EntityTypeBuilder<Orgao> builder)
        {
            builder.ToTable("Orgao");

            builder.HasKey(o => o.IdOrgao);

            builder.Property(o => o.IdOrgao)
                .HasColumnName("IdOrgao")
                .IsRequired();

            builder.Property(i => i.NomeOrgao)
                .HasMaxLength(250)
                .HasColumnName("NomeOrgao")
                .IsRequired();

            #region Relacionamento

            #endregion
        }
    }
}
