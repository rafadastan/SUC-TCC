using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //nome da tabela
            builder.ToTable("usuario");

            //chave primária
            builder.HasKey(u => u.IdUsuario);

            //mapeamento dos campos
            builder.Property(u => u.IdUsuario)
                .HasColumnName("IdUsuario")
                .IsRequired();

            builder.Property(u => u.IdPerfil)
                .HasColumnName("IdPerfil")
                .IsRequired();

            builder.Property(u => u.IdContato)
                .HasColumnName("IdContato");

            builder.Property(u => u.IdEndereco)
                .HasColumnName("IdEndereco");

            builder.Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Sobrenome)
                .HasColumnName("Sobrenome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.Created)
                .HasColumnName("Created")
                .HasColumnType("date");

            builder.Property(u => u.Modified)
                .HasColumnName("Modified")
                .HasColumnType("date");

            builder.Property(u => u.LastLogin)
                .HasColumnName("LastLogin")
                .HasColumnType("date");

            builder.HasOne(c => c.Contato)
                .WithMany()
                .HasForeignKey(x => x.IdContato)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Endereco)
                .WithMany()
                .HasForeignKey(x => x.IdEndereco)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Perfil)
                .WithMany()
                .HasForeignKey(x => x.IdPerfil)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
