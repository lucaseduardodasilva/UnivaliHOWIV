using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoIntegradorADS.Migrations
{
    public partial class adicionandoPropriedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Caracteristica",
                table: "Cars",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Cars",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Vendedor",
                table: "Cars",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caracteristica",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Vendedor",
                table: "Cars");
        }
    }
}
