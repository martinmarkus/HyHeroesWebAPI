using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class RemoveActualValueOfOneKredit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActualValueOfOneKredit");

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("2aa794ae-da27-4fea-b0e9-8bbb6d3a3365"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3a2e980d-1920-4937-b6f6-a6de4f4e2508"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("e3ba3472-a016-4aa1-903e-620bae8897b9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("3cc36bca-4d48-4111-89e9-706db2cfee45"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ab767b31-784a-41d9-a2a7-cefdbc1cff39"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("bed2f65e-2547-4006-8859-a5ab954cac05"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("eaf7de22-89c5-45d2-b2fc-b7743645506e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("066af45e-b343-49ba-a0ce-9378bdfce30a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1103dcd0-a29b-4266-8a3e-5091682d6e2b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("190aced4-aab7-43ba-be5f-13ce30e81956"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2ce9a028-61ee-4176-9cd9-aafbb25ba2b5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("38d75ca3-0feb-4aa1-9c2e-c1cbbd2624ef"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3cd503e8-9993-480f-9ca4-d60cc8008aae"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("40af799c-4d5c-4748-b184-6a7b07c5472e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4a68afca-fb5a-4b01-b2b6-e475ec8f85b4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5a40b56d-829e-406e-a9e6-2aa57898cc73"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("60e55d1c-a330-4a69-bb88-21644b80d239"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("63a8d4f7-1b39-4dbb-9d0e-d7a0977cf731"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6e6de300-2410-4291-bd9d-08bb7247ad82"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("87d4b279-00c7-41c3-826b-9682d2161e5c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8851d71c-6702-46d5-9933-b718b3f1d556"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("99f53314-b380-4d4b-94c9-1f0651ec9132"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9f313901-3523-460d-ae76-e60bf2cbde19"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a14f2e7a-41da-47d5-925a-9a7f08f8ba4d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("af47a8eb-257e-48f0-bb23-3cbb4fa2b8e4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b397a529-5cc0-4d5c-81ed-8e39636c65bb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b74c5da3-0acb-4fad-9f4b-b78c0c280a8d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c58d0577-f521-4bd9-a1a4-80061d5cfd65"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d59c3010-3f79-40e7-8213-85708a70c27f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("de1acc80-787c-4c86-b653-62903299fbb0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f4a80a13-e968-4379-8237-92b3fb530534"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("51a7845c-ac21-4f25-80c9-c7c087090609"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5e0c31d3-a8ef-4d34-9698-dd3ecad71d33"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9f82586e-33e3-4734-a896-88cfcb11db4d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d4358862-d6f2-4799-8b2d-04851ea374b6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f34a0399-d01f-4231-be3e-778dd17a6d67"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("611a9112-4df3-4069-804e-b3c571d7ee8c"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("6b010d63-ad93-4019-b047-d49f98410ccf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e7b735f-c1f5-4353-93b3-bab220c9c588"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("423fea96-2e75-43ab-b777-78d6c12c2fbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95f73b94-7d90-4e0b-aef7-62477815ac8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a16f0965-c632-4306-9b1a-11d2c48ec5c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be90ee05-ae79-4511-a9fd-91f44751e48a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e076094f-52a8-442c-843c-603d9178194f"));

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
                table: "BillingoClients",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddressed",
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
                    { new Guid("8dcc1f7a-2e9d-4a8b-8c07-f4b9374fef8c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(6391), new DateTime(2021, 2, 16, 15, 30, 35, 440, DateTimeKind.Local).AddTicks(7643), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("f6b49363-d298-47bc-9d62-abc68ead0c84"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(8648), new DateTime(2021, 2, 16, 15, 30, 35, 440, DateTimeKind.Local).AddTicks(8677), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("be4c725f-7232-4a8f-bd91-d3d7d9db5965"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(8701), new DateTime(2021, 2, 16, 15, 30, 35, 440, DateTimeKind.Local).AddTicks(8704), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("f200c636-859b-4e7d-ac2f-3c087cad013b"), new DateTime(2021, 2, 16, 15, 29, 35, 435, DateTimeKind.Local).AddTicks(6106), true, true, "GTA" },
                    { new Guid("aae14fba-49f6-491f-8368-175e8bbbed49"), new DateTime(2021, 2, 16, 15, 29, 35, 438, DateTimeKind.Local).AddTicks(7018), true, true, "Survival" },
                    { new Guid("82444e66-3e55-4520-a05a-f9ddc8945fc1"), new DateTime(2021, 2, 16, 15, 29, 35, 438, DateTimeKind.Local).AddTicks(7067), true, true, "Skyblock" },
                    { new Guid("5872c08e-5fcd-453e-9e76-f7d13ac55ab9"), new DateTime(2021, 2, 16, 15, 29, 35, 438, DateTimeKind.Local).AddTicks(7073), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("ba4ba241-f3bb-484a-a2e6-c7ca653a858c"), new DateTime(2021, 1, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2729), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("91b44bf4-5271-457a-8c8a-7c51962df897"), new DateTime(2020, 10, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2737), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c7b38f23-a956-47a2-abe4-dd38cabdf20a"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2745), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2870ee43-b775-4269-b0f0-50b3e1a54c70"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2752), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("151afc1e-c8ad-4a27-a690-a8713499fc8f"), new DateTime(2021, 1, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2793), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a56a6675-938f-473d-90c2-713c39895a4e"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2778), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f2a4706e-b3c6-4aa7-82fe-34aa648b99d5"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2785), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0d295bc8-5baa-4422-a89c-b54395ee3b3e"), new DateTime(2021, 1, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2721), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e145a6b6-e368-48a5-8a95-7bc16726e1cd"), new DateTime(2021, 1, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2800), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("db09786a-62fb-4db0-882c-1cf6b069badb"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2770), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fd4865a2-da20-4026-86a9-d73533cd6542"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2713), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("386a3915-0262-433f-bd8a-6e0cc80e8989"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2763), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a16be7bd-7e34-46af-bd34-b5269c97ac44"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2698), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b081af3d-4b81-4060-af37-5a070cd910d3"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2688), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6673101c-c562-498c-8557-14e843724b00"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2680), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d950b1e-867d-4fbb-acf9-80b999a48f0d"), new DateTime(2020, 10, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2672), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e7b6db62-87bb-44b7-ab44-5ff70acd5614"), new DateTime(2020, 10, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2664), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5fa83be6-8835-4f33-aca9-18cc0c156def"), new DateTime(2021, 1, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2657), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b05b8fe-5dac-4609-be15-e4787a73767e"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2649), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("69a383b1-39bb-41f3-ac78-6b2a105053ee"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2641), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("210cdc95-e77a-4026-9acd-e0d965404395"), new DateTime(2020, 11, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2632), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("290d164e-1906-4364-98b1-167f4d240c7d"), new DateTime(2020, 10, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2617), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3971a212-7287-43f2-9fc5-4a68d8625b50"), new DateTime(2020, 10, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2517), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3229b45-37d6-4259-8f1e-7bd4a7fe462e"), new DateTime(2020, 12, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(2706), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("eab4a252-b2c2-43aa-9f5c-63dd5bb3bbc4"), new DateTime(2021, 2, 16, 15, 29, 35, 442, DateTimeKind.Local).AddTicks(87), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("2bb71221-5758-4e54-b59a-4b77eb56eb6a"), new DateTime(2021, 2, 16, 15, 27, 55, 442, DateTimeKind.Local).AddTicks(71), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("9a863ed2-24d4-41dc-b5cc-a756463efe27"), new DateTime(2021, 2, 16, 15, 28, 45, 442, DateTimeKind.Local).AddTicks(79), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("735b3bbf-b089-4484-90db-9bb0ca14f94d"), new DateTime(2021, 2, 16, 15, 26, 15, 441, DateTimeKind.Local).AddTicks(9487), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("b479641a-0fe2-4cf4-8c4d-67c5bf6a5b42"), new DateTime(2021, 2, 16, 15, 27, 5, 442, DateTimeKind.Local).AddTicks(55), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c918634a-a587-4ba8-b24d-e3d8774000a6"), new Guid("b3a72389-7b99-4ac6-862d-a07c002437bc"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(6030), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fc2dd2a5-cb5e-4874-a634-0bb1c847149c"), new Guid("be28970e-5fc9-4eb9-ae5f-c5338295986c"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(7016), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("6c815d60-e86c-4c31-95b4-810fc67b1618"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(5214), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("b74687e9-e7ed-48ee-8bed-070a7b923896"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(5309), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("1adc62d5-dd1b-4c6a-a3f5-ea1b47ad226b"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(5318), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("92bfc215-ae16-4359-8f6e-2409678cce69"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(5329), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("9fcb3ec0-ebdd-4b1f-9410-457ddb0f3d0b"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(862), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("febc3ac1-c06e-4024-b627-d2ff543f620a"), new DateTime(2021, 2, 16, 15, 29, 35, 441, DateTimeKind.Local).AddTicks(5323), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 29, 35, 439, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(1129), new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(2856), new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(5654), new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(5659), new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(5557), new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(5598), new DateTime(2021, 2, 16, 15, 29, 35, 440, DateTimeKind.Local).AddTicks(5613) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("8dcc1f7a-2e9d-4a8b-8c07-f4b9374fef8c"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("be4c725f-7232-4a8f-bd91-d3d7d9db5965"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("f6b49363-d298-47bc-9d62-abc68ead0c84"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("5872c08e-5fcd-453e-9e76-f7d13ac55ab9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("82444e66-3e55-4520-a05a-f9ddc8945fc1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("aae14fba-49f6-491f-8368-175e8bbbed49"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("f200c636-859b-4e7d-ac2f-3c087cad013b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0d295bc8-5baa-4422-a89c-b54395ee3b3e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("151afc1e-c8ad-4a27-a690-a8713499fc8f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("210cdc95-e77a-4026-9acd-e0d965404395"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2870ee43-b775-4269-b0f0-50b3e1a54c70"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("290d164e-1906-4364-98b1-167f4d240c7d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("386a3915-0262-433f-bd8a-6e0cc80e8989"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3971a212-7287-43f2-9fc5-4a68d8625b50"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5fa83be6-8835-4f33-aca9-18cc0c156def"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6673101c-c562-498c-8557-14e843724b00"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("69a383b1-39bb-41f3-ac78-6b2a105053ee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7d950b1e-867d-4fbb-acf9-80b999a48f0d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b05b8fe-5dac-4609-be15-e4787a73767e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("91b44bf4-5271-457a-8c8a-7c51962df897"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a16be7bd-7e34-46af-bd34-b5269c97ac44"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a56a6675-938f-473d-90c2-713c39895a4e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b081af3d-4b81-4060-af37-5a070cd910d3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ba4ba241-f3bb-484a-a2e6-c7ca653a858c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c7b38f23-a956-47a2-abe4-dd38cabdf20a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("db09786a-62fb-4db0-882c-1cf6b069badb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e145a6b6-e368-48a5-8a95-7bc16726e1cd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e3229b45-37d6-4259-8f1e-7bd4a7fe462e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e7b6db62-87bb-44b7-ab44-5ff70acd5614"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f2a4706e-b3c6-4aa7-82fe-34aa648b99d5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fd4865a2-da20-4026-86a9-d73533cd6542"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("2bb71221-5758-4e54-b59a-4b77eb56eb6a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("735b3bbf-b089-4484-90db-9bb0ca14f94d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9a863ed2-24d4-41dc-b5cc-a756463efe27"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b479641a-0fe2-4cf4-8c4d-67c5bf6a5b42"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("eab4a252-b2c2-43aa-9f5c-63dd5bb3bbc4"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("c918634a-a587-4ba8-b24d-e3d8774000a6"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("fc2dd2a5-cb5e-4874-a634-0bb1c847149c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1adc62d5-dd1b-4c6a-a3f5-ea1b47ad226b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c815d60-e86c-4c31-95b4-810fc67b1618"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92bfc215-ae16-4359-8f6e-2409678cce69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fcb3ec0-ebdd-4b1f-9410-457ddb0f3d0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b74687e9-e7ed-48ee-8bed-070a7b923896"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("febc3ac1-c06e-4024-b627-d2ff543f620a"));

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
                table: "BillingoClients",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddressed",
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
                name: "ActualValueOfOneKredit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RowVersion = table.Column<DateTime>(type: "timestamp(6)", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActualValueOfOneKredit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("53b5b7c5-3ab5-4358-9ebb-a6d91c354480"), new DateTime(2021, 2, 16, 15, 26, 5, 490, DateTimeKind.Local).AddTicks(7755), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("2aa794ae-da27-4fea-b0e9-8bbb6d3a3365"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6876), new DateTime(2021, 2, 16, 15, 27, 5, 491, DateTimeKind.Local).AddTicks(8117), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("3a2e980d-1920-4937-b6f6-a6de4f4e2508"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(9090), new DateTime(2021, 2, 16, 15, 27, 5, 491, DateTimeKind.Local).AddTicks(9120), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("e3ba3472-a016-4aa1-903e-620bae8897b9"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(9142), new DateTime(2021, 2, 16, 15, 27, 5, 491, DateTimeKind.Local).AddTicks(9145), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ab767b31-784a-41d9-a2a7-cefdbc1cff39"), new DateTime(2021, 2, 16, 15, 26, 5, 486, DateTimeKind.Local).AddTicks(8217), true, true, "GTA" },
                    { new Guid("bed2f65e-2547-4006-8859-a5ab954cac05"), new DateTime(2021, 2, 16, 15, 26, 5, 489, DateTimeKind.Local).AddTicks(6829), true, true, "Survival" },
                    { new Guid("eaf7de22-89c5-45d2-b2fc-b7743645506e"), new DateTime(2021, 2, 16, 15, 26, 5, 489, DateTimeKind.Local).AddTicks(6872), true, true, "Skyblock" },
                    { new Guid("3cc36bca-4d48-4111-89e9-706db2cfee45"), new DateTime(2021, 2, 16, 15, 26, 5, 489, DateTimeKind.Local).AddTicks(6878), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("40af799c-4d5c-4748-b184-6a7b07c5472e"), new DateTime(2021, 1, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2912), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3cd503e8-9993-480f-9ca4-d60cc8008aae"), new DateTime(2020, 10, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2920), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f4a80a13-e968-4379-8237-92b3fb530534"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2927), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8851d71c-6702-46d5-9933-b718b3f1d556"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2945), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b74c5da3-0acb-4fad-9f4b-b78c0c280a8d"), new DateTime(2021, 1, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2976), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1103dcd0-a29b-4266-8a3e-5091682d6e2b"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2960), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2ce9a028-61ee-4176-9cd9-aafbb25ba2b5"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2968), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("190aced4-aab7-43ba-be5f-13ce30e81956"), new DateTime(2021, 1, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2905), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("38d75ca3-0feb-4aa1-9c2e-c1cbbd2624ef"), new DateTime(2021, 1, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2983), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("63a8d4f7-1b39-4dbb-9d0e-d7a0977cf731"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2952), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c58d0577-f521-4bd9-a1a4-80061d5cfd65"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2897), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("99f53314-b380-4d4b-94c9-1f0651ec9132"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2935), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b397a529-5cc0-4d5c-81ed-8e39636c65bb"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2882), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d59c3010-3f79-40e7-8213-85708a70c27f"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2872), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("af47a8eb-257e-48f0-bb23-3cbb4fa2b8e4"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2865), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5a40b56d-829e-406e-a9e6-2aa57898cc73"), new DateTime(2020, 10, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2857), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6e6de300-2410-4291-bd9d-08bb7247ad82"), new DateTime(2020, 10, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2849), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("de1acc80-787c-4c86-b653-62903299fbb0"), new DateTime(2021, 1, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2841), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("60e55d1c-a330-4a69-bb88-21644b80d239"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2834), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("066af45e-b343-49ba-a0ce-9378bdfce30a"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2826), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("87d4b279-00c7-41c3-826b-9682d2161e5c"), new DateTime(2020, 11, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2818), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9f313901-3523-460d-ae76-e60bf2cbde19"), new DateTime(2020, 10, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2803), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4a68afca-fb5a-4b01-b2b6-e475ec8f85b4"), new DateTime(2020, 10, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2701), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a14f2e7a-41da-47d5-925a-9a7f08f8ba4d"), new DateTime(2020, 12, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(2890), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("f34a0399-d01f-4231-be3e-778dd17a6d67"), new DateTime(2021, 2, 16, 15, 26, 5, 493, DateTimeKind.Local).AddTicks(352), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("5e0c31d3-a8ef-4d34-9698-dd3ecad71d33"), new DateTime(2021, 2, 16, 15, 24, 25, 493, DateTimeKind.Local).AddTicks(337), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("d4358862-d6f2-4799-8b2d-04851ea374b6"), new DateTime(2021, 2, 16, 15, 25, 15, 493, DateTimeKind.Local).AddTicks(344), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("9f82586e-33e3-4734-a896-88cfcb11db4d"), new DateTime(2021, 2, 16, 15, 22, 45, 492, DateTimeKind.Local).AddTicks(9774), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("51a7845c-ac21-4f25-80c9-c7c087090609"), new DateTime(2021, 2, 16, 15, 23, 35, 493, DateTimeKind.Local).AddTicks(321), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("6b010d63-ad93-4019-b047-d49f98410ccf"), new Guid("1261b5e5-c3be-4fea-8950-8646f346ef08"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(6339), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("611a9112-4df3-4069-804e-b3c571d7ee8c"), new Guid("3915acd1-652c-4da4-be45-f4ea634a1ee7"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(7325), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("3e7b735f-c1f5-4353-93b3-bab220c9c588"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(5534), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("95f73b94-7d90-4e0b-aef7-62477815ac8b"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(5632), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("423fea96-2e75-43ab-b777-78d6c12c2fbe"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(5639), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("be90ee05-ae79-4511-a9fd-91f44751e48a"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(5650), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a16f0965-c632-4306-9b1a-11d2c48ec5c5"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(1323), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e076094f-52a8-442c-843c-603d9178194f"), new DateTime(2021, 2, 16, 15, 26, 5, 492, DateTimeKind.Local).AddTicks(5645), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 15, 26, 5, 490, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(1642), new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(3340), new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6152), new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6158), new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6058), new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6098), new DateTime(2021, 2, 16, 15, 26, 5, 491, DateTimeKind.Local).AddTicks(6111) });
        }
    }
}
