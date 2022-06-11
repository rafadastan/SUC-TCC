﻿using Microsoft.EntityFrameworkCore;
using SUC.Domain.Entities;
using SUC.Domain.Entities.Telefone;
using SUC.Infra.Data.PostgresSQL.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options)
        {   }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(u => u.Cpf).IsUnique();
                entity.HasIndex(u => u.Email).IsUnique();
            });
        }
    }
}
