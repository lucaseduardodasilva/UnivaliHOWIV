using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoIntegradorADS.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CodigoCarro = table.Column<string>(type: "varchar(10)", nullable: false),
                    Ano = table.Column<string>(type: "varchar(100)", nullable: false),
                    Kilometragem = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
