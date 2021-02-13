using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class ClientIdentityTEst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("98e340be-fa70-426a-99a0-a5cb49f365da"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("2fd87ad3-60de-4034-b1f9-5889109336d2"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3fe29cb2-8b27-48c8-b8dc-77f81b2f129c"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("5bf76d98-e265-4ba5-b823-4ed1caf6ff99"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("0f53614e-6e45-4130-a79a-b89bf0962a92"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("66e19c65-fa9d-4371-977a-d93d1d8a0173"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("772b110f-2f35-45ed-9b42-b5b9ae021c0b"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d32822fe-1bdf-479a-bb52-2c3bdb4cea75"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0481b235-a080-4964-96d5-02901951c15d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("10ee9f78-8b8f-4198-a6a6-a01adf248d97"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("12efe594-e5dd-423d-8846-188eb0c2b757"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1c429b24-7627-47d0-be2e-85f964d66876"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1ef43851-e512-4236-bde5-0428adb13295"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1f76adea-0db9-4cbe-9cf8-84751d7dc594"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28b5821a-7ebc-4e81-9837-ab7d6908c41b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("352bc619-6647-4844-baf5-17fc9e1f1930"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("38e00158-8c0a-48a3-a51f-2084ce9169c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4ba6999d-b65e-46db-b875-c5909117eb53"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5a010f82-c88f-4642-aecd-986145632822"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5a941224-8e64-4125-bf1c-0350c8b1ec75"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("69e13486-742f-4f5d-a323-c6d2d7ca037b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6acc7264-21f6-4b0c-8717-b01a42291190"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("706f8ea9-2271-42eb-9ac8-2575426353ee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("86cd5848-7cf6-4790-a833-4a72ec496642"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8a365b49-da6b-4ccb-95fe-4c38d3b9870b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9353dca2-2b27-4c3e-8b15-38fa7865b9fd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a638c5d2-9a7f-4dbd-8149-8e2e25f61d22"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a8d090dd-8dec-440b-8e05-d1c6b42c833e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ad24bb97-e746-4641-8c18-9f4ecd1fe443"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ce2b7942-4793-4910-81c0-b8055e8bccc9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e05e245b-2445-4dcb-8990-dbfa298cdf57"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fbc8f40c-05e3-49f0-8b81-0e5ae7d040d5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1758ad0f-36e5-4707-942f-71ac0d47f422"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8777826f-aaec-4e94-877f-7a56f1ce36e6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("bb42dc2a-2b69-436b-a9db-08a3c85f02ac"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c169d576-af10-49a0-871e-b908e879d85f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f2c1389f-f16c-4757-891f-3a564c51a6c0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("15fca29c-1a89-4687-b37b-f8d523d91c80"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("acaf6f12-55ac-4eb7-a44f-0ad1fda5a11e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46713d63-f99e-4783-8e72-6528af310394"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f2df18b-00f1-43d7-874b-e517ae41519a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d28c2a8-a29b-42e7-a43a-cccf5fe81cb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b25a9c85-4c8a-4347-81c5-ab74ca386aed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccedc910-daf5-4f28-9da1-752164f19eff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f004efc7-fa8a-46e9-b3b3-a421d4cced56"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("98e340be-fa70-426a-99a0-a5cb49f365da"), new DateTime(2021, 2, 6, 20, 25, 42, 323, DateTimeKind.Local).AddTicks(2521), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("3fe29cb2-8b27-48c8-b8dc-77f81b2f129c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(1429), new DateTime(2021, 2, 6, 21, 25, 42, 324, DateTimeKind.Local).AddTicks(2748), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("5bf76d98-e265-4ba5-b823-4ed1caf6ff99"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(3748), new DateTime(2021, 2, 6, 21, 25, 42, 324, DateTimeKind.Local).AddTicks(3778), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("2fd87ad3-60de-4034-b1f9-5889109336d2"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(3800), new DateTime(2021, 2, 6, 21, 25, 42, 324, DateTimeKind.Local).AddTicks(3803), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("d32822fe-1bdf-479a-bb52-2c3bdb4cea75"), new DateTime(2021, 2, 6, 20, 25, 42, 319, DateTimeKind.Local).AddTicks(3212), true, true, "GTA" },
                    { new Guid("66e19c65-fa9d-4371-977a-d93d1d8a0173"), new DateTime(2021, 2, 6, 20, 25, 42, 322, DateTimeKind.Local).AddTicks(1592), true, true, "Survival" },
                    { new Guid("772b110f-2f35-45ed-9b42-b5b9ae021c0b"), new DateTime(2021, 2, 6, 20, 25, 42, 322, DateTimeKind.Local).AddTicks(1644), true, true, "Skyblock" },
                    { new Guid("0f53614e-6e45-4130-a79a-b89bf0962a92"), new DateTime(2021, 2, 6, 20, 25, 42, 322, DateTimeKind.Local).AddTicks(1650), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("10ee9f78-8b8f-4198-a6a6-a01adf248d97"), new DateTime(2021, 1, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7533), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1ef43851-e512-4236-bde5-0428adb13295"), new DateTime(2020, 10, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7540), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8a365b49-da6b-4ccb-95fe-4c38d3b9870b"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7548), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a638c5d2-9a7f-4dbd-8149-8e2e25f61d22"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7565), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("352bc619-6647-4844-baf5-17fc9e1f1930"), new DateTime(2021, 1, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7596), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5a941224-8e64-4125-bf1c-0350c8b1ec75"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7580), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("706f8ea9-2271-42eb-9ac8-2575426353ee"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7588), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("38e00158-8c0a-48a3-a51f-2084ce9169c0"), new DateTime(2021, 1, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7525), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1c429b24-7627-47d0-be2e-85f964d66876"), new DateTime(2021, 1, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7603), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9353dca2-2b27-4c3e-8b15-38fa7865b9fd"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7573), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("12efe594-e5dd-423d-8846-188eb0c2b757"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7518), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("69e13486-742f-4f5d-a323-c6d2d7ca037b"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7555), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("86cd5848-7cf6-4790-a833-4a72ec496642"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7502), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6acc7264-21f6-4b0c-8717-b01a42291190"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7492), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1f76adea-0db9-4cbe-9cf8-84751d7dc594"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7485), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e05e245b-2445-4dcb-8990-dbfa298cdf57"), new DateTime(2020, 10, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7477), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ad24bb97-e746-4641-8c18-9f4ecd1fe443"), new DateTime(2020, 10, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7470), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fbc8f40c-05e3-49f0-8b81-0e5ae7d040d5"), new DateTime(2021, 1, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7462), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ce2b7942-4793-4910-81c0-b8055e8bccc9"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7455), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28b5821a-7ebc-4e81-9837-ab7d6908c41b"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7447), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5a010f82-c88f-4642-aecd-986145632822"), new DateTime(2020, 11, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7439), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a8d090dd-8dec-440b-8e05-d1c6b42c833e"), new DateTime(2020, 10, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7424), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ba6999d-b65e-46db-b875-c5909117eb53"), new DateTime(2020, 10, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7309), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0481b235-a080-4964-96d5-02901951c15d"), new DateTime(2020, 12, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(7510), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("bb42dc2a-2b69-436b-a9db-08a3c85f02ac"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(4957), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("f2c1389f-f16c-4757-891f-3a564c51a6c0"), new DateTime(2021, 2, 6, 20, 24, 2, 325, DateTimeKind.Local).AddTicks(4942), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("1758ad0f-36e5-4707-942f-71ac0d47f422"), new DateTime(2021, 2, 6, 20, 24, 52, 325, DateTimeKind.Local).AddTicks(4950), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("8777826f-aaec-4e94-877f-7a56f1ce36e6"), new DateTime(2021, 2, 6, 20, 22, 22, 325, DateTimeKind.Local).AddTicks(4370), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("c169d576-af10-49a0-871e-b908e879d85f"), new DateTime(2021, 2, 6, 20, 23, 12, 325, DateTimeKind.Local).AddTicks(4927), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("15fca29c-1a89-4687-b37b-f8d523d91c80"), new Guid("2f28e530-54ef-4150-ac90-cc079ced0f7b"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(997), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("acaf6f12-55ac-4eb7-a44f-0ad1fda5a11e"), new Guid("80754a00-fa38-477d-a39f-ee0ed31fefc0"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(1989), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("4f2df18b-00f1-43d7-874b-e517ae41519a"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(207), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ccedc910-daf5-4f28-9da1-752164f19eff"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(305), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6d28c2a8-a29b-42e7-a43a-cccf5fe81cb4"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(313), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("46713d63-f99e-4783-8e72-6528af310394"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(323), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f004efc7-fa8a-46e9-b3b3-a421d4cced56"), new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(5944), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("b25a9c85-4c8a-4347-81c5-ab74ca386aed"), new DateTime(2021, 2, 6, 20, 25, 42, 325, DateTimeKind.Local).AddTicks(318), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 20, 25, 42, 323, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 20, 25, 42, 323, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 25, 42, 323, DateTimeKind.Local).AddTicks(6081), new DateTime(2021, 2, 6, 20, 25, 42, 323, DateTimeKind.Local).AddTicks(7773), new DateTime(2021, 2, 6, 20, 25, 42, 323, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(739), new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(746), new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(561), new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(615), new DateTime(2021, 2, 6, 20, 25, 42, 324, DateTimeKind.Local).AddTicks(630) });
        }
    }
}
