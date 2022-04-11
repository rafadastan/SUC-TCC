using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class minusculonomedabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioXPerfil_Perfil_PerfilId",
                table: "UsuarioXPerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioXPerfil_Usuario_UsuarioId",
                table: "UsuarioXPerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "Perfil",
                newName: "perfil");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_Email",
                table: "usuario",
                newName: "IX_usuario_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_Cpf",
                table: "usuario",
                newName: "IX_usuario_Cpf");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuario",
                table: "usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perfil",
                table: "perfil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioXPerfil_perfil_PerfilId",
                table: "UsuarioXPerfil",
                column: "PerfilId",
                principalTable: "perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioXPerfil_usuario_UsuarioId",
                table: "UsuarioXPerfil",
                column: "UsuarioId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioXPerfil_perfil_PerfilId",
                table: "UsuarioXPerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioXPerfil_usuario_UsuarioId",
                table: "UsuarioXPerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuario",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perfil",
                table: "perfil");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "perfil",
                newName: "Perfil");

            migrationBuilder.RenameIndex(
                name: "IX_usuario_Email",
                table: "Usuario",
                newName: "IX_Usuario_Email");

            migrationBuilder.RenameIndex(
                name: "IX_usuario_Cpf",
                table: "Usuario",
                newName: "IX_Usuario_Cpf");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioXPerfil_Perfil_PerfilId",
                table: "UsuarioXPerfil",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioXPerfil_Usuario_UsuarioId",
                table: "UsuarioXPerfil",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
