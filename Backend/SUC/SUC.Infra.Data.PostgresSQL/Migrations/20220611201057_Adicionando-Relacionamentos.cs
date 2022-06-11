using Microsoft.EntityFrameworkCore.Migrations;

namespace SUC.Infra.Data.PostgresSQL.Migrations
{
    public partial class AdicionandoRelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuario",
                newName: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "usuario",
                newName: "Id");
        }
    }
}
