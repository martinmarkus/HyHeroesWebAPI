using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BarionBillingAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("b2630c77-9919-4d91-a912-04dae0d77692"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3b20880b-70fb-442f-a936-04700b64b6af"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a81b0384-307d-4e66-995a-2962f155f7c5"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("fe8a5e66-73d9-483a-946b-564058cee3e9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("65c8af52-1330-4279-a17e-88b7d2b6ecc5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("6f53b9ca-8b2a-4023-a9f2-c52073b83b4b"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("74c4f997-cb5a-4ec6-8ab9-541bacd6e321"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("74e9442e-22e7-4b12-89be-ee88df436896"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0cae23b2-5709-47e4-a055-4e08bfafb8d1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0d188a12-99e3-4596-9e35-d416d1a3ca57"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("130e68da-7a08-402f-bed8-bc1e895627dc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1dee6569-2b6a-4920-bc36-96f0afabc5ff"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2043530c-df16-435a-a0d3-fce05b91e7fb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("36aecc4f-17da-44d2-b138-3147782a080f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("385d925f-495e-412c-ae3e-a2e305cb0b8c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c802ea9-9736-4156-8ab4-775ec53e3bf7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("47ce230a-4c31-4ba0-9be4-b5f10ad6868a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("47efb385-678a-404c-8edf-2e7f77489c3a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("487c7681-b350-4226-b2f6-67da0b970ecc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4d0ef14e-dfee-49a5-bf95-7fe34efba08c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("64f7fc86-35e2-4905-bbb8-da4068793ca1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("68fa5f23-5d44-4101-8ad9-ec02d092f09b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("79684762-5586-4bbe-a34d-d689eee631cd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7d3977a3-2a83-4736-9334-0f54c48c4dff"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8edcd02d-f801-46c0-8d8b-6250ae7e19ab"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("905b6274-eab6-45d0-9e4e-8d8e4db4025e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("932ba287-df60-4e8b-b2ff-e8eca904901b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("96f84ea6-b2cc-47ad-bda4-052519a62f1f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e3937c30-d90a-4e23-932a-34214d1b9c47"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e6a0dfcd-b8d9-4ae5-b73f-12d5a0960c09"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f148bb9f-bec3-4ab7-a9d2-d1d9e1a2c708"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f961c67e-fda0-4c6a-8c72-589db2c67048"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("19a5bdae-3d7f-4e2a-81bf-d2a20012f809"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1aec8f9b-eef4-47fb-b301-d307133bcd39"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("340538f6-37ed-4785-a525-c653de36a1e2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("684f58e8-b02f-4a07-94fe-8e07752ea1ff"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c808e63f-7d95-478b-ac19-dc0e858b5dc0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("156d7cab-387c-4859-88a4-08d5ed9667ab"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a262b36-fc9d-4cbd-b8f7-7aa305470c5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1751c9c1-3667-4d5c-a043-110137e9dd7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30b0d6c7-5352-428e-a7a6-c83152bd360d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("511faed4-8b67-46b2-aedc-f7de79efd093"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a84d6d8e-547f-4891-b3c9-05cf7f5bef86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcebd31c-b205-48b8-b761-9b5cdf4a9a03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5e3dec9-39e1-4a8f-9149-9d47db4623b8"));

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
                name: "BillingEmail",
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
                values: new object[] { new Guid("21c99134-cce0-4f56-adc4-c155b36aeedd"), new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(1764), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("a2a2e5ba-eea8-4418-8d35-e0fddc953fda"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(785), new DateTime(2021, 2, 4, 20, 48, 16, 374, DateTimeKind.Local).AddTicks(2088), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bad6f70f-575a-4002-960c-8c90189ac672"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 2, 4, 20, 48, 16, 374, DateTimeKind.Local).AddTicks(3168), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("5e4a6da1-d635-44a5-9a83-67a999859b71"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(3191), new DateTime(2021, 2, 4, 20, 48, 16, 374, DateTimeKind.Local).AddTicks(3195), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("ed9f1b4f-34b5-463f-962c-61b8d7dcef05"), new DateTime(2021, 2, 4, 19, 48, 16, 369, DateTimeKind.Local).AddTicks(460), true, true, "GTA" },
                    { new Guid("7e14dd4e-cab3-4830-8675-ef54b7647364"), new DateTime(2021, 2, 4, 19, 48, 16, 371, DateTimeKind.Local).AddTicks(9962), true, true, "Survival" },
                    { new Guid("30a59ee5-cb33-4567-8918-2b9bbd8c00e1"), new DateTime(2021, 2, 4, 19, 48, 16, 372, DateTimeKind.Local).AddTicks(11), true, true, "Skyblock" },
                    { new Guid("3f1c10b2-0990-4b02-a665-3ec993203509"), new DateTime(2021, 2, 4, 19, 48, 16, 372, DateTimeKind.Local).AddTicks(29), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa5ced26-8de6-4d03-b4c1-89f77b95d5cf"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7743), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("58e344c6-c360-4b12-8b93-935c57dddefd"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7751), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f0e5ee5e-32e5-4057-8232-ce55f318066e"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7758), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("81604681-016f-4074-80e6-1ab89d5be8c0"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7773), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("915b3682-b538-48b0-a911-4ad43f8fa58a"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7805), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("16085f65-cf11-4027-8c18-13bf6711418b"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7788), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c347fd1b-19ad-4655-ab63-57729fba287a"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7797), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e975fdf8-d231-4e62-af1b-24c50a6df7ee"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7736), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ccfa4c70-1360-4d9b-a33f-8cedeb371099"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7812), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b2348b89-0578-4428-b25e-146c85c372eb"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7781), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28b785e4-bbad-4271-aa59-67bf4fdaf023"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7726), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("543a1c71-bd8d-4154-abdb-0fcdee01fcbf"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7766), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d8f36831-7060-42d0-a0dc-186378f194e5"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7711), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6e493e06-43d9-4c7e-8923-c02237cec6c0"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7703), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b2136f4-5941-4494-8ea5-bf9c7bd9b2be"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7696), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dffa3cc6-b447-49a9-99b6-afaa7fb7e330"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7688), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7af55295-e182-47d6-8c8e-776de7c135e3"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7681), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6667f096-86fe-4d80-b96a-116a39f1c47f"), new DateTime(2021, 1, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7673), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aa09e56b-176c-4d50-bcf6-641f67dbfd7e"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7660), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a1cc6fb-9c7d-453f-a716-8d0c5dcdc6cc"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7652), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b7900bc1-b878-4ea2-b700-e9ccc4058b12"), new DateTime(2020, 11, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7644), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("86ac8b5a-2bd7-4aa4-9f50-29cbf183f8c7"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7635), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a6c34816-60a8-43ef-a432-1e3e014035a8"), new DateTime(2020, 10, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7528), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dc918305-a10b-42f5-9e86-e7329c0a740f"), new DateTime(2020, 12, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(7718), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("6d392abf-06e0-40b3-8b12-8fe9b559f214"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(5076), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("5ac82dc2-b300-4579-80b0-bad9913e121b"), new DateTime(2021, 2, 4, 19, 46, 36, 375, DateTimeKind.Local).AddTicks(5061), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("22d5daf6-38a7-4642-8038-e13ae141e313"), new DateTime(2021, 2, 4, 19, 47, 26, 375, DateTimeKind.Local).AddTicks(5069), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("dfadf811-ed26-40db-a152-8ec3bf7f24fd"), new DateTime(2021, 2, 4, 19, 44, 56, 375, DateTimeKind.Local).AddTicks(4451), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("12a6e1da-0ac2-4c22-a511-69d8440ffd6a"), new DateTime(2021, 2, 4, 19, 45, 46, 375, DateTimeKind.Local).AddTicks(5039), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ea178318-c10e-4b13-9906-6e40578b12bb"), new Guid("f8b4f37a-d2d5-4e98-9637-8ed1f7772c5c"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(914), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4c4cd815-23b9-4869-93ff-8c22a660e6e0"), new Guid("f91c5025-6659-4fc4-873b-8e97ae1c670b"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(1949), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("c836daf4-c948-497d-b227-bacc54773766"), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(9987), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("acfe2282-1c54-43ec-ac91-49b238599db0"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(159), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("83559d12-3354-497d-80aa-b0057a9c6960"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(169), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("14244119-fcdf-4492-ac3f-c85939aeb92f"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(189), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("8551f547-43c6-480d-9f66-d85c2ea11b56"), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(5427), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("76815196-e78c-4f48-847c-1e715fee27c2"), new DateTime(2021, 2, 4, 19, 48, 16, 375, DateTimeKind.Local).AddTicks(180), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(5451), new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(7208), new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(68), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(74), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 19, 48, 16, 373, DateTimeKind.Local).AddTicks(9960), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(16), new DateTime(2021, 2, 4, 19, 48, 16, 374, DateTimeKind.Local).AddTicks(32) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("21c99134-cce0-4f56-adc4-c155b36aeedd"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("5e4a6da1-d635-44a5-9a83-67a999859b71"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a2a2e5ba-eea8-4418-8d35-e0fddc953fda"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bad6f70f-575a-4002-960c-8c90189ac672"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("30a59ee5-cb33-4567-8918-2b9bbd8c00e1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("3f1c10b2-0990-4b02-a665-3ec993203509"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7e14dd4e-cab3-4830-8675-ef54b7647364"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ed9f1b4f-34b5-463f-962c-61b8d7dcef05"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("16085f65-cf11-4027-8c18-13bf6711418b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28b785e4-bbad-4271-aa59-67bf4fdaf023"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a1cc6fb-9c7d-453f-a716-8d0c5dcdc6cc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("543a1c71-bd8d-4154-abdb-0fcdee01fcbf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("58e344c6-c360-4b12-8b93-935c57dddefd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6667f096-86fe-4d80-b96a-116a39f1c47f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6e493e06-43d9-4c7e-8923-c02237cec6c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7af55295-e182-47d6-8c8e-776de7c135e3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("81604681-016f-4074-80e6-1ab89d5be8c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("86ac8b5a-2bd7-4aa4-9f50-29cbf183f8c7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b2136f4-5941-4494-8ea5-bf9c7bd9b2be"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("915b3682-b538-48b0-a911-4ad43f8fa58a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a6c34816-60a8-43ef-a432-1e3e014035a8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa09e56b-176c-4d50-bcf6-641f67dbfd7e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aa5ced26-8de6-4d03-b4c1-89f77b95d5cf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b2348b89-0578-4428-b25e-146c85c372eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b7900bc1-b878-4ea2-b700-e9ccc4058b12"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c347fd1b-19ad-4655-ab63-57729fba287a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ccfa4c70-1360-4d9b-a33f-8cedeb371099"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d8f36831-7060-42d0-a0dc-186378f194e5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dc918305-a10b-42f5-9e86-e7329c0a740f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dffa3cc6-b447-49a9-99b6-afaa7fb7e330"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e975fdf8-d231-4e62-af1b-24c50a6df7ee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f0e5ee5e-32e5-4057-8232-ce55f318066e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("12a6e1da-0ac2-4c22-a511-69d8440ffd6a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("22d5daf6-38a7-4642-8038-e13ae141e313"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5ac82dc2-b300-4579-80b0-bad9913e121b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("6d392abf-06e0-40b3-8b12-8fe9b559f214"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("dfadf811-ed26-40db-a152-8ec3bf7f24fd"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("4c4cd815-23b9-4869-93ff-8c22a660e6e0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("ea178318-c10e-4b13-9906-6e40578b12bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14244119-fcdf-4492-ac3f-c85939aeb92f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76815196-e78c-4f48-847c-1e715fee27c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83559d12-3354-497d-80aa-b0057a9c6960"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8551f547-43c6-480d-9f66-d85c2ea11b56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acfe2282-1c54-43ec-ac91-49b238599db0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c836daf4-c948-497d-b227-bacc54773766"));

            migrationBuilder.DropColumn(
                name: "BillingEmail",
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
                values: new object[] { new Guid("b2630c77-9919-4d91-a912-04dae0d77692"), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(762), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("a81b0384-307d-4e66-995a-2962f155f7c5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(9833), new DateTime(2021, 2, 4, 19, 57, 6, 452, DateTimeKind.Local).AddTicks(1144), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("3b20880b-70fb-442f-a936-04700b64b6af"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(2170), new DateTime(2021, 2, 4, 19, 57, 6, 452, DateTimeKind.Local).AddTicks(2203), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("fe8a5e66-73d9-483a-946b-564058cee3e9"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(2226), new DateTime(2021, 2, 4, 19, 57, 6, 452, DateTimeKind.Local).AddTicks(2230), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("74e9442e-22e7-4b12-89be-ee88df436896"), new DateTime(2021, 2, 4, 18, 57, 6, 446, DateTimeKind.Local).AddTicks(9046), true, true, "GTA" },
                    { new Guid("74c4f997-cb5a-4ec6-8ab9-541bacd6e321"), new DateTime(2021, 2, 4, 18, 57, 6, 449, DateTimeKind.Local).AddTicks(8793), true, true, "Survival" },
                    { new Guid("65c8af52-1330-4279-a17e-88b7d2b6ecc5"), new DateTime(2021, 2, 4, 18, 57, 6, 449, DateTimeKind.Local).AddTicks(8838), true, true, "Skyblock" },
                    { new Guid("6f53b9ca-8b2a-4023-a9f2-c52073b83b4b"), new DateTime(2021, 2, 4, 18, 57, 6, 449, DateTimeKind.Local).AddTicks(8844), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("47efb385-678a-404c-8edf-2e7f77489c3a"), new DateTime(2021, 1, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6919), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0cae23b2-5709-47e4-a055-4e08bfafb8d1"), new DateTime(2020, 10, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6927), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3937c30-d90a-4e23-932a-34214d1b9c47"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6937), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e6a0dfcd-b8d9-4ae5-b73f-12d5a0960c09"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6952), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c802ea9-9736-4156-8ab4-775ec53e3bf7"), new DateTime(2021, 1, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6982), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2043530c-df16-435a-a0d3-fce05b91e7fb"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6968), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d3977a3-2a83-4736-9334-0f54c48c4dff"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6975), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1dee6569-2b6a-4920-bc36-96f0afabc5ff"), new DateTime(2021, 1, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6911), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("905b6274-eab6-45d0-9e4e-8d8e4db4025e"), new DateTime(2021, 1, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6990), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8edcd02d-f801-46c0-8d8b-6250ae7e19ab"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6960), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("96f84ea6-b2cc-47ad-bda4-052519a62f1f"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6903), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("47ce230a-4c31-4ba0-9be4-b5f10ad6868a"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6944), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("64f7fc86-35e2-4905-bbb8-da4068793ca1"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6888), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0d188a12-99e3-4596-9e35-d416d1a3ca57"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6881), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("932ba287-df60-4e8b-b2ff-e8eca904901b"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6872), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("487c7681-b350-4226-b2f6-67da0b970ecc"), new DateTime(2020, 10, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6859), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("385d925f-495e-412c-ae3e-a2e305cb0b8c"), new DateTime(2020, 10, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6851), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("68fa5f23-5d44-4101-8ad9-ec02d092f09b"), new DateTime(2021, 1, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6843), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f148bb9f-bec3-4ab7-a9d2-d1d9e1a2c708"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6835), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("79684762-5586-4bbe-a34d-d689eee631cd"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6827), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("130e68da-7a08-402f-bed8-bc1e895627dc"), new DateTime(2020, 11, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6818), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4d0ef14e-dfee-49a5-bf95-7fe34efba08c"), new DateTime(2020, 10, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6808), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f961c67e-fda0-4c6a-8c72-589db2c67048"), new DateTime(2020, 10, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6696), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("36aecc4f-17da-44d2-b138-3147782a080f"), new DateTime(2020, 12, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(6896), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("1aec8f9b-eef4-47fb-b301-d307133bcd39"), new DateTime(2021, 2, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(4171), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("340538f6-37ed-4785-a525-c653de36a1e2"), new DateTime(2021, 2, 4, 18, 55, 26, 453, DateTimeKind.Local).AddTicks(4154), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("684f58e8-b02f-4a07-94fe-8e07752ea1ff"), new DateTime(2021, 2, 4, 18, 56, 16, 453, DateTimeKind.Local).AddTicks(4163), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("19a5bdae-3d7f-4e2a-81bf-d2a20012f809"), new DateTime(2021, 2, 4, 18, 53, 46, 453, DateTimeKind.Local).AddTicks(3567), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("c808e63f-7d95-478b-ac19-dc0e858b5dc0"), new DateTime(2021, 2, 4, 18, 54, 36, 453, DateTimeKind.Local).AddTicks(4140), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("156d7cab-387c-4859-88a4-08d5ed9667ab"), new Guid("f8400cb6-5d61-4f20-af57-0bb877cf8e63"), new DateTime(2021, 2, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(65), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a262b36-fc9d-4cbd-b8f7-7aa305470c5f"), new Guid("d72f0c33-21b3-45aa-8a55-257bff1de195"), new DateTime(2021, 2, 4, 18, 57, 6, 453, DateTimeKind.Local).AddTicks(1097), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("1751c9c1-3667-4d5c-a043-110137e9dd7c"), new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(9200), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("30b0d6c7-5352-428e-a7a6-c83152bd360d"), new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(9305), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("511faed4-8b67-46b2-aedc-f7de79efd093"), new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(9315), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("bcebd31c-b205-48b8-b761-9b5cdf4a9a03"), new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(9328), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a84d6d8e-547f-4891-b3c9-05cf7f5bef86"), new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(4573), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f5e3dec9-39e1-4a8f-9149-9d47db4623b8"), new DateTime(2021, 2, 4, 18, 57, 6, 452, DateTimeKind.Local).AddTicks(9320), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(4451), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(6216), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(9084), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(9090), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(8972), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(9028), new DateTime(2021, 2, 4, 18, 57, 6, 451, DateTimeKind.Local).AddTicks(9044) });
        }
    }
}
