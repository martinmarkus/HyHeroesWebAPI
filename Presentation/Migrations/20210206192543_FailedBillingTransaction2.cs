using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class FailedBillingTransaction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FailedTransactions_BillingTransactions_BillingTransactionId",
                table: "FailedTransactions");

            migrationBuilder.DropIndex(
                name: "IX_FailedTransactions_BillingTransactionId",
                table: "FailedTransactions");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("5f49ad6d-cddf-4166-af5a-d25500d14584"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("0dc69d5d-af49-4092-b855-ffd6fa6c9f02"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("56bc3cf4-c7cd-4c9e-8581-fdbf932122c4"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("90fc5912-e00d-4697-aee0-47d42f3f3ed5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("1e32710c-a91b-450c-bb6f-55687e5d936e"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("4c1d9cab-d6e1-448f-8a8e-8ac20f787442"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("5908e7da-8ac7-4413-8933-d66daa8bd62f"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("bcb6535c-5f6f-47d9-b504-6d9686e92db7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("03b58319-0cac-4aca-b9eb-aec6b08122ed"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b485629-bfc6-48c7-9bea-f5733d26afa9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0bd9ba5d-945f-46c5-8eee-62765ca10e3c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("11c753fb-ab5f-4cff-afe1-bf6a08482def"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("21165887-736a-41f8-bd91-93c692f74ce1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2c7bbf6a-63db-403a-a8d8-a396c0e42a00"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a1ff17b-36b4-4cab-b13a-35bdaa3e6d20"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3df8b0ff-9c9a-4027-922c-b9b58525aafd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3ea5cae9-3033-4b40-a593-88a32499e805"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("53bae153-f10c-475e-813b-ba082d3d84ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("71a712cc-1b56-4760-8673-fdbab37217d8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("84813171-71f3-4df4-95e5-ab459227434f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8d2a0acc-9142-4d52-a66f-12696d4c567f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("947c27c2-b91b-440d-ae83-a2d9baf4df15"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9dc3418b-3917-4bf3-b56f-6d415f8c1038"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a481e90f-8a69-4b2e-ae08-f3da94aa6fb8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a73bcd96-d20e-4040-b6ec-eb4c12ffc72b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a9663510-221c-4e19-925d-8959e5c1ec7f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ab8f84d2-a76d-445b-8674-e5c3e4d19b55"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e7e34358-cc6b-4089-9da6-8e89e528a306"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eac2525d-2433-43de-9584-a93081fa2b70"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eb4183f7-db81-4ede-bfcd-ef6a8b00d318"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ef99d1d9-39a4-4f0e-9689-c54378a131be"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f090cfaa-b4e9-4154-a92a-89f43d7838ff"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1d9cedd9-0adb-4ea3-bd5e-32c4e08d84fd"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4195b836-f58f-41aa-88a5-15b376f3a2d0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4f249271-451c-45d4-a04d-5225db53d5d5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("61ea59aa-4bb1-47c9-b474-ba8385d1f58f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("fac070f5-2717-49b5-a6d2-b59b8937a820"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("7ffcf7e9-64a2-4255-b204-4cc32f0ece35"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("9f91bf27-5c9f-4c8b-ac0e-25089b83b87b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ed18ec8-464b-4d06-95d2-d63d10166886"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4748568f-0074-4a95-8586-a0f2eb4cc9c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af4348ac-9022-471e-81fe-ce5e9a1b19a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6c35eee-d153-41cd-a5a2-bfa1e360864b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcbf4f76-1737-4945-becd-b3aded9c4ded"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f908d762-d770-49cc-a2d1-0706e88b6311"));

            migrationBuilder.DropColumn(
                name: "BillingTransactionId",
                table: "FailedTransactions");

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

            migrationBuilder.AddColumn<int>(
                name: "CurrencyValue",
                table: "FailedTransactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "FailedTransactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "FailedTransactions",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactions_UserId",
                table: "FailedTransactions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FailedTransactions_Users_UserId",
                table: "FailedTransactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FailedTransactions_Users_UserId",
                table: "FailedTransactions");

            migrationBuilder.DropIndex(
                name: "IX_FailedTransactions_UserId",
                table: "FailedTransactions");

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

            migrationBuilder.DropColumn(
                name: "CurrencyValue",
                table: "FailedTransactions");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "FailedTransactions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FailedTransactions");

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

            migrationBuilder.AddColumn<Guid>(
                name: "BillingTransactionId",
                table: "FailedTransactions",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                values: new object[] { new Guid("5f49ad6d-cddf-4166-af5a-d25500d14584"), new DateTime(2021, 2, 6, 0, 29, 7, 169, DateTimeKind.Local).AddTicks(8604), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("56bc3cf4-c7cd-4c9e-8581-fdbf932122c4"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(7549), new DateTime(2021, 2, 6, 1, 29, 7, 170, DateTimeKind.Local).AddTicks(8909), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0dc69d5d-af49-4092-b855-ffd6fa6c9f02"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(9905), new DateTime(2021, 2, 6, 1, 29, 7, 170, DateTimeKind.Local).AddTicks(9937), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("90fc5912-e00d-4697-aee0-47d42f3f3ed5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(9957), new DateTime(2021, 2, 6, 1, 29, 7, 170, DateTimeKind.Local).AddTicks(9961), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("1e32710c-a91b-450c-bb6f-55687e5d936e"), new DateTime(2021, 2, 6, 0, 29, 7, 165, DateTimeKind.Local).AddTicks(7375), true, true, "GTA" },
                    { new Guid("4c1d9cab-d6e1-448f-8a8e-8ac20f787442"), new DateTime(2021, 2, 6, 0, 29, 7, 168, DateTimeKind.Local).AddTicks(7352), true, true, "Survival" },
                    { new Guid("5908e7da-8ac7-4413-8933-d66daa8bd62f"), new DateTime(2021, 2, 6, 0, 29, 7, 168, DateTimeKind.Local).AddTicks(7398), true, true, "Skyblock" },
                    { new Guid("bcb6535c-5f6f-47d9-b504-6d9686e92db7"), new DateTime(2021, 2, 6, 0, 29, 7, 168, DateTimeKind.Local).AddTicks(7405), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("9dc3418b-3917-4bf3-b56f-6d415f8c1038"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3852), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ef99d1d9-39a4-4f0e-9689-c54378a131be"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3860), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a481e90f-8a69-4b2e-ae08-f3da94aa6fb8"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3869), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("947c27c2-b91b-440d-ae83-a2d9baf4df15"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3885), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a1ff17b-36b4-4cab-b13a-35bdaa3e6d20"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3914), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb4183f7-db81-4ede-bfcd-ef6a8b00d318"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3900), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3df8b0ff-9c9a-4027-922c-b9b58525aafd"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3907), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a73bcd96-d20e-4040-b6ec-eb4c12ffc72b"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3845), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ab8f84d2-a76d-445b-8674-e5c3e4d19b55"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3922), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a9663510-221c-4e19-925d-8959e5c1ec7f"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3892), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("03b58319-0cac-4aca-b9eb-aec6b08122ed"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3838), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("21165887-736a-41f8-bd91-93c692f74ce1"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3877), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("84813171-71f3-4df4-95e5-ab459227434f"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3823), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("11c753fb-ab5f-4cff-afe1-bf6a08482def"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3815), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3ea5cae9-3033-4b40-a593-88a32499e805"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3808), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b485629-bfc6-48c7-9bea-f5733d26afa9"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3795), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eac2525d-2433-43de-9584-a93081fa2b70"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3786), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e7e34358-cc6b-4089-9da6-8e89e528a306"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3778), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f090cfaa-b4e9-4154-a92a-89f43d7838ff"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3771), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0bd9ba5d-945f-46c5-8eee-62765ca10e3c"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3763), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2c7bbf6a-63db-403a-a8d8-a396c0e42a00"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3756), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("71a712cc-1b56-4760-8673-fdbab37217d8"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3745), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("53bae153-f10c-475e-813b-ba082d3d84ac"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3634), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8d2a0acc-9142-4d52-a66f-12696d4c567f"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3830), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("1d9cedd9-0adb-4ea3-bd5e-32c4e08d84fd"), new DateTime(2021, 2, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(1219), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("4f249271-451c-45d4-a04d-5225db53d5d5"), new DateTime(2021, 2, 6, 0, 27, 27, 172, DateTimeKind.Local).AddTicks(1202), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("4195b836-f58f-41aa-88a5-15b376f3a2d0"), new DateTime(2021, 2, 6, 0, 28, 17, 172, DateTimeKind.Local).AddTicks(1209), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("61ea59aa-4bb1-47c9-b474-ba8385d1f58f"), new DateTime(2021, 2, 6, 0, 25, 47, 172, DateTimeKind.Local).AddTicks(629), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("fac070f5-2717-49b5-a6d2-b59b8937a820"), new DateTime(2021, 2, 6, 0, 26, 37, 172, DateTimeKind.Local).AddTicks(1186), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9f91bf27-5c9f-4c8b-ac0e-25089b83b87b"), new Guid("91f580a5-8eb2-471f-bd73-e74616de9157"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(7252), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7ffcf7e9-64a2-4255-b204-4cc32f0ece35"), new Guid("2735330a-8ae8-46cb-819f-f45293ba90dd"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(8252), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("af4348ac-9022-471e-81fe-ce5e9a1b19a8"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6344), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("dcbf4f76-1737-4945-becd-b3aded9c4ded"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6541), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f908d762-d770-49cc-a2d1-0706e88b6311"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6551), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2ed18ec8-464b-4d06-95d2-d63d10166886"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6563), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4748568f-0074-4a95-8586-a0f2eb4cc9c9"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(2105), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d6c35eee-d153-41cd-a5a2-bfa1e360864b"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6557), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 169, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(2273), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(4066), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6848), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6854), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6743), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6795), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactions_BillingTransactionId",
                table: "FailedTransactions",
                column: "BillingTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FailedTransactions_BillingTransactions_BillingTransactionId",
                table: "FailedTransactions",
                column: "BillingTransactionId",
                principalTable: "BillingTransactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
