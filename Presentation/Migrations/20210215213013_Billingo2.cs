using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class Billingo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("6c3ac295-1bc0-451a-8520-004d2e9abfdf"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3b2f6084-d8d1-493d-bd48-8bd04803ead3"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("b6a50c21-aec7-4bb1-a42f-4385d1027c83"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("e0a7c6b8-0f66-4cf2-9d4b-b635f7948c0c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("065b9b83-c589-465d-910d-cf79de033153"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("323a3c83-540b-4ca3-b389-3eaab2008192"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("51ec2a20-8e43-40d8-95c5-46ccafa5086c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("6d0b9bc5-9ae3-4ee5-aee1-7b07798a3c52"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("08c80c31-8c44-4574-92b8-b8948d36e790"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("14f17160-6e84-4fe2-881f-87b3bb8b083f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("215b2056-7a99-4dab-b375-bdb352555472"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("388fa5e5-a98e-46b4-8956-a4a937d29128"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("397a4781-72e6-4cf1-bfbd-48a6334e1853"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c22e621-99d6-412f-af42-bb8ed88dcd8e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("48cbfe28-0820-42f3-b97b-8b04ff9e1c50"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4bdb80e9-a184-4a34-bff8-3c4088787f58"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4eda1cc1-109f-46d9-a2eb-f612c57550d9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5c0a55ac-b01a-46c9-8ae6-a1b5c573b465"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7210e4bc-beb4-425b-9722-46c035eaa2c2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("72b5549e-926d-4526-97ac-c1c6d62651c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("86a7b451-3f33-4621-b907-0c7387a90b9a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b0a0a8c-70dc-4acc-a1ac-772ffbbdab89"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9eaf1b14-7077-4e69-b7e4-52084cdbd5e6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("af91109b-811e-4ed7-9e2a-ef826b90ea8d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bfab8c70-2283-4a49-9c4f-e88b069ac2ca"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c9a53089-965e-47f6-8a0b-a116e553f976"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd91a416-352a-4ff9-a54a-6efb7d8f24a4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dbde1b4a-5fdf-4284-a4ee-ee9801f3213b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e17577a2-7324-40ef-8682-7d2db1358d37"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e4365606-1738-49a0-838b-69571656efb8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ea9e15a5-99d1-4a64-b475-bea8db21443f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ff100242-566b-439e-9b7a-80e7c2f5ed2b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("343ca7b6-b516-44ce-8e65-f98021dd911d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("37ea45f4-2cef-4a39-838a-c30fcf7278d5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("48e1f15a-a546-4784-8a13-7c8d2b3c2cf6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("55ebcea4-524a-47c5-bad7-89a82df80a13"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b829264e-8ded-419e-a850-2b7c22a83ae8"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("78040267-637c-46cf-8fc9-d7294ddd8272"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("94bccb85-26c6-46ae-bd80-700478243631"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00bb4177-9718-49b6-9d18-53ea0d8b2859"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f849029-5819-41ef-962f-96946c8c8e2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1d7233-d413-4777-a8a8-a2e3b6377319"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("901142da-3f9c-46eb-8f54-d35d88d98bb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c99ed6b6-7027-4327-b72d-97feb3de3c08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc1feb6c-fea5-4a5c-bbd6-46e43f589f63"));

            migrationBuilder.DropColumn(
                name: "Region",
                table: "BillingoBillingAddressed");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "BillingoBillingAddressed");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "BillingoBillingAddressed");

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

            migrationBuilder.AddColumn<string>(
                name: "HouseNrc",
                table: "BillingoBillingAddressed",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "BillingoBillingAddressed",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "BillingoBillingAddressed",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetType",
                table: "BillingoBillingAddressed",
                nullable: true);

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
                values: new object[] { new Guid("063c08ea-d64f-46a8-88db-92857cce011e"), new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(3947), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("7eeb5534-1479-4228-a68b-78201170827d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(3068), new DateTime(2021, 2, 15, 22, 31, 12, 746, DateTimeKind.Local).AddTicks(4310), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d6032798-1573-42c1-baf3-bfa1730d6818"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(5277), new DateTime(2021, 2, 15, 22, 31, 12, 746, DateTimeKind.Local).AddTicks(5306), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("9e98f1e8-c93a-4079-bf12-6ca1aa8cdd34"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(5327), new DateTime(2021, 2, 15, 22, 31, 12, 746, DateTimeKind.Local).AddTicks(5330), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("6b29e9af-820d-45b2-9c8d-25d103377b6a"), new DateTime(2021, 2, 15, 22, 30, 12, 741, DateTimeKind.Local).AddTicks(3457), true, true, "GTA" },
                    { new Guid("7fc82764-def8-410c-a2bd-db92b3e9facf"), new DateTime(2021, 2, 15, 22, 30, 12, 744, DateTimeKind.Local).AddTicks(2595), true, true, "Survival" },
                    { new Guid("40ef2b11-6295-448d-a853-737dcbf55af5"), new DateTime(2021, 2, 15, 22, 30, 12, 744, DateTimeKind.Local).AddTicks(2642), true, true, "Skyblock" },
                    { new Guid("0b3db5a1-41cb-4a79-a826-d0342a41cfd5"), new DateTime(2021, 2, 15, 22, 30, 12, 744, DateTimeKind.Local).AddTicks(2649), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("40763ab5-f691-4425-b245-eb6ed6a1c547"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8918), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("468cdf61-5221-46a2-92a0-1dff677581b7"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8925), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1ffabc7e-9530-43e7-9af4-a216f5995ae3"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8933), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2de2145e-0e7e-47dc-a063-9af4bdb95131"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8949), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("04793bc4-3802-4254-bccd-38a41083fc43"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8979), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("efce2569-13a6-4f1f-9e13-fc07a5893780"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8964), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9bee088b-6a0f-4bc8-a714-1ce9474e6669"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8972), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("13d7c203-b6f3-4817-a395-702797bf8646"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8910), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("29ca66a5-114b-421a-95e7-0e5e66146233"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8987), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9b255ddd-5beb-454e-8ea4-9e2b9c68f300"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8957), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("211f8c0c-5ba2-4eef-91b2-5521e8090ea0"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8902), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0f1a79e5-3daa-4e8f-bf74-6ff8158225d2"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8940), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("88224dce-0f91-461a-a56b-d489691d28eb"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8887), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fcb055e7-87df-4007-bac0-87198304e22c"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8877), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ef5d7ec-3b7e-42b5-8f4d-66fd9f1b81ac"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8870), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae3e0752-a236-4a73-a520-c82145dcb51e"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8863), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("60dcb2e1-f4b7-49f3-b497-53d1aa1628b5"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8855), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b81abd95-6d86-47ca-a541-99c400623262"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8847), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d5780007-a337-445b-bc51-be0e02509914"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8839), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb6ed58d-c12b-4d92-ab23-c25c1c6d2ab7"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8831), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9bdf8b75-6d8b-4d35-92b4-e61666758087"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8823), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("65cfaa80-c075-4acd-a9c5-44b623a30470"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8808), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28aaee62-f2fa-43d2-8a18-fac8e66cc8e9"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8711), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9aa23d46-8ca2-4304-b6cf-040f917c775d"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8895), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("98c01085-883c-44d7-b5bd-13204b717079"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(6419), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("46debc89-7360-4b78-b43f-114763c1b73b"), new DateTime(2021, 2, 15, 22, 28, 32, 747, DateTimeKind.Local).AddTicks(6405), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("f34bde09-46fa-4934-bef2-6b99eb6e437d"), new DateTime(2021, 2, 15, 22, 29, 22, 747, DateTimeKind.Local).AddTicks(6412), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("95f1c3e5-88ca-473e-a032-85e96d58b887"), new DateTime(2021, 2, 15, 22, 26, 52, 747, DateTimeKind.Local).AddTicks(5852), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("695c549e-33fe-4681-9ac3-1f96a1e3ebea"), new DateTime(2021, 2, 15, 22, 27, 42, 747, DateTimeKind.Local).AddTicks(6390), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f824b540-66fb-495d-960e-a3078cb06574"), new Guid("ac610d79-2109-421a-806e-0fea9c5ebef6"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(2550), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("083d5b40-b214-4ed3-858e-eae87e491dc0"), new Guid("4813e356-c057-42d8-8ae4-c61683c69074"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(3515), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("2cd160a5-fa98-4206-84cf-e3921b21b4b2"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1752), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6d8ba587-c2f3-40dc-9ead-45b4b4701e50"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1849), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0ed39aa6-cf39-4621-b49a-20d2564d055a"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1855), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7612b1ba-2d25-43ca-a834-cdfc2cd4f296"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1866), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5e0336b6-3914-480c-9256-69a06a517214"), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(7477), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4f2736b4-50b6-4ed4-a670-f103257d4940"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1861), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(7951), new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(9623), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2371), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2376), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2273), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2315), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2329) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("063c08ea-d64f-46a8-88db-92857cce011e"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7eeb5534-1479-4228-a68b-78201170827d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("9e98f1e8-c93a-4079-bf12-6ca1aa8cdd34"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("d6032798-1573-42c1-baf3-bfa1730d6818"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("0b3db5a1-41cb-4a79-a826-d0342a41cfd5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("40ef2b11-6295-448d-a853-737dcbf55af5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("6b29e9af-820d-45b2-9c8d-25d103377b6a"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7fc82764-def8-410c-a2bd-db92b3e9facf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("04793bc4-3802-4254-bccd-38a41083fc43"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0f1a79e5-3daa-4e8f-bf74-6ff8158225d2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("13d7c203-b6f3-4817-a395-702797bf8646"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1ffabc7e-9530-43e7-9af4-a216f5995ae3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("211f8c0c-5ba2-4eef-91b2-5521e8090ea0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28aaee62-f2fa-43d2-8a18-fac8e66cc8e9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("29ca66a5-114b-421a-95e7-0e5e66146233"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2de2145e-0e7e-47dc-a063-9af4bdb95131"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("40763ab5-f691-4425-b245-eb6ed6a1c547"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("468cdf61-5221-46a2-92a0-1dff677581b7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4ef5d7ec-3b7e-42b5-8f4d-66fd9f1b81ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("60dcb2e1-f4b7-49f3-b497-53d1aa1628b5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("65cfaa80-c075-4acd-a9c5-44b623a30470"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("88224dce-0f91-461a-a56b-d489691d28eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9aa23d46-8ca2-4304-b6cf-040f917c775d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9b255ddd-5beb-454e-8ea4-9e2b9c68f300"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9bdf8b75-6d8b-4d35-92b4-e61666758087"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9bee088b-6a0f-4bc8-a714-1ce9474e6669"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ae3e0752-a236-4a73-a520-c82145dcb51e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b81abd95-6d86-47ca-a541-99c400623262"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d5780007-a337-445b-bc51-be0e02509914"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eb6ed58d-c12b-4d92-ab23-c25c1c6d2ab7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("efce2569-13a6-4f1f-9e13-fc07a5893780"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fcb055e7-87df-4007-bac0-87198304e22c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("46debc89-7360-4b78-b43f-114763c1b73b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("695c549e-33fe-4681-9ac3-1f96a1e3ebea"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("95f1c3e5-88ca-473e-a032-85e96d58b887"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("98c01085-883c-44d7-b5bd-13204b717079"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f34bde09-46fa-4934-bef2-6b99eb6e437d"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("083d5b40-b214-4ed3-858e-eae87e491dc0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("f824b540-66fb-495d-960e-a3078cb06574"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ed39aa6-cf39-4621-b49a-20d2564d055a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cd160a5-fa98-4206-84cf-e3921b21b4b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f2736b4-50b6-4ed4-a670-f103257d4940"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e0336b6-3914-480c-9256-69a06a517214"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d8ba587-c2f3-40dc-9ead-45b4b4701e50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7612b1ba-2d25-43ca-a834-cdfc2cd4f296"));

            migrationBuilder.DropColumn(
                name: "HouseNrc",
                table: "BillingoBillingAddressed");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "BillingoBillingAddressed");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "BillingoBillingAddressed");

            migrationBuilder.DropColumn(
                name: "StreetType",
                table: "BillingoBillingAddressed");

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

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "BillingoBillingAddressed",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "BillingoBillingAddressed",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "BillingoBillingAddressed",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

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
                values: new object[] { new Guid("6c3ac295-1bc0-451a-8520-004d2e9abfdf"), new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(1499), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("e0a7c6b8-0f66-4cf2-9d4b-b635f7948c0c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(798), new DateTime(2021, 2, 15, 22, 24, 22, 563, DateTimeKind.Local).AddTicks(2073), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("b6a50c21-aec7-4bb1-a42f-4385d1027c83"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(3074), new DateTime(2021, 2, 15, 22, 24, 22, 563, DateTimeKind.Local).AddTicks(3102), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("3b2f6084-d8d1-493d-bd48-8bd04803ead3"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(3125), new DateTime(2021, 2, 15, 22, 24, 22, 563, DateTimeKind.Local).AddTicks(3128), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("51ec2a20-8e43-40d8-95c5-46ccafa5086c"), new DateTime(2021, 2, 15, 22, 23, 22, 558, DateTimeKind.Local).AddTicks(895), true, true, "GTA" },
                    { new Guid("6d0b9bc5-9ae3-4ee5-aee1-7b07798a3c52"), new DateTime(2021, 2, 15, 22, 23, 22, 560, DateTimeKind.Local).AddTicks(9958), true, true, "Survival" },
                    { new Guid("323a3c83-540b-4ca3-b389-3eaab2008192"), new DateTime(2021, 2, 15, 22, 23, 22, 561, DateTimeKind.Local).AddTicks(47), true, true, "Skyblock" },
                    { new Guid("065b9b83-c589-465d-910d-cf79de033153"), new DateTime(2021, 2, 15, 22, 23, 22, 561, DateTimeKind.Local).AddTicks(54), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("86a7b451-3f33-4621-b907-0c7387a90b9a"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7382), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9eaf1b14-7077-4e69-b7e4-52084cdbd5e6"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7390), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("388fa5e5-a98e-46b4-8956-a4a937d29128"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7397), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("215b2056-7a99-4dab-b375-bdb352555472"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7413), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e4365606-1738-49a0-838b-69571656efb8"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7445), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("72b5549e-926d-4526-97ac-c1c6d62651c0"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7430), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("af91109b-811e-4ed7-9e2a-ef826b90ea8d"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7438), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c22e621-99d6-412f-af42-bb8ed88dcd8e"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7374), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd91a416-352a-4ff9-a54a-6efb7d8f24a4"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7453), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("397a4781-72e6-4cf1-bfbd-48a6334e1853"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7423), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5c0a55ac-b01a-46c9-8ae6-a1b5c573b465"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7367), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("08c80c31-8c44-4574-92b8-b8948d36e790"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7405), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4bdb80e9-a184-4a34-bff8-3c4088787f58"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7349), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ea9e15a5-99d1-4a64-b475-bea8db21443f"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7341), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4eda1cc1-109f-46d9-a2eb-f612c57550d9"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7288), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9a53089-965e-47f6-8a0b-a116e553f976"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7280), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dbde1b4a-5fdf-4284-a4ee-ee9801f3213b"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7272), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7210e4bc-beb4-425b-9722-46c035eaa2c2"), new DateTime(2021, 1, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7264), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ff100242-566b-439e-9b7a-80e7c2f5ed2b"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7257), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("14f17160-6e84-4fe2-881f-87b3bb8b083f"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7249), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b0a0a8c-70dc-4acc-a1ac-772ffbbdab89"), new DateTime(2020, 11, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7236), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e17577a2-7324-40ef-8682-7d2db1358d37"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7226), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("48cbfe28-0820-42f3-b97b-8b04ff9e1c50"), new DateTime(2020, 10, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7116), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bfab8c70-2283-4a49-9c4f-e88b069ac2ca"), new DateTime(2020, 12, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(7359), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("b829264e-8ded-419e-a850-2b7c22a83ae8"), new DateTime(2021, 2, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(4699), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("37ea45f4-2cef-4a39-838a-c30fcf7278d5"), new DateTime(2021, 2, 15, 22, 21, 42, 564, DateTimeKind.Local).AddTicks(4685), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("55ebcea4-524a-47c5-bad7-89a82df80a13"), new DateTime(2021, 2, 15, 22, 22, 32, 564, DateTimeKind.Local).AddTicks(4692), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("48e1f15a-a546-4784-8a13-7c8d2b3c2cf6"), new DateTime(2021, 2, 15, 22, 20, 2, 564, DateTimeKind.Local).AddTicks(4101), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("343ca7b6-b516-44ce-8e65-f98021dd911d"), new DateTime(2021, 2, 15, 22, 20, 52, 564, DateTimeKind.Local).AddTicks(4669), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("78040267-637c-46cf-8fc9-d7294ddd8272"), new Guid("2d95b988-2ebf-4c57-8572-fb656e00c1a1"), new DateTime(2021, 2, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(671), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("94bccb85-26c6-46ae-bd80-700478243631"), new Guid("16d94b28-d89d-4f7f-b614-e69b8a4eda9b"), new DateTime(2021, 2, 15, 22, 23, 22, 564, DateTimeKind.Local).AddTicks(1675), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("c99ed6b6-7027-4327-b72d-97feb3de3c08"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9827), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("901142da-3f9c-46eb-8f54-d35d88d98bb2"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9938), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2f849029-5819-41ef-962f-96946c8c8e2d"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9946), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("00bb4177-9718-49b6-9d18-53ea0d8b2859"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9957), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cc1feb6c-fea5-4a5c-bbd6-46e43f589f63"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(5394), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5d1d7233-d413-4777-a8a8-a2e3b6377319"), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(9952), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(5463), new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(7241), new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(72), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(78), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 23, 22, 562, DateTimeKind.Local).AddTicks(9967), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(12), new DateTime(2021, 2, 15, 22, 23, 22, 563, DateTimeKind.Local).AddTicks(25) });
        }
    }
}
