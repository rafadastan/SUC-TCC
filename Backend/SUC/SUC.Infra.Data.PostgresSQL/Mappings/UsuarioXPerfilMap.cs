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
    public class UsuarioXPerfilMap : IEntityTypeConfiguration<UsuarioXPerfil>
    {
        public void Configure(EntityTypeBuilder<UsuarioXPerfil> builder)
        {
            builder.ToTable("usuarioxperfil");

            builder.HasKey(p => p.UsuarioXPerfilId);

            builder.Property(p => p.UsuarioXPerfilId)
                .HasColumnName("UsuarioXPerfilId")
                .IsRequired();

            builder.HasOne(p => p.Usuario)
                .WithMany(p => p.UsuarioXPerfilList)
                .HasForeignKey(p => p.UsuarioId);

            builder.HasOne(p => p.Perfil)
                .WithMany(p => p.UsuarioXPerfilList)
                .HasForeignKey(p=>p.PerfilId);
        }
    }
}
