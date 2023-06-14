﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreinTickets.Models.Data;

#nullable disable

namespace TreinTickets.Models.Migrations
{
    [DbContext(typeof(TreinTicketsDbContext))]
    [Migration("20230515173919_verwijderBestemmingsStad1")]
    partial class verwijderBestemmingsStad1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRole");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaim");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUser");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaim");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogin");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserToken");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Bestelling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BestellingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KlantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("KlantId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Status");

                    b.Property<int>("TicketsId")
                        .HasColumnType("int")
                        .HasColumnName("TicketId");

                    b.Property<double>("Totaalbedrag")
                        .HasColumnType("float")
                        .HasColumnName("TotaalBedrag");

                    b.HasKey("Id");

                    b.HasIndex("KlantId");

                    b.HasIndex("TicketsId");

                    b.ToTable("Bestellingen");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Rit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RitId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BestemmingsStadId")
                        .HasColumnType("int")
                        .HasColumnName("EindbestemmingsStadId");

                    b.Property<string>("KlantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PlaatsNummer")
                        .HasColumnType("int")
                        .HasColumnName("PlaatsNummer");

                    b.Property<int>("TreinKlasseId")
                        .HasColumnType("int")
                        .HasColumnName("KlasseId");

                    b.Property<DateTime>("VertrekDag")
                        .HasColumnType("datetime2");

                    b.Property<int>("VertrekStadId")
                        .HasColumnType("int")
                        .HasColumnName("VertrekstadId");

                    b.HasKey("Id");

                    b.HasIndex("BestemmingsStadId");

                    b.HasIndex("KlantId");

                    b.HasIndex("TreinKlasseId");

                    b.HasIndex("VertrekStadId");

                    b.ToTable("Ritten");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Stad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StadId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HotelAPI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HotelAPI");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Naam");

                    b.HasKey("Id");

                    b.ToTable("Steden");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Tickets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TicketId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RitId")
                        .HasColumnType("int")
                        .HasColumnName("RitId");

                    b.HasKey("Id");

                    b.HasIndex("RitId")
                        .IsUnique();

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Trein", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("TreinId");

                    b.Property<int>("AantalZitPlaatsen")
                        .HasColumnType("int")
                        .HasColumnName("AantalZitplaasten");

                    b.Property<int>("BestemmingsStadId")
                        .HasColumnType("int")
                        .HasColumnName("BestemmingsStad");

                    b.Property<double>("Duur")
                        .HasColumnType("float")
                        .HasColumnName("Duur");

                    b.Property<int>("VertrekStad")
                        .HasColumnType("int");

                    b.Property<int>("VertrekStadId")
                        .HasColumnType("int")
                        .HasColumnName("Vertrekstad");

                    b.Property<DateTime>("Vertrektijd")
                        .HasColumnType("datetime2")
                        .HasColumnName("Vertrektijd");

                    b.HasKey("Id");

                    b.ToTable("Treinen");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.TreinKlasse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KlasseId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("TreinKlasses");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Vakantie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VakantieId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BeginDag")
                        .HasColumnType("datetime2")
                        .HasColumnName("BeginDag");

                    b.Property<DateTime>("EindDag")
                        .HasColumnType("datetime2")
                        .HasColumnName("EindDag");

                    b.HasKey("Id");

                    b.ToTable("Vakanties");
                });

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreinTickets.Models.Entities.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetRoleClaim", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUserClaim", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUserLogin", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUserToken", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Bestelling", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.AspNetUser", "Klant")
                        .WithMany("Bestellingen")
                        .HasForeignKey("KlantId")
                        .IsRequired()
                        .HasConstraintName("FK_TicketBestelling_AspNetUsers");

                    b.HasOne("TreinTickets.Models.Entities.Tickets", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klant");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Rit", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.TreinKlasse", "BestemmingsStad")
                        .WithMany()
                        .HasForeignKey("BestemmingsStadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreinTickets.Models.Entities.AspNetUser", "Klant")
                        .WithMany()
                        .HasForeignKey("KlantId");

                    b.HasOne("TreinTickets.Models.Entities.TreinKlasse", "TreinKlasse")
                        .WithMany()
                        .HasForeignKey("TreinKlasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreinTickets.Models.Entities.TreinKlasse", "VertrekStad")
                        .WithMany()
                        .HasForeignKey("VertrekStadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BestemmingsStad");

                    b.Navigation("Klant");

                    b.Navigation("TreinKlasse");

                    b.Navigation("VertrekStad");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Tickets", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.Rit", "Rit")
                        .WithOne("TicketsnrNavigation")
                        .HasForeignKey("TreinTickets.Models.Entities.Tickets", "RitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rit");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Trein", b =>
                {
                    b.HasOne("TreinTickets.Models.Entities.Rit", "Rit")
                        .WithMany("Treinen")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rit");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserTokens");

                    b.Navigation("Bestellingen");
                });

            modelBuilder.Entity("TreinTickets.Models.Entities.Rit", b =>
                {
                    b.Navigation("TicketsnrNavigation")
                        .IsRequired();

                    b.Navigation("Treinen");
                });
#pragma warning restore 612, 618
        }
    }
}
