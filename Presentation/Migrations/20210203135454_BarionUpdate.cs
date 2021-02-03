using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BarionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("1fd9c757-b958-47b3-a034-57b3d36a5f31"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("46243715-e660-4b96-8fc0-fb7a029305f0"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("d0ff8355-5435-4a0f-b1f8-cb84af014dd2"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("d12e53d6-569e-45d9-af63-2a9cda41d3a0"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("12496520-53cc-411b-8779-6e40ce6dcb74"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("3694ccca-8c28-4620-b9d8-8b9985b78a11"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("5c735c90-4f3c-4a92-92e7-a341faeff22b"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d54fd439-aeae-45f3-b09f-0aa887849e2d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0af0cca4-3277-47f9-9b4c-90d62f24de87"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("21a878e8-43eb-4876-bda8-fb6c0a7e74d6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("289f806c-e12d-476f-be0a-ff7069ac8157"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3021f239-2211-46d8-91af-4e6196a2faaf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3cb0c557-704c-4594-815c-bde4bf895c16"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("41af7f29-6240-4aca-875e-4c316cb8b774"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4514e774-8948-4646-9118-2cc8d69eeb17"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4f1c6204-d86b-426e-b561-344cf7d8f59b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("516d9e1c-1d47-4a11-a91f-36337dab9de8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5978f06a-7e38-411e-883c-45abbb2a794f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("61d2a262-9c79-4203-b37a-9320d84311fe"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("631ff4f8-5143-4d19-bd34-c44336e345d1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7925a8be-3882-4c52-8e69-20efef0e4957"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7b541273-1406-413a-a6e0-395a35b764ff"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9c5dd261-3849-462c-bc68-8e12ec164efb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ab98bb28-f23d-488c-a589-099cf4c069e9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("af7a6fae-5dca-4958-a834-3efd33b3dd3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b5ce9eaf-7f85-4145-b058-95bf8b1a4a02"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bd5ce008-7568-4cf6-8717-cab5826424bb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c86823a7-6262-4de2-ae92-379bf83bc78f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c9bd3c91-baec-4c21-81d1-86a3365dc14d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e3a0ca54-3f87-47e2-860d-6ed50db736bf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e9220562-8f79-4441-84ae-f1b3894e06d5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ff3fb95f-e665-4e93-9346-a76236698021"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("2d39217a-51bd-4ae8-aac1-94b2611ce9b2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("75d0c0b4-b35f-49e3-a670-f6621dc46ee9"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ad4e4ce6-f2e2-4181-b135-5bab3dbda342"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b20244d8-9c82-4ca8-8863-da5ae9977455"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("cef1ef3a-b7f1-432d-9619-3b3d0ebbd4bd"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("69ef5ac7-2368-42b4-8f7d-1c678263ed49"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("b58f3c07-2879-434c-97e5-192d8e678121"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49784b23-34cd-4c33-9bf0-0e11eb1257d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a78ee24-2c4d-4a83-8b13-115e29a1c6b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("768485cc-2f47-4106-bcaa-b7806429169c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("886cf03f-94b7-49d1-a9a6-2bd023d60030"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97c04caf-0d7e-4a86-a491-e0d4da229461"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e63ca554-0cc4-46ba-b633-ee25e6fcb17c"));

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
                name: "GatewayURL",
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
                values: new object[] { new Guid("066154fa-2533-497f-891c-223f7e84670d"), new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(4963), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("7bcf7634-2a71-4200-a724-0b1960881cac"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(4228), new DateTime(2021, 2, 3, 15, 54, 53, 382, DateTimeKind.Local).AddTicks(5588), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("7108880c-6a8e-49bb-aad3-d3fcdcf1805b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(6625), new DateTime(2021, 2, 3, 15, 54, 53, 382, DateTimeKind.Local).AddTicks(6660), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("05a4d121-f48b-4929-a958-23a41d74ef92"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(6690), new DateTime(2021, 2, 3, 15, 54, 53, 382, DateTimeKind.Local).AddTicks(6693), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("eada129e-f282-4542-8972-1d3347ce0f0c"), new DateTime(2021, 2, 3, 14, 54, 53, 377, DateTimeKind.Local).AddTicks(2691), true, true, "GTA" },
                    { new Guid("a410b6c5-3cda-47a8-bef5-6bddcddef325"), new DateTime(2021, 2, 3, 14, 54, 53, 380, DateTimeKind.Local).AddTicks(2919), true, true, "Survival" },
                    { new Guid("8d878e78-a68c-4ab8-892b-c4af5e58b3ca"), new DateTime(2021, 2, 3, 14, 54, 53, 380, DateTimeKind.Local).AddTicks(2972), true, true, "Skyblock" },
                    { new Guid("514fc5ef-c3d5-4cc4-a36a-e5c0e7578921"), new DateTime(2021, 2, 3, 14, 54, 53, 380, DateTimeKind.Local).AddTicks(2978), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("d45c23e6-318f-45e2-93a5-01f08009e048"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1459), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8a30ae44-1ad0-48b1-9dbc-0b39b289f7f5"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1468), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ec762300-c19e-4fc5-af81-43b03874232d"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1476), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e7b94ffd-3742-4866-8b81-be2fa2bee6b2"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1491), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ecf08288-dd78-44d1-acc3-20a12ae891a9"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1526), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b7bc6aa-0855-4090-9758-49a737e63641"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1507), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("47a3a379-0527-4070-8eea-610691bf2ae6"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1515), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f93f6d00-7bae-47c8-9a57-770f1d3cf8a4"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1446), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("715be4fb-9d46-4cb1-945d-b5e991a30d70"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1534), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f9f5b815-8da5-46dc-913b-021260307562"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1499), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b27ead1a-b682-4c2b-a0ad-d5e0c799fbc0"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1438), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("284eaa16-aec5-42b3-8b18-0d48b3b8f0ec"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1484), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aedc3565-6bae-4133-a89d-010bbc189733"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1421), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7be7b568-0482-4a71-9917-2d0e3998e5c0"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1413), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("71c0f1a7-47ca-4320-b3cc-54107c69005e"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1405), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3ed33b27-9445-4df8-b2a4-e4705d9fddad"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1397), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("442f30fe-b578-4f36-b96d-39b1f5da4bf6"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1388), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e84d95b6-aa55-41ff-b607-61b73962d8e1"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1375), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ff13b0e-ab47-446a-802b-f90354da9db6"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1366), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f137ff74-de56-403d-b647-ed15fca8ef9f"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1358), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("612f0676-50ca-4c28-992e-7d148331fbdc"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1350), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("64963684-8c33-4c92-875a-bd726584d1b4"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1339), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8bc98922-ca90-4d90-b27c-24ec93a577f1"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1228), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4fba50c4-f7ad-4fe5-b9d5-fcd180bba705"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1429), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("5ee0c8b2-376e-4266-b112-cbc7c83260f8"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(8730), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("b6a8d536-ef2d-4140-a3a6-5d74811f856b"), new DateTime(2021, 2, 3, 14, 53, 13, 383, DateTimeKind.Local).AddTicks(8709), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("4f816993-055d-4d9c-8715-a0173448eaa8"), new DateTime(2021, 2, 3, 14, 54, 3, 383, DateTimeKind.Local).AddTicks(8723), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("967b927f-0b80-4c90-88ec-508af178930b"), new DateTime(2021, 2, 3, 14, 51, 33, 383, DateTimeKind.Local).AddTicks(8108), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("8f07dc60-6305-4969-990e-9103106a67f8"), new DateTime(2021, 2, 3, 14, 52, 23, 383, DateTimeKind.Local).AddTicks(8692), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("840ec630-199a-468b-94ec-fdf547799f12"), new Guid("15a48d5d-5187-4934-a1b7-98429b5366ac"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(4558), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d2b8fc31-bc62-40ac-890e-383f8e762822"), new Guid("ca822a11-ab43-40e7-a250-ca3552966fe6"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(5609), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("10b694c7-d87a-4b70-b55d-c853524ed07b"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3647), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4cfa46af-e1a4-49ac-ab13-e6e51d2a8699"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3746), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("262dc35f-4181-49ef-8065-1e2b31b7e6b3"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3754), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2b62743e-93ff-4003-b731-f8563b9d1298"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3769), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("951a6ee1-d7b8-4ba5-a46a-c46bb21d163d"), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(8963), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("9e6b7d96-968c-4fea-9a1a-ce5a2833f06d"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3759), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(8731), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(504), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3492), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3497), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3381), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3438), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3455) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("066154fa-2533-497f-891c-223f7e84670d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("05a4d121-f48b-4929-a958-23a41d74ef92"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7108880c-6a8e-49bb-aad3-d3fcdcf1805b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7bcf7634-2a71-4200-a724-0b1960881cac"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("514fc5ef-c3d5-4cc4-a36a-e5c0e7578921"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("8d878e78-a68c-4ab8-892b-c4af5e58b3ca"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a410b6c5-3cda-47a8-bef5-6bddcddef325"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("eada129e-f282-4542-8972-1d3347ce0f0c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b7bc6aa-0855-4090-9758-49a737e63641"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("284eaa16-aec5-42b3-8b18-0d48b3b8f0ec"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3ed33b27-9445-4df8-b2a4-e4705d9fddad"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("442f30fe-b578-4f36-b96d-39b1f5da4bf6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("47a3a379-0527-4070-8eea-610691bf2ae6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4fba50c4-f7ad-4fe5-b9d5-fcd180bba705"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4ff13b0e-ab47-446a-802b-f90354da9db6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("612f0676-50ca-4c28-992e-7d148331fbdc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("64963684-8c33-4c92-875a-bd726584d1b4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("715be4fb-9d46-4cb1-945d-b5e991a30d70"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("71c0f1a7-47ca-4320-b3cc-54107c69005e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7be7b568-0482-4a71-9917-2d0e3998e5c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8a30ae44-1ad0-48b1-9dbc-0b39b289f7f5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8bc98922-ca90-4d90-b27c-24ec93a577f1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aedc3565-6bae-4133-a89d-010bbc189733"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b27ead1a-b682-4c2b-a0ad-d5e0c799fbc0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d45c23e6-318f-45e2-93a5-01f08009e048"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e7b94ffd-3742-4866-8b81-be2fa2bee6b2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e84d95b6-aa55-41ff-b607-61b73962d8e1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ec762300-c19e-4fc5-af81-43b03874232d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ecf08288-dd78-44d1-acc3-20a12ae891a9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f137ff74-de56-403d-b647-ed15fca8ef9f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f93f6d00-7bae-47c8-9a57-770f1d3cf8a4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f9f5b815-8da5-46dc-913b-021260307562"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4f816993-055d-4d9c-8715-a0173448eaa8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5ee0c8b2-376e-4266-b112-cbc7c83260f8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8f07dc60-6305-4969-990e-9103106a67f8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("967b927f-0b80-4c90-88ec-508af178930b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b6a8d536-ef2d-4140-a3a6-5d74811f856b"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("840ec630-199a-468b-94ec-fdf547799f12"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("d2b8fc31-bc62-40ac-890e-383f8e762822"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10b694c7-d87a-4b70-b55d-c853524ed07b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("262dc35f-4181-49ef-8065-1e2b31b7e6b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b62743e-93ff-4003-b731-f8563b9d1298"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cfa46af-e1a4-49ac-ab13-e6e51d2a8699"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("951a6ee1-d7b8-4ba5-a46a-c46bb21d163d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e6b7d96-968c-4fea-9a1a-ce5a2833f06d"));

            migrationBuilder.DropColumn(
                name: "GatewayURL",
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
                values: new object[] { new Guid("1fd9c757-b958-47b3-a034-57b3d36a5f31"), new DateTime(2021, 1, 30, 14, 40, 53, 406, DateTimeKind.Local).AddTicks(9795), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("46243715-e660-4b96-8fc0-fb7a029305f0"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(8570), new DateTime(2021, 1, 30, 15, 40, 53, 407, DateTimeKind.Local).AddTicks(9821), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d12e53d6-569e-45d9-af63-2a9cda41d3a0"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(802), new DateTime(2021, 1, 30, 15, 40, 53, 408, DateTimeKind.Local).AddTicks(832), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d0ff8355-5435-4a0f-b1f8-cb84af014dd2"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(855), new DateTime(2021, 1, 30, 15, 40, 53, 408, DateTimeKind.Local).AddTicks(858), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("3694ccca-8c28-4620-b9d8-8b9985b78a11"), new DateTime(2021, 1, 30, 14, 40, 53, 402, DateTimeKind.Local).AddTicks(8796), true, true, "GTA" },
                    { new Guid("5c735c90-4f3c-4a92-92e7-a341faeff22b"), new DateTime(2021, 1, 30, 14, 40, 53, 405, DateTimeKind.Local).AddTicks(8580), true, true, "Survival" },
                    { new Guid("12496520-53cc-411b-8779-6e40ce6dcb74"), new DateTime(2021, 1, 30, 14, 40, 53, 405, DateTimeKind.Local).AddTicks(8627), true, true, "Skyblock" },
                    { new Guid("d54fd439-aeae-45f3-b09f-0aa887849e2d"), new DateTime(2021, 1, 30, 14, 40, 53, 405, DateTimeKind.Local).AddTicks(8633), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b541273-1406-413a-a6e0-395a35b764ff"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5228), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("21a878e8-43eb-4876-bda8-fb6c0a7e74d6"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5235), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("289f806c-e12d-476f-be0a-ff7069ac8157"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5244), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7925a8be-3882-4c52-8e69-20efef0e4957"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5263), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c86823a7-6262-4de2-ae92-379bf83bc78f"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5423), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("61d2a262-9c79-4203-b37a-9320d84311fe"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5278), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ff3fb95f-e665-4e93-9346-a76236698021"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5286), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3cb0c557-704c-4594-815c-bde4bf895c16"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5219), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5978f06a-7e38-411e-883c-45abbb2a794f"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5431), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3021f239-2211-46d8-91af-4e6196a2faaf"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5271), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9c5dd261-3849-462c-bc68-8e12ec164efb"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4940), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3a0ca54-3f87-47e2-860d-6ed50db736bf"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(5254), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4f1c6204-d86b-426e-b561-344cf7d8f59b"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4924), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("41af7f29-6240-4aca-875e-4c316cb8b774"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4916), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ab98bb28-f23d-488c-a589-099cf4c069e9"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4906), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bd5ce008-7568-4cf6-8717-cab5826424bb"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4897), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0af0cca4-3277-47f9-9b4c-90d62f24de87"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4890), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("631ff4f8-5143-4d19-bd34-c44336e345d1"), new DateTime(2020, 12, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4881), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("af7a6fae-5dca-4958-a834-3efd33b3dd3f"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4873), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9bd3c91-baec-4c21-81d1-86a3365dc14d"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4865), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b5ce9eaf-7f85-4145-b058-95bf8b1a4a02"), new DateTime(2020, 10, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4857), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e9220562-8f79-4441-84ae-f1b3894e06d5"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4847), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("516d9e1c-1d47-4a11-a91f-36337dab9de8"), new DateTime(2020, 9, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4730), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4514e774-8948-4646-9118-2cc8d69eeb17"), new DateTime(2020, 11, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(4932), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("b20244d8-9c82-4ca8-8863-da5ae9977455"), new DateTime(2021, 1, 30, 14, 40, 53, 409, DateTimeKind.Local).AddTicks(1916), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("75d0c0b4-b35f-49e3-a670-f6621dc46ee9"), new DateTime(2021, 1, 30, 14, 39, 13, 409, DateTimeKind.Local).AddTicks(1900), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("cef1ef3a-b7f1-432d-9619-3b3d0ebbd4bd"), new DateTime(2021, 1, 30, 14, 40, 3, 409, DateTimeKind.Local).AddTicks(1908), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("2d39217a-51bd-4ae8-aac1-94b2611ce9b2"), new DateTime(2021, 1, 30, 14, 37, 33, 409, DateTimeKind.Local).AddTicks(1335), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("ad4e4ce6-f2e2-4181-b135-5bab3dbda342"), new DateTime(2021, 1, 30, 14, 38, 23, 409, DateTimeKind.Local).AddTicks(1885), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("69ef5ac7-2368-42b4-8f7d-1c678263ed49"), new Guid("dfc9fa8e-fb0b-49a6-8bb8-932170f3a279"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7979), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b58f3c07-2879-434c-97e5-192d8e678121"), new Guid("02c27cf0-96e7-4a79-b471-b024965fb236"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(8968), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("e63ca554-0cc4-46ba-b633-ee25e6fcb17c"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7177), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6a78ee24-2c4d-4a83-8b13-115e29a1c6b5"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7276), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("768485cc-2f47-4106-bcaa-b7806429169c"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7284), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("886cf03f-94b7-49d1-a9a6-2bd023d60030"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7297), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("49784b23-34cd-4c33-9bf0-0e11eb1257d6"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(2971), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("97c04caf-0d7e-4a86-a491-e0d4da229461"), new DateTime(2021, 1, 30, 14, 40, 53, 408, DateTimeKind.Local).AddTicks(7291), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(3327), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(5099), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7877), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7882), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7773), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7827), new DateTime(2021, 1, 30, 14, 40, 53, 407, DateTimeKind.Local).AddTicks(7841) });
        }
    }
}
