using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Infrastructure.Migrations
{
    public partial class MockDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingoBankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BillingoBankAccountId = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    AccountNumberIban = table.Column<string>(nullable: true),
                    Swift = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    NeeedQr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoBankAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingoBillingAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    CountryCode = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoBillingAddresses", x => x.Id);
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
                    BillingDate = table.Column<DateTime>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    IsBilled = table.Column<bool>(nullable: false),
                    CountryCode = table.Column<string>(nullable: true),
                    Taxnumber = table.Column<string>(nullable: true),
                    ClientEmail = table.Column<string>(nullable: true),
                    ClientName = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
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
                name: "BillingoDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BillingoDocumentId = table.Column<long>(nullable: false),
                    PartnerId = table.Column<long>(nullable: false),
                    BlockId = table.Column<long>(nullable: false),
                    BankAccountId = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    FulfillmentDate = table.Column<string>(nullable: true),
                    DueDate = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    PaymentType = table.Column<string>(nullable: true),
                    ConversionRate = table.Column<int>(nullable: false),
                    Electronic = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    BillingoBankAccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingoDocuments_BillingoBankAccounts_BillingoBankAccountId",
                        column: x => x.BillingoBankAccountId,
                        principalTable: "BillingoBankAccounts",
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
                name: "BankTransfers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    KreditValue = table.Column<int>(nullable: false),
                    TransferCode = table.Column<string>(nullable: true),
                    CurrencyValue = table.Column<int>(nullable: false),
                    IsActivated = table.Column<bool>(nullable: false),
                    BillingEmail = table.Column<string>(nullable: true),
                    BillingName = table.Column<string>(nullable: true),
                    TaxNumber = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTransfers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    GatewayURL = table.Column<string>(nullable: true),
                    KreditAmount = table.Column<double>(nullable: false),
                    BillingName = table.Column<string>(nullable: true),
                    BillingEmail = table.Column<string>(nullable: true),
                    TotalCost = table.Column<double>(nullable: false),
                    TaxNumber = table.Column<string>(nullable: true),
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
                name: "BillingoPartners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BillingoPartnerId = table.Column<string>(nullable: true),
                    PartnerName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Taxcode = table.Column<string>(nullable: true),
                    Iban = table.Column<string>(nullable: true),
                    Swift = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    GeneralLedgerNumber = table.Column<string>(nullable: true),
                    TaxType = table.Column<string>(nullable: true),
                    BillingoBillingAddressId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoPartners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingoPartners_BillingoBillingAddresses_BillingoBillingAdd~",
                        column: x => x.BillingoBillingAddressId,
                        principalTable: "BillingoBillingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingoPartners_Users_UserId",
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
                    CurrencyValue = table.Column<int>(nullable: false),
                    ErrorMessage = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailedTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FailedTransactions_Users_UserId",
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
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Message = table.Column<string>(nullable: false),
                    IsOpened = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
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
                    IsOneTimeCommandRan = table.Column<bool>(nullable: false),
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
                name: "BankTransferBillingAddresses",
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
                    BankTransferId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransferBillingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTransferBillingAddresses_BankTransfers_BankTransferId",
                        column: x => x.BankTransferId,
                        principalTable: "BankTransfers",
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
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("496f0e16-94ac-49dd-8d17-99e22a3afbf8"), new DateTime(2021, 2, 22, 18, 53, 6, 63, DateTimeKind.Local).AddTicks(3343), true, true, "GTA" },
                    { new Guid("396cebb5-8cfb-4704-be97-ff462b730d3b"), new DateTime(2021, 2, 22, 18, 53, 6, 66, DateTimeKind.Local).AddTicks(3321), true, true, "Survival" },
                    { new Guid("4458b796-b25f-46a5-8131-2ff68463f2c3"), new DateTime(2021, 2, 22, 18, 53, 6, 66, DateTimeKind.Local).AddTicks(3372), true, true, "Skyblock" },
                    { new Guid("141eeb25-3ea4-4fab-93a6-84df745205e7"), new DateTime(2021, 2, 22, 18, 53, 6, 66, DateTimeKind.Local).AddTicks(3378), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "IsActive", "IsUsed", "Priority" },
                values: new object[,]
                {
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Csomagok", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(6071), true, false, 1 },
                    { new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Kisállatok", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(6967), true, false, 2 },
                    { new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Extrák", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(6997), true, false, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("3c0b3e5b-edc6-4626-85b1-55fa52eb5ed6"), new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(7672), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("6bc69d98-6713-44ec-b1df-0a02d6949483"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(1366), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("22947f9a-ec3f-4e94-93fb-32c695298df6"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(1447), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("9e72ba5c-f95e-480a-a7e1-b6c738988d87"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(1452), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("b50938df-2150-446b-8203-21c4b74bc88e"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(1456), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("9b54f03f-5dae-4c31-9bf6-0cadfa33b96b"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(1461), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 2, 22, 18, 53, 6, 67, DateTimeKind.Local).AddTicks(4839), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 2, 22, 18, 53, 6, 67, DateTimeKind.Local).AddTicks(6532), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[] { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2265), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2270), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2273), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[] { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 2, 22, 18, 53, 6, 67, DateTimeKind.Local).AddTicks(7657), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 2, 22, 18, 53, 6, 67, DateTimeKind.Local).AddTicks(9410), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(319), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[] { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2133), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2175), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2193), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("de9bc043-12cc-4abd-853f-9a521a128fb1"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(5404), new DateTime(2021, 2, 22, 18, 54, 6, 68, DateTimeKind.Local).AddTicks(5408), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("7b6b9c71-74e7-4846-b920-788c73745a9e"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(2958), new DateTime(2021, 2, 22, 18, 54, 6, 68, DateTimeKind.Local).AddTicks(4289), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("2c77af8b-e562-43e2-9127-8afbf8e7a81b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 22, 18, 53, 6, 68, DateTimeKind.Local).AddTicks(5351), new DateTime(2021, 2, 22, 18, 54, 6, 68, DateTimeKind.Local).AddTicks(5382), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("3130c324-3eeb-4a50-9eeb-fb08d830613f"), new DateTime(2021, 1, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9133), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ba235de-0564-424b-9668-16143290a2a4"), new DateTime(2021, 1, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9124), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0f6a4c53-171e-4b30-a250-a44393f33fba"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9115), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f3a65b98-b4cf-4d77-9f44-0ef627db848a"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9107), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("de92dcff-2a6e-424b-9c67-b4b824856a05"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9099), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6d3e4696-07f5-4747-91eb-b95f46f52077"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9092), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a0ab4679-7f3e-4da9-bbb4-313aba53b21b"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9081), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("825161c6-0d59-41b3-9c4d-1d071c4e29f5"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9073), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9df4aee6-4ce1-481c-862a-60c0dfc2b2b3"), new DateTime(2020, 10, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9022), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("799a5b43-8f67-42d3-a62c-82848732d06d"), new DateTime(2021, 1, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9014), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4b677179-98de-476d-8130-f4f13cb9f53d"), new DateTime(2021, 1, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(9007), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7146856c-06ec-4642-9458-f55c28e9c7c3"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8991), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7532dcdd-71f1-4018-8940-8144310e3110"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8999), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f8c41ec1-4e79-49e6-9da7-0ecb8ca8883a"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8915), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6fc86af8-4678-4e87-98cd-1cd1e4ce42e6"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8973), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f1d46809-d22b-4844-a94e-dc97701b1524"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8965), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("66e00303-c258-42af-a8f2-869f25d658a4"), new DateTime(2020, 10, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8956), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b10fefe1-22dd-409c-ab9c-b6509af27a12"), new DateTime(2020, 10, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8949), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("066df35b-8b78-442e-baaa-3ab0b8bcc8ef"), new DateTime(2021, 1, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8940), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5b29223c-2b67-4e0b-96c0-b35065d095c9"), new DateTime(2020, 12, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8932), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("952bbb65-3b29-4368-ab63-fae4cf9d1d92"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8924), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("790e6679-126f-419a-9c52-b9cb9765cd03"), new DateTime(2020, 11, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8983), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6f9f394a-c6c8-4eec-9f63-da0e6287bc73"), new DateTime(2020, 10, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8900), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("be3d84e2-a13e-4f8a-a3fa-035ce969218f"), new DateTime(2020, 10, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(8794), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("943157e4-8201-41d8-bd4f-2f04dcf949c1"), new DateTime(2021, 2, 22, 18, 52, 16, 69, DateTimeKind.Local).AddTicks(6239), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("071acf1e-1380-4dba-9491-56d6fbe870ce"), new DateTime(2021, 2, 22, 18, 51, 26, 69, DateTimeKind.Local).AddTicks(6232), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("0c65c40a-b047-4456-b3c4-08be76117cce"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(6247), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("0ebb0724-bab6-4f49-9939-d327e59a5908"), new DateTime(2021, 2, 22, 18, 49, 46, 69, DateTimeKind.Local).AddTicks(5649), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("4789ad05-78c1-4711-9e99-ade208109295"), new DateTime(2021, 2, 22, 18, 50, 36, 69, DateTimeKind.Local).AddTicks(6214), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("58b60856-a274-49f5-9725-d0986de4d8bb"), new Guid("5a95673c-ca3d-46a3-a4a7-c27b9672fb1c"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(3186), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("3f977f8c-c4f1-414c-8be7-ba12a9be0596"), new Guid("bae6737a-b821-4b11-8db1-be59c7160fa0"), new DateTime(2021, 2, 22, 18, 53, 6, 69, DateTimeKind.Local).AddTicks(2172), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankTransferBillingAddresses_BankTransferId",
                table: "BankTransferBillingAddresses",
                column: "BankTransferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankTransfers_UserId",
                table: "BankTransfers",
                column: "UserId");

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
                name: "IX_BillingoDocuments_BillingoBankAccountId",
                table: "BillingoDocuments",
                column: "BillingoBankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingoPartners_BillingoBillingAddressId",
                table: "BillingoPartners",
                column: "BillingoBillingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillingoPartners_UserId",
                table: "BillingoPartners",
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
                name: "IX_FailedTransactions_UserId",
                table: "FailedTransactions",
                column: "UserId");

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
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

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
                name: "BankTransferBillingAddresses");

            migrationBuilder.DropTable(
                name: "BarionBillingAddresses");

            migrationBuilder.DropTable(
                name: "BillingoDocuments");

            migrationBuilder.DropTable(
                name: "BillingoPartners");

            migrationBuilder.DropTable(
                name: "BillingTransactions");

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
                name: "Notifications");

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
                name: "BankTransfers");

            migrationBuilder.DropTable(
                name: "BarionTransactions");

            migrationBuilder.DropTable(
                name: "BillingoBankAccounts");

            migrationBuilder.DropTable(
                name: "BillingoBillingAddresses");

            migrationBuilder.DropTable(
                name: "KreditPurchases");

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
