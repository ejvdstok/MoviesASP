using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace MovieData.Models
{
    public partial class MovieDbContext : DbContext
    {
        public MovieDbContext()
        {
        }

        public MovieDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Klant> Klanten { get; set; }
        public virtual DbSet<Verhuur> Verhuur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\mssqllocaldb;Database=MoviesASP;Trusted_Connection=True;");
            }
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.FilmId);

                entity.Property(e => e.Prijs).HasColumnType("money");

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.GenreIdNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_GenreId");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreId);

                entity.Property(e => e.GenreNaam)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GenreNaam");
            });

            modelBuilder.Entity<Klant>(entity =>
            {
                entity.HasKey(e => e.KlantId);

                entity.HasIndex(e => e.DatumLid)
                    .HasDatabaseName("DATUMLID");

                entity.HasIndex(e => e.PostCode)
                    .HasDatabaseName("POSTCODE");

                entity.Property(e => e.DatumLid).HasColumnType("date");

                entity.Property(e => e.Gemeente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KlantStat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StraatNr)
                    .IsRequired()
                    .HasColumnName("Straat_Nr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voornaam)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Verhuur>(entity =>
            {
                entity.HasKey(e => e.VerhuurId);

                entity.HasIndex(e => e.FilmId).HasDatabaseName("FilmId");

                entity.HasIndex(e => e.KlantId).HasDatabaseName("KlantId");

                entity.Property(e => e.VerhuurDatum).HasColumnType("date");

                entity.HasOne(d => d.FilmIdNavigation)
                    .WithMany(p => p.Verhuur)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_BandNr");

                entity.HasOne(d => d.KlantIdNavigation)
                    .WithMany(p => p.Verhuur)
                    .HasForeignKey(d => d.KlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KlantId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder); 
    }
}
