using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BarionTransactoinUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("7328e4dc-65b4-4573-bca5-02d21832f0ad"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("0232980b-5530-4734-8145-fa25a5617a9f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("82e9ec6a-71fd-493a-80d7-695725e087f3"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("ee541414-13c4-457e-a4ee-7e3d2c0ab644"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("33ddcaef-8968-4a5c-b592-b9f2179b806d"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("48f9022c-f082-4eb8-9d0c-08aae28d4c58"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a57d7099-d390-4331-ba13-eddfdc677cd4"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("b5008477-28ea-4add-ac68-a081a5193db7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("05c09082-932e-4366-9e9c-f48dfff2c894"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1998bbad-ec97-429d-8a4b-bed3696dda64"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1fb314b7-b2a9-4ef1-aae3-23e48d1ff569"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("24360eed-6edf-429b-b4b4-c94287ad6e6f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("25e12943-780f-404d-9dc1-c75d6a7480bd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2e6982f5-828d-48a4-a519-525572a93b8f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2fa73b9d-4758-4097-b042-4a5777c9877b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a53560d-3f97-40d4-aaa5-346a81bfa080"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3acfea7e-cd69-463b-9b23-53f37bc067c2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5265755f-7210-47c1-a6d3-2d4d122d8f4f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("556d817b-1760-4c40-a9ba-5d437af754ad"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("762ffc97-fdda-45a6-acc3-93c95a465e8d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("831dd767-15d4-4169-87d2-3a680362e782"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("84901ef7-8bcb-4b9e-afe8-a5fad8e802ad"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8cac369a-378f-4676-80aa-d439f63c67ab"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8fb2f84f-e2ed-43e9-970d-e481537db629"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("94f5ccd5-5780-46cc-8222-75ce7a6b34f5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9ad8f530-bd92-4fe8-b8d7-350efc1506c4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a3315a5a-9ecb-4ff0-a6df-52a7ed9565a4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a7b85cf5-ee6f-4b44-99db-4cdd5163930b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("db006ca9-e668-4e56-a9ce-ddc1b475c96b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ee634b04-4768-4cc1-a683-c6e9442dab8a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fb02437b-98e9-49e6-ba3c-0d1409e575c2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fc2a6d5c-1042-4b55-bd56-801a153f49a5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("3292ef6c-33e6-4511-a047-7b3227ca3802"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4c760130-3729-4e5c-9d97-1f999b80fcff"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a29a6c42-b37b-4355-a10a-35943b87b4e6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ca83fbea-78c1-456f-8c6c-8342afea73b4"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f41424f3-9049-422a-8575-b6e1396a998d"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("08fa4915-e19e-4fae-9617-082124d4158c"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("a7ee7db1-af60-4a07-9372-056e4dc32d0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00730414-9fe4-4b28-a126-b462e4405f86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b13efff-bc92-4cfa-b492-24ec1c8b2afa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5191bc0a-3ede-4d6f-8bd8-c1fc51871e0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b844b3-1fa7-45c4-8a9e-8b77f76dcd04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8634ac5a-5b8c-4a8e-8981-c4711cf3cbac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fdd93e7-a766-4e0e-8277-e5cc23de2de0"));

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

            migrationBuilder.AddColumn<bool>(
                name: "IsBilled",
                table: "BillingTransactions",
                nullable: false,
                defaultValue: false);

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
                values: new object[] { new Guid("61013486-cb33-4b5b-b490-a5cee66f0aa4"), new DateTime(2021, 2, 5, 19, 55, 40, 263, DateTimeKind.Local).AddTicks(5949), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("c9d3d9fc-7bd2-47ea-89cf-aca4e51e8899"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4940), new DateTime(2021, 2, 5, 20, 55, 40, 264, DateTimeKind.Local).AddTicks(6236), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("10ccf853-17b3-4e44-9589-8064b92379dc"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(7253), new DateTime(2021, 2, 5, 20, 55, 40, 264, DateTimeKind.Local).AddTicks(7302), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("ba2ffd59-e4b8-4fdb-97e9-89074f92d358"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(7326), new DateTime(2021, 2, 5, 20, 55, 40, 264, DateTimeKind.Local).AddTicks(7329), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("d02c443e-c224-4f0a-a37c-d4b27e355d72"), new DateTime(2021, 2, 5, 19, 55, 40, 259, DateTimeKind.Local).AddTicks(3484), true, true, "GTA" },
                    { new Guid("39c684a7-271d-47fb-a246-36d6b4862c46"), new DateTime(2021, 2, 5, 19, 55, 40, 262, DateTimeKind.Local).AddTicks(3982), true, true, "Survival" },
                    { new Guid("0d0de8ff-77cb-4cb7-b8b6-3c3ef0b4e41d"), new DateTime(2021, 2, 5, 19, 55, 40, 262, DateTimeKind.Local).AddTicks(4042), true, true, "Skyblock" },
                    { new Guid("c92ab661-b5d3-41d2-9629-36ac8aad7aad"), new DateTime(2021, 2, 5, 19, 55, 40, 262, DateTimeKind.Local).AddTicks(4051), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("d4fd6c29-da90-457a-b4a7-f7760fdf2772"), new DateTime(2021, 1, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1899), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8fa911a7-8eb5-4a8a-bdd2-be9e84a0a7fa"), new DateTime(2020, 10, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1906), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f9c6b6de-57c3-4903-9f71-19738d279302"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1914), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c214739b-02ac-48e4-a88a-85774b560093"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1931), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b1848bd3-1f6f-4625-adea-446863e94beb"), new DateTime(2021, 1, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1963), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("85d919de-dd18-464c-af8a-3b703a6f9364"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1948), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7ced14e7-6bdc-497c-90b8-c458d9ea9d7a"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1956), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f3bf6669-1003-4c54-8415-d50ea1a5e26c"), new DateTime(2021, 1, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1890), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c5a6bb55-8167-46c1-b35b-785fe40dd2df"), new DateTime(2021, 1, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1971), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6adceb2d-939c-4d94-b973-127026529e5b"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1938), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0da73db0-c5b9-4d46-a4f0-d71fa0ad65ed"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1882), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28070fda-8fab-405e-8014-c377af254176"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1922), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cf17d060-9ab5-40fe-8ff1-9a42fd7bda52"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1864), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d80c3484-1e0d-4197-a8ba-be4062268ab2"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1856), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a745c24d-714f-462c-aacd-417e3861b0fd"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1848), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("78478be5-cf8e-4911-8a5c-878cccf2d880"), new DateTime(2020, 10, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1840), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9f17f1e3-7c37-4fe0-8bd8-cd2f0831a610"), new DateTime(2020, 10, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1832), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d46964c7-3c82-488f-be45-88f51128991a"), new DateTime(2021, 1, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1824), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("16ea2f20-1478-47df-b5c9-948e3314b439"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1816), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f9ad031d-18b8-4040-8f54-8ebb15a04562"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1803), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("21b336bd-33cc-4ad9-b63a-835fbe132f4e"), new DateTime(2020, 11, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1704), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5db3b576-2456-47a4-8a15-fbd2c4e940fe"), new DateTime(2020, 10, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1694), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f211262a-5c48-4a82-8047-9963fe0555ab"), new DateTime(2020, 10, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1565), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("074b72db-5fde-4d99-b4b2-83fa495fdb29"), new DateTime(2020, 12, 5, 19, 55, 40, 266, DateTimeKind.Local).AddTicks(1872), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("3c2aadbb-290f-4cca-9f50-0420b0d9d907"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(9095), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("86cff2e0-bbee-43f6-bc19-44667d2a8194"), new DateTime(2021, 2, 5, 19, 54, 0, 265, DateTimeKind.Local).AddTicks(9079), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("c67111d5-1f17-43a4-8ea9-00d63cdabc5a"), new DateTime(2021, 2, 5, 19, 54, 50, 265, DateTimeKind.Local).AddTicks(9087), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("5ba970a0-0f64-49c1-9055-344d174e4e5d"), new DateTime(2021, 2, 5, 19, 52, 20, 265, DateTimeKind.Local).AddTicks(8472), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("0fcd5570-2a02-4c3e-88ca-668aeb6d5400"), new DateTime(2021, 2, 5, 19, 53, 10, 265, DateTimeKind.Local).AddTicks(9063), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("1962959b-5672-4cf7-a57e-618e68ca2134"), new Guid("d4312150-07a8-44a8-a57e-7825fdfecd0d"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(4985), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aa11ea7f-8ea3-4ad5-aded-4c2709be0a4e"), new Guid("b0ceb749-abe6-420f-b972-c733c3b43cdd"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(6008), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("81457510-d0b2-4e44-bd4b-0dfe59da0683"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(4144), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("70460665-ca50-4bb4-99b2-14a4dbaa1b25"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(4243), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("77aa0cd4-113f-4b80-8d1f-b71724167dd1"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(4256), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f2dd1718-f490-4e02-a2ab-ff43e85d8e94"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(4267), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("dfb60717-f0f9-495f-8ccc-66a664e485ed"), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(9594), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5d4131ec-cf67-44cd-a1e2-2111d665c955"), new DateTime(2021, 2, 5, 19, 55, 40, 265, DateTimeKind.Local).AddTicks(4262), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 55, 40, 263, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 55, 40, 263, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 55, 40, 263, DateTimeKind.Local).AddTicks(9621), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(1362), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4209), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4215), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4093), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4152), new DateTime(2021, 2, 5, 19, 55, 40, 264, DateTimeKind.Local).AddTicks(4169) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("61013486-cb33-4b5b-b490-a5cee66f0aa4"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("10ccf853-17b3-4e44-9589-8064b92379dc"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("ba2ffd59-e4b8-4fdb-97e9-89074f92d358"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("c9d3d9fc-7bd2-47ea-89cf-aca4e51e8899"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("0d0de8ff-77cb-4cb7-b8b6-3c3ef0b4e41d"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("39c684a7-271d-47fb-a246-36d6b4862c46"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("c92ab661-b5d3-41d2-9629-36ac8aad7aad"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d02c443e-c224-4f0a-a37c-d4b27e355d72"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("074b72db-5fde-4d99-b4b2-83fa495fdb29"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0da73db0-c5b9-4d46-a4f0-d71fa0ad65ed"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("16ea2f20-1478-47df-b5c9-948e3314b439"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("21b336bd-33cc-4ad9-b63a-835fbe132f4e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28070fda-8fab-405e-8014-c377af254176"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5db3b576-2456-47a4-8a15-fbd2c4e940fe"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6adceb2d-939c-4d94-b973-127026529e5b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("78478be5-cf8e-4911-8a5c-878cccf2d880"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7ced14e7-6bdc-497c-90b8-c458d9ea9d7a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("85d919de-dd18-464c-af8a-3b703a6f9364"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8fa911a7-8eb5-4a8a-bdd2-be9e84a0a7fa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9f17f1e3-7c37-4fe0-8bd8-cd2f0831a610"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a745c24d-714f-462c-aacd-417e3861b0fd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b1848bd3-1f6f-4625-adea-446863e94beb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c214739b-02ac-48e4-a88a-85774b560093"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c5a6bb55-8167-46c1-b35b-785fe40dd2df"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cf17d060-9ab5-40fe-8ff1-9a42fd7bda52"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d46964c7-3c82-488f-be45-88f51128991a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d4fd6c29-da90-457a-b4a7-f7760fdf2772"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d80c3484-1e0d-4197-a8ba-be4062268ab2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f211262a-5c48-4a82-8047-9963fe0555ab"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f3bf6669-1003-4c54-8415-d50ea1a5e26c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f9ad031d-18b8-4040-8f54-8ebb15a04562"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f9c6b6de-57c3-4903-9f71-19738d279302"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0fcd5570-2a02-4c3e-88ca-668aeb6d5400"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("3c2aadbb-290f-4cca-9f50-0420b0d9d907"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5ba970a0-0f64-49c1-9055-344d174e4e5d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("86cff2e0-bbee-43f6-bc19-44667d2a8194"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c67111d5-1f17-43a4-8ea9-00d63cdabc5a"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("1962959b-5672-4cf7-a57e-618e68ca2134"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("aa11ea7f-8ea3-4ad5-aded-4c2709be0a4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d4131ec-cf67-44cd-a1e2-2111d665c955"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70460665-ca50-4bb4-99b2-14a4dbaa1b25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77aa0cd4-113f-4b80-8d1f-b71724167dd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81457510-d0b2-4e44-bd4b-0dfe59da0683"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfb60717-f0f9-495f-8ccc-66a664e485ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2dd1718-f490-4e02-a2ab-ff43e85d8e94"));

            migrationBuilder.DropColumn(
                name: "IsBilled",
                table: "BillingTransactions");

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
                values: new object[] { new Guid("7328e4dc-65b4-4573-bca5-02d21832f0ad"), new DateTime(2021, 2, 5, 19, 51, 22, 416, DateTimeKind.Local).AddTicks(4943), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("82e9ec6a-71fd-493a-80d7-695725e087f3"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3965), new DateTime(2021, 2, 5, 20, 51, 22, 417, DateTimeKind.Local).AddTicks(5223), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("ee541414-13c4-457e-a4ee-7e3d2c0ab644"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(6228), new DateTime(2021, 2, 5, 20, 51, 22, 417, DateTimeKind.Local).AddTicks(6262), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0232980b-5530-4734-8145-fa25a5617a9f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(6291), new DateTime(2021, 2, 5, 20, 51, 22, 417, DateTimeKind.Local).AddTicks(6294), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("33ddcaef-8968-4a5c-b592-b9f2179b806d"), new DateTime(2021, 2, 5, 19, 51, 22, 412, DateTimeKind.Local).AddTicks(3086), true, true, "GTA" },
                    { new Guid("48f9022c-f082-4eb8-9d0c-08aae28d4c58"), new DateTime(2021, 2, 5, 19, 51, 22, 415, DateTimeKind.Local).AddTicks(3099), true, true, "Survival" },
                    { new Guid("a57d7099-d390-4331-ba13-eddfdc677cd4"), new DateTime(2021, 2, 5, 19, 51, 22, 415, DateTimeKind.Local).AddTicks(3149), true, true, "Skyblock" },
                    { new Guid("b5008477-28ea-4add-ac68-a081a5193db7"), new DateTime(2021, 2, 5, 19, 51, 22, 415, DateTimeKind.Local).AddTicks(3157), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("8fb2f84f-e2ed-43e9-970d-e481537db629"), new DateTime(2021, 1, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(497), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1fb314b7-b2a9-4ef1-aae3-23e48d1ff569"), new DateTime(2020, 10, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(504), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("556d817b-1760-4c40-a9ba-5d437af754ad"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(512), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1998bbad-ec97-429d-8a4b-bed3696dda64"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(527), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5265755f-7210-47c1-a6d3-2d4d122d8f4f"), new DateTime(2021, 1, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(559), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a3315a5a-9ecb-4ff0-a6df-52a7ed9565a4"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(542), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9ad8f530-bd92-4fe8-b8d7-350efc1506c4"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(550), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2fa73b9d-4758-4097-b042-4a5777c9877b"), new DateTime(2021, 1, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(486), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("84901ef7-8bcb-4b9e-afe8-a5fad8e802ad"), new DateTime(2021, 1, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(567), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("831dd767-15d4-4169-87d2-3a680362e782"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(535), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a53560d-3f97-40d4-aaa5-346a81bfa080"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(479), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8cac369a-378f-4676-80aa-d439f63c67ab"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(519), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("05c09082-932e-4366-9e9c-f48dfff2c894"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(464), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3acfea7e-cd69-463b-9b23-53f37bc067c2"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(456), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fc2a6d5c-1042-4b55-bd56-801a153f49a5"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(448), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("db006ca9-e668-4e56-a9ce-ddc1b475c96b"), new DateTime(2020, 10, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(441), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2e6982f5-828d-48a4-a519-525572a93b8f"), new DateTime(2020, 10, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(433), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a7b85cf5-ee6f-4b44-99db-4cdd5163930b"), new DateTime(2021, 1, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(419), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("25e12943-780f-404d-9dc1-c75d6a7480bd"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(411), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("94f5ccd5-5780-46cc-8222-75ce7a6b34f5"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(403), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("24360eed-6edf-429b-b4b4-c94287ad6e6f"), new DateTime(2020, 11, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(395), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ee634b04-4768-4cc1-a683-c6e9442dab8a"), new DateTime(2020, 10, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(386), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fb02437b-98e9-49e6-ba3c-0d1409e575c2"), new DateTime(2020, 10, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(281), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("762ffc97-fdda-45a6-acc3-93c95a465e8d"), new DateTime(2020, 12, 5, 19, 51, 22, 419, DateTimeKind.Local).AddTicks(471), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("4c760130-3729-4e5c-9d97-1f999b80fcff"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(7884), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("a29a6c42-b37b-4355-a10a-35943b87b4e6"), new DateTime(2021, 2, 5, 19, 49, 42, 418, DateTimeKind.Local).AddTicks(7863), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("f41424f3-9049-422a-8575-b6e1396a998d"), new DateTime(2021, 2, 5, 19, 50, 32, 418, DateTimeKind.Local).AddTicks(7877), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("3292ef6c-33e6-4511-a047-7b3227ca3802"), new DateTime(2021, 2, 5, 19, 48, 2, 418, DateTimeKind.Local).AddTicks(7277), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("ca83fbea-78c1-456f-8c6c-8342afea73b4"), new DateTime(2021, 2, 5, 19, 48, 52, 418, DateTimeKind.Local).AddTicks(7847), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a7ee7db1-af60-4a07-9372-056e4dc32d0d"), new Guid("0947b660-ec36-4242-adfc-099f826d9ca2"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(3862), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("08fa4915-e19e-4fae-9617-082124d4158c"), new Guid("a110c4af-1dd8-406a-bbda-4468a22d3a40"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(4871), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("8fdd93e7-a766-4e0e-8277-e5cc23de2de0"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(3022), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2b13efff-bc92-4cfa-b492-24ec1c8b2afa"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(3122), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5191bc0a-3ede-4d6f-8bd8-c1fc51871e0c"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(3129), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("8634ac5a-5b8c-4a8e-8981-c4711cf3cbac"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(3145), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("00730414-9fe4-4b28-a126-b462e4405f86"), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(8481), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("74b844b3-1fa7-45c4-8a9e-8b77f76dcd04"), new DateTime(2021, 2, 5, 19, 51, 22, 418, DateTimeKind.Local).AddTicks(3135), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 51, 22, 416, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 5, 19, 51, 22, 416, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 51, 22, 416, DateTimeKind.Local).AddTicks(8652), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(364), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3231), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3236), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3115), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3171), new DateTime(2021, 2, 5, 19, 51, 22, 417, DateTimeKind.Local).AddTicks(3187) });
        }
    }
}
