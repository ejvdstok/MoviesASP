using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class KlantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_KlantNr",
                table: "Verhuur");

            migrationBuilder.RenameIndex(
                name: "KlantNr",
                table: "Verhuur",
                newName: "KlantId");

            migrationBuilder.RenameIndex(
                name: "BANDNR",
                table: "Verhuur",
                newName: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "fk_KlantId",
                table: "Verhuur",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantNr",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_KlantId",
                table: "Verhuur");

            migrationBuilder.RenameIndex(
                name: "KlantId",
                table: "Verhuur",
                newName: "KlantNr");

            migrationBuilder.RenameIndex(
                name: "FilmId",
                table: "Verhuur",
                newName: "BANDNR");

            migrationBuilder.AddForeignKey(
                name: "fk_KlantNr",
                table: "Verhuur",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantNr",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
