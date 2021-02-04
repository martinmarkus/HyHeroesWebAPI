using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BillingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("21c99134-cce0-4f56-adc4-c155b36aeedd"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("5e4a6da1-d635-44a5-9a83-67a999859b71"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a2a2e5ba-eea8-4418-8d35-e0fddc953fda"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bad6f70f-575a-4002-960c-8c90189ac672"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("30a59ee5-cb33-4567-8918-2b9bbd8c00e1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("3f1c10b2-0990-4b02-a665-3ec993203509"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7e14dd4e-cab3-4830-8675-ef54b7647364"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ed9f1b4f-34b5-463f-962c-61b8d7dcef05"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("16085f65-cf11-4027-8c18-13bf6711418b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28b785e4-bbad-4271-aa59-67bf4fdaf023"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a1cc6fb-9c7d-453f-a716-8d0c5dcdc6cc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("543a1c71-bd8d-4154-abdb-0fcdee01fcbf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("58e344c6-c360-4b12-8b93-935c57dddefd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6667f096-86fe-4d80-b96a-116a39f1c47f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6e493e06-43d9-4c7e-8923-c02237cec6c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7af55295-e182-47d6-8c8e-776de7c135e3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("81604681-016f-4074-80e6-1ab89d5be8c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("86ac8b5a-2bd7-4aa4-9f50-29cbf183f8c7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b2136f4-5941-4494-8ea5-bf9c7bd9b2be"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("915b3682-b538-48b0-a911-4ad43f8fa58a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a6c34816-60a8-43ef-a432-1e3e014035a8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa09e56b-176c-4d50-bcf6-641f67dbfd7e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa5ced26-8de6-4d03-b4c1-89f77b95d5cf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b2348b89-0578-4428-b25e-146c85c372eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b7900bc1-b878-4ea2-b700-e9ccc4058b12"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c347fd1b-19ad-4655-ab63-57729fba287a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ccfa4c70-1360-4d9b-a33f-8cedeb371099"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d8f36831-7060-42d0-a0dc-186378f194e5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dc918305-a10b-42f5-9e86-e7329c0a740f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dffa3cc6-b447-49a9-99b6-afaa7fb7e330"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e975fdf8-d231-4e62-af1b-24c50a6df7ee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f0e5ee5e-32e5-4057-8232-ce55f318066e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("12a6e1da-0ac2-4c22-a511-69d8440ffd6a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("22d5daf6-38a7-4642-8038-e13ae141e313"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5ac82dc2-b300-4579-80b0-bad9913e121b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("6d392abf-06e0-40b3-8b12-8fe9b559f214"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("dfadf811-ed26-40db-a152-8ec3bf7f24fd"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("4c4cd815-23b9-4869-93ff-8c22a660e6e0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("ea178318-c10e-4b13-9906-6e40578b12bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14244119-fcdf-4492-ac3f-c85939aeb92f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76815196-e78c-4f48-847c-1e715fee27c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83559d12-3354-497d-80aa-b0057a9c6960"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8551f547-43c6-480d-9f66-d85c2ea11b56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acfe2282-1c54-43ec-ac91-49b238599db0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c836daf4-c948-497d-b227-bacc54773766"));

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

            migrationBuilder.AddColumn<string>(
                name: "BillingName",
                table: "BarionTransactions",
                nullable: true);

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
                table: "ActualValueOfOneKredit",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("93301d7b-c248-49c6-9262-256c7f406a64"), new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(6249), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("25ccaa2f-9484-4e30-a470-a507f552bcb8"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(5365), new DateTime(2021, 2, 4, 21, 48, 47, 623, DateTimeKind.Local).AddTicks(6666), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d79549f9-6e32-4425-b76e-c7ab40575d4f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(7701), new DateTime(2021, 2, 4, 21, 48, 47, 623, DateTimeKind.Local).AddTicks(7751), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("fa5ad48a-1e72-46f9-9993-6da78e308c41"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(7781), new DateTime(2021, 2, 4, 21, 48, 47, 623, DateTimeKind.Local).AddTicks(7784), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ac05aae8-fb8e-411b-979d-e4db6ce328e1"), new DateTime(2021, 2, 4, 20, 48, 47, 618, DateTimeKind.Local).AddTicks(4307), true, true, "GTA" },
                    { new Guid("f5460ffc-4cdd-415a-b224-c4d2cb4eb210"), new DateTime(2021, 2, 4, 20, 48, 47, 621, DateTimeKind.Local).AddTicks(4253), true, true, "Survival" },
                    { new Guid("7281b404-d91e-4e04-9514-89c244f80cd7"), new DateTime(2021, 2, 4, 20, 48, 47, 621, DateTimeKind.Local).AddTicks(4304), true, true, "Skyblock" },
                    { new Guid("94ed23e0-f82e-42e4-99e0-42729919ddc4"), new DateTime(2021, 2, 4, 20, 48, 47, 621, DateTimeKind.Local).AddTicks(4310), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("dfb95a73-c9b5-4907-94c1-f26a37582b02"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2415), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("12f11752-1af3-40c3-9cad-57da9dc7e316"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2423), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dd1983ce-7ee7-493c-9774-ba08d874e04c"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2431), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cb76f23c-0eb4-432b-b471-258681b76f7b"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2446), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("202d1f2e-5c6f-4ca9-9e61-9d6875af6f7c"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2478), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a5783918-3d2b-4b60-8b28-ababbdfc27e1"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2461), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("504c0f09-de70-4b52-ae8e-24e437915f87"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2469), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bb1aaa27-db45-4635-a12f-cd64bebe029d"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2405), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c229466-6adf-4e52-9d2c-1bde9cfb5107"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2486), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1a7823b8-ebdc-43bc-99d4-281d2ff9736f"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2453), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b251bc2c-0fdb-419e-a6c2-c9be97d58174"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2398), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9ed08f66-6643-454b-b126-57c223ef4ed8"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2438), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("283ac6ae-1d21-46c5-959b-669078f15270"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2383), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d636f910-f51c-48c1-beec-8d7af9195917"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2375), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("648c2ac3-4282-4601-a18d-1923d3736eb8"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2367), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aa4fdf39-6e9a-4e31-a72d-eb0dea52f460"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2360), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ad18087a-69c2-4b6a-9f47-ec04dfe0af8e"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2352), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f041548e-0438-4303-b7f6-37b9a6ce35ae"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2339), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7fcc35fd-1df8-4cf5-a769-75d17f2ffa29"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2331), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("024b6712-6960-49d9-868e-13aead259a97"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2323), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("41f18776-4fbd-4a33-a33c-125e8d82bb6b"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2315), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0cf219d2-d6ab-40ac-b073-6f0ff469c55c"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2305), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("830eacc1-0780-44de-824b-decbcd9f3784"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2201), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6283b6dc-8a52-435c-9734-58d2e449a743"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2390), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("266b9103-6745-439f-90ac-d4816be91ac6"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(9720), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("dba51ddd-9e29-4fcf-a052-1feaeacaa275"), new DateTime(2021, 2, 4, 20, 47, 7, 624, DateTimeKind.Local).AddTicks(9697), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("80f431bb-24e1-4d74-98a4-eee3e053ac24"), new DateTime(2021, 2, 4, 20, 47, 57, 624, DateTimeKind.Local).AddTicks(9713), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("433752eb-8874-49dc-b52a-8bf33769a383"), new DateTime(2021, 2, 4, 20, 45, 27, 624, DateTimeKind.Local).AddTicks(9097), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("4f57a349-d12b-4f46-b361-8bcf880deb34"), new DateTime(2021, 2, 4, 20, 46, 17, 624, DateTimeKind.Local).AddTicks(9679), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4de751e8-c5c6-442c-906f-d1d4a7f1e758"), new Guid("8b7c89d4-67af-4bc7-a0cb-a115c8e884ae"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(5548), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("81efa3a6-f3ca-4a28-8039-81be0c9bf212"), new Guid("38dd020a-275f-40ef-8347-f8f3342066e4"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(6591), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("54ab3dfb-92a9-4e29-901b-792673940e2d"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4656), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("58f94f4b-aa9a-43a6-9fd5-0487fc6a8846"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4758), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("deabeb41-9c81-4ae2-bcf2-e5694fbaa319"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4767), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("bd657841-135b-47c0-8d62-491a09b69f0a"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4824), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("25573f10-f627-4b82-833d-6f4718a19307"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(18), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("c3f42c8d-2aba-464b-9de0-18da9bcc31eb"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4812), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(9973), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(1747), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4639), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4644), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4528), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4583), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4598) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("93301d7b-c248-49c6-9262-256c7f406a64"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("25ccaa2f-9484-4e30-a470-a507f552bcb8"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("d79549f9-6e32-4425-b76e-c7ab40575d4f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("fa5ad48a-1e72-46f9-9993-6da78e308c41"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7281b404-d91e-4e04-9514-89c244f80cd7"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("94ed23e0-f82e-42e4-99e0-42729919ddc4"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ac05aae8-fb8e-411b-979d-e4db6ce328e1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("f5460ffc-4cdd-415a-b224-c4d2cb4eb210"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("024b6712-6960-49d9-868e-13aead259a97"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0cf219d2-d6ab-40ac-b073-6f0ff469c55c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("12f11752-1af3-40c3-9cad-57da9dc7e316"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1a7823b8-ebdc-43bc-99d4-281d2ff9736f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("202d1f2e-5c6f-4ca9-9e61-9d6875af6f7c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("283ac6ae-1d21-46c5-959b-669078f15270"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c229466-6adf-4e52-9d2c-1bde9cfb5107"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("41f18776-4fbd-4a33-a33c-125e8d82bb6b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("504c0f09-de70-4b52-ae8e-24e437915f87"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6283b6dc-8a52-435c-9734-58d2e449a743"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("648c2ac3-4282-4601-a18d-1923d3736eb8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7fcc35fd-1df8-4cf5-a769-75d17f2ffa29"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("830eacc1-0780-44de-824b-decbcd9f3784"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9ed08f66-6643-454b-b126-57c223ef4ed8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a5783918-3d2b-4b60-8b28-ababbdfc27e1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa4fdf39-6e9a-4e31-a72d-eb0dea52f460"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ad18087a-69c2-4b6a-9f47-ec04dfe0af8e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b251bc2c-0fdb-419e-a6c2-c9be97d58174"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bb1aaa27-db45-4635-a12f-cd64bebe029d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cb76f23c-0eb4-432b-b471-258681b76f7b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d636f910-f51c-48c1-beec-8d7af9195917"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dd1983ce-7ee7-493c-9774-ba08d874e04c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dfb95a73-c9b5-4907-94c1-f26a37582b02"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f041548e-0438-4303-b7f6-37b9a6ce35ae"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("266b9103-6745-439f-90ac-d4816be91ac6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("433752eb-8874-49dc-b52a-8bf33769a383"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4f57a349-d12b-4f46-b361-8bcf880deb34"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("80f431bb-24e1-4d74-98a4-eee3e053ac24"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("dba51ddd-9e29-4fcf-a052-1feaeacaa275"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("4de751e8-c5c6-442c-906f-d1d4a7f1e758"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("81efa3a6-f3ca-4a28-8039-81be0c9bf212"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25573f10-f627-4b82-833d-6f4718a19307"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54ab3dfb-92a9-4e29-901b-792673940e2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58f94f4b-aa9a-43a6-9fd5-0487fc6a8846"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd657841-135b-47c0-8d62-491a09b69f0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3f42c8d-2aba-464b-9de0-18da9bcc31eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deabeb41-9c81-4ae2-bcf2-e5694fbaa319"));

            migrationBuilder.DropColumn(
                name: "BillingName",
                table: "BarionTransactions");

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
                values: new object[] { new Guid("21c99134-cce0-4f56-adc4-c155b36aeedd"), new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(1764), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("a2a2e5ba-eea8-4418-8d35-e0fddc953fda"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(785), new DateTime(2021, 2, 4, 20, 48, 16, 374, DateTimeKind.Local).AddTicks(2088), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bad6f70f-575a-4002-960c-8c90189ac672"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 2, 4, 20, 48, 16, 374, DateTimeKind.Local).AddTicks(3168), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("5e4a6da1-d635-44a5-9a83-67a999859b71"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(3191), new DateTime(2021, 2, 4, 20, 48, 16, 374, DateTimeKind.Local).AddTicks(3195), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ed9f1b4f-34b5-463f-962c-61b8d7dcef05"), new DateTime(2021, 2, 4, 19, 48, 16, 369, DateTimeKind.Local).AddTicks(460), true, true, "GTA" },
                    { new Guid("7e14dd4e-cab3-4830-8675-ef54b7647364"), new DateTime(2021, 2, 4, 19, 48, 16, 371, DateTimeKind.Local).AddTicks(9962), true, true, "Survival" },
                    { new Guid("30a59ee5-cb33-4567-8918-2b9bbd8c00e1"), new DateTime(2021, 2, 4, 19, 48, 16, 372, DateTimeKind.Local).AddTicks(11), true, true, "Skyblock" },
                    { new Guid("3f1c10b2-0990-4b02-a665-3ec993203509"), new DateTime(2021, 2, 4, 19, 48, 16, 372, DateTimeKind.Local).AddTicks(29), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa5ced26-8de6-4d03-b4c1-89f77b95d5cf"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7743), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("58e344c6-c360-4b12-8b93-935c57dddefd"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7751), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f0e5ee5e-32e5-4057-8232-ce55f318066e"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7758), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("81604681-016f-4074-80e6-1ab89d5be8c0"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7773), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("915b3682-b538-48b0-a911-4ad43f8fa58a"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7805), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("16085f65-cf11-4027-8c18-13bf6711418b"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7788), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c347fd1b-19ad-4655-ab63-57729fba287a"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7797), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e975fdf8-d231-4e62-af1b-24c50a6df7ee"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7736), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ccfa4c70-1360-4d9b-a33f-8cedeb371099"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7812), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b2348b89-0578-4428-b25e-146c85c372eb"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7781), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28b785e4-bbad-4271-aa59-67bf4fdaf023"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7726), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("543a1c71-bd8d-4154-abdb-0fcdee01fcbf"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7766), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d8f36831-7060-42d0-a0dc-186378f194e5"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7711), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6e493e06-43d9-4c7e-8923-c02237cec6c0"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7703), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b2136f4-5941-4494-8ea5-bf9c7bd9b2be"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7696), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dffa3cc6-b447-49a9-99b6-afaa7fb7e330"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7688), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7af55295-e182-47d6-8c8e-776de7c135e3"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7681), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6667f096-86fe-4d80-b96a-116a39f1c47f"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7673), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aa09e56b-176c-4d50-bcf6-641f67dbfd7e"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7660), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a1cc6fb-9c7d-453f-a716-8d0c5dcdc6cc"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7652), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b7900bc1-b878-4ea2-b700-e9ccc4058b12"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7644), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("86ac8b5a-2bd7-4aa4-9f50-29cbf183f8c7"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7635), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a6c34816-60a8-43ef-a432-1e3e014035a8"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7528), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dc918305-a10b-42f5-9e86-e7329c0a740f"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7718), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("6d392abf-06e0-40b3-8b12-8fe9b559f214"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(5076), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("5ac82dc2-b300-4579-80b0-bad9913e121b"), new DateTime(2021, 2, 4, 19, 46, 36, 375, DateTimeKind.Local).AddTicks(5061), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("22d5daf6-38a7-4642-8038-e13ae141e313"), new DateTime(2021, 2, 4, 19, 47, 26, 375, DateTimeKind.Local).AddTicks(5069), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("dfadf811-ed26-40db-a152-8ec3bf7f24fd"), new DateTime(2021, 2, 4, 19, 44, 56, 375, DateTimeKind.Local).AddTicks(4451), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("12a6e1da-0ac2-4c22-a511-69d8440ffd6a"), new DateTime(2021, 2, 4, 19, 45, 46, 375, DateTimeKind.Local).AddTicks(5039), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ea178318-c10e-4b13-9906-6e40578b12bb"), new Guid("f8b4f37a-d2d5-4e98-9637-8ed1f7772c5c"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(914), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4c4cd815-23b9-4869-93ff-8c22a660e6e0"), new Guid("f91c5025-6659-4fc4-873b-8e97ae1c670b"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(1949), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("c836daf4-c948-497d-b227-bacc54773766"), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(9987), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("acfe2282-1c54-43ec-ac91-49b238599db0"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(159), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("83559d12-3354-497d-80aa-b0057a9c6960"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(169), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("14244119-fcdf-4492-ac3f-c85939aeb92f"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(189), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("8551f547-43c6-480d-9f66-d85c2ea11b56"), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(5427), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("76815196-e78c-4f48-847c-1e715fee27c2"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(180), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(5451), new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(7208), new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(68), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(74), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(9960), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(16), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(32) });
        }
    }
}
