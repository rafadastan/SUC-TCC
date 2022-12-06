using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class RefatorandoLogicaderelacionamentousuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_contato_IdContato",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_endereco_IdEndereco",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_perfil_IdPerfil",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_usuario_IdContato",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_usuario_IdEndereco",
                table: "usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_usuario_IdContato",
                table: "contato",
                column: "IdContato",
                principalTable: "usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_usuario_IdEndereco",
                table: "endereco",
                column: "IdEndereco",
                principalTable: "usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_perfil_IdPerfil",
                table: "usuario",
                column: "IdPerfil",
                principalTable: "perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_usuario_IdContato",
                table: "contato");

            migrationBuilder.DropForeignKey(
                name: "FK_endereco_usuario_IdEndereco",
                table: "endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_perfil_IdPerfil",
                table: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdContato",
                table: "usuario",
                column: "IdContato");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdEndereco",
                table: "usuario",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_contato_IdContato",
                table: "usuario",
                column: "IdContato",
                principalTable: "contato",
                principalColumn: "IdContato",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_endereco_IdEndereco",
                table: "usuario",
                column: "IdEndereco",
                principalTable: "endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_perfil_IdPerfil",
                table: "usuario",
                column: "IdPerfil",
                principalTable: "perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
