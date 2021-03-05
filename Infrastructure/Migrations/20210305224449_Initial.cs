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
                name: "paypalorders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    OrderId = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paypalorders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paypalorders_users_UserId",
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
                name: "PayPalLinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Method = table.Column<string>(nullable: true),
                    Rel = table.Column<string>(nullable: true),
                    Href = table.Column<string>(nullable: true),
                    PayPalOrderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayPalLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayPalLinks_paypalorders_PayPalOrderId",
                        column: x => x.PayPalOrderId,
                        principalTable: "paypalorders",
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
                    { new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), new DateTime(2021, 3, 5, 23, 44, 48, 658, DateTimeKind.Local).AddTicks(6983), true, true, "GTA" },
                    { new Guid("4848a07e-65b1-45a8-af10-60ab27ab08d8"), new DateTime(2021, 3, 5, 23, 44, 48, 661, DateTimeKind.Local).AddTicks(6249), true, true, "Survival" },
                    { new Guid("a674e481-b3f0-41e0-b95b-84f5c9e6c021"), new DateTime(2021, 3, 5, 23, 44, 48, 661, DateTimeKind.Local).AddTicks(6300), true, true, "Skyblock" },
                    { new Guid("b6f17541-6c00-47f5-800f-db68623f11ff"), new DateTime(2021, 3, 5, 23, 44, 48, 661, DateTimeKind.Local).AddTicks(6320), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "productcategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "ImageUrl", "IsActive", "Priority" },
                values: new object[,]
                {
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Csomagok", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(8180), "http://localhost:4200/assets/img/debit-card-icon.png", true, 1 },
                    { new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Petek", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(9470), "http://localhost:4200/assets/img/debit-card-icon.png", true, 2 },
                    { new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Extrák", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(9509), "http://localhost:4200/assets/img/debit-card-icon.png", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("5761fa27-8baa-40c4-8145-ddc1fc85bcc3"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(4733), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("3ebfec6d-c266-405e-8443-f813a7c176ce"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(5174), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("4df08519-1dbd-40a9-bfa0-d70bdc5e4717"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(5200), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("107c115c-d2aa-46cd-9652-8412b97976b7"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(5204), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("3bbe2f77-bd68-4eef-b7c5-bbc120027f97"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(5208), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("ec50f0c2-67aa-43d3-9906-71c771d7e06a"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(5212), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 3, 5, 23, 44, 48, 662, DateTimeKind.Local).AddTicks(7682), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 3, 5, 23, 44, 48, 662, DateTimeKind.Local).AddTicks(8836), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("2e9e9f2a-ac77-4ceb-8b42-5875607f2816"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(125), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("a0093335-3f69-430f-bd67-6d83f25b5193"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(4606), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("cb0f652f-bcf9-423b-998d-f692fd4a22b1"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(4712), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 1", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("6506636a-05a6-4ec6-89fb-f70d96a05dba"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(4720), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 2", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(4562), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(4568), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(4571), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 3, 5, 23, 44, 48, 662, DateTimeKind.Local).AddTicks(9959), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(1729), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(2629), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(4460), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(4505), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(4519), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" }
                });

            migrationBuilder.InsertData(
                table: "clientidentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("045f548f-1a0c-4d7c-a4da-57a0ed6d1953"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(7547), new DateTime(2021, 3, 5, 23, 45, 48, 663, DateTimeKind.Local).AddTicks(7550), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("042643e8-52e0-4a07-8a3f-ebfe93c7399a"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(5229), new DateTime(2021, 3, 5, 23, 45, 48, 663, DateTimeKind.Local).AddTicks(6483), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("311107d9-cad4-4c44-bd85-bb2940bdde41"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 23, 44, 48, 663, DateTimeKind.Local).AddTicks(7485), new DateTime(2021, 3, 5, 23, 45, 48, 663, DateTimeKind.Local).AddTicks(7516), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "kreditpurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("9c8024b2-25fd-40b3-be65-9fc926bb3871"), new DateTime(2021, 2, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2755), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cbebc45c-48e3-490b-83cb-fa71a2d090c2"), new DateTime(2021, 2, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2747), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b5cf9d97-b7f3-41bb-81d2-34a4cee62ef4"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2740), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("74895294-e682-4b01-a9f9-498a0d28aa40"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2732), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("75ae35fc-4676-404c-9097-85a49226430b"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2725), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9d0281b0-f646-46e5-b7b2-d3861ae21058"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2717), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7b73b210-a764-4fa1-be20-ee18fe2b6af4"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2709), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("38f364de-3a7e-40f5-9843-fb68cbfa5b99"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2699), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("70821218-a4dd-41fc-87e3-70cf3bf6c9aa"), new DateTime(2020, 11, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2691), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("66a07c9f-18e0-4db1-a46e-0e0b2a19d76f"), new DateTime(2021, 2, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2684), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7bf8a821-9c46-4e88-822b-e07d961b98c3"), new DateTime(2021, 2, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2660), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("212b9da8-9c44-4daf-9f14-e7107db0d9a4"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2643), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b0603495-237a-48da-80df-082ff41e963c"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2652), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b8bee3e-4cca-47d4-b1cd-79a8c1b9aeb7"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2527), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9cf61afa-6935-469f-b49b-38bbab6e1f27"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2627), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5e05b49b-e661-432a-b37b-95c68fd9539a"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2576), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d6016be-f641-4ee8-b295-096a3224836f"), new DateTime(2020, 11, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2568), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0d384dd9-90c8-4205-b8d2-fe0b0c16ea9c"), new DateTime(2020, 11, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2560), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0dcaa73f-db25-4c98-b990-56f2351f21c2"), new DateTime(2021, 2, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2552), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b3f358f7-aa25-439b-8ea5-ddd12c8a19c6"), new DateTime(2021, 1, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2544), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5dc62728-2510-486c-9069-47306b54a0d5"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2536), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("061ae11b-73ad-4f6f-b2ac-6b2b1e46ab84"), new DateTime(2020, 12, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2635), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb1d3963-4669-42c9-9393-b2e04904261d"), new DateTime(2020, 11, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2514), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0963add0-bf66-4b8f-8416-2836b7ceb07f"), new DateTime(2020, 11, 5, 23, 44, 48, 665, DateTimeKind.Local).AddTicks(2397), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "news",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("725b63e4-e63b-4d83-9e4a-5e26613762ea"), new DateTime(2021, 3, 5, 23, 43, 58, 664, DateTimeKind.Local).AddTicks(9931), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("0b56253d-b0a6-430e-a559-cb2564ef0d00"), new DateTime(2021, 3, 5, 23, 43, 8, 664, DateTimeKind.Local).AddTicks(9923), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("3349f93b-6299-4c65-a431-7b066389a312"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(9938), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("2b775b34-c8e9-4b4c-bf6a-1b9ebb740a9c"), new DateTime(2021, 3, 5, 23, 41, 28, 664, DateTimeKind.Local).AddTicks(9344), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("f948f08c-143a-4de7-85f5-1c250839aa4a"), new DateTime(2021, 3, 5, 23, 42, 18, 664, DateTimeKind.Local).AddTicks(9906), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "passwordresetcodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c37a8d58-d2b0-4486-92f5-d72c4838d96a"), new Guid("2932d38b-6249-4548-bb59-fab256a34425"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(6925), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("11de4180-84b9-4770-ab47-066f2414b996"), new Guid("ba07f5f7-cbee-4d53-b55b-a13596403b0e"), new DateTime(2021, 3, 5, 23, 44, 48, 664, DateTimeKind.Local).AddTicks(5903), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
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
                name: "IX_PayPalLinks_PayPalOrderId",
                table: "PayPalLinks",
                column: "PayPalOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_paypalorders_UserId",
                table: "paypalorders",
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
                name: "PayPalLinks");

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
                name: "paypalorders");

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
