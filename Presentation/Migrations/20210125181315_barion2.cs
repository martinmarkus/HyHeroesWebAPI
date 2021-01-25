using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class barion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarionTransactionStarts");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("3137209b-0772-4068-a8e6-bacd55ca1028"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3748bdfb-9d79-4256-aa44-417245ac2b53"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("c31fca7c-e77e-4239-9cc0-be9dc6696f2d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("df26c675-fd74-4ca0-b153-3821361cf5fd"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("591a266f-4b6d-4c9c-85c3-750915582954"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("9b25ce60-7615-4c40-bb92-68882f0ffdda"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a8bb96fa-a51f-453d-8390-88a9db9bdb2c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("fb49ba7b-c9b4-4c2a-a3c4-5e4c32366de3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0030ab33-9beb-4c73-b9d4-ba24f1771464"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0177f2cd-dd35-46a4-a05d-707773b29032"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("17a1a1c5-bd0c-43bc-9971-b2c5cd8a2dd9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("19625c2d-eeef-4779-98d6-4abfa7871c36"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2d1e77f9-a065-44d7-9ebd-d279b43f082f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("37b330bc-7dd6-4031-ba5f-6be23a7c5556"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4428b5cc-228f-4a54-9a05-24176dd43975"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("47354b72-1e1e-4be6-a493-05e9e7807640"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("53d3d680-3349-48e3-b7ea-291931f683e4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5855428a-2715-46c3-b78d-7b7f736e76d6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5c3bf336-ef39-4dcc-8286-e23d3f2786bd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("76549e57-4d37-46b4-b543-e3560b22a6da"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7a9076c9-d87d-4ae4-830a-a8228590381d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9862778f-a54b-4ff8-a154-51d4fcc99786"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a7ea57f1-81d0-43c8-a91a-5e698dbf93ba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b0cb9095-298b-4d4e-9478-b026634d1e0a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b4708cad-5b07-4a82-9430-707896c00187"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bd86f74b-b0cd-474e-a244-ab576502c11b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c4d68a30-9b23-4fad-b44d-d31fc98fe96d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cc2ea486-9b2a-4795-badb-c36a8e03f92e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d19a0649-b59d-49b4-9ccc-6ca80dee0141"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d7ba575d-e8e5-4a2b-bfc9-0ebeca38ffee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("efa22164-6309-47d0-b40b-0407bcdd51a9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f94e13fa-7167-42bf-ade1-9f2e7161333e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("413d24bb-6301-4dd7-9f00-e9c06cd740d0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8ecc4b7f-f42a-4ddd-821d-b5e0e87e8824"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f2678baf-3351-46dc-ae45-61bc78ab80ee"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f27440ce-2815-404c-82e5-b0eb59869d24"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("fcf62f0f-7df3-44f3-8533-053b06922712"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("408e9fa7-9d65-4bc7-ab5c-eaa70098df09"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("e6348157-73b6-4852-90f2-2f4f1f1f6d93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c2f3fc7-bb9f-44a2-8f7d-e8729d84bff8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0248d4-410b-475a-a2c4-6d54adffce83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0f970f9-0bd5-4da2-893a-bc752afd662c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a900b649-2165-4f08-94dc-73eecbb7bef4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bde96e49-0ca1-4959-ae57-a5464cf29a16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2c4b770-39fb-440d-894b-5a87476694ca"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Users",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Roles",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PurchaseStates",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PurchasedProducts",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Products",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "ProductCategories",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PayPalTransactionRequests",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PayPalIPNMessages",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PasswordResetCodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "OnlinePlayerStates",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "News",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "MassKreditUserActivations",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "MassKreditActivationCodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "KreditPurchases",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "GameServers",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "FailedTransactions",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "EmailVerificationCodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "EDSMSPurchases",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "EDSMSActivationCodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "ClientIdentities",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BlacklistedIPs",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingTransactions",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "ActualValueOfOneKredit",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

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

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("8dc6fa73-861f-436a-b3f9-779636eb1a6f"), new DateTime(2021, 1, 25, 19, 13, 15, 56, DateTimeKind.Local).AddTicks(7359), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("407bea8f-aecb-454c-8580-056bd51d152e"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(6318), new DateTime(2021, 1, 25, 20, 13, 15, 57, DateTimeKind.Local).AddTicks(7598), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("cdaa9dc5-99d3-48d7-bf89-99ce62d61cad"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(8603), new DateTime(2021, 1, 25, 20, 13, 15, 57, DateTimeKind.Local).AddTicks(8635), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("04b4d599-008f-4df0-9546-99514d976ebe"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(8658), new DateTime(2021, 1, 25, 20, 13, 15, 57, DateTimeKind.Local).AddTicks(8661), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("922134d3-2c21-4c31-8420-b60e98ec0a68"), new DateTime(2021, 1, 25, 19, 13, 15, 52, DateTimeKind.Local).AddTicks(6176), true, true, "GTA" },
                    { new Guid("e01986b2-c7c4-4b0b-8d19-2facb68a170d"), new DateTime(2021, 1, 25, 19, 13, 15, 55, DateTimeKind.Local).AddTicks(5842), true, true, "Survival" },
                    { new Guid("de566637-c69b-4d8a-be62-bd2bf198ab82"), new DateTime(2021, 1, 25, 19, 13, 15, 55, DateTimeKind.Local).AddTicks(5891), true, true, "Skyblock" },
                    { new Guid("cb8b2ab6-8563-4e0b-89ef-da0e202c9f59"), new DateTime(2021, 1, 25, 19, 13, 15, 55, DateTimeKind.Local).AddTicks(5897), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("30cc6b93-a410-48b4-bf2a-470252368f05"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2879), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b70a4cb6-6871-4dd3-8888-7ae8c1155c45"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2887), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3f471cb1-bb6b-4d51-912b-a4a0f5676e5d"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2895), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d5114cc7-e609-47a7-bf6a-5f1e17ab05bf"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2912), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ca982694-a909-4c0a-9938-1469bf7495d4"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2943), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f643eb5b-8c46-461d-9150-7d556a6eac11"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2928), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e85ac996-17ac-4822-a0cf-a44316c3ccd7"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2935), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("721ac6ad-19dd-477a-865b-e9f1694f2852"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2870), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb0d658f-ac39-4b11-8db8-efe06ff139e8"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2951), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8ee6da2d-1602-4945-b0a3-8c9bfd8edeb0"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2920), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("66d010d0-8197-4c50-8faa-36ff59cfcf60"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2863), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("58fd7e6e-3c83-43ca-8ac0-357dc9d067c9"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2903), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("acf326a4-6ad0-49ca-9f5e-a97371cea7c4"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2848), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4a787864-40a6-4434-a4ed-9faff8636604"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2838), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6e104621-88bd-4cd7-a672-32732cd17fd8"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2830), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a8242bf5-96db-415b-9d61-2ff6760ef348"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2823), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("022629ba-3e4a-47eb-a3a1-184f75ac531f"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2816), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("15cf0190-211b-42f6-9b5b-e468609b44cc"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2808), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("696d75f0-cc55-49f1-bf4d-c5c51093c408"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2799), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bf71a4ac-3311-49ad-ae9d-4e37d6a1b297"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2791), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("04a4ddd2-149c-4b1f-a2d8-f54aa516dac6"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2783), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e19e66ff-ca17-4d09-98e5-671f0bfc1482"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2767), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("341e3ccf-bc0a-45eb-9a54-4862de8efe6e"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2660), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a9e6be5e-0386-48f6-9977-77f901a85223"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2855), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("3819f28e-ed62-4d36-b04b-d21451dc76e1"), new DateTime(2021, 1, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(233), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("944c7b49-4e09-4f9b-a71d-ae211a1661d2"), new DateTime(2021, 1, 25, 19, 11, 35, 59, DateTimeKind.Local).AddTicks(217), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("e4f8acdf-1b96-4efd-a9e8-882195391093"), new DateTime(2021, 1, 25, 19, 12, 25, 59, DateTimeKind.Local).AddTicks(225), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("a4705ccf-0bbb-4c89-abf2-032653484e7a"), new DateTime(2021, 1, 25, 19, 9, 55, 58, DateTimeKind.Local).AddTicks(9632), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("d171004a-9382-4a97-b8cf-6d7283946069"), new DateTime(2021, 1, 25, 19, 10, 45, 59, DateTimeKind.Local).AddTicks(201), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d590a46-9720-40b4-a259-478891885f86"), new Guid("a663cc2c-27ab-4734-8d83-a1bca6f2468a"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(6172), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("24d04f79-5e7b-4bb7-af5b-1c25d95ee1f5"), new Guid("438a0a7b-7400-4413-8178-739eb78d7630"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(7189), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("f5ee7a8c-3d0a-44bf-a1ff-1d488f61a5d9"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5339), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cd9da299-b38b-4edc-930c-71bcc54967c2"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5440), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("34a46814-0f4b-4dff-b8d5-228a2ce1f341"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5448), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("78755a26-0f7f-40eb-aba5-9c57b30524ce"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5458), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5b51fe44-472d-441a-8127-97244b9adaa6"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(864), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("adca74a8-0941-413a-9660-04a7525d4f04"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5453), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 56, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(989), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(2713), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5545), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5550), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5438), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5492), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.CreateIndex(
                name: "IX_BarionBillingAddresses_BarionTransactionId",
                table: "BarionBillingAddresses",
                column: "BarionTransactionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarionTransactions_UserId",
                table: "BarionTransactions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarionBillingAddresses");

            migrationBuilder.DropTable(
                name: "BarionTransactions");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("8dc6fa73-861f-436a-b3f9-779636eb1a6f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("04b4d599-008f-4df0-9546-99514d976ebe"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("407bea8f-aecb-454c-8580-056bd51d152e"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("cdaa9dc5-99d3-48d7-bf89-99ce62d61cad"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("922134d3-2c21-4c31-8420-b60e98ec0a68"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("cb8b2ab6-8563-4e0b-89ef-da0e202c9f59"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("de566637-c69b-4d8a-be62-bd2bf198ab82"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("e01986b2-c7c4-4b0b-8d19-2facb68a170d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("022629ba-3e4a-47eb-a3a1-184f75ac531f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("04a4ddd2-149c-4b1f-a2d8-f54aa516dac6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("15cf0190-211b-42f6-9b5b-e468609b44cc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("30cc6b93-a410-48b4-bf2a-470252368f05"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("341e3ccf-bc0a-45eb-9a54-4862de8efe6e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3f471cb1-bb6b-4d51-912b-a4a0f5676e5d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4a787864-40a6-4434-a4ed-9faff8636604"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("58fd7e6e-3c83-43ca-8ac0-357dc9d067c9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("66d010d0-8197-4c50-8faa-36ff59cfcf60"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("696d75f0-cc55-49f1-bf4d-c5c51093c408"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6e104621-88bd-4cd7-a672-32732cd17fd8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("721ac6ad-19dd-477a-865b-e9f1694f2852"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8ee6da2d-1602-4945-b0a3-8c9bfd8edeb0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a8242bf5-96db-415b-9d61-2ff6760ef348"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a9e6be5e-0386-48f6-9977-77f901a85223"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("acf326a4-6ad0-49ca-9f5e-a97371cea7c4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b70a4cb6-6871-4dd3-8888-7ae8c1155c45"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bf71a4ac-3311-49ad-ae9d-4e37d6a1b297"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ca982694-a909-4c0a-9938-1469bf7495d4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d5114cc7-e609-47a7-bf6a-5f1e17ab05bf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e19e66ff-ca17-4d09-98e5-671f0bfc1482"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e85ac996-17ac-4822-a0cf-a44316c3ccd7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eb0d658f-ac39-4b11-8db8-efe06ff139e8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f643eb5b-8c46-461d-9150-7d556a6eac11"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("3819f28e-ed62-4d36-b04b-d21451dc76e1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("944c7b49-4e09-4f9b-a71d-ae211a1661d2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a4705ccf-0bbb-4c89-abf2-032653484e7a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d171004a-9382-4a97-b8cf-6d7283946069"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e4f8acdf-1b96-4efd-a9e8-882195391093"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("24d04f79-5e7b-4bb7-af5b-1c25d95ee1f5"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("3d590a46-9720-40b4-a259-478891885f86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34a46814-0f4b-4dff-b8d5-228a2ce1f341"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b51fe44-472d-441a-8127-97244b9adaa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78755a26-0f7f-40eb-aba5-9c57b30524ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adca74a8-0941-413a-9660-04a7525d4f04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd9da299-b38b-4edc-930c-71bcc54967c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5ee7a8c-3d0a-44bf-a1ff-1d488f61a5d9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Users",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Roles",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PurchaseStates",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PurchasedProducts",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Products",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "ProductCategories",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PayPalTransactionRequests",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PayPalIPNMessages",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PasswordResetCodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "OnlinePlayerStates",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "News",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "MassKreditUserActivations",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "MassKreditActivationCodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "KreditPurchases",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "GameServers",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "FailedTransactions",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "EmailVerificationCodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "EDSMSPurchases",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "EDSMSActivationCodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "ClientIdentities",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BlacklistedIPs",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingTransactions",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "ActualValueOfOneKredit",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.CreateTable(
                name: "BarionTransactionStarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsFinished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PaymentId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RowVersion = table.Column<DateTime>(type: "timestamp(6)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarionTransactionStarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarionTransactionStarts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("3137209b-0772-4068-a8e6-bacd55ca1028"), new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(4404), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("3748bdfb-9d79-4256-aa44-417245ac2b53"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 1, 24, 21, 48, 49, 549, DateTimeKind.Local).AddTicks(4375), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("df26c675-fd74-4ca0-b153-3821361cf5fd"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(5393), new DateTime(2021, 1, 24, 21, 48, 49, 549, DateTimeKind.Local).AddTicks(5421), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("c31fca7c-e77e-4239-9cc0-be9dc6696f2d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(5441), new DateTime(2021, 1, 24, 21, 48, 49, 549, DateTimeKind.Local).AddTicks(5444), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("fb49ba7b-c9b4-4c2a-a3c4-5e4c32366de3"), new DateTime(2021, 1, 24, 20, 48, 49, 544, DateTimeKind.Local).AddTicks(4462), true, true, "GTA" },
                    { new Guid("591a266f-4b6d-4c9c-85c3-750915582954"), new DateTime(2021, 1, 24, 20, 48, 49, 547, DateTimeKind.Local).AddTicks(3394), true, true, "Survival" },
                    { new Guid("9b25ce60-7615-4c40-bb92-68882f0ffdda"), new DateTime(2021, 1, 24, 20, 48, 49, 547, DateTimeKind.Local).AddTicks(3441), true, true, "Skyblock" },
                    { new Guid("a8bb96fa-a51f-453d-8390-88a9db9bdb2c"), new DateTime(2021, 1, 24, 20, 48, 49, 547, DateTimeKind.Local).AddTicks(3447), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("19625c2d-eeef-4779-98d6-4abfa7871c36"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3941), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d7ba575d-e8e5-4a2b-bfc9-0ebeca38ffee"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3949), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("17a1a1c5-bd0c-43bc-9971-b2c5cd8a2dd9"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3956), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("47354b72-1e1e-4be6-a493-05e9e7807640"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3972), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cc2ea486-9b2a-4795-badb-c36a8e03f92e"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(4003), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4428b5cc-228f-4a54-9a05-24176dd43975"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3988), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2d1e77f9-a065-44d7-9ebd-d279b43f082f"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3995), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("76549e57-4d37-46b4-b543-e3560b22a6da"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3934), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d19a0649-b59d-49b4-9ccc-6ca80dee0141"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(4013), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b0cb9095-298b-4d4e-9478-b026634d1e0a"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3980), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7a9076c9-d87d-4ae4-830a-a8228590381d"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3927), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0177f2cd-dd35-46a4-a05d-707773b29032"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3963), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bd86f74b-b0cd-474e-a244-ab576502c11b"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3912), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c4d68a30-9b23-4fad-b44d-d31fc98fe96d"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3902), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a7ea57f1-81d0-43c8-a91a-5e698dbf93ba"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3895), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("53d3d680-3349-48e3-b7ea-291931f683e4"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3888), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5855428a-2715-46c3-b78d-7b7f736e76d6"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3881), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5c3bf336-ef39-4dcc-8286-e23d3f2786bd"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3873), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b4708cad-5b07-4a82-9430-707896c00187"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3865), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("efa22164-6309-47d0-b40b-0407bcdd51a9"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3857), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9862778f-a54b-4ff8-a154-51d4fcc99786"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3848), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("37b330bc-7dd6-4031-ba5f-6be23a7c5556"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3834), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f94e13fa-7167-42bf-ade1-9f2e7161333e"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3733), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0030ab33-9beb-4c73-b9d4-ba24f1771464"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3919), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("413d24bb-6301-4dd7-9f00-e9c06cd740d0"), new DateTime(2021, 1, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(1254), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("f27440ce-2815-404c-82e5-b0eb59869d24"), new DateTime(2021, 1, 24, 20, 47, 9, 551, DateTimeKind.Local).AddTicks(1239), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("f2678baf-3351-46dc-ae45-61bc78ab80ee"), new DateTime(2021, 1, 24, 20, 47, 59, 551, DateTimeKind.Local).AddTicks(1247), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("fcf62f0f-7df3-44f3-8533-053b06922712"), new DateTime(2021, 1, 24, 20, 45, 29, 551, DateTimeKind.Local).AddTicks(659), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("8ecc4b7f-f42a-4ddd-821d-b5e0e87e8824"), new DateTime(2021, 1, 24, 20, 46, 19, 551, DateTimeKind.Local).AddTicks(1224), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e6348157-73b6-4852-90f2-2f4f1f1f6d93"), new Guid("6fb04cdf-af87-42da-9729-12cf260ea456"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(7119), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("408e9fa7-9d65-4bc7-ab5c-eaa70098df09"), new Guid("f11e8541-5455-40dd-9348-d52c70d9b0ba"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(8183), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("bde96e49-0ca1-4959-ae57-a5464cf29a16"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6185), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7e0248d4-410b-475a-a2c4-6d54adffce83"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6294), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f2c4b770-39fb-440d-894b-5a87476694ca"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6303), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a900b649-2165-4f08-94dc-73eecbb7bef4"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6314), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4c2f3fc7-bb9f-44a2-8f7d-e8729d84bff8"), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(7581), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a0f970f9-0bd5-4da2-893a-bc752afd662c"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6308), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(7916), new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(9585), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2412), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2417), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2312), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2360), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.CreateIndex(
                name: "IX_BarionTransactionStarts_UserId",
                table: "BarionTransactionStarts",
                column: "UserId");
        }
    }
}
