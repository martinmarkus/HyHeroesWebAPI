﻿// <auto-generated />
using System;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    [DbContext(typeof(HyHeroesDbContext))]
    partial class HyHeroesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("BillingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
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

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.EDSMSActivationCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsGeneratedByAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("KreditPurchaseId")
                        .HasColumnType("char(36)");

                    b.Property<int>("KreditValue")
                        .HasColumnType("int");

                    b.Property<string>("SenderPhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("KreditPurchaseId");

                    b.ToTable("EDSMSActivationCodes");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.EDSMSPurchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CustomerPhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("GrossPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("IsTest")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("JatekFizetesId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Message")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Prefix")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ReceiverPhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("EDSMSPurchases");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.EmailVerificationCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ActivationCode")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ActivationTimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmailToVerify")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmailVerificationCodes");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.FailedBillingTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("BillingTransactionId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("FailDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("KreditAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillingTransactionId");

                    b.ToTable("FailedTransactions");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.KreditPurchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CurrencyValue")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("KreditValue")
                        .HasColumnType("int");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("KreditPurchases");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("FormattedNews")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PublisherUserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherUserId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.PayPalIPNMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AddressCity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressCountry")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressCountryCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressState")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressStatus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressStreet")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressZip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Charset")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Custom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HandlingAmount")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ItemName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ItemNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("McCurrency")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("McFee")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("McGross")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("NotifyVersion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PayerEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PayerId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PayerStatus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("PaymentFee")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PaymentGross")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PaymentType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProtectionEligibility")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResidenceCountry")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Shipping")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("TestIpn")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TransactionSubject")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TxnId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VerifySign")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("PayPalIPNMessages");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.PayPalTransactionRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRequestProcessed")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("RequesterUserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("RequesterUserId");

                    b.ToTable("PayPalTransactionRequests");
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

                    b.Property<int>("KreditSpentOn")
                        .HasColumnType("int");

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
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PermissionLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.ServerActivation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Arcade")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ComboFly")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Creative")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("GTA")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lobby")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("OpSkyBlock")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PotterCraft")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Prison")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("PurchasedProductId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("SkyBoss")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Survival")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("PurchasedProductId");

                    b.ToTable("ServerActivations");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.ServerExpiration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Arcade")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ComboFly")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Creative")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("GTA")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lobby")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("OpSkyBlock")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PotterCraft")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Prison")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("PurchasedProductId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("SkyBoss")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Survival")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("PurchasedProductId");

                    b.ToTable("ServerExpirations");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

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

                    b.HasAlternateKey("UserName");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.EDSMSActivationCode", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.KreditPurchase", "KreditPurchase")
                        .WithMany()
                        .HasForeignKey("KreditPurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.EmailVerificationCode", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.FailedBillingTransaction", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.BillingTransaction", "BillingTransaction")
                        .WithMany()
                        .HasForeignKey("BillingTransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.KreditPurchase", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.News", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.User", "PublisherUser")
                        .WithMany()
                        .HasForeignKey("PublisherUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.PayPalTransactionRequest", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.User", "RequesterUser")
                        .WithMany()
                        .HasForeignKey("RequesterUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.ServerActivation", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.PurchasedProduct", "PurchasedProduct")
                        .WithMany()
                        .HasForeignKey("PurchasedProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.ServerExpiration", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.PurchasedProduct", "PurchasedProduct")
                        .WithMany()
                        .HasForeignKey("PurchasedProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HyHeroesWebAPI.ApplicationCore.Entities.User", b =>
                {
                    b.HasOne("HyHeroesWebAPI.ApplicationCore.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
