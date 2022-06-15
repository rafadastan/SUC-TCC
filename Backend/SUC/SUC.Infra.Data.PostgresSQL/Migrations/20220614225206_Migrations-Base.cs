using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class MigrationsBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_usuario_UsuarioIdUsuario",
                table: "contato");

            migrationBuilder.DropForeignKey(
                name: "FK_endereco_usuario_UsuarioIdUsuario",
                table: "endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_perfil_PerfilIdPerfil",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_usuario_PerfilIdPerfil",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_endereco_UsuarioIdUsuario",
                table: "endereco");

            migrationBuilder.DropIndex(
                name: "IX_contato_UsuarioIdUsuario",
                table: "contato");

            migrationBuilder.DropColumn(
                name: "PerfilIdPerfil",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "endereco");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "contato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PerfilIdPerfil",
                table: "usuario",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "endereco",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "contato",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_PerfilIdPerfil",
                table: "usuario",
                column: "PerfilIdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_UsuarioIdUsuario",
                table: "endereco",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_contato_UsuarioIdUsuario",
                table: "contato",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_usuario_UsuarioIdUsuario",
                table: "contato",
                column: "UsuarioIdUsuario",
                principalTable: "usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_usuario_UsuarioIdUsuario",
                table: "endereco",
                column: "UsuarioIdUsuario",
                principalTable: "usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_perfil_PerfilIdPerfil",
                table: "usuario",
                column: "PerfilIdPerfil",
                principalTable: "perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
