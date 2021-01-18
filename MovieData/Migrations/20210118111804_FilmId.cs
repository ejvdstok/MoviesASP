using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class FilmId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KlantNr",
                table: "Verhuur",
                newName: "KlantId");

            migrationBuilder.RenameColumn(
                name: "BandNr",
                table: "Verhuur",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "VerhuurNr",
                table: "Verhuur",
                newName: "VerhuurId");

            migrationBuilder.RenameColumn(
                name: "BandNr",
                table: "Films",
                newName: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KlantId",
                table: "Verhuur",
                newName: "KlantNr");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Verhuur",
                newName: "BandNr");

            migrationBuilder.RenameColumn(
                name: "VerhuurId",
                table: "Verhuur",
                newName: "VerhuurNr");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Films",
                newName: "BandNr");
        }
    }
}
