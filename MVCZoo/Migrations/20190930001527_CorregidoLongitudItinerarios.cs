using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCZoo.Migrations
{
    public partial class CorregidoLongitudItinerarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logitud",
                table: "Itinerario",
                newName: "Longitud");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitud",
                table: "Itinerario",
                newName: "Logitud");
        }
    }
}
