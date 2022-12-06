using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUC.Domain.Entities.EntityEndereco;

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
                .WithOne()
                .HasForeignKey<Contato>(c => c.IdContato)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Endereco)
                .WithOne()
                .HasForeignKey<Endereco>(c => c.IdEndereco)
                .OnDelete(DeleteBehavior.Cascade);

            //Perfil não pode ser excluido, mas atribui null a referencia IdPerfil
            builder.HasOne(c => c.Perfil)
                .WithMany()
                .HasForeignKey(x => x.IdPerfil)
                .IsRequired()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
