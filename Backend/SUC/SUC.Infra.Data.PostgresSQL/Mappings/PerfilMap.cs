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
            builder.ToTable("Perfil");

            //chave primária
            builder.HasKey(u => u.Id);

            //mapeamento dos campos
            builder.Property(u => u.Id)
                .HasColumnName("Id");

            builder.Property(u => u.PerfilUsuario)
                .HasColumnName("PerfilUsuario")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(f => f.IdUsuario)
                .HasColumnName("UsuarioId")
                .IsRequired();

            #region Relacionamentos

            builder.HasOne(f => f.Usuario)
                .WithMany(e => e.Perfis)
                .HasForeignKey(f => f.IdUsuario);

            #endregion
        }
    }
}
