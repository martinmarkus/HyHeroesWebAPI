using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class Billingo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("5419128f-7511-4ab3-a5d7-fea5660986ae"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("25ce155a-750e-4e17-a83c-f800769dabb6"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("92096546-bff5-46ea-a17c-35ed2d531465"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("f225ac88-70e8-494a-b88d-4170d2e190c0"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("03491593-21ce-496c-b6a1-e53d26ff8d66"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("071ead6c-14dc-4d00-a1e0-a069957c4b19"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("b53b43ba-adff-406d-a42d-775202e24a4f"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("fc809158-e31a-4812-93b2-ef9317b5b24b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("125a08dd-08d2-45d6-ab1f-a2c34af092e4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("13c16eb3-05b5-4321-bf83-0d60cdec435a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("16a8b2d1-7fcf-46e9-87d8-dd9470ed6daa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2184ae18-8c12-48a8-a428-423c8933b4fd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2639f4b5-b65c-45f2-a381-d0d91478e132"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28fafeee-0536-4ee6-b3c4-db99524614fb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("29adc10b-3522-433d-8e8b-fd24bdb0e23b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("307767a6-7940-406d-a708-8aa6ca395de6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("34706131-dd99-4805-9fe5-561021f092bc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a59021e-2086-45f0-87cc-fb2cfd063e27"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4b0fc398-4265-4d51-ac0b-7b4b753df289"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4e79094b-3953-4828-885d-f9c3b701e423"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("63c0f142-6385-4840-a9eb-85dda58ba8ba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7208b8e3-a7d5-449d-b410-226d5d9e713c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("79647653-b381-4faf-8450-587e9b002269"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("823ca09d-a416-4c5b-913d-de694b9ee5ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("83baefcf-3e8f-45cd-8977-358187dbf529"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("93c4e1c2-718f-442c-a5d2-701b2c205374"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b3898984-1289-4c05-9474-ba947a9b811c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bce0d0d8-65ed-4bf6-ae62-cd4ee9361406"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c68f85a1-dded-484e-a151-5d250e05989b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d160320d-ae94-4cb1-919e-828ce3cf8bff"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d99d04b6-f54c-49ff-8337-ebceef3bd27b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fe146c75-1f12-4487-94f7-68d6cd15a5da"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ce07041-da49-4408-a6ed-051b1c945ba1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("38dbd534-1725-43e7-b928-9d5345bea2e8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("91a40402-e570-438a-b0a4-ab652f0c5770"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a8f78a16-de69-4be6-bcde-21434d22f248"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f0a86a59-d7c6-4fb0-ac62-545159b2c718"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("89e0f319-7132-4e78-8ce4-60f2f3219cdc"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("cd2cac3a-9444-43ff-8388-33069c1c8961"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("186b39f6-fe91-4a9b-9554-6ea7150ff949"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a9740bf-7c72-4010-8052-d8fa8297b5fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3742bc3b-72af-4826-90ea-6bc7cb1b23fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43a10e51-cbab-4812-9325-fa8f46a145b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9143cbca-95e4-4cd8-ab92-7c3c0961f9bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b494bfe2-e959-48e0-acd5-14bdd6c5106f"));

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
                table: "RefreshTokens",
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
                table: "KreditGifts",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "JatekfizetesRequests",
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
                table: "BarionTransactions",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BarionBillingAddresses",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BankTransfers",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BankTransferBillingAddresses",
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
                name: "BillingoBillingAddressed",
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
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoBillingAddressed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingoClients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BillingoBillingAddressId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingoClients_BillingoBillingAddressed_BillingoBillingAddr~",
                        column: x => x.BillingoBillingAddressId,
                        principalTable: "BillingoBillingAddressed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingoClients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("6c3ac295-1bc0-451a-8520-004d2e9abfdf"), new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(1499), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("e0a7c6b8-0f66-4cf2-9d4b-b635f7948c0c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(798), new DateTime(2021, 2, 15, 22, 24, 22, 563, DateTimeKind.Local).AddTicks(2073), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("b6a50c21-aec7-4bb1-a42f-4385d1027c83"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(3074), new DateTime(2021, 2, 15, 22, 24, 22, 563, DateTimeKind.Local).AddTicks(3102), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("3b2f6084-d8d1-493d-bd48-8bd04803ead3"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(3125), new DateTime(2021, 2, 15, 22, 24, 22, 563, DateTimeKind.Local).AddTicks(3128), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("51ec2a20-8e43-40d8-95c5-46ccafa5086c"), new DateTime(2021, 2, 15, 22, 23, 22, 558, DateTimeKind.Local).AddTicks(895), true, true, "GTA" },
                    { new Guid("6d0b9bc5-9ae3-4ee5-aee1-7b07798a3c52"), new DateTime(2021, 2, 15, 22, 23, 22, 560, DateTimeKind.Local).AddTicks(9958), true, true, "Survival" },
                    { new Guid("323a3c83-540b-4ca3-b389-3eaab2008192"), new DateTime(2021, 2, 15, 22, 23, 22, 561, DateTimeKind.Local).AddTicks(47), true, true, "Skyblock" },
                    { new Guid("065b9b83-c589-465d-910d-cf79de033153"), new DateTime(2021, 2, 15, 22, 23, 22, 561, DateTimeKind.Local).AddTicks(54), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("86a7b451-3f33-4621-b907-0c7387a90b9a"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7382), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9eaf1b14-7077-4e69-b7e4-52084cdbd5e6"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7390), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("388fa5e5-a98e-46b4-8956-a4a937d29128"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7397), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("215b2056-7a99-4dab-b375-bdb352555472"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7413), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e4365606-1738-49a0-838b-69571656efb8"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7445), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("72b5549e-926d-4526-97ac-c1c6d62651c0"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7430), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("af91109b-811e-4ed7-9e2a-ef826b90ea8d"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7438), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c22e621-99d6-412f-af42-bb8ed88dcd8e"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7374), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd91a416-352a-4ff9-a54a-6efb7d8f24a4"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7453), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("397a4781-72e6-4cf1-bfbd-48a6334e1853"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7423), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5c0a55ac-b01a-46c9-8ae6-a1b5c573b465"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7367), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("08c80c31-8c44-4574-92b8-b8948d36e790"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7405), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4bdb80e9-a184-4a34-bff8-3c4088787f58"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7349), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ea9e15a5-99d1-4a64-b475-bea8db21443f"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7341), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4eda1cc1-109f-46d9-a2eb-f612c57550d9"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7288), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9a53089-965e-47f6-8a0b-a116e553f976"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7280), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dbde1b4a-5fdf-4284-a4ee-ee9801f3213b"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7272), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7210e4bc-beb4-425b-9722-46c035eaa2c2"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7264), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ff100242-566b-439e-9b7a-80e7c2f5ed2b"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7257), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("14f17160-6e84-4fe2-881f-87b3bb8b083f"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7249), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b0a0a8c-70dc-4acc-a1ac-772ffbbdab89"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7236), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e17577a2-7324-40ef-8682-7d2db1358d37"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7226), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("48cbfe28-0820-42f3-b97b-8b04ff9e1c50"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7116), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bfab8c70-2283-4a49-9c4f-e88b069ac2ca"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7359), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("b829264e-8ded-419e-a850-2b7c22a83ae8"), new DateTime(2021, 2, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(4699), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("37ea45f4-2cef-4a39-838a-c30fcf7278d5"), new DateTime(2021, 2, 15, 22, 21, 42, 564, DateTimeKind.Local).AddTicks(4685), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("55ebcea4-524a-47c5-bad7-89a82df80a13"), new DateTime(2021, 2, 15, 22, 22, 32, 564, DateTimeKind.Local).AddTicks(4692), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("48e1f15a-a546-4784-8a13-7c8d2b3c2cf6"), new DateTime(2021, 2, 15, 22, 20, 2, 564, DateTimeKind.Local).AddTicks(4101), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("343ca7b6-b516-44ce-8e65-f98021dd911d"), new DateTime(2021, 2, 15, 22, 20, 52, 564, DateTimeKind.Local).AddTicks(4669), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("78040267-637c-46cf-8fc9-d7294ddd8272"), new Guid("2d95b988-2ebf-4c57-8572-fb656e00c1a1"), new DateTime(2021, 2, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(671), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("94bccb85-26c6-46ae-bd80-700478243631"), new Guid("16d94b28-d89d-4f7f-b614-e69b8a4eda9b"), new DateTime(2021, 2, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(1675), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("c99ed6b6-7027-4327-b72d-97feb3de3c08"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9827), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("901142da-3f9c-46eb-8f54-d35d88d98bb2"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9938), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2f849029-5819-41ef-962f-96946c8c8e2d"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9946), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("00bb4177-9718-49b6-9d18-53ea0d8b2859"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9957), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cc1feb6c-fea5-4a5c-bbd6-46e43f589f63"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(5394), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5d1d7233-d413-4777-a8a8-a2e3b6377319"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9952), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(5463), new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(7241), new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(72), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(78), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(9967), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(12), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.CreateIndex(
                name: "IX_BillingoClients_BillingoBillingAddressId",
                table: "BillingoClients",
                column: "BillingoBillingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillingoClients_UserId",
                table: "BillingoClients",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingoClients");

            migrationBuilder.DropTable(
                name: "BillingoBillingAddressed");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("6c3ac295-1bc0-451a-8520-004d2e9abfdf"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3b2f6084-d8d1-493d-bd48-8bd04803ead3"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("b6a50c21-aec7-4bb1-a42f-4385d1027c83"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("e0a7c6b8-0f66-4cf2-9d4b-b635f7948c0c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("065b9b83-c589-465d-910d-cf79de033153"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("323a3c83-540b-4ca3-b389-3eaab2008192"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("51ec2a20-8e43-40d8-95c5-46ccafa5086c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("6d0b9bc5-9ae3-4ee5-aee1-7b07798a3c52"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("08c80c31-8c44-4574-92b8-b8948d36e790"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("14f17160-6e84-4fe2-881f-87b3bb8b083f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("215b2056-7a99-4dab-b375-bdb352555472"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("388fa5e5-a98e-46b4-8956-a4a937d29128"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("397a4781-72e6-4cf1-bfbd-48a6334e1853"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c22e621-99d6-412f-af42-bb8ed88dcd8e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("48cbfe28-0820-42f3-b97b-8b04ff9e1c50"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4bdb80e9-a184-4a34-bff8-3c4088787f58"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4eda1cc1-109f-46d9-a2eb-f612c57550d9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5c0a55ac-b01a-46c9-8ae6-a1b5c573b465"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7210e4bc-beb4-425b-9722-46c035eaa2c2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("72b5549e-926d-4526-97ac-c1c6d62651c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("86a7b451-3f33-4621-b907-0c7387a90b9a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b0a0a8c-70dc-4acc-a1ac-772ffbbdab89"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9eaf1b14-7077-4e69-b7e4-52084cdbd5e6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("af91109b-811e-4ed7-9e2a-ef826b90ea8d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bfab8c70-2283-4a49-9c4f-e88b069ac2ca"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c9a53089-965e-47f6-8a0b-a116e553f976"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd91a416-352a-4ff9-a54a-6efb7d8f24a4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dbde1b4a-5fdf-4284-a4ee-ee9801f3213b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e17577a2-7324-40ef-8682-7d2db1358d37"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e4365606-1738-49a0-838b-69571656efb8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ea9e15a5-99d1-4a64-b475-bea8db21443f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ff100242-566b-439e-9b7a-80e7c2f5ed2b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("343ca7b6-b516-44ce-8e65-f98021dd911d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("37ea45f4-2cef-4a39-838a-c30fcf7278d5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("48e1f15a-a546-4784-8a13-7c8d2b3c2cf6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("55ebcea4-524a-47c5-bad7-89a82df80a13"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b829264e-8ded-419e-a850-2b7c22a83ae8"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("78040267-637c-46cf-8fc9-d7294ddd8272"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("94bccb85-26c6-46ae-bd80-700478243631"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00bb4177-9718-49b6-9d18-53ea0d8b2859"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f849029-5819-41ef-962f-96946c8c8e2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1d7233-d413-4777-a8a8-a2e3b6377319"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("901142da-3f9c-46eb-8f54-d35d88d98bb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c99ed6b6-7027-4327-b72d-97feb3de3c08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc1feb6c-fea5-4a5c-bbd6-46e43f589f63"));

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
                table: "RefreshTokens",
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
                table: "KreditGifts",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "JatekfizetesRequests",
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
                table: "BarionTransactions",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BarionBillingAddresses",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BankTransfers",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BankTransferBillingAddresses",
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

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("5419128f-7511-4ab3-a5d7-fea5660986ae"), new DateTime(2021, 2, 14, 12, 54, 6, 899, DateTimeKind.Local).AddTicks(4311), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("92096546-bff5-46ea-a17c-35ed2d531465"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3915), new DateTime(2021, 2, 14, 12, 55, 6, 900, DateTimeKind.Local).AddTicks(5216), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("f225ac88-70e8-494a-b88d-4170d2e190c0"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(6830), new DateTime(2021, 2, 14, 12, 55, 6, 900, DateTimeKind.Local).AddTicks(6862), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("25ce155a-750e-4e17-a83c-f800769dabb6"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(6884), new DateTime(2021, 2, 14, 12, 55, 6, 900, DateTimeKind.Local).AddTicks(6887), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("fc809158-e31a-4812-93b2-ef9317b5b24b"), new DateTime(2021, 2, 14, 12, 54, 6, 895, DateTimeKind.Local).AddTicks(1463), true, true, "GTA" },
                    { new Guid("b53b43ba-adff-406d-a42d-775202e24a4f"), new DateTime(2021, 2, 14, 12, 54, 6, 898, DateTimeKind.Local).AddTicks(2578), true, true, "Survival" },
                    { new Guid("03491593-21ce-496c-b6a1-e53d26ff8d66"), new DateTime(2021, 2, 14, 12, 54, 6, 898, DateTimeKind.Local).AddTicks(2633), true, true, "Skyblock" },
                    { new Guid("071ead6c-14dc-4d00-a1e0-a069957c4b19"), new DateTime(2021, 2, 14, 12, 54, 6, 898, DateTimeKind.Local).AddTicks(2639), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("823ca09d-a416-4c5b-913d-de694b9ee5ac"), new DateTime(2021, 1, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1818), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2184ae18-8c12-48a8-a428-423c8933b4fd"), new DateTime(2020, 10, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1826), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("63c0f142-6385-4840-a9eb-85dda58ba8ba"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1834), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d160320d-ae94-4cb1-919e-828ce3cf8bff"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1849), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2639f4b5-b65c-45f2-a381-d0d91478e132"), new DateTime(2021, 1, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1883), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bce0d0d8-65ed-4bf6-ae62-cd4ee9361406"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1867), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("79647653-b381-4faf-8450-587e9b002269"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1875), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("125a08dd-08d2-45d6-ab1f-a2c34af092e4"), new DateTime(2021, 1, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1810), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("16a8b2d1-7fcf-46e9-87d8-dd9470ed6daa"), new DateTime(2021, 1, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1892), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7208b8e3-a7d5-449d-b410-226d5d9e713c"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1859), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fe146c75-1f12-4487-94f7-68d6cd15a5da"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1797), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("13c16eb3-05b5-4321-bf83-0d60cdec435a"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1842), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4b0fc398-4265-4d51-ac0b-7b4b753df289"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1777), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("83baefcf-3e8f-45cd-8977-358187dbf529"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1768), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b3898984-1289-4c05-9474-ba947a9b811c"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1760), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d99d04b6-f54c-49ff-8337-ebceef3bd27b"), new DateTime(2020, 10, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1752), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("34706131-dd99-4805-9fe5-561021f092bc"), new DateTime(2020, 10, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1745), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c68f85a1-dded-484e-a151-5d250e05989b"), new DateTime(2021, 1, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1737), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28fafeee-0536-4ee6-b3c4-db99524614fb"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1729), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("93c4e1c2-718f-442c-a5d2-701b2c205374"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1721), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4e79094b-3953-4828-885d-f9c3b701e423"), new DateTime(2020, 11, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1706), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a59021e-2086-45f0-87cc-fb2cfd063e27"), new DateTime(2020, 10, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1696), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("307767a6-7940-406d-a708-8aa6ca395de6"), new DateTime(2020, 10, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1587), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("29adc10b-3522-433d-8e8b-fd24bdb0e23b"), new DateTime(2020, 12, 14, 12, 54, 6, 902, DateTimeKind.Local).AddTicks(1787), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("91a40402-e570-438a-b0a4-ab652f0c5770"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(9131), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("1ce07041-da49-4408-a6ed-051b1c945ba1"), new DateTime(2021, 2, 14, 12, 52, 26, 901, DateTimeKind.Local).AddTicks(9116), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("f0a86a59-d7c6-4fb0-ac62-545159b2c718"), new DateTime(2021, 2, 14, 12, 53, 16, 901, DateTimeKind.Local).AddTicks(9123), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("38dbd534-1725-43e7-b928-9d5345bea2e8"), new DateTime(2021, 2, 14, 12, 50, 46, 901, DateTimeKind.Local).AddTicks(8526), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("a8f78a16-de69-4be6-bcde-21434d22f248"), new DateTime(2021, 2, 14, 12, 51, 36, 901, DateTimeKind.Local).AddTicks(9099), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("89e0f319-7132-4e78-8ce4-60f2f3219cdc"), new Guid("5f1a0d7d-513d-489a-948b-bcb092f54c42"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(4657), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd2cac3a-9444-43ff-8388-33069c1c8961"), new Guid("dfe8b794-175e-4f3b-9ed5-222a64937db3"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(5801), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("b494bfe2-e959-48e0-acd5-14bdd6c5106f"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(3804), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("186b39f6-fe91-4a9b-9554-6ea7150ff949"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(3911), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("9143cbca-95e4-4cd8-ab92-7c3c0961f9bf"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(3919), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("3742bc3b-72af-4826-90ea-6bc7cb1b23fa"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(3931), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("43a10e51-cbab-4812-9325-fa8f46a145b4"), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(9413), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2a9740bf-7c72-4010-8052-d8fa8297b5fd"), new DateTime(2021, 2, 14, 12, 54, 6, 901, DateTimeKind.Local).AddTicks(3926), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 12, 54, 6, 899, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 12, 54, 6, 899, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 14, 12, 54, 6, 899, DateTimeKind.Local).AddTicks(8417), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(186), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3167), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3173), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3057), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3100), new DateTime(2021, 2, 14, 12, 54, 6, 900, DateTimeKind.Local).AddTicks(3117) });
        }
    }
}
