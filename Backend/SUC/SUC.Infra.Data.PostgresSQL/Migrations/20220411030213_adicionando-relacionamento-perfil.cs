using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class adicionandorelacionamentoperfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Usuario_UsuarioId",
                table: "Perfil");

            migrationBuilder.DropIndex(
                name: "IX_Perfil_UsuarioId",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Perfil");

            migrationBuilder.CreateTable(
                name: "UsuarioXPerfil",
                columns: table => new
                {
                    UsuarioXPerfilId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: false),
                    AssociateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DissociateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioXPerfil", x => x.UsuarioXPerfilId);
                    table.ForeignKey(
                        name: "FK_UsuarioXPerfil_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioXPerfil_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioXPerfil_PerfilId",
                table: "UsuarioXPerfil",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioXPerfil_UsuarioId",
                table: "UsuarioXPerfil",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioXPerfil");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Perfil",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_UsuarioId",
                table: "Perfil",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Usuario_UsuarioId",
                table: "Perfil",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
