using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.DepartamentoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class DepartamentoMap : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamento");

            builder.HasKey(d => d.IdDepartamento);

            builder.Property(d => d.IdDepartamento)
                .HasColumnName("IdDepartamento")
                .IsRequired();

            builder.Property(d => d.NomeDepartamento)
                .HasColumnName("NomeDepartamento")
                .IsRequired();

            #region Relacionamento

            #endregion
        }
    }
}
