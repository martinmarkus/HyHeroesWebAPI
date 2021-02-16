using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class Notfication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("59c568ee-c119-4928-8bb5-43c6f49cb9fd"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("0689e551-d628-44ec-aa2e-8468f83cc1a5"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("4b639f52-a12f-4bf3-936d-4b6b12e30e0b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("ea1f00fc-2c01-4cd5-91e6-79e9f40ffceb"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("44c9c3bd-edba-4f7c-9375-9b49a9a32a84"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("4764b46c-c53f-46b1-9fe2-a957c6e9f9d9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d5f95782-f1c0-48a4-ae59-bf43e11bb778"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ea8255f3-13a2-4678-9193-bedd7b76fdca"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("09c9a984-986d-4cd3-8e3f-1c1d8371799f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1b3220f1-55fd-4751-ad84-0112094a84c5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2226d447-7eda-4ddb-a60e-e5a08e6cd72d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2ac0badb-9869-49dc-a25f-befce818737f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("353f6e8c-d702-45ba-9122-4bb15c93f03e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("46fd3b67-7550-4d5d-99f0-10cdc766dd46"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4e28be67-9a7f-46dc-8033-a8e80f72e1cf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("506cf7a2-4459-4cc1-8498-c94d1a42fccc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5a28e0e4-a704-419f-ab16-a03dca2e7a0b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5dd812d2-454e-46fd-9c17-ce85dc554fa7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("65892bad-b675-4fb9-a425-3fa71804f3fc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6b08458a-f3b9-40b0-a418-4508210ce614"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6c834214-2489-4988-aea0-0bd224a5b136"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("833d5909-9473-44fd-ba01-1b77b3453d46"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("843d18ab-4d93-4313-8705-24acaae7068b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("84960fcf-a4d6-45b1-a44b-793ff75664a0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9273261a-dc88-43bc-9bf4-81a69eeb0f7b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("acdfb88d-4023-4f36-b4eb-843ed6901f39"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ae6a7a95-367b-4f7e-8d31-3b46f81028ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c06450f7-e217-4b2b-91b4-eac34335d22a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c6bd7909-c45b-42d3-b7b9-a22ab6111773"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f2cacfe2-21c0-4891-9edd-b9f47db42079"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f306dd6a-8dff-42ff-9e8a-cd27ada79db1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fa13a9c5-cd5c-4814-93ff-44c51169490d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1fcb43d4-60f3-4d1e-9a1c-d075280dbb53"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("26664e22-16d0-4c6b-bb70-fd1979a6f8b2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("678e43b7-496d-407d-a0ca-031dee1a6dd4"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("70fa8cfb-a1b2-42c7-ad06-05aab9c77870"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("aae8e37b-9720-4d9e-9d2b-48900cfbaa56"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("434b4df3-c180-4439-a9f6-f524db43d471"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("c9ffff02-d874-4e11-8caa-50ea7617a938"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dce9a97-565b-40b7-9ac7-b96a1cda92f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("729ec07d-ae57-4dfc-9dcc-e0a6d967d169"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a24fc238-4970-4467-8a43-29dc1a613e02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd832b02-7f27-4a0d-8de5-139c2d14bf39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddcf5478-686c-490f-9edd-398dd8237282"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e895af9c-95ea-437f-87e0-7d1e6d614a51"));

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Notifications");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Notifications",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("53b5b7c5-3ab5-4358-9ebb-a6d91c354480"));

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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Notifications",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Notifications",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<Guid>(
                name: "ReceiverId",
                table: "Notifications",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                values: new object[] { new Guid("59c568ee-c119-4928-8bb5-43c6f49cb9fd"), new DateTime(2021, 2, 16, 14, 26, 43, 925, DateTimeKind.Local).AddTicks(6322), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("4b639f52-a12f-4bf3-936d-4b6b12e30e0b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5853), new DateTime(2021, 2, 16, 14, 27, 43, 926, DateTimeKind.Local).AddTicks(7182), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0689e551-d628-44ec-aa2e-8468f83cc1a5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(8209), new DateTime(2021, 2, 16, 14, 27, 43, 926, DateTimeKind.Local).AddTicks(8248), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("ea1f00fc-2c01-4cd5-91e6-79e9f40ffceb"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 2, 16, 14, 27, 43, 926, DateTimeKind.Local).AddTicks(8275), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("d5f95782-f1c0-48a4-ae59-bf43e11bb778"), new DateTime(2021, 2, 16, 14, 26, 43, 921, DateTimeKind.Local).AddTicks(5996), true, true, "GTA" },
                    { new Guid("44c9c3bd-edba-4f7c-9375-9b49a9a32a84"), new DateTime(2021, 2, 16, 14, 26, 43, 924, DateTimeKind.Local).AddTicks(5088), true, true, "Survival" },
                    { new Guid("ea8255f3-13a2-4678-9193-bedd7b76fdca"), new DateTime(2021, 2, 16, 14, 26, 43, 924, DateTimeKind.Local).AddTicks(5135), true, true, "Skyblock" },
                    { new Guid("4764b46c-c53f-46b1-9fe2-a957c6e9f9d9"), new DateTime(2021, 2, 16, 14, 26, 43, 924, DateTimeKind.Local).AddTicks(5141), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("353f6e8c-d702-45ba-9122-4bb15c93f03e"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2490), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f306dd6a-8dff-42ff-9e8a-cd27ada79db1"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2498), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f2cacfe2-21c0-4891-9edd-b9f47db42079"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2506), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fa13a9c5-cd5c-4814-93ff-44c51169490d"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2523), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("833d5909-9473-44fd-ba01-1b77b3453d46"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2553), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c06450f7-e217-4b2b-91b4-eac34335d22a"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2538), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9273261a-dc88-43bc-9bf4-81a69eeb0f7b"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2546), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2226d447-7eda-4ddb-a60e-e5a08e6cd72d"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2483), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4e28be67-9a7f-46dc-8033-a8e80f72e1cf"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2561), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("843d18ab-4d93-4313-8705-24acaae7068b"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2531), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5a28e0e4-a704-419f-ab16-a03dca2e7a0b"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2475), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6b08458a-f3b9-40b0-a418-4508210ce614"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2513), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("46fd3b67-7550-4d5d-99f0-10cdc766dd46"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2460), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae6a7a95-367b-4f7e-8d31-3b46f81028ac"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2450), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("09c9a984-986d-4cd3-8e3f-1c1d8371799f"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2442), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("506cf7a2-4459-4cc1-8498-c94d1a42fccc"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2435), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("acdfb88d-4023-4f36-b4eb-843ed6901f39"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2427), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c6bd7909-c45b-42d3-b7b9-a22ab6111773"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2419), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5dd812d2-454e-46fd-9c17-ce85dc554fa7"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2411), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2ac0badb-9869-49dc-a25f-befce818737f"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2404), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("65892bad-b675-4fb9-a425-3fa71804f3fc"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2396), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1b3220f1-55fd-4751-ad84-0112094a84c5"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2380), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("84960fcf-a4d6-45b1-a44b-793ff75664a0"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2272), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6c834214-2489-4988-aea0-0bd224a5b136"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2467), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("aae8e37b-9720-4d9e-9d2b-48900cfbaa56"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(9768), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("678e43b7-496d-407d-a0ca-031dee1a6dd4"), new DateTime(2021, 2, 16, 14, 25, 3, 927, DateTimeKind.Local).AddTicks(9753), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("26664e22-16d0-4c6b-bb70-fd1979a6f8b2"), new DateTime(2021, 2, 16, 14, 25, 53, 927, DateTimeKind.Local).AddTicks(9761), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("70fa8cfb-a1b2-42c7-ad06-05aab9c77870"), new DateTime(2021, 2, 16, 14, 23, 23, 927, DateTimeKind.Local).AddTicks(9173), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("1fcb43d4-60f3-4d1e-9a1c-d075280dbb53"), new DateTime(2021, 2, 16, 14, 24, 13, 927, DateTimeKind.Local).AddTicks(9738), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("434b4df3-c180-4439-a9f6-f524db43d471"), new Guid("79f9a880-5a9a-49cb-8d7e-b705051002fc"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5722), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9ffff02-d874-4e11-8caa-50ea7617a938"), new Guid("a87f472b-fb72-49a5-a64c-9b9dfb43d7c0"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(6722), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("a24fc238-4970-4467-8a43-29dc1a613e02"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(4905), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ddcf5478-686c-490f-9edd-398dd8237282"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5004), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cd832b02-7f27-4a0d-8de5-139c2d14bf39"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5012), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e895af9c-95ea-437f-87e0-7d1e6d614a51"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5022), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("729ec07d-ae57-4dfc-9dcc-e0a6d967d169"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(569), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("3dce9a97-565b-40b7-9ac7-b96a1cda92f9"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5017), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 925, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 925, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(436), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(2194), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5033), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5038), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(4930), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(4973), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(4987) });
        }
    }
}
