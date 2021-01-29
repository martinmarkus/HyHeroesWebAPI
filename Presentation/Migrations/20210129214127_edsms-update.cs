using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class edsmsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("8e2d8396-27dc-42e8-99c2-f407937bc40e"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("1315a789-79d9-4d2a-bcd0-ffcae430226b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("678c9adc-de85-43ad-9fe5-551cf42e7b91"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("6e6c9f65-77f4-43de-879c-2f692a03a898"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("047e9389-75af-4aab-93c2-b066c7846bbc"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("20eb5d8a-6715-402f-9b6f-8f8c1b93c081"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a4e0c382-b717-4998-9cf7-8f2ad1caffa7"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("c9f45a3e-2708-4da4-b7a9-9acefffe54cc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("07d49e0d-413f-4c80-869d-e3ead29fa4f9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0ad63268-532d-48c8-b5ab-da6902baeccd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("143b1921-7c66-4c9b-b9c0-94e526abe6db"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1aed4a0a-f983-4b47-9565-433c9f389f91"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2791121e-0ef8-4361-9648-bc5ef2179ebe"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("353940c1-a329-4371-b741-b8454bbe3bee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("49f61ae7-5e83-4517-a0d6-9bcae6fe7800"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("607b3045-e9a3-479d-92fb-495e01ec3f29"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("60fbf293-6d6a-4be2-b5dc-82f1473240f3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6743239b-7ba0-48f6-bc2a-651842cc9262"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("770ccfce-7f2f-4b70-a36f-670084269863"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("90bc4637-a227-4698-b2e2-d37ef2ab9a1f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("99f47b26-77bf-4763-a47f-48e02f840ec0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a42ae8c4-0509-4554-a5e6-34c75bd96192"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("acfb57b7-f8b0-4690-9bd1-78d1bf8f8625"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c3088b35-cc75-4ff8-ae50-09b00fc0c232"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cce0a0a2-27b1-466a-9593-8cb1c99be998"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd2401ab-38cd-405b-aa14-6743011a9a15"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d14034bb-02e4-4b15-a49a-2c1c54200c8a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dbebbc80-fc7e-45ef-8490-aec83ec2746e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e032414f-c203-475d-901f-a05a7346b3ea"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e798a0ac-035c-4251-9a4b-10f75b7aee68"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ec0a006e-58c5-4170-a6f1-66f0d37f273e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ec0a59a8-6359-4eed-9d6c-c5a997436e28"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("47b8f921-e350-4c56-9517-4ee491df7359"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("6aad4ab3-942d-4d03-a46b-d1965e2e9dd5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8a4a716e-498f-4473-bc1d-41f6d435f496"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d6df8faf-0072-478d-894d-2f7fe0a56b8a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ebf268e6-fd51-44cd-b197-d9992ef88e11"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("a05fbe47-bf91-4f77-be73-c19977b031d1"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("a8738125-e9fb-4a7e-a61e-afd58284a86b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19ef3988-693e-4658-93dd-eca2ad0e9d9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b7145bb-1c4d-47f6-907a-60390d26d7f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60869d11-9635-4a4c-aa80-c8354bb79bda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83575c91-ee74-4e7d-8adb-a2ac940e3efe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d252839d-4321-4bd2-a922-43cc4758e072"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f69126fd-48e0-49a6-a8dc-9c60d8181205"));

            migrationBuilder.DropColumn(
                name: "SenderPhoneNumber",
                table: "EDSMSActivationCodes");

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
                table: "EDSMSActivationCodes",
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
                values: new object[] { new Guid("d305ee76-f080-4a79-ac35-3d0d9f04117d"), new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(2095), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("315007d2-f9da-4920-8cae-74a88b538bc6"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(1500), new DateTime(2021, 1, 29, 23, 41, 26, 477, DateTimeKind.Local).AddTicks(2728), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bffc1bb5-b2a2-486c-92ad-54fbd268397d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(3697), new DateTime(2021, 1, 29, 23, 41, 26, 477, DateTimeKind.Local).AddTicks(3732), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("01335e9f-43d0-42cb-b92e-bb2c29560e24"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(3755), new DateTime(2021, 1, 29, 23, 41, 26, 477, DateTimeKind.Local).AddTicks(3758), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("cf4608d3-0b9d-475f-961c-cc4ee5eb8081"), new DateTime(2021, 1, 29, 22, 41, 26, 472, DateTimeKind.Local).AddTicks(720), true, true, "GTA" },
                    { new Guid("d33cc6d3-9ad7-4ff8-9bc0-ea047c616a5f"), new DateTime(2021, 1, 29, 22, 41, 26, 475, DateTimeKind.Local).AddTicks(777), true, true, "Survival" },
                    { new Guid("68a9f1d2-d935-41c6-9758-2ffc5e5a7424"), new DateTime(2021, 1, 29, 22, 41, 26, 475, DateTimeKind.Local).AddTicks(830), true, true, "Skyblock" },
                    { new Guid("533a445e-5e37-49a4-aee3-951683c1ec7a"), new DateTime(2021, 1, 29, 22, 41, 26, 475, DateTimeKind.Local).AddTicks(836), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("cca19aed-5586-43f7-a6b3-b2b981a2069f"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9600), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6c0f829c-95e1-4b48-b298-5d10d6132644"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9607), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b651e0db-4395-4874-9a07-26d6252afb7e"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9618), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f52430d7-26b5-4c6e-a933-e3b4937f5e00"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9632), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4f253bbc-f505-42b9-bb15-4a7f85c650ac"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9661), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("406e3b93-b0c1-4324-867a-77b33298adf9"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9647), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2fcba9d6-070b-4b7e-85c0-7ce7f007ccfa"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9654), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0924befa-eb01-4862-9ca8-4ee7488d9691"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9592), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("18cd576d-3bb5-4d62-9174-ca2324f43dfd"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9669), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5817dc13-c871-4ef4-93b4-5d36577fd597"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9639), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3e80b8cd-991e-49ac-a58b-cde9191de2c0"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9585), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("29c78304-80b8-4d4e-9400-bcf0fc88ae8d"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9625), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f5585a47-7b95-4ab9-8ca3-0ebbe5780812"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9570), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("687c83fe-b710-45ee-b6c8-b418e440ef43"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9562), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("83344f22-4fd6-4154-a955-24661b67b210"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9554), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("50d036b2-dc1f-4040-a171-758b70918d07"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9540), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1d030e70-c213-456e-8b75-bfca3c7b5dc2"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9533), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6d6f9c67-ce6a-46c2-b071-1b7f46cc6b3f"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9526), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("08eb4bff-8103-41ef-a014-2abc061e7583"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9518), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f561b462-65ff-408f-b67f-219e8f7f081d"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9510), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd30132b-f2b6-4328-b9bf-223e25210e4f"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9501), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("394067de-3eea-4e73-9f29-a659c49b4c92"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9490), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c181281c-c554-4d17-989b-a9ae4ae61232"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9365), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("36b8e506-3c8c-4486-9ffa-c4186a09a7d3"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9577), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("95b6bf6c-88f0-49ee-9b3c-35753bf6a4a8"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(6771), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("1a7f759e-a84f-4cf1-940f-d18415973fa1"), new DateTime(2021, 1, 29, 22, 39, 46, 478, DateTimeKind.Local).AddTicks(6754), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("9ba9edc3-5785-4da7-986a-e2f6468a8ef1"), new DateTime(2021, 1, 29, 22, 40, 36, 478, DateTimeKind.Local).AddTicks(6761), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("f4bf01ee-7eb1-4bdc-ab8d-357b403444d3"), new DateTime(2021, 1, 29, 22, 38, 6, 478, DateTimeKind.Local).AddTicks(6104), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("e5d08294-84de-4373-b187-e4f4975c5085"), new DateTime(2021, 1, 29, 22, 38, 56, 478, DateTimeKind.Local).AddTicks(6736), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("bf4c3928-f96f-48b3-870d-91d1310be838"), new Guid("11fbb629-0472-4b52-8cbc-e4b6a3377f10"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(1672), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e9838a29-1b80-4538-9f1f-5ab1857ac496"), new Guid("5b7a2add-bc94-4f27-9452-4f9800b4bc92"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(3267), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("91dc868a-ecef-42d7-b21a-8bb475af3b99"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(810), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("c1c532d7-91fe-4908-ba87-213c1aaedbdd"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(918), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("697f7f3d-45c1-4023-9c93-7252f4e6ff22"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(927), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cb09cd43-9ba5-4fe1-99cb-ba56e214e73e"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(983), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("81955be4-be11-438d-b1ea-1fe8ca3728dc"), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(5866), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f77adf85-26a4-409b-b716-9e41ee0bad6d"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(977), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(6369), new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(8072), new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(817), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(821), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(703), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(756), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(774) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("d305ee76-f080-4a79-ac35-3d0d9f04117d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("01335e9f-43d0-42cb-b92e-bb2c29560e24"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("315007d2-f9da-4920-8cae-74a88b538bc6"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bffc1bb5-b2a2-486c-92ad-54fbd268397d"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("533a445e-5e37-49a4-aee3-951683c1ec7a"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("68a9f1d2-d935-41c6-9758-2ffc5e5a7424"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("cf4608d3-0b9d-475f-961c-cc4ee5eb8081"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d33cc6d3-9ad7-4ff8-9bc0-ea047c616a5f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("08eb4bff-8103-41ef-a014-2abc061e7583"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0924befa-eb01-4862-9ca8-4ee7488d9691"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("18cd576d-3bb5-4d62-9174-ca2324f43dfd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1d030e70-c213-456e-8b75-bfca3c7b5dc2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("29c78304-80b8-4d4e-9400-bcf0fc88ae8d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2fcba9d6-070b-4b7e-85c0-7ce7f007ccfa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("36b8e506-3c8c-4486-9ffa-c4186a09a7d3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("394067de-3eea-4e73-9f29-a659c49b4c92"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3e80b8cd-991e-49ac-a58b-cde9191de2c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("406e3b93-b0c1-4324-867a-77b33298adf9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4f253bbc-f505-42b9-bb15-4a7f85c650ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("50d036b2-dc1f-4040-a171-758b70918d07"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5817dc13-c871-4ef4-93b4-5d36577fd597"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("687c83fe-b710-45ee-b6c8-b418e440ef43"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6c0f829c-95e1-4b48-b298-5d10d6132644"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6d6f9c67-ce6a-46c2-b071-1b7f46cc6b3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("83344f22-4fd6-4154-a955-24661b67b210"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b651e0db-4395-4874-9a07-26d6252afb7e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c181281c-c554-4d17-989b-a9ae4ae61232"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cca19aed-5586-43f7-a6b3-b2b981a2069f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd30132b-f2b6-4328-b9bf-223e25210e4f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f52430d7-26b5-4c6e-a933-e3b4937f5e00"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f5585a47-7b95-4ab9-8ca3-0ebbe5780812"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f561b462-65ff-408f-b67f-219e8f7f081d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1a7f759e-a84f-4cf1-940f-d18415973fa1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("95b6bf6c-88f0-49ee-9b3c-35753bf6a4a8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9ba9edc3-5785-4da7-986a-e2f6468a8ef1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e5d08294-84de-4373-b187-e4f4975c5085"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f4bf01ee-7eb1-4bdc-ab8d-357b403444d3"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("bf4c3928-f96f-48b3-870d-91d1310be838"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("e9838a29-1b80-4538-9f1f-5ab1857ac496"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("697f7f3d-45c1-4023-9c93-7252f4e6ff22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81955be4-be11-438d-b1ea-1fe8ca3728dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91dc868a-ecef-42d7-b21a-8bb475af3b99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1c532d7-91fe-4908-ba87-213c1aaedbdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb09cd43-9ba5-4fe1-99cb-ba56e214e73e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f77adf85-26a4-409b-b716-9e41ee0bad6d"));

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
                table: "EDSMSActivationCodes",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<string>(
                name: "SenderPhoneNumber",
                table: "EDSMSActivationCodes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

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
                values: new object[] { new Guid("8e2d8396-27dc-42e8-99c2-f407937bc40e"), new DateTime(2021, 1, 28, 20, 42, 2, 560, DateTimeKind.Local).AddTicks(2626), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("1315a789-79d9-4d2a-bcd0-ffcae430226b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(1747), new DateTime(2021, 1, 28, 21, 42, 2, 561, DateTimeKind.Local).AddTicks(3046), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("678c9adc-de85-43ad-9fe5-551cf42e7b91"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(4065), new DateTime(2021, 1, 28, 21, 42, 2, 561, DateTimeKind.Local).AddTicks(4099), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("6e6c9f65-77f4-43de-879c-2f692a03a898"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(4127), new DateTime(2021, 1, 28, 21, 42, 2, 561, DateTimeKind.Local).AddTicks(4130), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("c9f45a3e-2708-4da4-b7a9-9acefffe54cc"), new DateTime(2021, 1, 28, 20, 42, 2, 556, DateTimeKind.Local).AddTicks(1408), true, true, "GTA" },
                    { new Guid("047e9389-75af-4aab-93c2-b066c7846bbc"), new DateTime(2021, 1, 28, 20, 42, 2, 559, DateTimeKind.Local).AddTicks(1024), true, true, "Survival" },
                    { new Guid("a4e0c382-b717-4998-9cf7-8f2ad1caffa7"), new DateTime(2021, 1, 28, 20, 42, 2, 559, DateTimeKind.Local).AddTicks(1069), true, true, "Skyblock" },
                    { new Guid("20eb5d8a-6715-402f-9b6f-8f8c1b93c081"), new DateTime(2021, 1, 28, 20, 42, 2, 559, DateTimeKind.Local).AddTicks(1075), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("1aed4a0a-f983-4b47-9565-433c9f389f91"), new DateTime(2020, 12, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8476), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2791121e-0ef8-4361-9648-bc5ef2179ebe"), new DateTime(2020, 9, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8483), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ec0a59a8-6359-4eed-9d6c-c5a997436e28"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8491), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cce0a0a2-27b1-466a-9593-8cb1c99be998"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8506), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ec0a006e-58c5-4170-a6f1-66f0d37f273e"), new DateTime(2020, 12, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8577), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("07d49e0d-413f-4c80-869d-e3ead29fa4f9"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8521), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a42ae8c4-0509-4554-a5e6-34c75bd96192"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8567), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("770ccfce-7f2f-4b70-a36f-670084269863"), new DateTime(2020, 12, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8465), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("49f61ae7-5e83-4517-a0d6-9bcae6fe7800"), new DateTime(2020, 12, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8584), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("acfb57b7-f8b0-4690-9bd1-78d1bf8f8625"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8513), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dbebbc80-fc7e-45ef-8490-aec83ec2746e"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8458), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d14034bb-02e4-4b15-a49a-2c1c54200c8a"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8498), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c3088b35-cc75-4ff8-ae50-09b00fc0c232"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8442), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e798a0ac-035c-4251-9a4b-10f75b7aee68"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8435), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("353940c1-a329-4371-b741-b8454bbe3bee"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8427), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("90bc4637-a227-4698-b2e2-d37ef2ab9a1f"), new DateTime(2020, 9, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8404), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("607b3045-e9a3-479d-92fb-495e01ec3f29"), new DateTime(2020, 9, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8396), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("143b1921-7c66-4c9b-b9c0-94e526abe6db"), new DateTime(2020, 12, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8383), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("60fbf293-6d6a-4be2-b5dc-82f1473240f3"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8375), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6743239b-7ba0-48f6-bc2a-651842cc9262"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8367), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e032414f-c203-475d-901f-a05a7346b3ea"), new DateTime(2020, 10, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8359), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("99f47b26-77bf-4763-a47f-48e02f840ec0"), new DateTime(2020, 9, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8348), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0ad63268-532d-48c8-b5ab-da6902baeccd"), new DateTime(2020, 9, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8225), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd2401ab-38cd-405b-aa14-6743011a9a15"), new DateTime(2020, 11, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(8450), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("d6df8faf-0072-478d-894d-2f7fe0a56b8a"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(5636), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("ebf268e6-fd51-44cd-b197-d9992ef88e11"), new DateTime(2021, 1, 28, 20, 40, 22, 562, DateTimeKind.Local).AddTicks(5615), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("47b8f921-e350-4c56-9517-4ee491df7359"), new DateTime(2021, 1, 28, 20, 41, 12, 562, DateTimeKind.Local).AddTicks(5629), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("6aad4ab3-942d-4d03-a46b-d1965e2e9dd5"), new DateTime(2021, 1, 28, 20, 38, 42, 562, DateTimeKind.Local).AddTicks(5028), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("8a4a716e-498f-4473-bc1d-41f6d435f496"), new DateTime(2021, 1, 28, 20, 39, 32, 562, DateTimeKind.Local).AddTicks(5601), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a05fbe47-bf91-4f77-be73-c19977b031d1"), new Guid("e051bb08-959d-40bd-95c2-7fd25947ff85"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(1542), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a8738125-e9fb-4a7e-a61e-afd58284a86b"), new Guid("2c860a4e-9276-4e23-ac1c-f9caba77d595"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(2575), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("d252839d-4321-4bd2-a922-43cc4758e072"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(700), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5b7145bb-1c4d-47f6-907a-60390d26d7f6"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(797), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f69126fd-48e0-49a6-a8dc-9c60d8181205"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(804), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("83575c91-ee74-4e7d-8adb-a2ac940e3efe"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(820), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("19ef3988-693e-4658-93dd-eca2ad0e9d9c"), new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(6345), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("60869d11-9635-4a4c-aa80-c8354bb79bda"), new DateTime(2021, 1, 28, 20, 42, 2, 562, DateTimeKind.Local).AddTicks(809), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 28, 20, 42, 2, 560, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 28, 20, 42, 2, 560, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 28, 20, 42, 2, 560, DateTimeKind.Local).AddTicks(6377), new DateTime(2021, 1, 28, 20, 42, 2, 560, DateTimeKind.Local).AddTicks(8126), new DateTime(2021, 1, 28, 20, 42, 2, 560, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(1012), new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(1018), new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(897), new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(951), new DateTime(2021, 1, 28, 20, 42, 2, 561, DateTimeKind.Local).AddTicks(969) });
        }
    }
}
