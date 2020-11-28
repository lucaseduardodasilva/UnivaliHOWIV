using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoIntegradorADS.Migrations
{
    public partial class adicionandoCor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Cars",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Cars");
        }
    }
}
