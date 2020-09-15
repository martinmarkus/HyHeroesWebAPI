﻿// <auto-generated />
using System;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    [DbContext(typeof(HyHeroesDbContext))]
    [Migration("20200915202702_initial21")]
    partial class initial21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.ActualValueOfOneKredit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("ActualValueOfOneKredit");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.BillingTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsBilled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoAdoszam")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoAzonosito")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoCim")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoIrsz")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoMegjegyzes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoNev")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoPostazasiCim")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoPostazasiIrsz")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoPostazasiNev")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoPostazasiTelepules")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoSendEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoTelefonszam")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VevoTelepules")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("BillingTransactions");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("InGameActivatorCommand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("InGameDeactivatorCommand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRank")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PermanentPrice")
                        .HasColumnType("int");

                    b.Property<int>("PricePerMonth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.PurchasedProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("ActualValueOfOneKredit")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsExpirationVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOverwrittenByOtherRank")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPermanent")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRepeatable")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("ValidityPeriodInMonths")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("PurchasedProducts");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("PermissionLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("HyCoin")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastAuthenticationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastAuthenticationIp")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasAlternateKey("UserName", "Email");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.PurchasedProduct", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.User", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
