using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class userFix : Migration
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
                name: "EDSMSPurchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    JatekFizetesId = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    ReceiverPhoneNumber = table.Column<string>(nullable: true),
                    CustomerPhoneNumber = table.Column<string>(nullable: true),
                    GrossPrice = table.Column<string>(nullable: true),
                    IsTest = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDSMSPurchases", x => x.Id);
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
                    ProductCategoryId = table.Column<Guid>(nullable: false)
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
                name: "EDSMSActivationCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Code = table.Column<string>(nullable: true),
                    SenderPhoneNumber = table.Column<string>(nullable: true),
                    KreditValue = table.Column<int>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    IsGeneratedByAdmin = table.Column<bool>(nullable: false),
                    KreditPurchaseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDSMSActivationCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EDSMSActivationCodes_KreditPurchases_KreditPurchaseId",
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
                values: new object[] { new Guid("898f2d61-af5d-4b66-aceb-0fd1ce88147e"), new DateTime(2020, 12, 30, 12, 54, 13, 589, DateTimeKind.Local).AddTicks(7400), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ddefe26b-6fbc-4b44-8e24-178b9ff13ed5"), new DateTime(2020, 12, 30, 12, 54, 13, 585, DateTimeKind.Local).AddTicks(8810), true, true, "GTA" },
                    { new Guid("8000fd14-df16-40c6-90db-b9b3b4cd5627"), new DateTime(2020, 12, 30, 12, 54, 13, 588, DateTimeKind.Local).AddTicks(6557), true, true, "Survival" },
                    { new Guid("7f647c5c-d526-402d-9659-fc52f65ee503"), new DateTime(2020, 12, 30, 12, 54, 13, 588, DateTimeKind.Local).AddTicks(6599), true, true, "Skyblock" },
                    { new Guid("492934a4-dbe7-4f0b-884e-45f3b4fe72ae"), new DateTime(2020, 12, 30, 12, 54, 13, 588, DateTimeKind.Local).AddTicks(6604), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "IsActive", "IsUsed", "Priority" },
                values: new object[,]
                {
                    { new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"), "Rangok", new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(6108), true, false, 1 },
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Other", new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(6988), true, false, 2 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreationDate", "IsActive", "Name", "PermissionLevel" },
                values: new object[,]
                {
                    { new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), new DateTime(2020, 12, 30, 12, 54, 13, 589, DateTimeKind.Local).AddTicks(8677), true, "User", 1 },
                    { new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(159), true, "Admin", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("318c6ec9-5cce-4952-9993-416571efa31a"), new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(7621), "test description", "test url", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d5504351-32ad-44b9-8cb4-30b1db7edd6b"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(1675), "test description", "test url", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6576d11e-a517-4978-8d24-508927fd0ea4"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(1777), "test description", "test url", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a2d0fa0a-e149-4274-9570-bdd008e342d1"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(1789), "test description", "test url", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("39159adb-4496-44a7-9a18-b8f69ca0a6cd"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(1795), "test description", "test url", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2d2f1c36-515b-4a07-b57c-62728c52fa9e"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(1799), "test description", "test url", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(5466), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(5472), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(5475), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" },
                    { new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(901), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(2644), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(3531), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(5368), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(5417), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 30, 12, 54, 13, 590, DateTimeKind.Local).AddTicks(5436), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[] { new Guid("fc84cdd0-c100-47dd-bd0e-c7954fb7752a"), new Guid("87343279-f3e0-46dd-be30-2b27ac6ba777"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(3464), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[] { new Guid("17d1bf38-719a-4a17-b5df-9f0d293991db"), new Guid("fdcdf86e-6979-4de5-91a1-8e97157b9bb9"), new DateTime(2020, 12, 30, 12, 54, 13, 591, DateTimeKind.Local).AddTicks(2482), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") });

            migrationBuilder.CreateIndex(
                name: "IX_EDSMSActivationCodes_KreditPurchaseId",
                table: "EDSMSActivationCodes",
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
                name: "EDSMSActivationCodes");

            migrationBuilder.DropTable(
                name: "EDSMSPurchases");

            migrationBuilder.DropTable(
                name: "EmailVerificationCodes");

            migrationBuilder.DropTable(
                name: "FailedTransactions");

            migrationBuilder.DropTable(
                name: "MassKreditUserActivations");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "PasswordResetCodes");

            migrationBuilder.DropTable(
                name: "PayPalIPNMessages");

            migrationBuilder.DropTable(
                name: "PayPalTransactionRequests");

            migrationBuilder.DropTable(
                name: "PurchaseStates");

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
