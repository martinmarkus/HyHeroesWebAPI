using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class EdsmsRequestCooldown2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActualValueOfOneKredit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActualValueOfOneKredit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    BillingDate = table.Column<DateTime>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    VevoAdoszam = table.Column<string>(nullable: true),
                    VevoSendEmail = table.Column<string>(nullable: true),
                    VevoAzonosito = table.Column<string>(nullable: true),
                    VevoEmail = table.Column<string>(nullable: true),
                    VevoMegjegyzes = table.Column<string>(nullable: true),
                    VevoTelefonszam = table.Column<string>(nullable: true),
                    VevoNev = table.Column<string>(nullable: true),
                    VevoIrsz = table.Column<string>(nullable: true),
                    VevoTelepules = table.Column<string>(nullable: true),
                    VevoCim = table.Column<string>(nullable: true),
                    VevoPostazasiNev = table.Column<string>(nullable: true),
                    VevoPostazasiIrsz = table.Column<string>(nullable: true),
                    VevoPostazasiTelepules = table.Column<string>(nullable: true),
                    VevoPostazasiCim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlacklistedIPs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    IP = table.Column<string>(nullable: true),
                    IsIPBanned = table.Column<bool>(nullable: false),
                    BanDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlacklistedIPs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameServers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ServerName = table.Column<string>(nullable: true),
                    IsServerRunning = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameServers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MassKreditActivationCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Code = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    KreditValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassKreditActivationCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayPalIPNMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    McGross = table.Column<decimal>(nullable: false),
                    ProtectionEligibility = table.Column<string>(nullable: true),
                    AddressStatus = table.Column<string>(nullable: true),
                    PayerId = table.Column<string>(nullable: true),
                    Tax = table.Column<decimal>(nullable: false),
                    AddressStreet = table.Column<string>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    PaymentStatus = table.Column<string>(nullable: true),
                    Charset = table.Column<string>(nullable: true),
                    AddressZip = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    McFee = table.Column<decimal>(nullable: false),
                    AddressCountryCode = table.Column<string>(nullable: true),
                    AddressName = table.Column<string>(nullable: true),
                    NotifyVersion = table.Column<string>(nullable: true),
                    Custom = table.Column<string>(nullable: true),
                    PayerStatus = table.Column<string>(nullable: true),
                    AddressCountry = table.Column<string>(nullable: true),
                    AddressCity = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    VerifySign = table.Column<string>(nullable: true),
                    PayerEmail = table.Column<string>(nullable: true),
                    TxnId = table.Column<string>(nullable: true),
                    PaymentType = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    AddressState = table.Column<string>(nullable: true),
                    ReceiverEmail = table.Column<string>(nullable: true),
                    PaymentFee = table.Column<decimal>(nullable: false),
                    ReceiverId = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    McCurrency = table.Column<string>(nullable: true),
                    ItemNumber = table.Column<string>(nullable: true),
                    ResidenceCountry = table.Column<string>(nullable: true),
                    TestIpn = table.Column<string>(nullable: true),
                    HandlingAmount = table.Column<string>(nullable: true),
                    TransactionSubject = table.Column<string>(nullable: true),
                    PaymentGross = table.Column<decimal>(nullable: false),
                    Shipping = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayPalIPNMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Name = table.Column<string>(nullable: false),
                    PermissionLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailedTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    FailDate = table.Column<DateTime>(nullable: false),
                    KreditAmount = table.Column<int>(nullable: false),
                    BillingTransactionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailedTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FailedTransactions_BillingTransactions_BillingTransactionId",
                        column: x => x.BillingTransactionId,
                        principalTable: "BillingTransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlinePlayerStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    OnlinePlayerCount = table.Column<int>(nullable: false),
                    GameServerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlinePlayerStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlinePlayerStates_GameServers_GameServerId",
                        column: x => x.GameServerId,
                        principalTable: "GameServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Name = table.Column<string>(nullable: false),
                    PricePerMonth = table.Column<int>(nullable: false),
                    PermanentPrice = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InGameActivatorCommand = table.Column<string>(nullable: true),
                    InGameDeactivatorCommand = table.Column<string>(nullable: true),
                    OneTimeCommand = table.Column<string>(nullable: true),
                    IsRank = table.Column<bool>(nullable: false),
                    ProductCategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Currency = table.Column<int>(nullable: false),
                    HyCoin = table.Column<int>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    LastAuthenticationIp = table.Column<string>(nullable: false),
                    LastAuthenticationDate = table.Column<DateTime>(nullable: false),
                    IsBanned = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_UserName", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarionTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    PaymentId = table.Column<Guid>(nullable: false),
                    IsFinished = table.Column<bool>(nullable: false),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    KreditAmount = table.Column<double>(nullable: false),
                    TotalCost = table.Column<double>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarionTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarionTransactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientIdentities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BaseValue = table.Column<string>(nullable: true),
                    ValidatorHash = table.Column<string>(nullable: true),
                    ValidatorSalt = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientIdentities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailVerificationCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ActivationCode = table.Column<Guid>(nullable: false),
                    IsActivated = table.Column<bool>(nullable: false),
                    EmailToVerify = table.Column<string>(nullable: true),
                    ActivationTimeStamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailVerificationCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailVerificationCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JatekfizetesRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ClientIP = table.Column<string>(nullable: false),
                    CallDate = table.Column<DateTime>(nullable: false),
                    IsActivationSuccessful = table.Column<bool>(nullable: false),
                    CallerUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JatekfizetesRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JatekfizetesRequests_Users_CallerUserId",
                        column: x => x.CallerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KreditGifts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    KreditGiftAmount = table.Column<int>(nullable: false),
                    SenderUserId = table.Column<Guid>(nullable: false),
                    ReceiverUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KreditGifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KreditGifts_Users_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KreditGifts_Users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KreditPurchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    KreditValue = table.Column<int>(nullable: false),
                    CurrencyValue = table.Column<int>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KreditPurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KreditPurchases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MassKreditUserActivations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    MassKreditActivationCodeId = table.Column<Guid>(nullable: false),
                    ActivationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassKreditUserActivations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MassKreditUserActivations_MassKreditActivationCodes_MassKred~",
                        column: x => x.MassKreditActivationCodeId,
                        principalTable: "MassKreditActivationCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MassKreditUserActivations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Title = table.Column<string>(nullable: false),
                    Preview = table.Column<string>(nullable: true),
                    FormattedNews = table.Column<string>(nullable: false),
                    PublisherUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Users_PublisherUserId",
                        column: x => x.PublisherUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordResetCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Code = table.Column<Guid>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResetCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordResetCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayPalTransactionRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    IsRequestProcessed = table.Column<bool>(nullable: false),
                    RequesterUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayPalTransactionRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayPalTransactionRequests_Users_RequesterUserId",
                        column: x => x.RequesterUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    LastPurchaseDate = table.Column<DateTime>(nullable: false),
                    IsPermanent = table.Column<bool>(nullable: false),
                    IsRepeatable = table.Column<bool>(nullable: false),
                    IsOverwrittenByOtherRank = table.Column<bool>(nullable: false),
                    ValidityPeriodInMonths = table.Column<int>(nullable: false),
                    KreditSpentOn = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarionBillingAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Street2 = table.Column<string>(nullable: true),
                    Street3 = table.Column<string>(nullable: true),
                    BarionTransactionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarionBillingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarionBillingAddresses_BarionTransactions_BarionTransactionId",
                        column: x => x.BarionTransactionId,
                        principalTable: "BarionTransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EDSMSPurchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ActivationCode = table.Column<string>(nullable: true),
                    KreditPurchaseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDSMSPurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EDSMSPurchases_KreditPurchases_KreditPurchaseId",
                        column: x => x.KreditPurchaseId,
                        principalTable: "KreditPurchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    IsActivationVerified = table.Column<bool>(nullable: false),
                    IsExpirationVerified = table.Column<bool>(nullable: false),
                    GameServerId = table.Column<Guid>(nullable: false),
                    PurchasedProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseStates_GameServers_GameServerId",
                        column: x => x.GameServerId,
                        principalTable: "GameServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseStates_PurchasedProducts_PurchasedProductId",
                        column: x => x.PurchasedProductId,
                        principalTable: "PurchasedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("1fd9c757-b958-47b3-a034-57b3d36a5f31"), new DateTime(2021, 1, 30, 14, 40, 53, 406, DateTimeKind.Local).AddTicks(9795), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("3694ccca-8c28-4620-b9d8-8b9985b78a11"), new DateTime(2021, 1, 30, 14, 40, 53, 402, DateTimeKind.Local).AddTicks(8796), true, true, "GTA" },
                    { new Guid("5c735c90-4f3c-4a92-92e7-a341faeff22b"), new DateTime(2021, 1, 30, 14, 40, 53, 405, DateTimeKind.Local).AddTicks(8580), true, true, "Survival" },
                    { new Guid("12496520-53cc-411b-8779-6e40ce6dcb74"), new DateTime(2021, 1, 30, 14, 40, 53, 405, DateTimeKind.Local).AddTicks(8627), true, true, "Skyblock" },
                    { new Guid("d54fd439-aeae-45f3-b09f-0aa887849e2d"), new DateTime(2021, 1, 30, 14, 40, 53, 405, DateTimeKind.Local).AddTicks(8633), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "IsActive", "IsUsed", "Priority" },
                values: new object[,]
                {
                    { new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"), "Rangok", new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(1471), true, false, 1 },
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Egyéb", new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(2337), true, false, 2 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(1056), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(2557), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("49784b23-34cd-4c33-9bf0-0e11eb1257d6"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(2971), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e63ca554-0cc4-46ba-b633-ee25e6fcb17c"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7177), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6a78ee24-2c4d-4a83-8b13-115e29a1c6b5"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7276), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("768485cc-2f47-4106-bcaa-b7806429169c"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7284), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("97c04caf-0d7e-4a86-a491-e0d4da229461"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7291), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("886cf03f-94b7-49d1-a9a6-2bd023d60030"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7297), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7877), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7882), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7885), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(3327), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(5099), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(6000), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7773), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7827), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7841), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" }
                });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("d0ff8355-5435-4a0f-b1f8-cb84af014dd2"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(855), new DateTime(2021, 1, 30, 15, 40, 53, 408, DateTimeKind.Local).AddTicks(858), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("46243715-e660-4b96-8fc0-fb7a029305f0"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(8570), new DateTime(2021, 1, 30, 15, 40, 53, 407, DateTimeKind.Local).AddTicks(9821), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d12e53d6-569e-45d9-af63-2a9cda41d3a0"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(802), new DateTime(2021, 1, 30, 15, 40, 53, 408, DateTimeKind.Local).AddTicks(832), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("5978f06a-7e38-411e-883c-45abbb2a794f"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5431), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c86823a7-6262-4de2-ae92-379bf83bc78f"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5423), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ff3fb95f-e665-4e93-9346-a76236698021"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5286), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("61d2a262-9c79-4203-b37a-9320d84311fe"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5278), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3021f239-2211-46d8-91af-4e6196a2faaf"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5271), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7925a8be-3882-4c52-8e69-20efef0e4957"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5263), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3a0ca54-3f87-47e2-860d-6ed50db736bf"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5254), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("289f806c-e12d-476f-be0a-ff7069ac8157"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5244), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("21a878e8-43eb-4876-bda8-fb6c0a7e74d6"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5235), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7b541273-1406-413a-a6e0-395a35b764ff"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5228), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3cb0c557-704c-4594-815c-bde4bf895c16"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5219), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4514e774-8948-4646-9118-2cc8d69eeb17"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4932), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9c5dd261-3849-462c-bc68-8e12ec164efb"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4940), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b5ce9eaf-7f85-4145-b058-95bf8b1a4a02"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4857), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("41af7f29-6240-4aca-875e-4c316cb8b774"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4916), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ab98bb28-f23d-488c-a589-099cf4c069e9"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4906), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bd5ce008-7568-4cf6-8717-cab5826424bb"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4897), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0af0cca4-3277-47f9-9b4c-90d62f24de87"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4890), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("631ff4f8-5143-4d19-bd34-c44336e345d1"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4881), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("af7a6fae-5dca-4958-a834-3efd33b3dd3f"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4873), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9bd3c91-baec-4c21-81d1-86a3365dc14d"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4865), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4f1c6204-d86b-426e-b561-344cf7d8f59b"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4924), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e9220562-8f79-4441-84ae-f1b3894e06d5"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4847), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("516d9e1c-1d47-4a11-a91f-36337dab9de8"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4730), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("cef1ef3a-b7f1-432d-9619-3b3d0ebbd4bd"), new DateTime(2021, 1, 30, 14, 40, 3, 409, DateTimeKind.Local).AddTicks(1908), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("75d0c0b4-b35f-49e3-a670-f6621dc46ee9"), new DateTime(2021, 1, 30, 14, 39, 13, 409, DateTimeKind.Local).AddTicks(1900), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("b20244d8-9c82-4ca8-8863-da5ae9977455"), new DateTime(2021, 1, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(1916), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("2d39217a-51bd-4ae8-aac1-94b2611ce9b2"), new DateTime(2021, 1, 30, 14, 37, 33, 409, DateTimeKind.Local).AddTicks(1335), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("ad4e4ce6-f2e2-4181-b135-5bab3dbda342"), new DateTime(2021, 1, 30, 14, 38, 23, 409, DateTimeKind.Local).AddTicks(1885), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b58f3c07-2879-434c-97e5-192d8e678121"), new Guid("02c27cf0-96e7-4a79-b471-b024965fb236"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(8968), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("69ef5ac7-2368-42b4-8f7d-1c678263ed49"), new Guid("dfc9fa8e-fb0b-49a6-8bb8-932170f3a279"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7979), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BarionBillingAddresses_BarionTransactionId",
                table: "BarionBillingAddresses",
                column: "BarionTransactionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarionTransactions_UserId",
                table: "BarionTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientIdentities_UserId",
                table: "ClientIdentities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EDSMSPurchases_KreditPurchaseId",
                table: "EDSMSPurchases",
                column: "KreditPurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerificationCodes_UserId",
                table: "EmailVerificationCodes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactions_BillingTransactionId",
                table: "FailedTransactions",
                column: "BillingTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_JatekfizetesRequests_CallerUserId",
                table: "JatekfizetesRequests",
                column: "CallerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KreditGifts_ReceiverUserId",
                table: "KreditGifts",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KreditGifts_SenderUserId",
                table: "KreditGifts",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KreditPurchases_UserId",
                table: "KreditPurchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MassKreditUserActivations_MassKreditActivationCodeId",
                table: "MassKreditUserActivations",
                column: "MassKreditActivationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_MassKreditUserActivations_UserId",
                table: "MassKreditUserActivations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_PublisherUserId",
                table: "News",
                column: "PublisherUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlinePlayerStates_GameServerId",
                table: "OnlinePlayerStates",
                column: "GameServerId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResetCodes_UserId",
                table: "PasswordResetCodes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PayPalTransactionRequests_RequesterUserId",
                table: "PayPalTransactionRequests",
                column: "RequesterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_ProductId",
                table: "PurchasedProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_UserId",
                table: "PurchasedProducts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseStates_GameServerId",
                table: "PurchaseStates",
                column: "GameServerId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseStates_PurchasedProductId",
                table: "PurchaseStates",
                column: "PurchasedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActualValueOfOneKredit");

            migrationBuilder.DropTable(
                name: "BarionBillingAddresses");

            migrationBuilder.DropTable(
                name: "BlacklistedIPs");

            migrationBuilder.DropTable(
                name: "ClientIdentities");

            migrationBuilder.DropTable(
                name: "EDSMSPurchases");

            migrationBuilder.DropTable(
                name: "EmailVerificationCodes");

            migrationBuilder.DropTable(
                name: "FailedTransactions");

            migrationBuilder.DropTable(
                name: "JatekfizetesRequests");

            migrationBuilder.DropTable(
                name: "KreditGifts");

            migrationBuilder.DropTable(
                name: "MassKreditUserActivations");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "OnlinePlayerStates");

            migrationBuilder.DropTable(
                name: "PasswordResetCodes");

            migrationBuilder.DropTable(
                name: "PayPalIPNMessages");

            migrationBuilder.DropTable(
                name: "PayPalTransactionRequests");

            migrationBuilder.DropTable(
                name: "PurchaseStates");

            migrationBuilder.DropTable(
                name: "BarionTransactions");

            migrationBuilder.DropTable(
                name: "KreditPurchases");

            migrationBuilder.DropTable(
                name: "BillingTransactions");

            migrationBuilder.DropTable(
                name: "MassKreditActivationCodes");

            migrationBuilder.DropTable(
                name: "GameServers");

            migrationBuilder.DropTable(
                name: "PurchasedProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
