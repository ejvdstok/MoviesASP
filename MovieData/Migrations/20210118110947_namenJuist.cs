using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class namenJuist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreNr",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "GenreNr",
                table: "Films",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_GenreNr",
                table: "Films",
                newName: "IX_Films_GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genres",
                newName: "GenreNr");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Films",
                newName: "GenreNr");

            migrationBuilder.RenameIndex(
                name: "IX_Films_GenreId",
                table: "Films",
                newName: "IX_Films_GenreNr");
        }
    }
}
