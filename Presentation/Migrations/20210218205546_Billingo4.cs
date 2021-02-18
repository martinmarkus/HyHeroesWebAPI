using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class Billingo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingoProducts");

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("1fc89cee-88b0-4b25-a9b8-f3a10fdc9bf1"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("915a2595-e164-4b77-9023-d340af846d69"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a7874293-461a-4ca8-bb35-e6ebdf2a5522"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("99be7f18-cf0a-41e3-9db9-5a95bdab2d53"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a3fcdbb4-10fb-4cf4-8dba-6c4afc1ea928"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("aaf868df-3b11-4ba0-84b7-8172ac3b4d4e"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ec1e4530-1e33-4de7-ac94-8fc2ef81af1a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("00ff2be7-6a57-4915-a3ea-f75def2f8591"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("12f45fa1-0f7a-4fa9-9d10-ba5fcaab4070"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1d14a96f-e871-46fc-9259-b416d31b321f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("25194310-cf8a-4040-9f73-b6c8997b709e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("26c8f593-438d-4656-953a-8bbf41be62de"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("363f271b-8e29-42fd-8c5a-03296cfe6ee7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5351ca3c-ba5b-48b8-9eda-ef5210262094"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5efdcc29-fc54-4aeb-9ca0-44e404f77598"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("63aafe65-0c01-46d4-9664-38ad5a60199a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6d771ce9-3e84-4b78-adec-f702fb97a027"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("771d19ff-f817-4613-a00e-92634a515ac2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7912a32f-fbd8-450a-a0e1-8d89980e28f5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7d130ce9-aa40-47f8-b98e-ac01d3a34857"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7e10d605-0647-4f89-a963-e00b7232415b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("833c52ec-d49b-468f-bfc8-ce192df13303"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9274b162-e3aa-4a2c-bd7d-ad0adc5cf7fb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9e952308-4054-458b-8c4e-dcabc0652b48"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b3106d53-3965-48f9-95c7-26feb4490e26"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b355db09-d191-45bb-9bcd-ac106e6940a1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d0103433-2715-49e3-98c7-befaf5b2380d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d4a1c26a-b995-4e47-a3f9-956c8b260a92"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dd8fff31-b56d-4cc0-aaff-3afdc32b40eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e3cd5ae5-c575-41d4-9cb8-625cd2c4a305"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ea22d0f0-d4e8-428e-956b-3dd3dcf5f61d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("10d8a8ab-b41a-4d66-b91c-6602f256b582"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("348221ed-30d2-4df7-895c-5498053b8bbf"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("550add99-5112-465f-b39a-b674de53ae5b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("83174175-1b50-4a75-bab8-73edfdf00afb"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c131d68b-8542-4362-bf87-d9acf7399c1f"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("40eb605a-4304-4582-9527-871cbcf1d943"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("fd5942e8-2580-4170-8972-7800e2092e81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0794c1e2-6fba-4bb4-b0a5-36586323e008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15012eb1-5a1b-493b-87cd-fc5c38d96bee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("220b3225-4c6a-4143-bedd-ad9e7b7d0fe0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cf9a875-d7fb-4b54-9dff-61c73eabc645"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7626938e-2fc2-45db-9542-6c2748df069b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0ab47f4-a727-4117-83a1-cb168397d2bb"));

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
                table: "Notifications",
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
                table: "BillingoPartners",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoDocumentSettings",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoDocuments",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddresses",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBankAccounts",
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

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("5f6095ef-7001-4508-92a7-d73dc3e278f6"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5989), new DateTime(2021, 2, 18, 21, 56, 45, 976, DateTimeKind.Local).AddTicks(7240), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("c2ab4a51-f703-47ab-8e39-f213a26301ca"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(8332), new DateTime(2021, 2, 18, 21, 56, 45, 976, DateTimeKind.Local).AddTicks(8364), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("4c489817-3395-4002-ac4e-adace30d13c5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(8389), new DateTime(2021, 2, 18, 21, 56, 45, 976, DateTimeKind.Local).AddTicks(8391), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("f7dba7d0-6ecd-4116-8e3d-5fc5c244717d"), new DateTime(2021, 2, 18, 21, 55, 45, 971, DateTimeKind.Local).AddTicks(7879), true, true, "GTA" },
                    { new Guid("6c3772ea-4c3c-4a05-8400-26a48869c456"), new DateTime(2021, 2, 18, 21, 55, 45, 974, DateTimeKind.Local).AddTicks(6472), true, true, "Survival" },
                    { new Guid("cfb85914-22fb-4bf9-8c3c-f8484f515642"), new DateTime(2021, 2, 18, 21, 55, 45, 974, DateTimeKind.Local).AddTicks(6521), true, true, "Skyblock" },
                    { new Guid("e25854a5-7e39-4e33-8e03-c90289703242"), new DateTime(2021, 2, 18, 21, 55, 45, 974, DateTimeKind.Local).AddTicks(6527), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("b9fc43bc-ef07-4c8f-ac9c-895dac869523"), new DateTime(2021, 1, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2316), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("30917941-830f-4f5f-ba47-c149d46b56e2"), new DateTime(2020, 10, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2324), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0c55b0f7-c008-424f-8370-f9072a6cd69b"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2332), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("31874db8-6488-4e3a-bc4c-f62e1c1f4dda"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2340), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5cb29b5e-768c-4f4b-adbc-6dbcfca33743"), new DateTime(2021, 1, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2508), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fe29223f-a2ce-4c4f-9302-a21f1c32eada"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2365), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d17547fa-2e3f-401f-9430-7ab14bc6ba32"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2373), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("044d4028-71f4-4ba5-81d8-332f1ed02c1d"), new DateTime(2021, 1, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2308), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c0cbd20-ec29-446b-b155-7f187b89146c"), new DateTime(2021, 1, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2516), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2c2413d9-bdd5-463d-9c45-e5bd1ea1d2d1"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2358), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae7ce35a-0cb7-4bd8-8013-3400fbc3539d"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2301), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("38b3a223-687e-4b6f-a6cf-1ac6c8ef4563"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2348), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a6b01e33-331c-4079-a513-9302e4c511a1"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2282), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cabcde46-4845-4a6a-9f14-0f431cafd7fd"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2274), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("416105b2-232c-47a5-9fb2-6f39dd4c460b"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2266), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7deecb23-dba5-46dd-b427-f0c087f22578"), new DateTime(2020, 10, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2258), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5623bd0b-22eb-4d87-bcf2-21973c7dae0e"), new DateTime(2020, 10, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2249), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("913768cf-4de1-48b9-bd12-40ba621821c9"), new DateTime(2021, 1, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2241), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("96a45798-0371-4117-9306-8f6e009eac61"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2233), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dad689d7-9639-46d8-92a2-c75acadbfa4e"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2225), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4f8c9a7b-102c-4b1f-8a98-73527c054675"), new DateTime(2020, 11, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2211), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b89452a9-bac8-4a91-82f7-0abf0852eab0"), new DateTime(2020, 10, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2200), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3f2c64ee-619a-49fe-b1db-6ffed8ff8725"), new DateTime(2020, 10, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2099), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b5ef3c71-01d5-4dd7-97f0-9640e4e9c3ba"), new DateTime(2020, 12, 18, 21, 55, 45, 978, DateTimeKind.Local).AddTicks(2293), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("1b027332-f56c-42aa-a9c9-049724b51879"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(9734), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("33db3477-24d0-4bc5-bffd-9ef9072665c0"), new DateTime(2021, 2, 18, 21, 54, 5, 977, DateTimeKind.Local).AddTicks(9719), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("027f5ee7-acf2-4493-b6d2-683d937ae61c"), new DateTime(2021, 2, 18, 21, 54, 55, 977, DateTimeKind.Local).AddTicks(9726), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("89a3c79d-e1f5-4362-82a0-352e07af50fb"), new DateTime(2021, 2, 18, 21, 52, 25, 977, DateTimeKind.Local).AddTicks(9147), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("60112ece-25cb-4f50-8c83-c633e9707cdb"), new DateTime(2021, 2, 18, 21, 53, 15, 977, DateTimeKind.Local).AddTicks(9704), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0bcc614e-c462-4b45-9cde-27f74d5a857b"), new Guid("094b3ef4-b763-4a0e-b42e-a557da2c34a8"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(5711), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5b87831a-56e6-40cc-bfef-ca29225350ed"), new Guid("467eed78-cead-4850-b7cd-80198dd327bc"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(6698), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("60efb43a-605d-4587-a0bd-a1267b30ff0f"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(4841), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("da5a6ef2-2f34-48f3-84a6-94c608e37ea5"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(4945), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("9aed0dd5-4a7e-4e0f-a916-1e6d1c96db50"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(4954), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("79d6aa2a-7457-40ba-bb94-6fb966a65de9"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(4965), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("068b1675-c758-406a-9ad7-a14aca5e59a8"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(589), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("c367a6c8-2cf9-4d05-b328-0743be006c81"), new DateTime(2021, 2, 18, 21, 55, 45, 977, DateTimeKind.Local).AddTicks(4960), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 55, 45, 975, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 55, 45, 975, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(644), new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(2399), new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5253), new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5259), new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5144), new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5187), new DateTime(2021, 2, 18, 21, 55, 45, 976, DateTimeKind.Local).AddTicks(5203) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("4c489817-3395-4002-ac4e-adace30d13c5"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("5f6095ef-7001-4508-92a7-d73dc3e278f6"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("c2ab4a51-f703-47ab-8e39-f213a26301ca"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("6c3772ea-4c3c-4a05-8400-26a48869c456"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("cfb85914-22fb-4bf9-8c3c-f8484f515642"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("e25854a5-7e39-4e33-8e03-c90289703242"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("f7dba7d0-6ecd-4116-8e3d-5fc5c244717d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("044d4028-71f4-4ba5-81d8-332f1ed02c1d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0c55b0f7-c008-424f-8370-f9072a6cd69b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2c2413d9-bdd5-463d-9c45-e5bd1ea1d2d1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("30917941-830f-4f5f-ba47-c149d46b56e2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("31874db8-6488-4e3a-bc4c-f62e1c1f4dda"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("38b3a223-687e-4b6f-a6cf-1ac6c8ef4563"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c0cbd20-ec29-446b-b155-7f187b89146c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3f2c64ee-619a-49fe-b1db-6ffed8ff8725"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("416105b2-232c-47a5-9fb2-6f39dd4c460b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4f8c9a7b-102c-4b1f-8a98-73527c054675"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5623bd0b-22eb-4d87-bcf2-21973c7dae0e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5cb29b5e-768c-4f4b-adbc-6dbcfca33743"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7deecb23-dba5-46dd-b427-f0c087f22578"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("913768cf-4de1-48b9-bd12-40ba621821c9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("96a45798-0371-4117-9306-8f6e009eac61"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a6b01e33-331c-4079-a513-9302e4c511a1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ae7ce35a-0cb7-4bd8-8013-3400fbc3539d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b5ef3c71-01d5-4dd7-97f0-9640e4e9c3ba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b89452a9-bac8-4a91-82f7-0abf0852eab0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b9fc43bc-ef07-4c8f-ac9c-895dac869523"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cabcde46-4845-4a6a-9f14-0f431cafd7fd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d17547fa-2e3f-401f-9430-7ab14bc6ba32"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dad689d7-9639-46d8-92a2-c75acadbfa4e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fe29223f-a2ce-4c4f-9302-a21f1c32eada"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("027f5ee7-acf2-4493-b6d2-683d937ae61c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1b027332-f56c-42aa-a9c9-049724b51879"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("33db3477-24d0-4bc5-bffd-9ef9072665c0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("60112ece-25cb-4f50-8c83-c633e9707cdb"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("89a3c79d-e1f5-4362-82a0-352e07af50fb"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("0bcc614e-c462-4b45-9cde-27f74d5a857b"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("5b87831a-56e6-40cc-bfef-ca29225350ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("068b1675-c758-406a-9ad7-a14aca5e59a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60efb43a-605d-4587-a0bd-a1267b30ff0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79d6aa2a-7457-40ba-bb94-6fb966a65de9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9aed0dd5-4a7e-4e0f-a916-1e6d1c96db50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c367a6c8-2cf9-4d05-b328-0743be006c81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da5a6ef2-2f34-48f3-84a6-94c608e37ea5"));

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
                table: "Notifications",
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
                table: "BillingoPartners",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoDocumentSettings",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoDocuments",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddresses",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBankAccounts",
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

            migrationBuilder.CreateTable(
                name: "BillingoProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    BillingoDocumentId = table.Column<Guid>(type: "char(36)", nullable: true),
                    BillingoProductId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Comment = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Currency = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Entitlement = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    GeneralLedgerNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    GeneralLedgerTaxcode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProductName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<DateTime>(type: "timestamp(6)", nullable: true),
                    Unit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    UnitPriceType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Vat = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingoProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingoProducts_BillingoDocuments_BillingoDocumentId",
                        column: x => x.BillingoDocumentId,
                        principalTable: "BillingoDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("915a2595-e164-4b77-9023-d340af846d69"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(2533), new DateTime(2021, 2, 18, 21, 32, 55, 507, DateTimeKind.Local).AddTicks(3829), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("1fc89cee-88b0-4b25-a9b8-f3a10fdc9bf1"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(4868), new DateTime(2021, 2, 18, 21, 32, 55, 507, DateTimeKind.Local).AddTicks(4903), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("a7874293-461a-4ca8-bb35-e6ebdf2a5522"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(4925), new DateTime(2021, 2, 18, 21, 32, 55, 507, DateTimeKind.Local).AddTicks(4928), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("a3fcdbb4-10fb-4cf4-8dba-6c4afc1ea928"), new DateTime(2021, 2, 18, 21, 31, 55, 502, DateTimeKind.Local).AddTicks(2862), true, true, "GTA" },
                    { new Guid("99be7f18-cf0a-41e3-9db9-5a95bdab2d53"), new DateTime(2021, 2, 18, 21, 31, 55, 505, DateTimeKind.Local).AddTicks(2648), true, true, "Survival" },
                    { new Guid("ec1e4530-1e33-4de7-ac94-8fc2ef81af1a"), new DateTime(2021, 2, 18, 21, 31, 55, 505, DateTimeKind.Local).AddTicks(2695), true, true, "Skyblock" },
                    { new Guid("aaf868df-3b11-4ba0-84b7-8172ac3b4d4e"), new DateTime(2021, 2, 18, 21, 31, 55, 505, DateTimeKind.Local).AddTicks(2701), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("26c8f593-438d-4656-953a-8bbf41be62de"), new DateTime(2021, 1, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9452), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9274b162-e3aa-4a2c-bd7d-ad0adc5cf7fb"), new DateTime(2020, 10, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9460), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b355db09-d191-45bb-9bcd-ac106e6940a1"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9526), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("63aafe65-0c01-46d4-9664-38ad5a60199a"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9534), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d0103433-2715-49e3-98c7-befaf5b2380d"), new DateTime(2021, 1, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9575), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d4a1c26a-b995-4e47-a3f9-956c8b260a92"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9560), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("12f45fa1-0f7a-4fa9-9d10-ba5fcaab4070"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9567), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("25194310-cf8a-4040-9f73-b6c8997b709e"), new DateTime(2021, 1, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9444), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("833c52ec-d49b-468f-bfc8-ce192df13303"), new DateTime(2021, 1, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9583), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("363f271b-8e29-42fd-8c5a-03296cfe6ee7"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9552), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7e10d605-0647-4f89-a963-e00b7232415b"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9436), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b3106d53-3965-48f9-95c7-26feb4490e26"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9542), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ea22d0f0-d4e8-428e-956b-3dd3dcf5f61d"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9417), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1d14a96f-e871-46fc-9259-b416d31b321f"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9409), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9e952308-4054-458b-8c4e-dcabc0652b48"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9402), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("00ff2be7-6a57-4915-a3ea-f75def2f8591"), new DateTime(2020, 10, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9394), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("771d19ff-f817-4613-a00e-92634a515ac2"), new DateTime(2020, 10, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9386), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6d771ce9-3e84-4b78-adec-f702fb97a027"), new DateTime(2021, 1, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9378), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5efdcc29-fc54-4aeb-9ca0-44e404f77598"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9370), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3cd5ae5-c575-41d4-9cb8-625cd2c4a305"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9362), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5351ca3c-ba5b-48b8-9eda-ef5210262094"), new DateTime(2020, 11, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9349), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7912a32f-fbd8-450a-a0e1-8d89980e28f5"), new DateTime(2020, 10, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9340), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d130ce9-aa40-47f8-b98e-ac01d3a34857"), new DateTime(2020, 10, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9235), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dd8fff31-b56d-4cc0-aaff-3afdc32b40eb"), new DateTime(2020, 12, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(9428), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("348221ed-30d2-4df7-895c-5498053b8bbf"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(6787), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("83174175-1b50-4a75-bab8-73edfdf00afb"), new DateTime(2021, 2, 18, 21, 30, 15, 508, DateTimeKind.Local).AddTicks(6773), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("c131d68b-8542-4362-bf87-d9acf7399c1f"), new DateTime(2021, 2, 18, 21, 31, 5, 508, DateTimeKind.Local).AddTicks(6780), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("10d8a8ab-b41a-4d66-b91c-6602f256b582"), new DateTime(2021, 2, 18, 21, 28, 35, 508, DateTimeKind.Local).AddTicks(6187), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("550add99-5112-465f-b39a-b674de53ae5b"), new DateTime(2021, 2, 18, 21, 29, 25, 508, DateTimeKind.Local).AddTicks(6757), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("40eb605a-4304-4582-9527-871cbcf1d943"), new Guid("cb39a8f2-0d6b-4f88-86e3-06188cd4ed59"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(2550), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fd5942e8-2580-4170-8972-7800e2092e81"), new Guid("afc6d5d7-7007-4a85-9836-ffaa3bd21f7f"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(3565), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("15012eb1-5a1b-493b-87cd-fc5c38d96bee"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(1656), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("220b3225-4c6a-4143-bedd-ad9e7b7d0fe0"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(1755), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0794c1e2-6fba-4bb4-b0a5-36586323e008"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(1762), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("c0ab47f4-a727-4117-83a1-cb168397d2bb"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(1773), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7626938e-2fc2-45db-9542-6c2748df069b"), new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(7229), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5cf9a875-d7fb-4b54-9dff-61c73eabc645"), new DateTime(2021, 2, 18, 21, 31, 55, 508, DateTimeKind.Local).AddTicks(1767), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 31, 55, 506, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 18, 21, 31, 55, 506, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 31, 55, 506, DateTimeKind.Local).AddTicks(7163), new DateTime(2021, 2, 18, 21, 31, 55, 506, DateTimeKind.Local).AddTicks(8927), new DateTime(2021, 2, 18, 21, 31, 55, 506, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(1780), new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(1785), new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(1671), new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(1712), new DateTime(2021, 2, 18, 21, 31, 55, 507, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.CreateIndex(
                name: "IX_BillingoProducts_BillingoDocumentId",
                table: "BillingoProducts",
                column: "BillingoDocumentId");
        }
    }
}
