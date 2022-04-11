﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SUC.Infra.Data.PostgresSQL.Contexts;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20220411030213_adicionando-relacionamento-perfil")]
    partial class adicionandorelacionamentoperfil
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SUC.Domain.Entities.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("PerfilUsuario")
                        .HasMaxLength(150)
                        .HasColumnType("integer")
                        .HasColumnName("PerfilUsuario");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("date")
                        .HasColumnName("Created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Email");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("date")
                        .HasColumnName("LastLogin");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("date")
                        .HasColumnName("Modified");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Senha");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SUC.Domain.Entities.UsuarioXPerfil", b =>
                {
                    b.Property<Guid>("UsuarioXPerfilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AssociateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DissociateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.HasKey("UsuarioXPerfilId");

                    b.HasIndex("PerfilId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioXPerfil");
                });

            modelBuilder.Entity("SUC.Domain.Entities.UsuarioXPerfil", b =>
                {
                    b.HasOne("SUC.Domain.Entities.Perfil", "Perfil")
                        .WithMany("UsuarioXPerfilList")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUC.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioXPerfilList")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Perfil", b =>
                {
                    b.Navigation("UsuarioXPerfilList");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("UsuarioXPerfilList");
                });
#pragma warning restore 612, 618
        }
    }
}
