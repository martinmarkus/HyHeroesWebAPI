using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class blacklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("714c95ad-f2d1-488e-83f1-523e7b87deed"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("14cee08d-fbab-45f1-ba35-42503b2b4b17"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("283d0b28-0627-45ec-961f-e4fad3a4423e"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a0f22b42-a0fc-4426-9432-b0c3c09da63f"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("526d50dd-d8c5-4726-8b66-6164ed0aecdb"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("52ddf923-9e3c-4830-a88d-f60299c7feae"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("747cbe64-13e1-4edf-a5d2-6d1f972463fd"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("e085e0db-c6ef-47b7-adca-4d0825855fa8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0186a1e0-41fa-4319-bb13-b4fbbb229b4c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("03e7cf9c-cc5e-4908-84b9-ce433b883eb2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("065bcee6-a89f-4635-b8f0-ba556266acb0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0db52e68-7256-4d3a-843b-b166ad89f26e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("12083836-f9b2-4c9b-8a3f-263da1999876"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("188aed26-29b6-4aa7-9b86-b0affad70ed1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("357464a9-f6a6-4c0d-8278-12f67da12378"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4bf5f123-eebf-4024-a2b3-80d6878c3556"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("60c8acd5-00b1-45cf-a876-f9dd93ea8c19"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6947dea1-334b-4647-b3a0-90e9de4419b2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7263d18b-086b-4ebf-8a0e-128246e26642"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("839e9d01-4d5c-4acb-b1a2-7ef480aac8da"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8ae40e42-6595-4190-bd4a-da747c05182a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("903346e9-4484-4b59-90b4-d9cadff92cc1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("908fbdc4-77b5-4618-97a3-7ca4195558eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9a75d6bf-2a69-4058-880f-460d6fa728e2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9eace636-3f4a-4bed-a8df-69891b0454e3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9ed1a275-dec2-4dd8-b9ae-9a14ece4d268"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("abc2caaf-303c-4ce6-85db-9b964b5e2468"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c9d864e4-4a9f-4cfe-aceb-0171beee29f2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cfcf94a0-6b5e-4f28-807f-8bbfe76aefc0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("db0436d3-75a4-4de0-8dc4-e0c03a37b20c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f4e4af6f-9c1c-449d-9cb6-b2f2eed61e5b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fea4951d-e505-4eca-8b09-7a830ca3d83e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0b260b8e-4e82-47c2-b696-019b2f3dcf0f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4705f650-4db5-44b7-9bfc-734915d94a0f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("90149138-c486-44e6-8013-2f8536556c92"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9cfc23ca-afac-42ec-95bc-80ea175e2224"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c0cde653-7b23-4874-a3f0-094caf78692e"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("2de42580-622e-4782-a7f8-0d6a83421fc0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("b1f9a1a4-863e-41bd-b479-7140f10b3fd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15727fb7-c020-4103-ba37-a4dc682046fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("211f6213-a625-4138-a1e4-5f6814a8e516"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69315297-d703-44b0-97ce-3703cdf8f52b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7273dbd5-08d6-4227-a4a7-10f71536a29d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c65c634-b709-4d7b-8467-18047051e95c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af5c55ff-1d55-4917-bcf8-026c859f5b59"));

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

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("40b83c71-b09c-4e62-9b61-f769482cc8f9"), new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(202), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("2e2a8adb-ce5a-41f3-91cb-bc1ed678d0fc"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(4663), new DateTime(2021, 1, 22, 20, 56, 48, 119, DateTimeKind.Local).AddTicks(7652), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bf13a895-496a-4613-8dd3-6567105ff924"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(932), new DateTime(2021, 1, 22, 20, 56, 48, 120, DateTimeKind.Local).AddTicks(989), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("9c7635e6-0aaa-4c30-9c5f-d7dba155c747"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(1023), new DateTime(2021, 1, 22, 20, 56, 48, 120, DateTimeKind.Local).AddTicks(1026), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("b3c66986-0027-4eae-ada7-a950a6ac9cb2"), new DateTime(2021, 1, 22, 19, 56, 48, 112, DateTimeKind.Local).AddTicks(762), true, true, "GTA" },
                    { new Guid("984f04de-5a46-4ad1-bcf7-216b7380ab39"), new DateTime(2021, 1, 22, 19, 56, 48, 115, DateTimeKind.Local).AddTicks(7091), true, true, "Survival" },
                    { new Guid("a8cad085-5abc-43e0-ba60-82792a9af380"), new DateTime(2021, 1, 22, 19, 56, 48, 115, DateTimeKind.Local).AddTicks(7183), true, true, "Skyblock" },
                    { new Guid("9351f3c6-957c-43ef-817f-3ce5da0edaa1"), new DateTime(2021, 1, 22, 19, 56, 48, 115, DateTimeKind.Local).AddTicks(7192), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("f3980ca7-04c8-4169-933b-985b0727ff45"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4413), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b77ac46-9b3a-4ca8-a895-4d67f14f790e"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4423), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3fee8af2-d227-48ab-91d8-919a23362843"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4431), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a50112f7-15ce-49f4-bd8b-b1c68367ca3f"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4446), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b8a7b005-5402-4583-8aab-b9413f8a320f"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4477), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("96c3045e-d425-4a56-af10-b393b77a0aa7"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4462), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7307ff00-811a-4baa-b31d-8adca7138773"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4470), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("228113f8-cad5-4a14-9dc1-f137160ed68a"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4405), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d9a98637-6317-4419-b890-a11c3981f4d4"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4487), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b98f4b0-f51e-473f-9467-f8ee0d544dc3"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4454), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("82a1c119-b759-486c-929d-b00abbb7dff2"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4397), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4dfdf6f5-a438-4983-8241-d025b0c22a09"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4439), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f717dc6a-b8f9-4f8c-b79a-11f0e88a7f45"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4382), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("feb284a0-0915-4d12-8789-527aa5f4f17b"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4374), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1ace8adb-cdcd-4aa3-9edd-d7ff0348292b"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4366), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5707c6de-d681-468a-aeda-6998120ffddf"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4359), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3d6bc7c2-f270-4462-9f92-b0396775d68e"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4343), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("14ca3976-28fe-4948-bbe1-0da6710bdbe6"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4335), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2d0bc217-408b-44ba-899f-d917a3ccfa9e"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4328), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("079960c5-f3c7-4c38-8da0-f696e024cd0a"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4319), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dde7519b-efa7-4b36-8c4f-4f1046dadd27"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4310), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b73995d-ac73-42dc-abe0-a99afa56582e"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4299), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9cb3f786-e805-4975-9c2a-810eb2f7be93"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4091), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d6e92924-b502-41d2-b3c6-1e3a4820fa60"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4390), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("df0af38d-d5a4-49e9-b267-f154205406ee"), new DateTime(2021, 1, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(842), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("9307abd3-35fc-468f-baa6-e560883b6edf"), new DateTime(2021, 1, 22, 19, 55, 8, 122, DateTimeKind.Local).AddTicks(817), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("a23bd6be-53e0-4359-8714-2e13a95ba9c1"), new DateTime(2021, 1, 22, 19, 55, 58, 122, DateTimeKind.Local).AddTicks(834), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("eabea0aa-1ba9-4866-83a5-2450ef867b2d"), new DateTime(2021, 1, 22, 19, 53, 28, 122, DateTimeKind.Local).AddTicks(153), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("9d9a4340-fd66-4e1b-9c29-583074fdb75e"), new DateTime(2021, 1, 22, 19, 54, 18, 122, DateTimeKind.Local).AddTicks(799), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("164ef4b5-c9f4-4833-b987-86099ba0b11e"), new Guid("497d03c6-26ac-4648-9b9d-e27855ee596d"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(5986), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c4f8d52d-5587-4947-8755-42ff005b28cf"), new Guid("98b2e827-6f2e-43f7-847a-83bec0749d24"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(7321), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("fb617fe9-8db3-4df6-b516-f4ff8092d731"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4197), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6180f6c5-b39c-4a7c-9105-390ccbf7a4de"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4360), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("923fd496-897e-43c1-91db-7b31acb60ae8"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4370), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("be32afde-8514-4097-95fc-558053a33c2e"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4393), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a74579f7-7ea2-4d00-9784-8868954b67b1"), new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(4777), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("26fd153c-a5a4-4ea9-b0a9-285d72d81842"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4386), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(4945), new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(7851), new DateTime(2021, 1, 22, 19, 56, 48, 118, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(996), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(780), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(915), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(932) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlacklistedIPs");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("40b83c71-b09c-4e62-9b61-f769482cc8f9"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("2e2a8adb-ce5a-41f3-91cb-bc1ed678d0fc"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("9c7635e6-0aaa-4c30-9c5f-d7dba155c747"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bf13a895-496a-4613-8dd3-6567105ff924"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("9351f3c6-957c-43ef-817f-3ce5da0edaa1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("984f04de-5a46-4ad1-bcf7-216b7380ab39"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a8cad085-5abc-43e0-ba60-82792a9af380"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("b3c66986-0027-4eae-ada7-a950a6ac9cb2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("079960c5-f3c7-4c38-8da0-f696e024cd0a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b73995d-ac73-42dc-abe0-a99afa56582e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b77ac46-9b3a-4ca8-a895-4d67f14f790e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("14ca3976-28fe-4948-bbe1-0da6710bdbe6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1ace8adb-cdcd-4aa3-9edd-d7ff0348292b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("228113f8-cad5-4a14-9dc1-f137160ed68a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2d0bc217-408b-44ba-899f-d917a3ccfa9e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3d6bc7c2-f270-4462-9f92-b0396775d68e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3fee8af2-d227-48ab-91d8-919a23362843"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4dfdf6f5-a438-4983-8241-d025b0c22a09"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5707c6de-d681-468a-aeda-6998120ffddf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7307ff00-811a-4baa-b31d-8adca7138773"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("82a1c119-b759-486c-929d-b00abbb7dff2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b98f4b0-f51e-473f-9467-f8ee0d544dc3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("96c3045e-d425-4a56-af10-b393b77a0aa7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9cb3f786-e805-4975-9c2a-810eb2f7be93"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a50112f7-15ce-49f4-bd8b-b1c68367ca3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b8a7b005-5402-4583-8aab-b9413f8a320f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d6e92924-b502-41d2-b3c6-1e3a4820fa60"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d9a98637-6317-4419-b890-a11c3981f4d4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dde7519b-efa7-4b36-8c4f-4f1046dadd27"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f3980ca7-04c8-4169-933b-985b0727ff45"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f717dc6a-b8f9-4f8c-b79a-11f0e88a7f45"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("feb284a0-0915-4d12-8789-527aa5f4f17b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9307abd3-35fc-468f-baa6-e560883b6edf"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9d9a4340-fd66-4e1b-9c29-583074fdb75e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a23bd6be-53e0-4359-8714-2e13a95ba9c1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("df0af38d-d5a4-49e9-b267-f154205406ee"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("eabea0aa-1ba9-4866-83a5-2450ef867b2d"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("164ef4b5-c9f4-4833-b987-86099ba0b11e"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("c4f8d52d-5587-4947-8755-42ff005b28cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fd153c-a5a4-4ea9-b0a9-285d72d81842"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6180f6c5-b39c-4a7c-9105-390ccbf7a4de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("923fd496-897e-43c1-91db-7b31acb60ae8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a74579f7-7ea2-4d00-9784-8868954b67b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be32afde-8514-4097-95fc-558053a33c2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb617fe9-8db3-4df6-b516-f4ff8092d731"));

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

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("714c95ad-f2d1-488e-83f1-523e7b87deed"), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(459), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("a0f22b42-a0fc-4426-9432-b0c3c09da63f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(9537), new DateTime(2021, 1, 17, 14, 40, 50, 38, DateTimeKind.Local).AddTicks(817), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("283d0b28-0627-45ec-961f-e4fad3a4423e"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 17, 13, 40, 50, 38, DateTimeKind.Local).AddTicks(2767), new DateTime(2021, 1, 17, 14, 40, 50, 38, DateTimeKind.Local).AddTicks(2821), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("14cee08d-fbab-45f1-ba35-42503b2b4b17"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 17, 13, 40, 50, 38, DateTimeKind.Local).AddTicks(2854), new DateTime(2021, 1, 17, 14, 40, 50, 38, DateTimeKind.Local).AddTicks(2857), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("747cbe64-13e1-4edf-a5d2-6d1f972463fd"), new DateTime(2021, 1, 17, 13, 40, 50, 33, DateTimeKind.Local).AddTicks(549), true, true, "GTA" },
                    { new Guid("e085e0db-c6ef-47b7-adca-4d0825855fa8"), new DateTime(2021, 1, 17, 13, 40, 50, 35, DateTimeKind.Local).AddTicks(8984), true, true, "Survival" },
                    { new Guid("526d50dd-d8c5-4726-8b66-6164ed0aecdb"), new DateTime(2021, 1, 17, 13, 40, 50, 35, DateTimeKind.Local).AddTicks(9058), true, true, "Skyblock" },
                    { new Guid("52ddf923-9e3c-4830-a88d-f60299c7feae"), new DateTime(2021, 1, 17, 13, 40, 50, 35, DateTimeKind.Local).AddTicks(9064), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("9eace636-3f4a-4bed-a8df-69891b0454e3"), new DateTime(2020, 12, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3915), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6947dea1-334b-4647-b3a0-90e9de4419b2"), new DateTime(2020, 9, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3923), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("839e9d01-4d5c-4acb-b1a2-7ef480aac8da"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3930), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9d864e4-4a9f-4cfe-aceb-0171beee29f2"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3947), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8ae40e42-6595-4190-bd4a-da747c05182a"), new DateTime(2020, 12, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3977), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("357464a9-f6a6-4c0d-8278-12f67da12378"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3962), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cfcf94a0-6b5e-4f28-807f-8bbfe76aefc0"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3969), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9ed1a275-dec2-4dd8-b9ae-9a14ece4d268"), new DateTime(2020, 12, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3908), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("188aed26-29b6-4aa7-9b86-b0affad70ed1"), new DateTime(2020, 12, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3984), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("03e7cf9c-cc5e-4908-84b9-ce433b883eb2"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3955), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("908fbdc4-77b5-4618-97a3-7ca4195558eb"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3900), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0db52e68-7256-4d3a-843b-b166ad89f26e"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3937), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0186a1e0-41fa-4319-bb13-b4fbbb229b4c"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3885), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("065bcee6-a89f-4635-b8f0-ba556266acb0"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3875), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9a75d6bf-2a69-4058-880f-460d6fa728e2"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3868), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fea4951d-e505-4eca-8b09-7a830ca3d83e"), new DateTime(2020, 9, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3860), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7263d18b-086b-4ebf-8a0e-128246e26642"), new DateTime(2020, 9, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3852), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("12083836-f9b2-4c9b-8a3f-263da1999876"), new DateTime(2020, 12, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3845), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("db0436d3-75a4-4de0-8dc4-e0c03a37b20c"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3837), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("60c8acd5-00b1-45cf-a876-f9dd93ea8c19"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3829), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4bf5f123-eebf-4024-a2b3-80d6878c3556"), new DateTime(2020, 10, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3821), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f4e4af6f-9c1c-449d-9cb6-b2f2eed61e5b"), new DateTime(2020, 9, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3802), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("903346e9-4484-4b59-90b4-d9cadff92cc1"), new DateTime(2020, 9, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3642), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("abc2caaf-303c-4ce6-85db-9b964b5e2468"), new DateTime(2020, 11, 17, 13, 40, 50, 40, DateTimeKind.Local).AddTicks(3893), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("4705f650-4db5-44b7-9bfc-734915d94a0f"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(8804), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("c0cde653-7b23-4874-a3f0-094caf78692e"), new DateTime(2021, 1, 17, 13, 39, 10, 39, DateTimeKind.Local).AddTicks(8789), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("90149138-c486-44e6-8013-2f8536556c92"), new DateTime(2021, 1, 17, 13, 40, 0, 39, DateTimeKind.Local).AddTicks(8797), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("0b260b8e-4e82-47c2-b696-019b2f3dcf0f"), new DateTime(2021, 1, 17, 13, 37, 30, 39, DateTimeKind.Local).AddTicks(8173), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("9cfc23ca-afac-42ec-95bc-80ea175e2224"), new DateTime(2021, 1, 17, 13, 38, 20, 39, DateTimeKind.Local).AddTicks(8771), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("2de42580-622e-4782-a7f8-0d6a83421fc0"), new Guid("dd73d403-a09a-4113-9b18-3d9918cc0e16"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(4476), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b1f9a1a4-863e-41bd-b479-7140f10b3fd2"), new Guid("57f13a72-c593-48e3-a895-51bc71433e6b"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(5503), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 13, 40, 50, 38, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 13, 40, 50, 38, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("15727fb7-c020-4103-ba37-a4dc682046fb"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(3579), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("af5c55ff-1d55-4917-bcf8-026c859f5b59"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(3696), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("211f6213-a625-4138-a1e4-5f6814a8e516"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(3704), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("8c65c634-b709-4d7b-8467-18047051e95c"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(3716), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("69315297-d703-44b0-97ce-3703cdf8f52b"), new DateTime(2021, 1, 17, 13, 40, 50, 38, DateTimeKind.Local).AddTicks(9089), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7273dbd5-08d6-4227-a4a7-10f71536a29d"), new DateTime(2021, 1, 17, 13, 40, 50, 39, DateTimeKind.Local).AddTicks(3710), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(4133), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(5948), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(8784), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(8789), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(8677), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(8734), new DateTime(2021, 1, 17, 13, 40, 50, 37, DateTimeKind.Local).AddTicks(8751) });
        }
    }
}
