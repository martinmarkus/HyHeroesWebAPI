using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Infrastructure.Migrations
{
    public partial class PayPalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientidentities",
                keyColumn: "Id",
                keyValue: new Guid("0b6ab724-0842-41c2-b3f7-295258d17acd"));

            migrationBuilder.DeleteData(
                table: "clientidentities",
                keyColumn: "Id",
                keyValue: new Guid("a684c1ab-bb8a-47d9-b839-8da599078b59"));

            migrationBuilder.DeleteData(
                table: "clientidentities",
                keyColumn: "Id",
                keyValue: new Guid("f43207ad-8af9-4b15-8439-75557ef1e490"));

            migrationBuilder.DeleteData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("2d03bfe6-b490-45a4-89ca-20d2ddf6d7f6"));

            migrationBuilder.DeleteData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("6754b4fe-a5d9-4d22-9e7e-81099183f148"));

            migrationBuilder.DeleteData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("9c8e648a-e1c0-4c82-866f-b01988a94228"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("03c2b819-5089-4ed1-8ea3-aa23ccf37ff0"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("07f38c1b-d1be-403d-b575-87fed2a8d2b6"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("18e8a487-59c2-4f57-b201-91b27b76ef41"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("1c95410c-f175-4cfe-a98b-a5bbf010e8f4"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("24a3f587-bc39-48cf-a883-8fd8a6f3f856"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a063187-196d-40f8-93a2-8f42ead9c72a"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("426b263e-8d09-45f7-82d4-ed96eb11406b"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("449c5a6f-358a-4bdd-91c5-726840098541"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("508a1ad3-daa3-4376-96cc-b92f309987ca"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("630717c4-ea05-42b0-90bf-34a593dae333"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("6f63ff31-2d4c-4695-ae38-93966a552a2d"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("8a08854a-2938-428f-8f28-ccd1d7993cc7"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("8de2b594-e3b9-46ef-9ec1-b7b8689f5d67"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("904d75e1-a495-4295-85e5-49b5bf20fb54"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("95092c7d-8e73-446e-b743-3edccc2b696a"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("9b078b4c-21d9-4ce3-9e07-a4fdcf952194"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("a1eca47c-5022-4653-9e4c-a20ddd0a3119"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("a764b819-b310-4ab4-a755-9e81ee30c374"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa6a2858-5bda-4e15-9805-a181b6799145"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("b18308f1-07a2-418a-aa34-b048639a40d1"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("b531f7d7-4808-4ad2-95b4-71062779a2bd"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("d6f82dd2-e07b-4f77-8f6c-6c929b37deb0"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("da8ca36a-5997-472d-b614-09e76de6dd42"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("debe773d-d55d-4efa-b494-026c1e064792"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("09342542-7621-450a-9649-a5a7d3adc592"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("20d2f041-edf9-4998-bec5-77b36b1ccdc5"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("a6a46290-971b-4e3c-9810-db1df14e430f"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("b11c42c1-5457-4756-a167-120db53632d4"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("dcb1b058-bf30-4d97-ae0c-15bae060e793"));

            migrationBuilder.DeleteData(
                table: "passwordresetcodes",
                keyColumn: "Id",
                keyValue: new Guid("ee7aa147-8317-415c-9e2f-4af536c1a3b9"));

            migrationBuilder.DeleteData(
                table: "passwordresetcodes",
                keyColumn: "Id",
                keyValue: new Guid("fda8794b-c431-47bc-b4df-d844fb38b6a7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("0a6d5937-9dec-472c-ae08-1bda2b3a1f32"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("0bfe40ab-eb37-43f1-90e6-7d96b05ca8c2"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("174717ba-bfb8-42bd-8ebc-133e098ec72d"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("5176f7a5-7288-4a41-9411-7cdb8d9d4c21"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("61ecb8aa-214d-4e81-9f58-9b1d8b281a66"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("7db7b0c2-8e2a-414d-b9a7-b65836f6baa6"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("93e5f0c6-8453-4e55-b8c1-7fd41d7aa9c1"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("99a2dfce-bcde-4863-a136-b40d1ad24a44"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("bf3819bd-b136-4410-afd4-d46057cfc820"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("ee73f383-aed3-4378-bd2d-b23740e096d3"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "users",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "roles",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "purchasestates",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "purchasedproducts",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "products",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "productcategories",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "paypaltransactionrequests",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "paypalorders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "paypalorders",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "paypalorders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PayPalLinks",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "paypalipnmessages",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "passwordresetcodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "onlineplayerstates",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "notifications",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "news",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "masskredituseractivations",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "masskreditactivationcodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "kreditpurchases",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "kreditgifts",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "jatekfizetesrequests",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "gameservers",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "failedbillingtransactions",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "emailverificationcodes",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "edsmspurchases",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "discorduserids",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "clientidentities",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "blacklistedips",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingtransactions",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingopartners",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingodocuments",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingobillingaddresses",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingobankaccounts",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "bariontransactions",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "barionbillingaddresses",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "banktransfers",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "banktransferbillingaddresses",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.InsertData(
                table: "clientidentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("5df37f9b-ba26-4f87-8814-231b4c23ed6c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(9716), new DateTime(2021, 3, 5, 21, 26, 58, 397, DateTimeKind.Local).AddTicks(1022), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0d56265e-9ad4-49e4-afbe-baad4a72f703"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(2046), new DateTime(2021, 3, 5, 21, 26, 58, 397, DateTimeKind.Local).AddTicks(2077), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("c2e43242-3f1d-43e8-9f6a-7da36669df88"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(2101), new DateTime(2021, 3, 5, 21, 26, 58, 397, DateTimeKind.Local).AddTicks(2104), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.UpdateData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 21, 25, 58, 392, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.InsertData(
                table: "gameservers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("b3ee4cab-caa0-45ac-86d7-8e09d688b476"), new DateTime(2021, 3, 5, 21, 25, 58, 395, DateTimeKind.Local).AddTicks(626), true, true, "Skyblock" },
                    { new Guid("2b33450f-b3b1-493a-9b7b-f2b0b22451cd"), new DateTime(2021, 3, 5, 21, 25, 58, 395, DateTimeKind.Local).AddTicks(632), true, false, "RPG" },
                    { new Guid("d7ad2385-d123-4643-af03-43e381515d4e"), new DateTime(2021, 3, 5, 21, 25, 58, 395, DateTimeKind.Local).AddTicks(579), true, true, "Survival" }
                });

            migrationBuilder.InsertData(
                table: "kreditpurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("a8b7692a-b09d-4436-81db-47c594043e02"), new DateTime(2021, 2, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7764), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("857ce46b-eb3e-479a-854e-a8659e8c9795"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7748), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bfb8ded9-bfc4-4a14-821d-9a72f3c11be2"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7740), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5272931a-70d2-4c6e-b097-264513ff9934"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7729), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("732049a0-f712-498c-adc0-3612ebe3170a"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7721), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a868a2d1-082c-453b-adf7-d40a22498845"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7713), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0e0c5d91-3453-4bfe-839a-e46b593ff0c9"), new DateTime(2020, 11, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7705), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9b4692c9-fc6f-4719-84af-72c38c6f1415"), new DateTime(2021, 2, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7697), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2038a5b0-49d0-4f9f-90e8-b1659249fed5"), new DateTime(2021, 2, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7689), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("19b1e19c-79f5-4b36-827d-d309d06e0a91"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7681), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a1052a38-9471-4b76-a1c1-7136056941c5"), new DateTime(2021, 2, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7772), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2530a984-c752-4832-82db-4f250e398337"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7663), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("031b9f4c-29e6-4723-a81a-8c2141e30dc9"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7673), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e22b1e17-53e6-4860-a435-e2e51d666c77"), new DateTime(2020, 11, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7462), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4c3ff199-958b-4b81-b211-3fdf83a197c6"), new DateTime(2020, 11, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7581), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f1b99579-0198-4938-b808-831af427f491"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7592), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("92bd31be-4f3b-499b-8ea6-8ca1d1f1fb99"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7606), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("76871e6e-817b-42ed-990d-a677078cd131"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7756), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c09c60a4-f41c-4b48-ba10-e774854cb994"), new DateTime(2021, 2, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7622), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9e5d8ef2-033a-476f-880a-9dac60c6af1f"), new DateTime(2020, 11, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7630), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ee1aaee2-a428-45f0-994e-4a8493be05a7"), new DateTime(2021, 1, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7614), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8368c716-d358-4271-9963-03768d5c34cf"), new DateTime(2020, 11, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7639), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("82c48b09-c592-4442-bd75-91575539b633"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7647), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("583448e9-9955-4421-a9c5-a97c256b3203"), new DateTime(2020, 12, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(7655), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "news",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("7d063f7b-535f-4201-812f-242642b9c9ec"), new DateTime(2021, 3, 5, 21, 22, 38, 398, DateTimeKind.Local).AddTicks(4391), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("15e2eec7-86b9-495d-8e14-a28f50bd6bcd"), new DateTime(2021, 3, 5, 21, 23, 28, 398, DateTimeKind.Local).AddTicks(4962), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" },
                    { new Guid("20ffb671-44e6-4760-91b2-4a1b5868a815"), new DateTime(2021, 3, 5, 21, 24, 18, 398, DateTimeKind.Local).AddTicks(4977), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("8a0c21d6-ae64-45d1-9396-7a082949ed8a"), new DateTime(2021, 3, 5, 21, 25, 8, 398, DateTimeKind.Local).AddTicks(4985), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("facca026-bdfd-4e3e-8329-f87798bbab71"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(4993), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" }
                });

            migrationBuilder.InsertData(
                table: "passwordresetcodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d3594f95-ce1f-4e75-9653-cab9ce768620"), new Guid("05b6434f-e323-43eb-ac78-e767fce61355"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(1917), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("8759c733-3b88-4335-84d0-a7bd7fa2c6ef"), new Guid("02b8228a-0e50-47a4-a65e-a83c6defde7b"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(815), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.UpdateData(
                table: "productcategories",
                keyColumn: "Id",
                keyValue: new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "productcategories",
                keyColumn: "Id",
                keyValue: new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "productcategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("063ce3cb-3ded-4bf7-973d-6f98e141645a"), new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(4791), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("6ca71ae7-a711-4eab-a7f5-9f09e0680207"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(14), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("0daf2f7c-a24e-4a79-8b60-e2e282d8fda7"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(10), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("cb04ee52-bd4a-4da6-9c66-4b418087b8ee"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(18), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null },
                    { new Guid("d7df8e29-5ebe-4333-92e3-316a06490c01"), new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(9973), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("1867ce8d-9593-449b-bf8e-4ab740074478"), new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(9524), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("5062284b-307a-4fd1-9718-938b2646103c"), new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(9508), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 1", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("47d8fc6b-fa67-4423-afa3-32095794abf5"), new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(9395), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("1a083149-4182-4e9a-8ebd-373eb138312c"), new DateTime(2021, 3, 5, 21, 25, 58, 398, DateTimeKind.Local).AddTicks(5), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("9a026614-3abb-430e-bd31-7d279cc3b50b"), new DateTime(2021, 3, 5, 21, 25, 58, 397, DateTimeKind.Local).AddTicks(9517), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 2", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(4215), new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(6063), new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(9029), new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(9035), new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(8927), new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(8972), new DateTime(2021, 3, 5, 21, 25, 58, 396, DateTimeKind.Local).AddTicks(8986) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientidentities",
                keyColumn: "Id",
                keyValue: new Guid("0d56265e-9ad4-49e4-afbe-baad4a72f703"));

            migrationBuilder.DeleteData(
                table: "clientidentities",
                keyColumn: "Id",
                keyValue: new Guid("5df37f9b-ba26-4f87-8814-231b4c23ed6c"));

            migrationBuilder.DeleteData(
                table: "clientidentities",
                keyColumn: "Id",
                keyValue: new Guid("c2e43242-3f1d-43e8-9f6a-7da36669df88"));

            migrationBuilder.DeleteData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("2b33450f-b3b1-493a-9b7b-f2b0b22451cd"));

            migrationBuilder.DeleteData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("b3ee4cab-caa0-45ac-86d7-8e09d688b476"));

            migrationBuilder.DeleteData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("d7ad2385-d123-4643-af03-43e381515d4e"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("031b9f4c-29e6-4723-a81a-8c2141e30dc9"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("0e0c5d91-3453-4bfe-839a-e46b593ff0c9"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("19b1e19c-79f5-4b36-827d-d309d06e0a91"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("2038a5b0-49d0-4f9f-90e8-b1659249fed5"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("2530a984-c752-4832-82db-4f250e398337"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("4c3ff199-958b-4b81-b211-3fdf83a197c6"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("5272931a-70d2-4c6e-b097-264513ff9934"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("583448e9-9955-4421-a9c5-a97c256b3203"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("732049a0-f712-498c-adc0-3612ebe3170a"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("76871e6e-817b-42ed-990d-a677078cd131"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("82c48b09-c592-4442-bd75-91575539b633"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("8368c716-d358-4271-9963-03768d5c34cf"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("857ce46b-eb3e-479a-854e-a8659e8c9795"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("92bd31be-4f3b-499b-8ea6-8ca1d1f1fb99"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("9b4692c9-fc6f-4719-84af-72c38c6f1415"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("9e5d8ef2-033a-476f-880a-9dac60c6af1f"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("a1052a38-9471-4b76-a1c1-7136056941c5"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("a868a2d1-082c-453b-adf7-d40a22498845"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("a8b7692a-b09d-4436-81db-47c594043e02"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("bfb8ded9-bfc4-4a14-821d-9a72f3c11be2"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("c09c60a4-f41c-4b48-ba10-e774854cb994"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("e22b1e17-53e6-4860-a435-e2e51d666c77"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("ee1aaee2-a428-45f0-994e-4a8493be05a7"));

            migrationBuilder.DeleteData(
                table: "kreditpurchases",
                keyColumn: "Id",
                keyValue: new Guid("f1b99579-0198-4938-b808-831af427f491"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("15e2eec7-86b9-495d-8e14-a28f50bd6bcd"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("20ffb671-44e6-4760-91b2-4a1b5868a815"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("7d063f7b-535f-4201-812f-242642b9c9ec"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("8a0c21d6-ae64-45d1-9396-7a082949ed8a"));

            migrationBuilder.DeleteData(
                table: "news",
                keyColumn: "Id",
                keyValue: new Guid("facca026-bdfd-4e3e-8329-f87798bbab71"));

            migrationBuilder.DeleteData(
                table: "passwordresetcodes",
                keyColumn: "Id",
                keyValue: new Guid("8759c733-3b88-4335-84d0-a7bd7fa2c6ef"));

            migrationBuilder.DeleteData(
                table: "passwordresetcodes",
                keyColumn: "Id",
                keyValue: new Guid("d3594f95-ce1f-4e75-9653-cab9ce768620"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("063ce3cb-3ded-4bf7-973d-6f98e141645a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("0daf2f7c-a24e-4a79-8b60-e2e282d8fda7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("1867ce8d-9593-449b-bf8e-4ab740074478"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("1a083149-4182-4e9a-8ebd-373eb138312c"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("47d8fc6b-fa67-4423-afa3-32095794abf5"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("5062284b-307a-4fd1-9718-938b2646103c"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("6ca71ae7-a711-4eab-a7f5-9f09e0680207"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("9a026614-3abb-430e-bd31-7d279cc3b50b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("cb04ee52-bd4a-4da6-9c66-4b418087b8ee"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("d7df8e29-5ebe-4333-92e3-316a06490c01"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "users",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "roles",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "purchasestates",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "purchasedproducts",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "products",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "productcategories",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "paypaltransactionrequests",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "paypalorders",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "paypalorders",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "paypalorders",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "PayPalLinks",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "paypalipnmessages",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "passwordresetcodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "onlineplayerstates",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "notifications",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "news",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "masskredituseractivations",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "masskreditactivationcodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "kreditpurchases",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "kreditgifts",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "jatekfizetesrequests",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "gameservers",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "failedbillingtransactions",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "emailverificationcodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "edsmspurchases",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "discorduserids",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "clientidentities",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "blacklistedips",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingtransactions",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingopartners",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingodocuments",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingobillingaddresses",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "billingobankaccounts",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "bariontransactions",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "barionbillingaddresses",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "banktransfers",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "banktransferbillingaddresses",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.InsertData(
                table: "clientidentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("a684c1ab-bb8a-47d9-b839-8da599078b59"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(8550), new DateTime(2021, 3, 5, 19, 50, 7, 311, DateTimeKind.Local).AddTicks(9887), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0b6ab724-0842-41c2-b3f7-295258d17acd"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(967), new DateTime(2021, 3, 5, 19, 50, 7, 312, DateTimeKind.Local).AddTicks(1006), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("f43207ad-8af9-4b15-8439-75557ef1e490"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(1038), new DateTime(2021, 3, 5, 19, 50, 7, 312, DateTimeKind.Local).AddTicks(1043), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.UpdateData(
                table: "gameservers",
                keyColumn: "Id",
                keyValue: new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 19, 49, 7, 307, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.InsertData(
                table: "gameservers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("9c8e648a-e1c0-4c82-866f-b01988a94228"), new DateTime(2021, 3, 5, 19, 49, 7, 309, DateTimeKind.Local).AddTicks(7853), true, true, "Skyblock" },
                    { new Guid("2d03bfe6-b490-45a4-89ca-20d2ddf6d7f6"), new DateTime(2021, 3, 5, 19, 49, 7, 309, DateTimeKind.Local).AddTicks(7859), true, false, "RPG" },
                    { new Guid("6754b4fe-a5d9-4d22-9e7e-81099183f148"), new DateTime(2021, 3, 5, 19, 49, 7, 309, DateTimeKind.Local).AddTicks(7798), true, true, "Survival" }
                });

            migrationBuilder.InsertData(
                table: "kreditpurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c95410c-f175-4cfe-a98b-a5bbf010e8f4"), new DateTime(2021, 2, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7658), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aa6a2858-5bda-4e15-9805-a181b6799145"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7636), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("24a3f587-bc39-48cf-a883-8fd8a6f3f856"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7626), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("508a1ad3-daa3-4376-96cc-b92f309987ca"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7616), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("07f38c1b-d1be-403d-b575-87fed2a8d2b6"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7606), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a1eca47c-5022-4653-9e4c-a20ddd0a3119"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7595), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("449c5a6f-358a-4bdd-91c5-726840098541"), new DateTime(2020, 11, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7585), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("debe773d-d55d-4efa-b494-026c1e064792"), new DateTime(2021, 2, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7575), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("95092c7d-8e73-446e-b743-3edccc2b696a"), new DateTime(2021, 2, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7562), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8a08854a-2938-428f-8f28-ccd1d7993cc7"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7552), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d6f82dd2-e07b-4f77-8f6c-6c929b37deb0"), new DateTime(2021, 2, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7668), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("426b263e-8d09-45f7-82d4-ed96eb11406b"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7532), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9b078b4c-21d9-4ce3-9e07-a4fdcf952194"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7542), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("03c2b819-5089-4ed1-8ea3-aa23ccf37ff0"), new DateTime(2020, 11, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7302), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b18308f1-07a2-418a-aa34-b048639a40d1"), new DateTime(2020, 11, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7430), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b531f7d7-4808-4ad2-95b4-71062779a2bd"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7442), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a764b819-b310-4ab4-a755-9e81ee30c374"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7453), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a063187-196d-40f8-93a2-8f42ead9c72a"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7646), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("630717c4-ea05-42b0-90bf-34a593dae333"), new DateTime(2021, 2, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7474), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("18e8a487-59c2-4f57-b201-91b27b76ef41"), new DateTime(2020, 11, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7490), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6f63ff31-2d4c-4695-ae38-93966a552a2d"), new DateTime(2021, 1, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7463), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("904d75e1-a495-4295-85e5-49b5bf20fb54"), new DateTime(2020, 11, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7501), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8de2b594-e3b9-46ef-9ec1-b7b8689f5d67"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7511), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("da8ca36a-5997-472d-b614-09e76de6dd42"), new DateTime(2020, 12, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(7521), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "news",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("a6a46290-971b-4e3c-9810-db1df14e430f"), new DateTime(2021, 3, 5, 19, 45, 47, 313, DateTimeKind.Local).AddTicks(4056), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("09342542-7621-450a-9649-a5a7d3adc592"), new DateTime(2021, 3, 5, 19, 46, 37, 313, DateTimeKind.Local).AddTicks(4723), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" },
                    { new Guid("b11c42c1-5457-4756-a167-120db53632d4"), new DateTime(2021, 3, 5, 19, 47, 27, 313, DateTimeKind.Local).AddTicks(4742), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("dcb1b058-bf30-4d97-ae0c-15bae060e793"), new DateTime(2021, 3, 5, 19, 48, 17, 313, DateTimeKind.Local).AddTicks(4758), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("20d2f041-edf9-4998-bec5-77b36b1ccdc5"), new DateTime(2021, 3, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(4767), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<hr><h3>Where does it come from?</h3><div style='margin-top: 30px;'>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</div><div style='margin-top: 20px;'>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</div>", true, "Ez a hír előnézeti szövege. Ez a hír előnézeti szövege. <b>Ez a hír előnézeti szövege.</b> Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" }
                });

            migrationBuilder.InsertData(
                table: "passwordresetcodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("fda8794b-c431-47bc-b4df-d844fb38b6a7"), new Guid("47fddbf4-e49e-4f88-a167-9cb8f2c8a169"), new DateTime(2021, 3, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(1295), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") },
                    { new Guid("ee7aa147-8317-415c-9e2f-4af536c1a3b9"), new Guid("bdf6c51e-8cda-45ee-b446-fe35d0d5e8f2"), new DateTime(2021, 3, 5, 19, 49, 7, 313, DateTimeKind.Local).AddTicks(219), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.UpdateData(
                table: "productcategories",
                keyColumn: "Id",
                keyValue: new Guid("3d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "productcategories",
                keyColumn: "Id",
                keyValue: new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "productcategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreationDate", "Description", "GameServerId", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("0a6d5937-9dec-472c-ae08-1bda2b3a1f32"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(3981), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 1", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("93e5f0c6-8453-4e55-b8c1-7fd41d7aa9c1"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(9454), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, null },
                    { new Guid("99a2dfce-bcde-4863-a136-b40d1ad24a44"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(9448), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, null },
                    { new Guid("174717ba-bfb8-42bd-8ebc-133e098ec72d"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(9465), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, null },
                    { new Guid("ee73f383-aed3-4378-bd2d-b23740e096d3"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(9411), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, null },
                    { new Guid("bf3819bd-b136-4410-afd4-d46057cfc820"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(8938), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, null },
                    { new Guid("61ecb8aa-214d-4e81-9f58-9b1d8b281a66"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(8919), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 1", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("7db7b0c2-8e2a-414d-b9a7-b65836f6baa6"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(8805), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Teszt csomag 2", "onetime command", 500, 0, new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28") },
                    { new Guid("0bfe40ab-eb37-43f1-90e6-7d96b05ca8c2"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(9443), "test description", null, "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, null },
                    { new Guid("5176f7a5-7288-4a41-9411-7cdb8d9d4c21"), new DateTime(2021, 3, 5, 19, 49, 7, 312, DateTimeKind.Local).AddTicks(8929), "test description", new Guid("ffe6eacd-024c-4c86-89c8-c28d1cc24cde"), "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, false, "Pet 2", "onetime command", 500, 0, new Guid("4d32fedf-28f9-4bc9-9899-4bacbbe9ea28") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(2852), new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(4702), new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(7794), new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(7801), new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(7661), new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(7712), new DateTime(2021, 3, 5, 19, 49, 7, 311, DateTimeKind.Local).AddTicks(7731) });
        }
    }
}
