using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class UserRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
