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
    [Migration("20221206024729_Refatorando-Logica-de-relacionamento-usuario")]
    partial class RefatorandoLogicaderelacionamentousuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SUC.Domain.Entities.Agenda.Agenda", b =>
                {
                    b.Property<Guid>("IdAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("IdAgenda");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DataAgenda")
                        .HasColumnType("Date")
                        .HasColumnName("DataAgenda");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("Descricao");

                    b.Property<string>("Local")
                        .HasColumnType("text")
                        .HasColumnName("Local");

                    b.Property<string>("Titulo")
                        .HasColumnType("text")
                        .HasColumnName("Titulo");

                    b.HasKey("IdAgenda");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("SUC.Domain.Entities.EntityEndereco.Endereco", b =>
                {
                    b.Property<Guid>("IdEndereco")
                        .HasColumnType("uuid")
                        .HasColumnName("IdEndereco");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cidade");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreationDate");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorUserId");

                    b.Property<string>("EnderecoNome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("EnderecoNome");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Estado");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("LastModificationDate");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierUserId");

                    b.HasKey("IdEndereco");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Perfil", b =>
                {
                    b.Property<Guid>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("IdPerfil");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("Ativo");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Descricao");

                    b.Property<int>("PerfilUsuario")
                        .HasMaxLength(150)
                        .HasColumnType("integer")
                        .HasColumnName("PerfilUsuario");

                    b.HasKey("IdPerfil");

                    b.ToTable("perfil");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Telefone.Contato", b =>
                {
                    b.Property<Guid>("IdContato")
                        .HasColumnType("uuid")
                        .HasColumnName("IdContato");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreationDate");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorUserId");

                    b.Property<string>("DDDNumero")
                        .HasColumnType("text")
                        .HasColumnName("DDDNumero");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("LastModificationDate");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierUserId");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Numero");

                    b.HasKey("IdContato");

                    b.ToTable("contato");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("IdUsuario");

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("date")
                        .HasColumnName("Created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Email");

                    b.Property<Guid?>("IdContato")
                        .HasColumnType("uuid")
                        .HasColumnName("IdContato");

                    b.Property<Guid?>("IdEndereco")
                        .HasColumnType("uuid")
                        .HasColumnName("IdEndereco");

                    b.Property<Guid>("IdPerfil")
                        .HasColumnType("uuid")
                        .HasColumnName("IdPerfil");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("date")
                        .HasColumnName("LastLogin");

                    b.Property<DateTime?>("Modified")
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

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Sobrenome");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdPerfil");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("SUC.Domain.Entities.EntityEndereco.Endereco", b =>
                {
                    b.HasOne("SUC.Domain.Entities.Usuario", null)
                        .WithOne("Endereco")
                        .HasForeignKey("SUC.Domain.Entities.EntityEndereco.Endereco", "IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SUC.Domain.Entities.Telefone.Contato", b =>
                {
                    b.HasOne("SUC.Domain.Entities.Usuario", null)
                        .WithOne("Contato")
                        .HasForeignKey("SUC.Domain.Entities.Telefone.Contato", "IdContato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SUC.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("SUC.Domain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("SUC.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Contato");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}