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
                    BillingEmail = table.Column<string>(nullable: true),
                    BillingName = table.Column<string>(nullable: true),
                    IsFinished = table.Column<bool>(nullable: false),
                    TaxNumber = table.Column<string>(nullable: true),
                    KreditAmount = table.Column<int>(nullable: false),
                    CurrencyValue = table.Column<int>(nullable: false),
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
                name: "paypalbillingaddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    PayPalOrderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paypalbillingaddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paypalbillingaddress_paypalorders_PayPalOrderId",
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
                    { new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), new DateTime(2021, 3, 11, 20, 51, 26, 342, DateTimeKind.Local).AddTicks(4356), true, true, "Szerver 1" },
                    { new Guid("8016fd7a-4da9-44a9-9b30-838faff28c86"), new DateTime(2021, 3, 11, 20, 51, 26, 345, DateTimeKind.Local).AddTicks(2825), true, true, "SuSzerver 2" },
                    { new Guid("4e7898e6-6aa4-4af2-b58b-ff8325ef2213"), new DateTime(2021, 3, 11, 20, 51, 26, 345, DateTimeKind.Local).AddTicks(2875), true, true, "Szerver 3" },
                    { new Guid("b3c197ff-6e00-42bd-9071-2cda661bbb50"), new DateTime(2021, 3, 11, 20, 51, 26, 345, DateTimeKind.Local).AddTicks(2882), true, false, "Szerver 4" }
                });

            migrationBuilder.InsertData(
                table: "productcategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "ImageUrl", "IsActive", "Priority" },
                values: new object[,]
                {
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Kategória 1", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(5433), "http://localhost:4200/assets/img/debit-card-icon.png", true, 1 },
                    { new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Kategória 2", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(6847), "http://localhost:4200/assets/img/debit-card-icon.png", true, 2 },
                    { new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Kategória 3", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(6890), "http://localhost:4200/assets/img/debit-card-icon.png", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("54d42b35-b9ac-4418-8d45-2243ab63acee"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(2482), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Csomag 1", "onetime command", 2000, 1000, null },
                    { new Guid("1cd02c0b-72cc-4207-92bb-832ec28d3cf8"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(2954), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Csomag 2", "onetime command", 6000, 3000, null },
                    { new Guid("030720b0-955b-400a-b889-c8a5e7bb8e2f"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(2981), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Csomag 3", "onetime command", 10000, 5000, null },
                    { new Guid("c1107d62-01af-40cd-856a-59d2bc5c3757"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(3025), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Csomag 4", "onetime command", 14000, 8000, null },
                    { new Guid("5f1e4bc8-cd69-48b7-b2c0-c779398891c7"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(3030), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Csomag 5", "onetime command", 16000, 10000, null },
                    { new Guid("d7147cb3-43c4-4f04-a584-afb467e7634a"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(3034), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Csomag 6", "onetime command", 20000, 16000, null }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2021, 3, 11, 20, 51, 26, 346, DateTimeKind.Local).AddTicks(4342), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2021, 3, 11, 20, 51, 26, 346, DateTimeKind.Local).AddTicks(5473), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("a54c3447-1552-4d55-8379-3f66d580f50a"), new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(7548), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt termék 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("b3f8a273-9215-4c98-89c5-f2101f3835ef"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(2364), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt termék 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("0aafe1ee-92e7-41e6-bcc7-5b1be0d44620"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(2467), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt termék 3", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("e01bec98-79e1-41c9-a722-610efe625f2d"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(2476), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt termék 4", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(1599), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(1604), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(1606), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "testuser1" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2021, 3, 11, 20, 51, 26, 346, DateTimeKind.Local).AddTicks(6581), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2021, 3, 11, 20, 51, 26, 346, DateTimeKind.Local).AddTicks(8525), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 3, 11, 20, 51, 26, 346, DateTimeKind.Local).AddTicks(9513), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "testadmin1" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(1497), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(1541), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(1556), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "testadmin2" }
                });

            migrationBuilder.InsertData(
                table: "clientidentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("47563072-56f5-4945-92d1-bd3693838ca5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(4774), new DateTime(2021, 3, 11, 20, 52, 26, 347, DateTimeKind.Local).AddTicks(4777), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("54243cef-1940-4fe4-a04f-b9f93a2e3a39"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(2280), new DateTime(2021, 3, 11, 20, 52, 26, 347, DateTimeKind.Local).AddTicks(3643), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("6cfcff39-68ed-4f14-8e3e-55c07a33f49c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 11, 20, 51, 26, 347, DateTimeKind.Local).AddTicks(4720), new DateTime(2021, 3, 11, 20, 52, 26, 347, DateTimeKind.Local).AddTicks(4751), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "kreditpurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("02e34b50-62f0-4607-90f9-ccc90598f9f2"), new DateTime(2021, 2, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(942), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("236a0b06-d14c-4950-a21c-597761102e9b"), new DateTime(2021, 2, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(934), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ff2d86e3-45cd-4eb7-b287-9134b774e8ce"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(927), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c8e3b6e8-a101-4899-bc46-3049271a3cff"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(919), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae24a007-9001-4fd5-be6c-9a4554e1a152"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(912), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5ad114c6-b440-4693-9a85-f5d03c3509fd"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(904), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ae6b36e-db74-433e-a6d5-4ffb57cf4427"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(895), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f663dbec-fa20-4055-8806-c0d16d1f6c9f"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(887), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8eee5daf-08d8-44ca-884b-d7f1ff7c7288"), new DateTime(2020, 11, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(879), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0bfec9d0-2f38-4d36-8e69-0f75b15e9cb7"), new DateTime(2021, 2, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(872), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5887a76e-3694-4bd9-a16b-df56a6e6db6f"), new DateTime(2021, 2, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(864), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ee7b60c2-0b4c-4b27-98c9-379d20dacf36"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(848), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f0b81405-7eb8-45b7-9120-fc165c177974"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(856), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("99ba56df-ce8d-4fbe-a84f-fe5d75342d35"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(776), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d373c214-cc31-47bb-8c1e-1616019edbf3"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(831), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("868eee6e-924b-414a-809e-712f69e11cf6"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(823), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c613fdca-d891-4440-875e-aaec25089cfd"), new DateTime(2020, 11, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(815), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0d573283-d6bc-4010-a634-7ecf6521be69"), new DateTime(2020, 11, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(808), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d3b7493d-0933-44e3-99e4-20742dfcdcbb"), new DateTime(2021, 2, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(800), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c3db8fb7-8ad0-41d9-b44a-4e1b0e115876"), new DateTime(2021, 1, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(792), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("853ec652-738a-4572-a5cc-885fdbc2eeb2"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(784), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5227b3d5-36d7-4811-8a3a-5e4b1b56690d"), new DateTime(2020, 12, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(841), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b94977ab-2672-46a4-af6e-3b72e181e52a"), new DateTime(2020, 11, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(760), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("11b6f944-2853-4b88-b861-967af2650291"), new DateTime(2020, 11, 11, 20, 51, 26, 349, DateTimeKind.Local).AddTicks(647), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "news",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("33b26355-71ab-4b9d-a78c-de269166f78c"), new DateTime(2021, 3, 11, 20, 50, 36, 348, DateTimeKind.Local).AddTicks(8104), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("47240ea4-cfa2-4c2d-be5c-12ea67122d6a"), new DateTime(2021, 3, 11, 20, 49, 46, 348, DateTimeKind.Local).AddTicks(8095), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("cbf8c4c7-faad-4c21-ad4b-f7a73930f26b"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(8111), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("1f9be36b-a7f1-4ea7-b458-6213bf930e78"), new DateTime(2021, 3, 11, 20, 48, 6, 348, DateTimeKind.Local).AddTicks(7472), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("ef38f20a-1b36-46d3-9da6-13c2bf1fc321"), new DateTime(2021, 3, 11, 20, 48, 56, 348, DateTimeKind.Local).AddTicks(8078), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "passwordresetcodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("11723960-04ff-47a1-89af-986104f577be"), new Guid("dac8e80e-756a-47bb-9c6e-768d6bebe532"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(4885), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("ecf4941b-7111-4769-8202-28023b11b4a2"), new Guid("ed5413c9-9e70-4f58-b8dc-582ce3290fcc"), new DateTime(2021, 3, 11, 20, 51, 26, 348, DateTimeKind.Local).AddTicks(3731), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
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
                name: "IX_paypalbillingaddress_PayPalOrderId",
                table: "paypalbillingaddress",
                column: "PayPalOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_paypalorders_UserId",
                table: "paypalorders",
                column: "UserId");

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
                name: "paypalbillingaddress");

            migrationBuilder.DropTable(
                name: "paypalipnmessages");

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
