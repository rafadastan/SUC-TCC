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
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            //nome da tabela
            builder.ToTable("perfil");

            //chave primária
            builder.HasKey(u => u.IdPerfil);

            //mapeamento dos campos
            builder.Property(u => u.IdPerfil)
                .HasColumnName("Id");

            builder.Property(u => u.PerfilUsuario)
                .HasColumnName("PerfilUsuario")
                .HasMaxLength(150);

            builder.Property(u => u.Description)
                .HasColumnName("Descricao")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Active)
                .HasColumnName("Ativo")
                .IsRequired();
        }
    }
}
