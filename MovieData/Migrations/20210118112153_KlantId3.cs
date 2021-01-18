using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class KlantId3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KlantNr",
                table: "Klanten",
                newName: "KlantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KlantId",
                table: "Klanten",
                newName: "KlantNr");
        }
    }
}
