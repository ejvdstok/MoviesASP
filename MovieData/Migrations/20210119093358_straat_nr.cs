using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class straat_nr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StraatNr",
                table: "Klanten",
                newName: "Straat_Nr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Straat_Nr",
                table: "Klanten",
                newName: "StraatNr");
        }
    }
}
