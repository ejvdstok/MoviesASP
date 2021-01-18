﻿// <auto-generated />
using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MovieData.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20210118111804_FilmId")]
    partial class FilmId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Data.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GenreNaam")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("GenreNaam");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieData.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("InVoorraad")
                        .HasColumnType("int");

                    b.Property<decimal>("Prijs")
                        .HasColumnType("money");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<int>("TotaalVerhuurd")
                        .HasColumnType("int");

                    b.Property<int>("UitVoorraad")
                        .HasColumnType("int");

                    b.HasKey("FilmId");

                    b.HasIndex("GenreId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("MovieData.Models.Klant", b =>
                {
                    b.Property<int>("KlantNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DatumLid")
                        .HasColumnType("date");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("HuurAantal")
                        .HasColumnType("int");

                    b.Property<string>("KlantStat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Lidgeld")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<string>("StraatNr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Straat_Nr");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("KlantNr");

                    b.HasIndex("DatumLid")
                        .HasDatabaseName("DATUMLID");

                    b.HasIndex("PostCode")
                        .HasDatabaseName("POSTCODE");

                    b.ToTable("Klanten");
                });

            modelBuilder.Entity("MovieData.Models.Verhuur", b =>
                {
                    b.Property<int>("VerhuurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("KlantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerhuurDatum")
                        .HasColumnType("date");

                    b.HasKey("VerhuurId");

                    b.HasIndex("FilmId")
                        .HasDatabaseName("BANDNR");

                    b.HasIndex("KlantId")
                        .HasDatabaseName("KlantNr");

                    b.ToTable("Verhuur");
                });

            modelBuilder.Entity("MovieData.Models.Film", b =>
                {
                    b.HasOne("Data.Models.Genre", "GenreIdNavigation")
                        .WithMany("Films")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("fk_GenreId")
                        .IsRequired();

                    b.Navigation("GenreIdNavigation");
                });

            modelBuilder.Entity("MovieData.Models.Verhuur", b =>
                {
                    b.HasOne("MovieData.Models.Film", "FilmIdNavigation")
                        .WithMany("Verhuur")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("fk_BandNr")
                        .IsRequired();

                    b.HasOne("MovieData.Models.Klant", "KlantIdNavigation")
                        .WithMany("Verhuur")
                        .HasForeignKey("KlantId")
                        .HasConstraintName("fk_KlantNr")
                        .IsRequired();

                    b.Navigation("FilmIdNavigation");

                    b.Navigation("KlantIdNavigation");
                });

            modelBuilder.Entity("Data.Models.Genre", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("MovieData.Models.Film", b =>
                {
                    b.Navigation("Verhuur");
                });

            modelBuilder.Entity("MovieData.Models.Klant", b =>
                {
                    b.Navigation("Verhuur");
                });
#pragma warning restore 612, 618
        }
    }
}
