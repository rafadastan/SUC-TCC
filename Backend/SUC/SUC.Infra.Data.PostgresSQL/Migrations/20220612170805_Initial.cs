using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uuid", nullable: false),
                    IdContato = table.Column<Guid>(type: "uuid", nullable: false),
                    IdPerfil = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Sobrenome = table.Column<string>(type: "text", nullable: true),
                    Cpf = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Created = table.Column<DateTime>(type: "date", nullable: false),
                    Modified = table.Column<DateTime>(type: "date", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "contato",
                columns: table => new
                {
                    IdContato = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifierUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    DDDNumero = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UsuarioIdUsuario = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contato", x => x.IdContato);
                    table.ForeignKey(
                        name: "FK_contato_usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "perfil",
                columns: table => new
                {
                    IdPerfil = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilUsuario = table.Column<int>(type: "integer", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    UsuarioIdUsuario = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil", x => x.IdPerfil);
                    table.ForeignKey(
                        name: "FK_perfil_usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contato_UsuarioIdUsuario",
                table: "contato",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_UsuarioIdUsuario",
                table: "perfil",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_Cpf",
                table: "usuario",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_Email",
                table: "usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdContato",
                table: "usuario",
                column: "IdContato");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdPerfil",
                table: "usuario",
                column: "IdPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_contato_IdContato",
                table: "usuario",
                column: "IdContato",
                principalTable: "contato",
                principalColumn: "IdContato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_perfil_IdPerfil",
                table: "usuario",
                column: "IdPerfil",
                principalTable: "perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_usuario_UsuarioIdUsuario",
                table: "contato");

            migrationBuilder.DropForeignKey(
                name: "FK_perfil_usuario_UsuarioIdUsuario",
                table: "perfil");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "contato");

            migrationBuilder.DropTable(
                name: "perfil");
        }
    }
}
