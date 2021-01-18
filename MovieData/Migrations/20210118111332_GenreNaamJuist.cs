using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class GenreNaamJuist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreNr",
                table: "Films");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Genres",
                newName: "GenreNaam");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreId",
                table: "Films",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreId",
                table: "Films");

            migrationBuilder.RenameColumn(
                name: "GenreNaam",
                table: "Genres",
                newName: "Genre");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreNr",
                table: "Films",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
