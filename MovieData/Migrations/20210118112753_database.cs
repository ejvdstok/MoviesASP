using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieData.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "fk_BandNr",
                table: "Verhuur");

            migrationBuilder.DropForeignKey(
                name: "fk_KlantId",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "DATUMLID",
                table: "Klanten");

            migrationBuilder.DropIndex(
                name: "POSTCODE",
                table: "Klanten");

            migrationBuilder.RenameIndex(
                name: "KlantId",
                table: "Verhuur",
                newName: "IX_Verhuur_KlantId");

            migrationBuilder.RenameIndex(
                name: "FilmId",
                table: "Verhuur",
                newName: "IX_Verhuur_FilmId");

            migrationBuilder.RenameColumn(
                name: "Straat_Nr",
                table: "Klanten",
                newName: "StraatNr");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VerhuurDatum",
                table: "Verhuur",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Voornaam",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "KlantStat",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gemeente",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumLid",
                table: "Klanten",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "StraatNr",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "GenreNaam",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Titel",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(50)",
                oldFixedLength: true,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prijs",
                table: "Films",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Genres_GenreId",
                table: "Films",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Verhuur_Films_FilmId",
                table: "Verhuur",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Verhuur_Klanten_KlantId",
                table: "Verhuur",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Genres_GenreId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Verhuur_Films_FilmId",
                table: "Verhuur");

            migrationBuilder.DropForeignKey(
                name: "FK_Verhuur_Klanten_KlantId",
                table: "Verhuur");

            migrationBuilder.RenameIndex(
                name: "IX_Verhuur_KlantId",
                table: "Verhuur",
                newName: "KlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Verhuur_FilmId",
                table: "Verhuur",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "StraatNr",
                table: "Klanten",
                newName: "Straat_Nr");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VerhuurDatum",
                table: "Verhuur",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Voornaam",
                table: "Klanten",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Klanten",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KlantStat",
                table: "Klanten",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gemeente",
                table: "Klanten",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumLid",
                table: "Klanten",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Straat_Nr",
                table: "Klanten",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GenreNaam",
                table: "Genres",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titel",
                table: "Films",
                type: "nchar(50)",
                fixedLength: true,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prijs",
                table: "Films",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "DATUMLID",
                table: "Klanten",
                column: "DatumLid");

            migrationBuilder.CreateIndex(
                name: "POSTCODE",
                table: "Klanten",
                column: "PostCode");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreId",
                table: "Films",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_BandNr",
                table: "Verhuur",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_KlantId",
                table: "Verhuur",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
