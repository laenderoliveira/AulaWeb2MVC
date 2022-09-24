using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AulaWeb2MVC.Migrations
{
    public partial class Versao10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculdade",
                columns: table => new
                {
                    Fac_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fac_Nome_Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fac_Nome_Completo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculdade", x => x.Fac_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faculdade");
        }
    }
}
