using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class CriandoEntidadeEnderecoeRelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_usuario_UsuarioIdUsuario",
                table: "contato");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_contato_IdContato",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_usuario_IdContato",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "IdContato",
                table: "usuario");

            migrationBuilder.RenameColumn(
                name: "IdContato",
                table: "contato",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "UsuarioIdUsuario",
                table: "contato",
                newName: "IdUsuario1");

            migrationBuilder.RenameIndex(
                name: "IX_contato_UsuarioIdUsuario",
                table: "contato",
                newName: "IX_contato_IdUsuario1");

            migrationBuilder.AddColumn<Guid>(
                name: "ContatoIdContato",
                table: "usuario",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoIdEndereco",
                table: "usuario",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<Guid>(type: "uuid", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uuid", nullable: true),
                    EnderecoNome = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_endereco_usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuario_ContatoIdContato",
                table: "usuario",
                column: "ContatoIdContato");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_EnderecoIdEndereco",
                table: "usuario",
                column: "EnderecoIdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_IdUsuario",
                table: "endereco",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_usuario_IdUsuario1",
                table: "contato",
                column: "IdUsuario1",
                principalTable: "usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_contato_ContatoIdContato",
                table: "usuario",
                column: "ContatoIdContato",
                principalTable: "contato",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_endereco_EnderecoIdEndereco",
                table: "usuario",
                column: "EnderecoIdEndereco",
                principalTable: "endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_usuario_IdUsuario1",
                table: "contato");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_contato_ContatoIdContato",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_endereco_EnderecoIdEndereco",
                table: "usuario");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropIndex(
                name: "IX_usuario_ContatoIdContato",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_usuario_EnderecoIdEndereco",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "ContatoIdContato",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "EnderecoIdEndereco",
                table: "usuario");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "contato",
                newName: "IdContato");

            migrationBuilder.RenameColumn(
                name: "IdUsuario1",
                table: "contato",
                newName: "UsuarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_contato_IdUsuario1",
                table: "contato",
                newName: "IX_contato_UsuarioIdUsuario");

            migrationBuilder.AddColumn<Guid>(
                name: "IdContato",
                table: "usuario",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdContato",
                table: "usuario",
                column: "IdContato");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_usuario_UsuarioIdUsuario",
                table: "contato",
                column: "UsuarioIdUsuario",
                principalTable: "usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_contato_IdContato",
                table: "usuario",
                column: "IdContato",
                principalTable: "contato",
                principalColumn: "IdContato",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
