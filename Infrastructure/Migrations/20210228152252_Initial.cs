using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "billingobankaccounts",
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
                    table.PrimaryKey("PK_billingobankaccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "billingobillingaddresses",
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
                    table.PrimaryKey("PK_billingobillingaddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "billingtransactions",
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
                    table.PrimaryKey("PK_billingtransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "blacklistedips",
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
                    table.PrimaryKey("PK_blacklistedips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gameservers",
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
                    table.PrimaryKey("PK_gameservers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "masskreditactivationcodes",
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
                    table.PrimaryKey("PK_masskreditactivationcodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "paypalipnmessages",
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
                    table.PrimaryKey("PK_paypalipnmessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productcategories",
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
                    table.PrimaryKey("PK_productcategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
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
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "billingodocuments",
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
                    table.PrimaryKey("PK_billingodocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_billingodocuments_billingobankaccounts_BillingoBankAccountId",
                        column: x => x.BillingoBankAccountId,
                        principalTable: "billingobankaccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "onlineplayerstates",
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
                    table.PrimaryKey("PK_onlineplayerstates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_onlineplayerstates_gameservers_GameServerId",
                        column: x => x.GameServerId,
                        principalTable: "gameservers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
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
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_gameservers_GameServerId",
                        column: x => x.GameServerId,
                        principalTable: "gameservers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productcategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "productcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
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
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.UniqueConstraint("AK_users_UserName", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_users_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banktransfers",
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
                    table.PrimaryKey("PK_banktransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_banktransfers_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bariontransactions",
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
                    table.PrimaryKey("PK_bariontransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bariontransactions_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "billingopartners",
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
                    table.PrimaryKey("PK_billingopartners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_billingopartners_billingobillingaddresses_BillingoBillingAdd~",
                        column: x => x.BillingoBillingAddressId,
                        principalTable: "billingobillingaddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_billingopartners_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientidentities",
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
                    table.PrimaryKey("PK_clientidentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientidentities_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "discorduserids",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    DiscordId = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discorduserids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_discorduserids_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emailverificationcodes",
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
                    table.PrimaryKey("PK_emailverificationcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emailverificationcodes_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "failedbillingtransactions",
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
                    table.PrimaryKey("PK_failedbillingtransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_failedbillingtransactions_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jatekfizetesrequests",
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
                    table.PrimaryKey("PK_jatekfizetesrequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jatekfizetesrequests_users_CallerUserId",
                        column: x => x.CallerUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kreditgifts",
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
                    table.PrimaryKey("PK_kreditgifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kreditgifts_users_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kreditgifts_users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kreditpurchases",
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
                    table.PrimaryKey("PK_kreditpurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kreditpurchases_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "masskredituseractivations",
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
                    table.PrimaryKey("PK_masskredituseractivations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_masskredituseractivations_masskreditactivationcodes_MassKred~",
                        column: x => x.MassKreditActivationCodeId,
                        principalTable: "masskreditactivationcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_masskredituseractivations_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "news",
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
                    table.PrimaryKey("PK_news", x => x.Id);
                    table.ForeignKey(
                        name: "FK_news_users_PublisherUserId",
                        column: x => x.PublisherUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notifications",
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
                    table.PrimaryKey("PK_notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notifications_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "passwordresetcodes",
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
                    table.PrimaryKey("PK_passwordresetcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_passwordresetcodes_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "paypaltransactionrequests",
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
                    table.PrimaryKey("PK_paypaltransactionrequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paypaltransactionrequests_users_RequesterUserId",
                        column: x => x.RequesterUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchasedproducts",
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
                    table.PrimaryKey("PK_purchasedproducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchasedproducts_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchasedproducts_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banktransferbillingaddresses",
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
                    table.PrimaryKey("PK_banktransferbillingaddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_banktransferbillingaddresses_banktransfers_BankTransferId",
                        column: x => x.BankTransferId,
                        principalTable: "banktransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "barionbillingaddresses",
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
                    table.PrimaryKey("PK_barionbillingaddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_barionbillingaddresses_bariontransactions_BarionTransactionId",
                        column: x => x.BarionTransactionId,
                        principalTable: "bariontransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "edsmspurchases",
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
                    table.PrimaryKey("PK_edsmspurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edsmspurchases_kreditpurchases_KreditPurchaseId",
                        column: x => x.KreditPurchaseId,
                        principalTable: "kreditpurchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchasestates",
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
                    table.PrimaryKey("PK_purchasestates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchasestates_gameservers_GameServerId",
                        column: x => x.GameServerId,
                        principalTable: "gameservers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchasestates_purchasedproducts_PurchasedProductId",
                        column: x => x.PurchasedProductId,
                        principalTable: "purchasedproducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "gameservers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), new DateTime(2021, 2, 28, 16, 22, 52, 238, DateTimeKind.Local).AddTicks(5479), true, true, "GTA" },
                    { new Guid("da63d425-257a-4bf2-8426-971965f7a7a9"), new DateTime(2021, 2, 28, 16, 22, 52, 241, DateTimeKind.Local).AddTicks(4980), true, true, "Survival" },
                    { new Guid("5d772d0c-ec24-460c-a2bb-c9f0fb8817f0"), new DateTime(2021, 2, 28, 16, 22, 52, 241, DateTimeKind.Local).AddTicks(5029), true, true, "Skyblock" },
                    { new Guid("390bf1b2-fb89-4016-8ee0-d07a7d73714b"), new DateTime(2021, 2, 28, 16, 22, 52, 241, DateTimeKind.Local).AddTicks(5035), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "productcategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "ImageUrl", "IsActive", "Priority" },
                values: new object[,]
                {
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Csomagok", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(7113), "http://localhost:4200/assets/img/debit-card-icon.png", true, 1 },
                    { new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Petek", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(8562), "http://localhost:4200/assets/img/debit-card-icon.png", true, 2 },
                    { new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Extrák", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(8599), "http://localhost:4200/assets/img/debit-card-icon.png", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("d7f82277-bcf9-4eae-8222-92655d725daf"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(3755), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("1114fc1f-3c77-48f8-80eb-d0f85aa672a4"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(4193), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("8669b0de-a542-4385-bb5d-1a15d9e82682"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(4219), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("389de35b-b63f-4e1a-907f-e13d10c8a2d3"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(4223), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("819c31e0-0e11-4f51-aad9-9713b82ce35d"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(4227), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("16803032-b77e-485b-a42b-6dbd84aba292"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(4235), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 2, 28, 16, 22, 52, 242, DateTimeKind.Local).AddTicks(6492), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 2, 28, 16, 22, 52, 242, DateTimeKind.Local).AddTicks(7542), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("198255bf-562e-443b-b166-79a619d5af27"), new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(9238), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("24ecfd73-195c-49e7-b8e0-c81c302a8d35"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(3631), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("aa091738-1e74-4d4e-9827-ededed1603d9"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(3739), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 1", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("25a4ea09-9b70-4ceb-9384-dd59d1ab2c1c"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(3747), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 2", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(3306), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(3311), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(3314), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 2, 28, 16, 22, 52, 242, DateTimeKind.Local).AddTicks(8675), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(459), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(1372), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(3198), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(3239), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(3255), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" }
                });

            migrationBuilder.InsertData(
                table: "clientidentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("0722b542-8488-4861-b8bf-75cebe5fbd96"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(6456), new DateTime(2021, 2, 28, 16, 23, 52, 243, DateTimeKind.Local).AddTicks(6459), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("a34baa3f-9d2a-4081-87ae-69af5e957e58"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(4104), new DateTime(2021, 2, 28, 16, 23, 52, 243, DateTimeKind.Local).AddTicks(5392), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("6e887037-6ca8-4c79-a84c-6fefeadfdf9e"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 28, 16, 22, 52, 243, DateTimeKind.Local).AddTicks(6402), new DateTime(2021, 2, 28, 16, 23, 52, 243, DateTimeKind.Local).AddTicks(6433), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "kreditpurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("9a3755da-4f06-4fbf-9bec-b78ba5a5595a"), new DateTime(2021, 1, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1861), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3978b1cd-52e7-40f5-8511-c7ae61acd39f"), new DateTime(2021, 1, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1854), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("488d0b3b-db1c-4f49-92be-330b61b295ce"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1804), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1fd31627-0deb-4096-93f1-fe00df78742c"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1797), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4dcfa216-c332-4488-81a8-dd69c4490157"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1789), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ec27786f-8059-40ea-8512-91584cfec00d"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1782), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b41754b7-bc1b-44dd-83a3-31866a460b35"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1775), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9e9cff26-dd27-4214-bcab-65f4a73ed96d"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1767), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ea7da71a-1791-40c1-9a14-f957d75b7b74"), new DateTime(2020, 10, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1760), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d3f3cfe4-0001-4497-a56f-d05d9b40f02b"), new DateTime(2021, 1, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1752), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("985f442b-a8e7-490c-9179-4a03dd33cfa6"), new DateTime(2021, 1, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1743), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("873fd677-c45e-4ed3-8737-6e18aa0f1c09"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1728), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3b7b9bbf-3041-44f4-af28-f611c8f99661"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1735), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f9579daa-0f66-44de-b198-bd905c6a2eae"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1655), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("885e32bf-9a05-4f21-9ed8-9d4c7284503c"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1713), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("857e5164-32af-4638-bbf6-2ba0c29e961c"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1706), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("09b2f047-3b0d-4841-8519-e5d267c19198"), new DateTime(2020, 10, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1698), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("304b88ff-c790-4ebb-9cac-ddd18ee209f5"), new DateTime(2020, 10, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1691), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a83ab72d-7310-4782-a428-a8a402d50fca"), new DateTime(2021, 1, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1678), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bdf4817e-3cbf-4880-bf9d-5d841a38326d"), new DateTime(2020, 12, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1670), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9c575dcc-bc44-4ce6-9431-7eff1544f68f"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1663), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb7a5108-17b2-47d7-a561-67da362c690e"), new DateTime(2020, 11, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1720), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dca48ef1-5fae-4eeb-a44a-da36893d2e51"), new DateTime(2020, 10, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1645), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("07678a85-447e-4f0f-aa5c-0db96591515f"), new DateTime(2020, 10, 28, 16, 22, 52, 245, DateTimeKind.Local).AddTicks(1530), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "news",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("088b8bad-9705-494f-98c1-842c75b78e9a"), new DateTime(2021, 2, 28, 16, 22, 2, 244, DateTimeKind.Local).AddTicks(9110), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("23c123e9-c335-44c5-95fb-0c7d2551d3b1"), new DateTime(2021, 2, 28, 16, 21, 12, 244, DateTimeKind.Local).AddTicks(9098), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("029995cd-974d-408f-a290-a2840ee032e2"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(9117), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("2dd33c96-2ff5-4fd5-ba72-29fff2c98467"), new DateTime(2021, 2, 28, 16, 19, 32, 244, DateTimeKind.Local).AddTicks(8515), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("30c2b5fa-c320-4140-b1eb-687c3d36f99b"), new DateTime(2021, 2, 28, 16, 20, 22, 244, DateTimeKind.Local).AddTicks(9078), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "passwordresetcodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("af6ab1bf-d450-401f-b766-611a7a389f68"), new Guid("b872d02b-d102-46fc-94ef-924c9971436c"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(6059), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("dab3af88-ae2f-408b-bd41-9020b7d223f5"), new Guid("c4b15fd9-7982-4603-8da9-3bbad190374d"), new DateTime(2021, 2, 28, 16, 22, 52, 244, DateTimeKind.Local).AddTicks(5047), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_banktransferbillingaddresses_BankTransferId",
                table: "banktransferbillingaddresses",
                column: "BankTransferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_banktransfers_UserId",
                table: "banktransfers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_barionbillingaddresses_BarionTransactionId",
                table: "barionbillingaddresses",
                column: "BarionTransactionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_bariontransactions_UserId",
                table: "bariontransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_billingodocuments_BillingoBankAccountId",
                table: "billingodocuments",
                column: "BillingoBankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_billingopartners_BillingoBillingAddressId",
                table: "billingopartners",
                column: "BillingoBillingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_billingopartners_UserId",
                table: "billingopartners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_clientidentities_UserId",
                table: "clientidentities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_discorduserids_UserId",
                table: "discorduserids",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edsmspurchases_KreditPurchaseId",
                table: "edsmspurchases",
                column: "KreditPurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_emailverificationcodes_UserId",
                table: "emailverificationcodes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_failedbillingtransactions_UserId",
                table: "failedbillingtransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_jatekfizetesrequests_CallerUserId",
                table: "jatekfizetesrequests",
                column: "CallerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_kreditgifts_ReceiverUserId",
                table: "kreditgifts",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_kreditgifts_SenderUserId",
                table: "kreditgifts",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_kreditpurchases_UserId",
                table: "kreditpurchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_masskredituseractivations_MassKreditActivationCodeId",
                table: "masskredituseractivations",
                column: "MassKreditActivationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_masskredituseractivations_UserId",
                table: "masskredituseractivations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_news_PublisherUserId",
                table: "news",
                column: "PublisherUserId");

            migrationBuilder.CreateIndex(
                name: "IX_notifications_UserId",
                table: "notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_onlineplayerstates_GameServerId",
                table: "onlineplayerstates",
                column: "GameServerId");

            migrationBuilder.CreateIndex(
                name: "IX_passwordresetcodes_UserId",
                table: "passwordresetcodes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_paypaltransactionrequests_RequesterUserId",
                table: "paypaltransactionrequests",
                column: "RequesterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_products_GameServerId",
                table: "products",
                column: "GameServerId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductCategoryId",
                table: "products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasedproducts_ProductId",
                table: "purchasedproducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasedproducts_UserId",
                table: "purchasedproducts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasestates_GameServerId",
                table: "purchasestates",
                column: "GameServerId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasestates_PurchasedProductId",
                table: "purchasestates",
                column: "PurchasedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_users_RoleId",
                table: "users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banktransferbillingaddresses");

            migrationBuilder.DropTable(
                name: "barionbillingaddresses");

            migrationBuilder.DropTable(
                name: "billingodocuments");

            migrationBuilder.DropTable(
                name: "billingopartners");

            migrationBuilder.DropTable(
                name: "billingtransactions");

            migrationBuilder.DropTable(
                name: "blacklistedips");

            migrationBuilder.DropTable(
                name: "clientidentities");

            migrationBuilder.DropTable(
                name: "discorduserids");

            migrationBuilder.DropTable(
                name: "edsmspurchases");

            migrationBuilder.DropTable(
                name: "emailverificationcodes");

            migrationBuilder.DropTable(
                name: "failedbillingtransactions");

            migrationBuilder.DropTable(
                name: "jatekfizetesrequests");

            migrationBuilder.DropTable(
                name: "kreditgifts");

            migrationBuilder.DropTable(
                name: "masskredituseractivations");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "notifications");

            migrationBuilder.DropTable(
                name: "onlineplayerstates");

            migrationBuilder.DropTable(
                name: "passwordresetcodes");

            migrationBuilder.DropTable(
                name: "paypalipnmessages");

            migrationBuilder.DropTable(
                name: "paypaltransactionrequests");

            migrationBuilder.DropTable(
                name: "purchasestates");

            migrationBuilder.DropTable(
                name: "banktransfers");

            migrationBuilder.DropTable(
                name: "bariontransactions");

            migrationBuilder.DropTable(
                name: "billingobankaccounts");

            migrationBuilder.DropTable(
                name: "billingobillingaddresses");

            migrationBuilder.DropTable(
                name: "kreditpurchases");

            migrationBuilder.DropTable(
                name: "masskreditactivationcodes");

            migrationBuilder.DropTable(
                name: "purchasedproducts");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "gameservers");

            migrationBuilder.DropTable(
                name: "productcategories");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
