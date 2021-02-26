using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Infrastructure.Migrations
{
    public partial class KreditGifting : Migration
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
                    ImageUrl = table.Column<string>(nullable: true)
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
                    GameServerId = table.Column<Guid>(nullable: true),
                    ProductCategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_GameServers_GameServerId",
                        column: x => x.GameServerId,
                        principalTable: "GameServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), new DateTime(2021, 2, 26, 16, 45, 39, 457, DateTimeKind.Local).AddTicks(8876), true, true, "GTA" },
                    { new Guid("10ef2811-0534-4d3c-8171-579f3a5ffc22"), new DateTime(2021, 2, 26, 16, 45, 39, 460, DateTimeKind.Local).AddTicks(7430), true, true, "Survival" },
                    { new Guid("9076903a-5d62-4d99-88e3-40e9f8dfb252"), new DateTime(2021, 2, 26, 16, 45, 39, 460, DateTimeKind.Local).AddTicks(7473), true, true, "Skyblock" },
                    { new Guid("e7bea221-3852-4059-bd21-3d03a856729e"), new DateTime(2021, 2, 26, 16, 45, 39, 460, DateTimeKind.Local).AddTicks(7479), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "ImageUrl", "IsActive", "Priority" },
                values: new object[,]
                {
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Csomagok", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(8490), "http://localhost:4200/assets/img/debit-card-icon.png", true, 1 },
                    { new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Petek", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(9763), "http://localhost:4200/assets/img/debit-card-icon.png", true, 2 },
                    { new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Extrák", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(9800), "http://localhost:4200/assets/img/debit-card-icon.png", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("df6be124-9f9d-4206-81a9-6a57168d77ef"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(4760), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("e932821e-2bb7-4507-9085-8c6da2195926"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(5187), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("9be94a3b-4a68-4e7c-a840-93d727629ce3"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(5218), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("9d5438ef-d46c-4dce-83ff-641cc1774999"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(5222), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("47af8079-f470-470b-9c54-ffc47c7bda4f"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(5226), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("c60f06e5-4906-4a1e-8f67-b2de108b0399"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(5229), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 2, 26, 16, 45, 39, 461, DateTimeKind.Local).AddTicks(8232), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 2, 26, 16, 45, 39, 461, DateTimeKind.Local).AddTicks(9263), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("ae705afb-eee0-4bd9-be53-2c7a246449db"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(411), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("3114bc4e-befb-4125-bd5d-3fa3b160406c"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(4651), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("a0eeb377-c2c9-4fc0-99c3-ae19ef1bf5e6"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(4746), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 1", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("1818e29a-d9c9-41d8-b2b8-9ea1480129a7"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(4754), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 2", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(4900), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(4905), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(4908), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(310), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(2036), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(3009), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(4802), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(4844), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(4860), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" }
                });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("e40b25ba-10d9-4d83-8f08-6a85b14bf919"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(7855), new DateTime(2021, 2, 26, 16, 46, 39, 462, DateTimeKind.Local).AddTicks(7857), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("4f73d5c5-ff6e-4221-8e4e-7c817f53e152"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(5583), new DateTime(2021, 2, 26, 16, 46, 39, 462, DateTimeKind.Local).AddTicks(6824), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("803d8963-c1eb-4f30-a1ef-e98e54b0e2f4"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 26, 16, 45, 39, 462, DateTimeKind.Local).AddTicks(7806), new DateTime(2021, 2, 26, 16, 46, 39, 462, DateTimeKind.Local).AddTicks(7835), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("642a10d8-c9d8-40af-9626-1cbbb34e870f"), new DateTime(2021, 1, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2584), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ba03262-fbd7-4768-908a-e1bd3799e776"), new DateTime(2021, 1, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2576), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7e71db3d-402d-4e80-a1fa-d47e7df132b7"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2569), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("557f6d41-f0dc-4f5e-a331-794c1618a8c7"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2561), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("efb9c911-439f-4e3d-90dd-68d210e7556a"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2554), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("41045835-71d3-4a76-b3d3-3b16dbf355b0"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2545), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("04d54611-7342-40c1-852a-5952190e2b2a"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2537), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5f9c8464-cecb-4e4a-848e-29198022912e"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2530), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3f97a99a-5ed6-4694-9eee-61acd8a73e88"), new DateTime(2020, 10, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2523), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d41d77a1-4ea0-483a-bc5b-e35f8cdcff4b"), new DateTime(2021, 1, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2515), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("86effe34-4c0a-4cdf-9ef4-6cb0a18f145e"), new DateTime(2021, 1, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2508), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("48fe46e9-fc30-4eaf-98de-33d9a98ff953"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2492), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("56ad064b-b0fa-4425-85ca-68318aed0662"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2500), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ed962a86-44bf-4b4b-8cd0-69db6232193d"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2417), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("45a0ccd9-f103-47ad-a1c7-62543de771fb"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2475), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae262daf-b79a-4007-b909-a18e53b7d19c"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2468), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3adca4d0-30dd-4369-a8e0-46a3dd43522c"), new DateTime(2020, 10, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2461), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a5b4c3a1-6611-4e1f-9c90-e9f7e6a62b19"), new DateTime(2020, 10, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2453), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("60a42f64-db23-48eb-9849-5b43ceff7c04"), new DateTime(2021, 1, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2446), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("af84427f-071a-4246-8c84-3f169966d0bb"), new DateTime(2020, 12, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2438), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5dbaf88e-1a1a-489c-ad4f-3865f168c7a7"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2431), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("35a754f3-6248-4071-82f5-b8c2c66bd237"), new DateTime(2020, 11, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2483), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("53e18b29-0db5-4b88-bcd1-0248dd6c9ead"), new DateTime(2020, 10, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2408), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9e5a0e8-e7c0-4f54-aadc-5b25221eaf0b"), new DateTime(2020, 10, 26, 16, 45, 39, 464, DateTimeKind.Local).AddTicks(2313), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("baacd718-e958-4a4f-a13b-3a721e46a282"), new DateTime(2021, 2, 26, 16, 44, 49, 463, DateTimeKind.Local).AddTicks(9972), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("d625730d-a6a5-45bc-914d-e8217f1a3222"), new DateTime(2021, 2, 26, 16, 43, 59, 463, DateTimeKind.Local).AddTicks(9965), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("2457f87a-f6ae-4f83-a323-6673ccd2d42e"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(9979), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("508f2d3f-87a2-41ec-83ac-ee675ffe45ce"), new DateTime(2021, 2, 26, 16, 42, 19, 463, DateTimeKind.Local).AddTicks(9404), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("a7b3ebe4-2dbe-4292-9661-c587e4439e52"), new DateTime(2021, 2, 26, 16, 43, 9, 463, DateTimeKind.Local).AddTicks(9950), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("686481db-d02e-4a64-ac5f-c9340b991b61"), new Guid("ec059b21-998a-4a92-b86c-1c9d262ef764"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(6882), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("4bbf3643-7067-429c-8faf-0451cf025b7d"), new Guid("62be45a4-06e2-4595-9124-64969b0e73f5"), new DateTime(2021, 2, 26, 16, 45, 39, 463, DateTimeKind.Local).AddTicks(5909), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
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
                name: "IX_Products_GameServerId",
                table: "Products",
                column: "GameServerId");

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
                name: "PurchasedProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GameServers");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
