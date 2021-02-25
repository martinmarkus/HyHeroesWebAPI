using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Infrastructure.Migrations
{
    public partial class MigrationReplace : Migration
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
                    IsUsed = table.Column<bool>(nullable: false),
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
                    { new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), new DateTime(2021, 2, 25, 10, 54, 44, 956, DateTimeKind.Local).AddTicks(5917), true, true, "GTA" },
                    { new Guid("638a0289-07f4-41c7-87ff-36b41a606d55"), new DateTime(2021, 2, 25, 10, 54, 44, 958, DateTimeKind.Local).AddTicks(6215), true, true, "Survival" },
                    { new Guid("447b23ad-a5dc-44b7-995f-b2d315dd8dc3"), new DateTime(2021, 2, 25, 10, 54, 44, 958, DateTimeKind.Local).AddTicks(6256), true, true, "Skyblock" },
                    { new Guid("0ba4da54-7dbe-4da0-8ba4-7f66e3d8e610"), new DateTime(2021, 2, 25, 10, 54, 44, 958, DateTimeKind.Local).AddTicks(6262), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "ImageUrl", "IsActive", "IsUsed", "Priority" },
                values: new object[,]
                {
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Csomagok", new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(432), null, true, false, 1 },
                    { new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Petek", new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(856), null, true, false, 2 },
                    { new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Extrák", new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(882), null, true, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("58596b07-d003-48bc-b1a2-d39d09a10b84"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3524), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("b21c882f-ef9e-4260-abb2-690c0b52b669"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3736), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("b3bd4f70-20b2-4dfd-916f-c002340aaaf7"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3756), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("9c08784c-da04-470d-9238-8321fcd0cd70"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3760), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("d1a1680d-35e8-48fd-8011-9225f8c01ade"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3764), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("34d1ebc5-bfba-4040-b17a-9d65d0f866e4"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3767), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(4770), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(5340), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("8246f095-f712-4ab0-ba8f-1791f15ab512"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(1255), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("60750e24-a3c8-48e2-8262-3796ee5710ae"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3410), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("2bba5d99-d720-43e6-b7db-7c40e9cb42c6"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3509), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 1", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("164d9ea4-cd95-4b61-ac46-4b7d8bbc5b78"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(3517), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 2", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8412), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8417), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8420), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(6134), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(7008), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(7437), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8322), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8362), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8376), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" }
                });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("2cb13bc1-6535-42c5-93e9-416cc886867d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(9972), new DateTime(2021, 2, 25, 10, 55, 44, 959, DateTimeKind.Local).AddTicks(9975), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("867e5e62-2a24-4e25-b534-af4c6bf8fccd"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(8823), new DateTime(2021, 2, 25, 10, 55, 44, 959, DateTimeKind.Local).AddTicks(9394), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bd5dd3f3-e6c5-45c5-b921-578c9e49c001"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 25, 10, 54, 44, 959, DateTimeKind.Local).AddTicks(9916), new DateTime(2021, 2, 25, 10, 55, 44, 959, DateTimeKind.Local).AddTicks(9949), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a5e79a6-d9e8-4be3-a584-e12fd945e627"), new DateTime(2021, 1, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7884), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9fec8413-47ad-4546-8aa4-cba6d1924873"), new DateTime(2021, 1, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7877), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2982ed5e-e180-4014-93c2-5d9dd78c711f"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7870), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5bfc7480-d589-4115-8cb4-99fe7210b447"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7863), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0efef9fa-9371-486a-8908-54dfb67883b4"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7856), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8ef046a4-8667-463e-a962-b7250c5e1f05"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7849), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4a01e54d-5082-4c7d-b829-ab3160b60661"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7840), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5785f049-dbbf-4785-8077-3ad64e0da486"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7833), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a6a039e0-d181-443e-aaeb-96d90d97753b"), new DateTime(2020, 10, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7826), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dbdd7eec-4e1b-4cea-a373-cc9460c33e54"), new DateTime(2021, 1, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7819), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("103c251d-7261-42ca-be12-7623fe00e60f"), new DateTime(2021, 1, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7812), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9bf76b7d-b1b2-4ae5-9ae3-a3860538963b"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7797), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c4919d2d-bb95-4ffe-b590-a4f31b9f6227"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7804), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c53ca1fc-cdfa-4c24-96e1-237a95534616"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7729), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("00064f84-7ec7-4731-bb99-85e2a273a5d4"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7781), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("94a83fd4-d268-4502-8458-e582b08d8c1c"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7773), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("703a8eed-800d-4aec-97e3-2e532daca1ca"), new DateTime(2020, 10, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7766), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b695c868-993d-4fff-a45a-aa0f6a014c24"), new DateTime(2020, 10, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7758), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3ba56c1c-b0fb-46b2-9aa6-87a4523ebd51"), new DateTime(2021, 1, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7751), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("037890f3-93ce-42fe-b434-2cbdfe80b250"), new DateTime(2020, 12, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7743), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9959d5e2-3d6e-4c2f-969f-49cfd37728ce"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7737), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c064eee1-2aa8-489c-9134-bb15cfec9656"), new DateTime(2020, 11, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7790), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("45460b0c-47e3-45c8-a2b1-a2c6d296170e"), new DateTime(2020, 10, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7715), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("61647a69-0036-419b-abf1-4c709eb24230"), new DateTime(2020, 10, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(7612), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("af05536c-ea76-4500-b333-8f2df5a8094f"), new DateTime(2021, 2, 25, 10, 53, 54, 960, DateTimeKind.Local).AddTicks(6384), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("acbba7fd-e770-43e7-a93c-b3308e555226"), new DateTime(2021, 2, 25, 10, 53, 4, 960, DateTimeKind.Local).AddTicks(6376), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("065c08ec-eec7-4e41-b435-495d223dd081"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(6419), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("f8420023-7380-4af6-8a9e-272e0a7ae10e"), new DateTime(2021, 2, 25, 10, 51, 24, 960, DateTimeKind.Local).AddTicks(6045), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("50f185cd-c972-4cb3-b188-285183ae3b71"), new DateTime(2021, 2, 25, 10, 52, 14, 960, DateTimeKind.Local).AddTicks(6360), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b7f9a2e1-bf6c-4076-960d-f7ce0661cebc"), new Guid("d61b4599-fd9a-43eb-8217-a1e280071fbd"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(4708), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("b6e083a3-0e49-4820-b165-f6661ddf3aef"), new Guid("b7c857ea-d9da-4400-83e1-1039dd07fe30"), new DateTime(2021, 2, 25, 10, 54, 44, 960, DateTimeKind.Local).AddTicks(4196), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
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
