using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class FailedBillingTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("93301d7b-c248-49c6-9262-256c7f406a64"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("25ccaa2f-9484-4e30-a470-a507f552bcb8"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("d79549f9-6e32-4425-b76e-c7ab40575d4f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("fa5ad48a-1e72-46f9-9993-6da78e308c41"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7281b404-d91e-4e04-9514-89c244f80cd7"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("94ed23e0-f82e-42e4-99e0-42729919ddc4"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ac05aae8-fb8e-411b-979d-e4db6ce328e1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("f5460ffc-4cdd-415a-b224-c4d2cb4eb210"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("024b6712-6960-49d9-868e-13aead259a97"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0cf219d2-d6ab-40ac-b073-6f0ff469c55c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("12f11752-1af3-40c3-9cad-57da9dc7e316"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1a7823b8-ebdc-43bc-99d4-281d2ff9736f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("202d1f2e-5c6f-4ca9-9e61-9d6875af6f7c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("283ac6ae-1d21-46c5-959b-669078f15270"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c229466-6adf-4e52-9d2c-1bde9cfb5107"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("41f18776-4fbd-4a33-a33c-125e8d82bb6b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("504c0f09-de70-4b52-ae8e-24e437915f87"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6283b6dc-8a52-435c-9734-58d2e449a743"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("648c2ac3-4282-4601-a18d-1923d3736eb8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7fcc35fd-1df8-4cf5-a769-75d17f2ffa29"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("830eacc1-0780-44de-824b-decbcd9f3784"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9ed08f66-6643-454b-b126-57c223ef4ed8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a5783918-3d2b-4b60-8b28-ababbdfc27e1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa4fdf39-6e9a-4e31-a72d-eb0dea52f460"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ad18087a-69c2-4b6a-9f47-ec04dfe0af8e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b251bc2c-0fdb-419e-a6c2-c9be97d58174"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bb1aaa27-db45-4635-a12f-cd64bebe029d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cb76f23c-0eb4-432b-b471-258681b76f7b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d636f910-f51c-48c1-beec-8d7af9195917"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dd1983ce-7ee7-493c-9774-ba08d874e04c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dfb95a73-c9b5-4907-94c1-f26a37582b02"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f041548e-0438-4303-b7f6-37b9a6ce35ae"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("266b9103-6745-439f-90ac-d4816be91ac6"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("433752eb-8874-49dc-b52a-8bf33769a383"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4f57a349-d12b-4f46-b361-8bcf880deb34"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("80f431bb-24e1-4d74-98a4-eee3e053ac24"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("dba51ddd-9e29-4fcf-a052-1feaeacaa275"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("4de751e8-c5c6-442c-906f-d1d4a7f1e758"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("81efa3a6-f3ca-4a28-8039-81be0c9bf212"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25573f10-f627-4b82-833d-6f4718a19307"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54ab3dfb-92a9-4e29-901b-792673940e2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58f94f4b-aa9a-43a6-9fd5-0487fc6a8846"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd657841-135b-47c0-8d62-491a09b69f0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3f42c8d-2aba-464b-9de0-18da9bcc31eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deabeb41-9c81-4ae2-bcf2-e5694fbaa319"));

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

            migrationBuilder.AddColumn<string>(
                name: "ErrorMessage",
                table: "FailedTransactions",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ErrorMessage",
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
                values: new object[] { new Guid("93301d7b-c248-49c6-9262-256c7f406a64"), new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(6249), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("25ccaa2f-9484-4e30-a470-a507f552bcb8"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(5365), new DateTime(2021, 2, 4, 21, 48, 47, 623, DateTimeKind.Local).AddTicks(6666), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d79549f9-6e32-4425-b76e-c7ab40575d4f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(7701), new DateTime(2021, 2, 4, 21, 48, 47, 623, DateTimeKind.Local).AddTicks(7751), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("fa5ad48a-1e72-46f9-9993-6da78e308c41"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(7781), new DateTime(2021, 2, 4, 21, 48, 47, 623, DateTimeKind.Local).AddTicks(7784), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ac05aae8-fb8e-411b-979d-e4db6ce328e1"), new DateTime(2021, 2, 4, 20, 48, 47, 618, DateTimeKind.Local).AddTicks(4307), true, true, "GTA" },
                    { new Guid("f5460ffc-4cdd-415a-b224-c4d2cb4eb210"), new DateTime(2021, 2, 4, 20, 48, 47, 621, DateTimeKind.Local).AddTicks(4253), true, true, "Survival" },
                    { new Guid("7281b404-d91e-4e04-9514-89c244f80cd7"), new DateTime(2021, 2, 4, 20, 48, 47, 621, DateTimeKind.Local).AddTicks(4304), true, true, "Skyblock" },
                    { new Guid("94ed23e0-f82e-42e4-99e0-42729919ddc4"), new DateTime(2021, 2, 4, 20, 48, 47, 621, DateTimeKind.Local).AddTicks(4310), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("dfb95a73-c9b5-4907-94c1-f26a37582b02"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2415), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("12f11752-1af3-40c3-9cad-57da9dc7e316"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2423), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dd1983ce-7ee7-493c-9774-ba08d874e04c"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2431), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cb76f23c-0eb4-432b-b471-258681b76f7b"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2446), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("202d1f2e-5c6f-4ca9-9e61-9d6875af6f7c"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2478), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a5783918-3d2b-4b60-8b28-ababbdfc27e1"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2461), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("504c0f09-de70-4b52-ae8e-24e437915f87"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2469), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bb1aaa27-db45-4635-a12f-cd64bebe029d"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2405), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c229466-6adf-4e52-9d2c-1bde9cfb5107"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2486), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1a7823b8-ebdc-43bc-99d4-281d2ff9736f"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2453), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b251bc2c-0fdb-419e-a6c2-c9be97d58174"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2398), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9ed08f66-6643-454b-b126-57c223ef4ed8"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2438), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("283ac6ae-1d21-46c5-959b-669078f15270"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2383), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d636f910-f51c-48c1-beec-8d7af9195917"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2375), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("648c2ac3-4282-4601-a18d-1923d3736eb8"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2367), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aa4fdf39-6e9a-4e31-a72d-eb0dea52f460"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2360), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ad18087a-69c2-4b6a-9f47-ec04dfe0af8e"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2352), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f041548e-0438-4303-b7f6-37b9a6ce35ae"), new DateTime(2021, 1, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2339), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7fcc35fd-1df8-4cf5-a769-75d17f2ffa29"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2331), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("024b6712-6960-49d9-868e-13aead259a97"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2323), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("41f18776-4fbd-4a33-a33c-125e8d82bb6b"), new DateTime(2020, 11, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2315), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0cf219d2-d6ab-40ac-b073-6f0ff469c55c"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2305), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("830eacc1-0780-44de-824b-decbcd9f3784"), new DateTime(2020, 10, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2201), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6283b6dc-8a52-435c-9734-58d2e449a743"), new DateTime(2020, 12, 4, 20, 48, 47, 625, DateTimeKind.Local).AddTicks(2390), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("266b9103-6745-439f-90ac-d4816be91ac6"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(9720), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("dba51ddd-9e29-4fcf-a052-1feaeacaa275"), new DateTime(2021, 2, 4, 20, 47, 7, 624, DateTimeKind.Local).AddTicks(9697), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("80f431bb-24e1-4d74-98a4-eee3e053ac24"), new DateTime(2021, 2, 4, 20, 47, 57, 624, DateTimeKind.Local).AddTicks(9713), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("433752eb-8874-49dc-b52a-8bf33769a383"), new DateTime(2021, 2, 4, 20, 45, 27, 624, DateTimeKind.Local).AddTicks(9097), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("4f57a349-d12b-4f46-b361-8bcf880deb34"), new DateTime(2021, 2, 4, 20, 46, 17, 624, DateTimeKind.Local).AddTicks(9679), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4de751e8-c5c6-442c-906f-d1d4a7f1e758"), new Guid("8b7c89d4-67af-4bc7-a0cb-a115c8e884ae"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(5548), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("81efa3a6-f3ca-4a28-8039-81be0c9bf212"), new Guid("38dd020a-275f-40ef-8347-f8f3342066e4"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(6591), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("54ab3dfb-92a9-4e29-901b-792673940e2d"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4656), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("58f94f4b-aa9a-43a6-9fd5-0487fc6a8846"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4758), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("deabeb41-9c81-4ae2-bcf2-e5694fbaa319"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4767), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("bd657841-135b-47c0-8d62-491a09b69f0a"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4824), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("25573f10-f627-4b82-833d-6f4718a19307"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(18), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("c3f42c8d-2aba-464b-9de0-18da9bcc31eb"), new DateTime(2021, 2, 4, 20, 48, 47, 624, DateTimeKind.Local).AddTicks(4812), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 48, 47, 622, DateTimeKind.Local).AddTicks(9973), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(1747), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4639), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4644), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4528), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4583), new DateTime(2021, 2, 4, 20, 48, 47, 623, DateTimeKind.Local).AddTicks(4598) });
        }
    }
}
