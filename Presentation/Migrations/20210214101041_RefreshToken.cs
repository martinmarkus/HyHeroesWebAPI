using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("6f1c97dc-a4d5-4813-b030-5f2120027765"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("197edab6-2cdb-4316-a4df-9b1f86618a0f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("b8bf96e2-c772-40d1-a4d2-40ac365c71bf"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("e4ea489b-bbff-4aa2-93e8-c4a6f68744cd"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("42d32548-577a-49cd-9820-0a23281adeae"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("87d01b58-37c5-4657-968c-cfee18e90fcf"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("8bcb5cd6-9e6d-4c69-9c2e-878a571260ca"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("bc8bedc3-13c4-46fa-a72a-c8e8f7997f06"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("007ca112-a729-4e5c-8a31-92cf6e4ddb12"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("08099de1-c113-4cd7-9f2f-25e1869507a5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("14511d88-0f60-4545-8624-ff70f5faedfb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1bd85d8b-1d59-4187-bf32-e0c61382972b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1cb758d1-856c-4c9f-bf77-325ea722dd04"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3197527c-b965-4e3a-b1f0-dd2e7ca82906"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("57a17299-f94d-4484-b8af-09e3e32ae147"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6566cf87-f8bd-4a0d-83d9-90b32dc7c511"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("65a4c70c-2eee-4822-9574-c1decc9a7ec1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6b4083bc-de9c-49b3-b7d4-d2f419ac2aa1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7e33bb30-dd1b-47ac-af47-7b1bf064f383"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8f110dfc-2f80-4e8a-8dfd-e207272f15dc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9c82428d-c09f-4679-ad98-13dc20641919"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a8b723e3-170d-4426-8e14-32b3340285a0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("abf07558-496c-45bd-b5d4-a0cae652a961"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ad0f082b-4c79-44d5-86e9-b422c9b18fdc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("adda26fb-8181-42e6-b24e-13521771abe5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("afa39b0c-5b8e-493c-a42e-b9f43c71c991"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b722e940-999e-4c02-8484-91d784e58566"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c318f77a-4e23-450b-86bd-d62312b42995"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("de165cd3-2b3b-4c12-b45c-444bd5d48077"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e3e29c2c-3949-472a-b401-81be0c7cf606"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f6b55dfa-f562-4e17-83b0-2e27dded16f1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fa00f7d5-8e6c-4ae1-bd6c-c0085cf97360"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("45baa07e-cd15-42a1-b0a7-547d7e01b8fd"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4c1f481b-341e-448b-b13a-45566d356236"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4e058def-8c7a-4506-aa9a-e0af7d9d5292"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("75efb87e-2694-40ec-ba9a-5c37484beebd"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("778f7c45-9b2e-47e9-ac82-63169ae236d4"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("dd9ddd0f-4191-4b71-927c-20cc79af2df1"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("e7367503-0b2a-4f51-a69c-70368c96ff52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b2a6fd9-f34d-45a7-87b3-348bb16eb060"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57b914e4-6154-4631-a311-f9ae04b82ed0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83085ee6-8e6b-4855-b855-4ee2e5d62199"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f509666-c640-4843-9b23-24acd74ec099"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acfe3a13-6da8-449b-8678-cced7ec4c118"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baca7038-f261-4236-a759-3a54afdcca9f"));

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
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    TokenValue = table.Column<string>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("3b641223-9ad8-4d10-bdd6-2b34eb3bc95c"), new DateTime(2021, 2, 14, 11, 10, 40, 422, DateTimeKind.Local).AddTicks(8495), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("b3241851-1f3a-459d-8209-6a36c3e9563b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7916), new DateTime(2021, 2, 14, 11, 11, 40, 423, DateTimeKind.Local).AddTicks(9213), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("6c998e4e-4f2d-49a6-a139-4fdfe53d83c7"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(227), new DateTime(2021, 2, 14, 11, 11, 40, 424, DateTimeKind.Local).AddTicks(258), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("7ef0c364-52be-4fa3-b205-c1ce92caac2b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(282), new DateTime(2021, 2, 14, 11, 11, 40, 424, DateTimeKind.Local).AddTicks(286), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("be90db9a-503b-456a-b221-7877312df5ab"), new DateTime(2021, 2, 14, 11, 10, 40, 418, DateTimeKind.Local).AddTicks(7558), true, true, "GTA" },
                    { new Guid("b13e6c2a-1418-421d-bb48-37e09dc19eeb"), new DateTime(2021, 2, 14, 11, 10, 40, 421, DateTimeKind.Local).AddTicks(7042), true, true, "Survival" },
                    { new Guid("93959ca5-9599-4d3e-964c-9f0f83bfcc19"), new DateTime(2021, 2, 14, 11, 10, 40, 421, DateTimeKind.Local).AddTicks(7087), true, true, "Skyblock" },
                    { new Guid("0efa4778-ec64-45fd-9c7f-b080ab13c11f"), new DateTime(2021, 2, 14, 11, 10, 40, 421, DateTimeKind.Local).AddTicks(7093), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("822b6a5c-ec50-467f-b60b-cfd117055d50"), new DateTime(2021, 1, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4793), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("32c55f6b-5d1e-4fdd-b840-423464a26cd7"), new DateTime(2020, 10, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4800), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0d89183f-6cfc-4df8-ad99-6169816b5b7c"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4811), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d2f52780-3859-4542-9ee0-081bd0664d3f"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4826), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("51546736-1e04-45f5-9935-8bdb2ee0e14e"), new DateTime(2021, 1, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4856), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3f0a5b6c-3a5a-4aaa-8c53-91af9245377e"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4841), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1d743540-aaf6-4428-ba7e-3728c7574176"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4849), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1bbb38a1-a9b5-438b-bae2-45a92a95ee0b"), new DateTime(2021, 1, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4785), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b87b4095-c1ef-4d63-955c-9c05bbf66191"), new DateTime(2021, 1, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4864), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("626ad195-14f5-46bf-8b0d-2ad2c9ae23f1"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4833), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("677c787f-5bf3-4162-8a3b-da5093594f33"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4777), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f64a649e-ccee-4709-ac8b-0fdbac692486"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4818), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7ca02cba-cd20-429c-8a3a-122fd46bc3ee"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4762), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c667d899-6353-46bf-98f0-fad3317be864"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4754), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6e5ccc2d-8d69-4008-a295-d8279a6fe22b"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4746), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a9ecb0a2-07f9-4eeb-a40d-9caea4daebbd"), new DateTime(2020, 10, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4733), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b44c9c5f-ca67-40dc-939b-4fd58e213e9d"), new DateTime(2020, 10, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4726), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9978265d-9f89-402b-b33b-1358b90cc5eb"), new DateTime(2021, 1, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4718), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("beba305a-dcb7-4f4b-be45-7d76bbbd6516"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4710), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a9d43ed5-ae4e-4fe2-8c80-d0f3352d92b8"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4703), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("72c0e7bf-2fd7-45e0-ac1a-6c5c745445aa"), new DateTime(2020, 11, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4695), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e7a7c08c-cb5a-4264-bd41-ae1019e5a846"), new DateTime(2020, 10, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4685), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9dd1127b-7108-4964-a085-98c5d6feda8f"), new DateTime(2020, 10, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4574), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6d19f0e9-06aa-4447-b24b-2279c6ae6c0a"), new DateTime(2020, 12, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(4770), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("246e387e-5dc6-4b27-974f-c2ec3c9efd05"), new DateTime(2021, 2, 14, 11, 10, 40, 425, DateTimeKind.Local).AddTicks(2027), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("e69a98c8-2242-4338-aca5-4b85ebed581b"), new DateTime(2021, 2, 14, 11, 9, 0, 425, DateTimeKind.Local).AddTicks(2013), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("73bf27db-71b3-45bc-b473-1275ff3eb9a2"), new DateTime(2021, 2, 14, 11, 9, 50, 425, DateTimeKind.Local).AddTicks(2020), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("69426e7e-ef6a-40cc-8bda-97973e507d2d"), new DateTime(2021, 2, 14, 11, 7, 20, 425, DateTimeKind.Local).AddTicks(1417), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("affdc6c7-8ba3-42b0-b360-0ed7107ac7cd"), new DateTime(2021, 2, 14, 11, 8, 10, 425, DateTimeKind.Local).AddTicks(1998), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ef8d3fe1-57af-445b-9a9f-d8ae8c217de6"), new Guid("c6becc09-8a10-4dbc-9c90-131cdd404d47"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(7755), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("635dd048-a196-4017-9b6d-2a3e1e1e3a79"), new Guid("473caf62-aba7-419d-aaab-5c563870bcb5"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(8786), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("3ba81028-0011-497c-a8eb-7adb8dc0fef8"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(6913), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d965d587-eab7-4982-ae25-8c586cb85294"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(7013), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ba332a31-3256-478a-8ad7-baae1c70ebf8"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(7020), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("fcbff7ea-ae35-4f16-8c80-a67c8caf56fa"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(7031), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("46cd5a44-f011-4d21-86cb-66bcfc5075a2"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(2530), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5a8b6c76-cc5b-4951-b61a-5c4a7b3734f8"), new DateTime(2021, 2, 14, 11, 10, 40, 424, DateTimeKind.Local).AddTicks(7026), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 14, 11, 10, 40, 422, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(2555), new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(4329), new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7180), new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7185), new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7082), new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7124), new DateTime(2021, 2, 14, 11, 10, 40, 423, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("3b641223-9ad8-4d10-bdd6-2b34eb3bc95c"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("6c998e4e-4f2d-49a6-a139-4fdfe53d83c7"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7ef0c364-52be-4fa3-b205-c1ce92caac2b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("b3241851-1f3a-459d-8209-6a36c3e9563b"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("0efa4778-ec64-45fd-9c7f-b080ab13c11f"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("93959ca5-9599-4d3e-964c-9f0f83bfcc19"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("b13e6c2a-1418-421d-bb48-37e09dc19eeb"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("be90db9a-503b-456a-b221-7877312df5ab"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0d89183f-6cfc-4df8-ad99-6169816b5b7c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1bbb38a1-a9b5-438b-bae2-45a92a95ee0b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1d743540-aaf6-4428-ba7e-3728c7574176"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("32c55f6b-5d1e-4fdd-b840-423464a26cd7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3f0a5b6c-3a5a-4aaa-8c53-91af9245377e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("51546736-1e04-45f5-9935-8bdb2ee0e14e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("626ad195-14f5-46bf-8b0d-2ad2c9ae23f1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("677c787f-5bf3-4162-8a3b-da5093594f33"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6d19f0e9-06aa-4447-b24b-2279c6ae6c0a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6e5ccc2d-8d69-4008-a295-d8279a6fe22b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("72c0e7bf-2fd7-45e0-ac1a-6c5c745445aa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7ca02cba-cd20-429c-8a3a-122fd46bc3ee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("822b6a5c-ec50-467f-b60b-cfd117055d50"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9978265d-9f89-402b-b33b-1358b90cc5eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9dd1127b-7108-4964-a085-98c5d6feda8f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a9d43ed5-ae4e-4fe2-8c80-d0f3352d92b8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a9ecb0a2-07f9-4eeb-a40d-9caea4daebbd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b44c9c5f-ca67-40dc-939b-4fd58e213e9d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b87b4095-c1ef-4d63-955c-9c05bbf66191"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("beba305a-dcb7-4f4b-be45-7d76bbbd6516"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c667d899-6353-46bf-98f0-fad3317be864"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d2f52780-3859-4542-9ee0-081bd0664d3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e7a7c08c-cb5a-4264-bd41-ae1019e5a846"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f64a649e-ccee-4709-ac8b-0fdbac692486"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("246e387e-5dc6-4b27-974f-c2ec3c9efd05"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("69426e7e-ef6a-40cc-8bda-97973e507d2d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("73bf27db-71b3-45bc-b473-1275ff3eb9a2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("affdc6c7-8ba3-42b0-b360-0ed7107ac7cd"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e69a98c8-2242-4338-aca5-4b85ebed581b"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("635dd048-a196-4017-9b6d-2a3e1e1e3a79"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("ef8d3fe1-57af-445b-9a9f-d8ae8c217de6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ba81028-0011-497c-a8eb-7adb8dc0fef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46cd5a44-f011-4d21-86cb-66bcfc5075a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a8b6c76-cc5b-4951-b61a-5c4a7b3734f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba332a31-3256-478a-8ad7-baae1c70ebf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d965d587-eab7-4982-ae25-8c586cb85294"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcbff7ea-ae35-4f16-8c80-a67c8caf56fa"));

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
                values: new object[] { new Guid("6f1c97dc-a4d5-4813-b030-5f2120027765"), new DateTime(2021, 2, 13, 20, 19, 26, 551, DateTimeKind.Local).AddTicks(4207), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("e4ea489b-bbff-4aa2-93e8-c4a6f68744cd"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(4099), new DateTime(2021, 2, 13, 20, 20, 26, 552, DateTimeKind.Local).AddTicks(5607), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("197edab6-2cdb-4316-a4df-9b1f86618a0f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(6658), new DateTime(2021, 2, 13, 20, 20, 26, 552, DateTimeKind.Local).AddTicks(6688), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("b8bf96e2-c772-40d1-a4d2-40ac365c71bf"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(6711), new DateTime(2021, 2, 13, 20, 20, 26, 552, DateTimeKind.Local).AddTicks(6714), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("87d01b58-37c5-4657-968c-cfee18e90fcf"), new DateTime(2021, 2, 13, 20, 19, 26, 546, DateTimeKind.Local).AddTicks(8917), true, true, "GTA" },
                    { new Guid("42d32548-577a-49cd-9820-0a23281adeae"), new DateTime(2021, 2, 13, 20, 19, 26, 550, DateTimeKind.Local).AddTicks(1719), true, true, "Survival" },
                    { new Guid("bc8bedc3-13c4-46fa-a72a-c8e8f7997f06"), new DateTime(2021, 2, 13, 20, 19, 26, 550, DateTimeKind.Local).AddTicks(1776), true, true, "Skyblock" },
                    { new Guid("8bcb5cd6-9e6d-4c69-9c2e-878a571260ca"), new DateTime(2021, 2, 13, 20, 19, 26, 550, DateTimeKind.Local).AddTicks(1782), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("1cb758d1-856c-4c9f-bf77-325ea722dd04"), new DateTime(2021, 1, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2622), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ad0f082b-4c79-44d5-86e9-b422c9b18fdc"), new DateTime(2020, 10, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2630), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("08099de1-c113-4cd7-9f2f-25e1869507a5"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2638), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6566cf87-f8bd-4a0d-83d9-90b32dc7c511"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2653), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c318f77a-4e23-450b-86bd-d62312b42995"), new DateTime(2021, 1, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2686), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6b4083bc-de9c-49b3-b7d4-d2f419ac2aa1"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2671), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("abf07558-496c-45bd-b5d4-a0cae652a961"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2678), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1bd85d8b-1d59-4187-bf32-e0c61382972b"), new DateTime(2021, 1, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2615), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("57a17299-f94d-4484-b8af-09e3e32ae147"), new DateTime(2021, 1, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2694), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3e29c2c-3949-472a-b401-81be0c7cf606"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2663), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("afa39b0c-5b8e-493c-a42e-b9f43c71c991"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2607), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b722e940-999e-4c02-8484-91d784e58566"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2646), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7e33bb30-dd1b-47ac-af47-7b1bf064f383"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2431), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fa00f7d5-8e6c-4ae1-bd6c-c0085cf97360"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2423), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9c82428d-c09f-4679-ad98-13dc20641919"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2416), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a8b723e3-170d-4426-8e14-32b3340285a0"), new DateTime(2020, 10, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2408), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("14511d88-0f60-4545-8624-ff70f5faedfb"), new DateTime(2020, 10, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2401), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f6b55dfa-f562-4e17-83b0-2e27dded16f1"), new DateTime(2021, 1, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2393), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("65a4c70c-2eee-4822-9574-c1decc9a7ec1"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2385), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3197527c-b965-4e3a-b1f0-dd2e7ca82906"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2377), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8f110dfc-2f80-4e8a-8dfd-e207272f15dc"), new DateTime(2020, 11, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2364), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("adda26fb-8181-42e6-b24e-13521771abe5"), new DateTime(2020, 10, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2354), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("de165cd3-2b3b-4c12-b45c-444bd5d48077"), new DateTime(2020, 10, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2242), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("007ca112-a729-4e5c-8a31-92cf6e4ddb12"), new DateTime(2020, 12, 13, 20, 19, 26, 554, DateTimeKind.Local).AddTicks(2599), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("45baa07e-cd15-42a1-b0a7-547d7e01b8fd"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(9664), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("778f7c45-9b2e-47e9-ac82-63169ae236d4"), new DateTime(2021, 2, 13, 20, 17, 46, 553, DateTimeKind.Local).AddTicks(9648), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("4c1f481b-341e-448b-b13a-45566d356236"), new DateTime(2021, 2, 13, 20, 18, 36, 553, DateTimeKind.Local).AddTicks(9656), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("4e058def-8c7a-4506-aa9a-e0af7d9d5292"), new DateTime(2021, 2, 13, 20, 16, 6, 553, DateTimeKind.Local).AddTicks(8953), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("75efb87e-2694-40ec-ba9a-5c37484beebd"), new DateTime(2021, 2, 13, 20, 16, 56, 553, DateTimeKind.Local).AddTicks(9634), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e7367503-0b2a-4f51-a69c-70368c96ff52"), new Guid("0417fd6c-c81f-47d8-b3fa-2540b7c0f30f"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(4901), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dd9ddd0f-4191-4b71-927c-20cc79af2df1"), new Guid("6fcfd239-53ca-4017-85c2-46d9c3017533"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(6248), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("baca7038-f261-4236-a759-3a54afdcca9f"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(4011), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("83085ee6-8e6b-4855-b855-4ee2e5d62199"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(4122), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0b2a6fd9-f34d-45a7-87b3-348bb16eb060"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(4130), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("57b914e4-6154-4631-a311-f9ae04b82ed0"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(4140), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("9f509666-c640-4843-9b23-24acd74ec099"), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(9117), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("acfe3a13-6da8-449b-8678-cced7ec4c118"), new DateTime(2021, 2, 13, 20, 19, 26, 553, DateTimeKind.Local).AddTicks(4135), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 13, 20, 19, 26, 551, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 13, 20, 19, 26, 551, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 13, 20, 19, 26, 551, DateTimeKind.Local).AddTicks(8458), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(265), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(3303), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(3310), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(3185), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(3234), new DateTime(2021, 2, 13, 20, 19, 26, 552, DateTimeKind.Local).AddTicks(3248) });
        }
    }
}
