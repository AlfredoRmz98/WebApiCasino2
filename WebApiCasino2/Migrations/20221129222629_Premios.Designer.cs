﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCasino2;

#nullable disable

namespace WebApiCasino2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221129222629_Premios")]
    partial class Premios
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BarajaRifa", b =>
                {
                    b.Property<int>("BarajaId")
                        .HasColumnType("int");

                    b.Property<int>("RifaId")
                        .HasColumnType("int");

                    b.HasKey("BarajaId", "RifaId");

                    b.HasIndex("RifaId");

                    b.ToTable("BarajaRifa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Baraja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Barajas");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BarajaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PremioNombre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BarajaId");

                    b.HasIndex("PremioNombre");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.ParticipanteRifa", b =>
                {
                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int");

                    b.Property<int>("RifaId")
                        .HasColumnType("int");

                    b.Property<int?>("BarajaId")
                        .HasColumnType("int");

                    b.HasKey("ParticipanteId", "RifaId");

                    b.HasIndex("BarajaId");

                    b.HasIndex("RifaId");

                    b.ToTable("ParticipanteRifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Premio", b =>
                {
                    b.Property<int>("Nombre")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nombre"));

                    b.Property<int?>("BarajaId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("RifaId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nombre");

                    b.HasIndex("BarajaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Premios");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.PremioRifa", b =>
                {
                    b.Property<int>("RifaId")
                        .HasColumnType("int");

                    b.Property<string>("PremioNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PremioNombre1")
                        .HasColumnType("int");

                    b.HasKey("RifaId", "PremioNombre");

                    b.HasIndex("PremioNombre1");

                    b.ToTable("PremioRifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Rifa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PremioNombre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PremioNombre");

                    b.ToTable("Rifas");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.RifaPremio", b =>
                {
                    b.Property<int>("PremioId")
                        .HasColumnType("int");

                    b.Property<string>("RifaNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RifaId")
                        .HasColumnType("int");

                    b.HasKey("PremioId", "RifaNombre");

                    b.HasIndex("RifaId");

                    b.ToTable("RifaPremio");
                });

            modelBuilder.Entity("BarajaRifa", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Baraja", null)
                        .WithMany()
                        .HasForeignKey("BarajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCasino2.Entidades.Rifa", null)
                        .WithMany()
                        .HasForeignKey("RifaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Baraja", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Participante", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Baraja", null)
                        .WithMany("Participante")
                        .HasForeignKey("BarajaId");

                    b.HasOne("WebApiCasino2.Entidades.Premio", null)
                        .WithMany("Participante")
                        .HasForeignKey("PremioNombre");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.ParticipanteRifa", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Baraja", null)
                        .WithMany("ParticipanteRifa")
                        .HasForeignKey("BarajaId");

                    b.HasOne("WebApiCasino2.Entidades.Participante", "Participante")
                        .WithMany("ParticipanteRifa")
                        .HasForeignKey("ParticipanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCasino2.Entidades.Rifa", "Rifa")
                        .WithMany("ParticipanteRifa")
                        .HasForeignKey("RifaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participante");

                    b.Navigation("Rifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Premio", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Baraja", null)
                        .WithMany("Premio")
                        .HasForeignKey("BarajaId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.PremioRifa", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Premio", "Premio")
                        .WithMany()
                        .HasForeignKey("PremioNombre1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCasino2.Entidades.Rifa", "Rifa")
                        .WithMany()
                        .HasForeignKey("RifaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Premio");

                    b.Navigation("Rifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Rifa", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Premio", null)
                        .WithMany("Rifa")
                        .HasForeignKey("PremioNombre");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.RifaPremio", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Premio", "Premio")
                        .WithMany()
                        .HasForeignKey("PremioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCasino2.Entidades.Rifa", "Rifa")
                        .WithMany()
                        .HasForeignKey("RifaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Premio");

                    b.Navigation("Rifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Baraja", b =>
                {
                    b.Navigation("Participante");

                    b.Navigation("ParticipanteRifa");

                    b.Navigation("Premio");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Participante", b =>
                {
                    b.Navigation("ParticipanteRifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Premio", b =>
                {
                    b.Navigation("Participante");

                    b.Navigation("Rifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Rifa", b =>
                {
                    b.Navigation("ParticipanteRifa");
                });
#pragma warning restore 612, 618
        }
    }
}
