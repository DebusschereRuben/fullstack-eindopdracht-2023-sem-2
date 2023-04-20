using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TreinTickets.Models.Entities;

namespace TreinTickets.Models.Data
{
    public partial class TreinTicketsVerkoopDBContext : DbContext
    {
        public TreinTicketsVerkoopDBContext()
        {
        }

        public TreinTicketsVerkoopDBContext(DbContextOptions<TreinTicketsVerkoopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Bestelling> Bestellingen { get; set; } = null!;
        public virtual DbSet<Rit> Ritten { get; set; } = null!;
        public virtual DbSet<Stad> Steden { get; set; } = null!;
        public virtual DbSet<Tickets> Tickets { get; set; } = null!;
        public virtual DbSet<Trein> Treinen { get; set; } = null!;
        public virtual DbSet<TreinKlasse> TreinKlasses { get; set; } = null!;
        public virtual DbSet<Vakantie> Vakanties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                //todo: connectionstring aanpassen voor veiligheid redenen (Ruben)
                optionsBuilder.UseSqlServer("Server=.\\SQL19_VIVES; Database=TreinTicketsDB; Trusted_Connection=True; MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Bestelling>(entity =>
            {
                entity.HasKey(e => new { e.BestellingId });

                entity.Property(e => e.BestellingId).HasColumnName("BestellingId");

                entity.Property(e => e.KlantId).HasColumnName("KlantId");

                entity.Property(e => e.Totaalbedrag).HasColumnName("TotaalBedrag");

                entity.Property(e => e.TicketId).HasColumnName("TicketId");

                entity.Property(e => e.Status).HasColumnName("Status"); ;

                entity.HasOne(d => d.Klant)
                    .WithMany(p => p.Bestellingen)
                    .HasForeignKey(d => d.KlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketBestelling_AspNetUsers");
            });

            modelBuilder.Entity<Rit>(entity =>
            {
                entity.HasKey(e => new { e.RitId });

                entity.Property(e => e.RitId).HasColumnName("RitId");

                entity.Property(e => e.KlantId).HasColumnName("KlantId");

                entity.Property(e => e.TreinId).HasColumnName("TreinId");

                entity.Property(e => e.KlasseId).HasColumnName("KlasseId");
                entity.Property(e => e.PlaatsNummer).HasColumnName("PlaatsNummer");
                entity.Property(e => e.VertrekStadId).HasColumnName("VertrekstadId");
                entity.Property(e => e.BestemmingsStadId).HasColumnName("EindbestemmingsStadId");
                
            });

            modelBuilder.Entity<Stad>(entity =>
            {
                entity.HasKey(e => new { e.StadId });

                entity.Property(e => e.StadId).HasColumnName("StadId");

                entity.Property(e => e.Naam).HasColumnName("Naam");

                entity.Property(e => e.HotelAPI).HasColumnName("HotelAPI");

            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => new { e.TicketId });

                entity.Property(e => e.TicketId).HasColumnName("TicketId");

                entity.Property(e => e.TreinId).HasColumnName("TreinId");

                entity.Property(e => e.RitId).HasColumnName("RitId");

            });

            modelBuilder.Entity<Trein>(entity =>
            {
                entity.HasKey(e => new { e.TreinId });

                entity.Property(e => e.TreinId).HasColumnName("TreinId");

                entity.Property(e => e.VertrekStadId).HasColumnName("Vertrekstad");

                entity.Property(e => e.Vertrektijd).HasColumnName("Vertrektijd");
                entity.Property(e => e.BestemmingsStadId).HasColumnName("BestemmingsStad");
                entity.Property(e => e.Duur).HasColumnName("Duur");
                entity.Property(e => e.AantalZitPlaatsen).HasColumnName("AantalZitplaasten");

                entity.HasOne(d => d.Rit)
                    .WithMany(p => p.Treinen)
                    .HasForeignKey(d => d.TreinId);
            });

            modelBuilder.Entity<TreinKlasse>(entity =>
            {
                entity.HasKey(e => new { e.KlasseId });

                entity.Property(e => e.KlasseId).HasColumnName("KlasseId");

                entity.Property(e => e.Type).HasColumnName("Type");
            });

            modelBuilder.Entity<Vakantie>(entity =>
            {
                entity.HasKey(e => new { e.Id });

                entity.Property(e => e.Id).HasColumnName("VakantieId");

                entity.Property(e => e.BeginDag).HasColumnName("BeginDag");
                entity.Property(e => e.EindDag).HasColumnName("EindDag");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
