using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class AdicionandoRelacionamentoUsuarioContato : Migration
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_contato_IdContato",
                table: "usuario",
                column: "IdContato",
                principalTable: "contato",
                principalColumn: "IdContato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_endereco_IdEndereco",
                table: "usuario",
                column: "IdEndereco",
                principalTable: "endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_perfil_IdPerfil",
                table: "usuario",
                column: "IdPerfil",
                principalTable: "perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
