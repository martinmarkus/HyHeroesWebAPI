using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class RefactorEDSMSCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("c4d5eb57-45c4-4c91-9260-bbfc9fd26c96"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("33fbfa01-6d0d-4cdb-90ab-311a1f1f540f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("54a61203-9d6a-4a95-9279-3326ccfa2531"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("f661ae9d-5bab-4323-83d2-a7659e5331a1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("14868005-b6d1-40b7-914f-3f339a2ca1b0"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("38ac8f69-f2c1-4123-bc4b-b143b8b5bcd9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("60636dc7-a2aa-4d9d-b6f9-f65f8936a388"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("c14af257-6720-4715-9069-c7e8517b5753"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("04e05f8a-4159-4dfa-8867-a79b7cf6d528"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("07de4ee2-c5a0-44cf-92f8-40bcdd240ad5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0fcc9b37-b5e4-4fd0-b4cb-d3f54d58289f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1030a800-ac25-4555-a504-f6624ff09e41"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("15830faa-fc75-4ca0-8880-bf64fce70f4b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("221e7aac-bbea-412f-9204-b2bb1213a6cd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2cdda6c1-2431-428a-a8df-9944190e376b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("32f69612-e697-4407-bb20-9c41d29969e5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("358978fd-f440-48a4-8372-27fd4d304c07"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("39455ed2-d937-4ac2-ba5d-04a07539034b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5245d713-4227-44bb-a49f-666591709905"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5d3eb027-a907-4d1c-967b-c0ffe01dae47"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("70f04978-58d9-410f-bb56-697f0732505b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("70ff7742-bb09-4b96-ae6e-3fda05ec4941"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("84b978c4-b2de-4a51-b84d-409ce308f600"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("916f1ccf-4f18-4ddc-a195-f3defa18ad13"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("948648d3-3f06-4532-99bc-f3f3162b2215"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9702b871-6c11-40ea-9dab-f7bdcb80559f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9de8c79e-48da-456e-ab3b-39ddee99c2e4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a589214b-4101-46fa-8541-f17ee34f4f2b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b26bb6b7-3515-4a78-a627-7a942dfac34a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b487e4d2-302e-49a2-8139-86736fe53d86"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e221a623-3a49-4f21-b083-0e8e70d0c5f4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fed0d0d8-bc1a-442c-b2ff-785b4be1c4c4"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("53693dbd-5509-4141-9796-3a9fd8ae341b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a46fa2dd-5409-4ed0-bd7d-e8dcc4df3465"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c2585adf-719a-436d-a662-a95b8649f2a8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d8b19b85-fa2c-4df8-b78f-8daa8e5262ae"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("fede556f-6daa-4c79-9afb-b8371562abc1"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("4a75aaca-c8d2-400f-baa1-3ddf3e2d8176"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("dfc938e8-830c-4add-acea-f72849110cdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4efc8a90-6ee4-426f-8598-0d7434f3a2f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8912402d-86b1-4058-80aa-1d2adf58dc1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8a93954-fee5-47b0-a46f-320525790768"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d261f302-1f3e-4423-9843-ef856319a6bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7a283ae-1289-4e08-8aee-1060d7a59c96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed891a1c-e709-4b94-bcdb-fd586ee59ea3"));

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
                values: new object[] { new Guid("d4e3becf-60e3-4da3-a1f8-997a91746b6f"), new DateTime(2021, 1, 30, 12, 43, 0, 405, DateTimeKind.Local).AddTicks(6673), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("77694e0c-3e25-4589-b158-eeaba94a0564"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(5834), new DateTime(2021, 1, 30, 13, 43, 0, 406, DateTimeKind.Local).AddTicks(7128), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("697c9542-4749-4b07-8b6a-4f4ab068a5df"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(8146), new DateTime(2021, 1, 30, 13, 43, 0, 406, DateTimeKind.Local).AddTicks(8180), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("fb9a7aca-d418-4819-bd15-1b0c58c584e8"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(8205), new DateTime(2021, 1, 30, 13, 43, 0, 406, DateTimeKind.Local).AddTicks(8208), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("a2894ae1-eafc-4619-b6db-a1fa0a1cfbf2"), new DateTime(2021, 1, 30, 12, 43, 0, 401, DateTimeKind.Local).AddTicks(5949), true, true, "GTA" },
                    { new Guid("7da094cb-cdb0-40ec-9d4e-41e517b05c06"), new DateTime(2021, 1, 30, 12, 43, 0, 404, DateTimeKind.Local).AddTicks(5026), true, true, "Survival" },
                    { new Guid("2d3c366c-3af3-40d3-a0d8-648c73daa370"), new DateTime(2021, 1, 30, 12, 43, 0, 404, DateTimeKind.Local).AddTicks(5073), true, true, "Skyblock" },
                    { new Guid("7926c572-c9f3-484d-97dc-ef5065ae14eb"), new DateTime(2021, 1, 30, 12, 43, 0, 404, DateTimeKind.Local).AddTicks(5079), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("d9c4279c-d984-4e53-87f0-8c28fca4585f"), new DateTime(2020, 12, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2594), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("66ebb5d7-348a-45d0-9cc0-d629a23b54f6"), new DateTime(2020, 9, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2601), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a94f23b2-68a3-452e-ab71-8184f94b7de3"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2609), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fed596bd-8c0c-42c7-88ea-1291220e801e"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2627), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e95a8164-ab02-4a57-88ee-82f7fb2ff17e"), new DateTime(2020, 12, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2659), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e5344811-7832-4084-9cc5-ac5ea0764625"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2643), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d6e3d1dd-64c6-4c5a-b867-463195fb46c5"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2651), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9cafd5c3-31b0-4017-aef3-f4ea372a6d9b"), new DateTime(2020, 12, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2586), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c595f2d-6c1d-46c2-a2b2-5054b4e1c5d6"), new DateTime(2020, 12, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2666), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f2170d1b-ea33-4be0-881e-9601f87716a8"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2636), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5dadb3c2-955c-4a2e-998d-5851ce891818"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2577), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("12601b06-277a-4f1a-90ff-ebbad22fc920"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2618), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("728a7667-e682-4270-9d3b-51daf51b1ca8"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2561), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4c685b95-7823-4175-8455-9fe8fd746994"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2553), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8f644da6-567a-4351-b6ce-58b128baf202"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2543), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9a8c22e6-9e91-46bc-8a87-54e17a294744"), new DateTime(2020, 9, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2535), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6765b58d-af11-489a-92f7-bef0d158baba"), new DateTime(2020, 9, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2528), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b71da406-f91d-41e1-8d3f-cab57a0aef78"), new DateTime(2020, 12, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2519), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d5f85b5-a15c-4063-9415-0004a22a328c"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2512), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d92393ca-657a-4d2c-bf76-1a565d0fe6d9"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2502), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ded0a612-716d-4049-8865-7434bfd8249a"), new DateTime(2020, 10, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2492), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0f7aebe2-6347-4f6f-8bb3-f4fc06d0e93d"), new DateTime(2020, 9, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2481), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6daaa1fd-d6aa-466d-b3aa-cc66e3ca053f"), new DateTime(2020, 9, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2355), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c5806aa7-32e9-4d77-9c0c-e893aec6be69"), new DateTime(2020, 11, 30, 12, 43, 0, 408, DateTimeKind.Local).AddTicks(2569), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("b9962258-d864-4f06-bcb5-dcdddea7e067"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(9799), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("a6fdd945-b0d3-4044-97ea-b6e9d0e7e736"), new DateTime(2021, 1, 30, 12, 41, 20, 407, DateTimeKind.Local).AddTicks(9782), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("d3936d0c-9bca-4b53-9db1-1062e34d8f23"), new DateTime(2021, 1, 30, 12, 42, 10, 407, DateTimeKind.Local).AddTicks(9790), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("580bd902-65ae-42c5-befb-b67ffdf90dee"), new DateTime(2021, 1, 30, 12, 39, 40, 407, DateTimeKind.Local).AddTicks(9149), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("221a0ea3-0542-453a-8772-a97199520923"), new DateTime(2021, 1, 30, 12, 40, 30, 407, DateTimeKind.Local).AddTicks(9766), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("fab62bcd-9cb8-47f6-b9c3-1822f13c6e91"), new Guid("e21d531c-836f-4805-8b2c-dbbe8d5ca641"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(5617), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("329ae3d2-b30f-449e-9960-d4e625bcd199"), new Guid("97770e15-ac82-4191-bdea-258bcb4272a6"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(6636), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("7a7302bc-6211-4497-a97a-7d767cba01fc"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(4789), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("721327ab-3702-4365-9b65-6226a3728052"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(4891), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("effa09fd-ea99-4920-9ac6-2a5bd1f6b36b"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(4898), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0c68b74f-d1dd-46f8-b326-a383e71f3ae7"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(4910), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a53e0ad8-81b9-4221-8ea8-b18330fbbd5e"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(391), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("743b4523-4c09-40cd-a608-104d24f78433"), new DateTime(2021, 1, 30, 12, 43, 0, 407, DateTimeKind.Local).AddTicks(4904), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 43, 0, 405, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 43, 0, 405, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(531), new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(2268), new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(5106), new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(5112), new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(4993), new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(5051), new DateTime(2021, 1, 30, 12, 43, 0, 406, DateTimeKind.Local).AddTicks(5069) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("d4e3becf-60e3-4da3-a1f8-997a91746b6f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("697c9542-4749-4b07-8b6a-4f4ab068a5df"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("77694e0c-3e25-4589-b158-eeaba94a0564"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("fb9a7aca-d418-4819-bd15-1b0c58c584e8"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("2d3c366c-3af3-40d3-a0d8-648c73daa370"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7926c572-c9f3-484d-97dc-ef5065ae14eb"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7da094cb-cdb0-40ec-9d4e-41e517b05c06"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a2894ae1-eafc-4619-b6db-a1fa0a1cfbf2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0f7aebe2-6347-4f6f-8bb3-f4fc06d0e93d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("12601b06-277a-4f1a-90ff-ebbad22fc920"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c595f2d-6c1d-46c2-a2b2-5054b4e1c5d6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4c685b95-7823-4175-8455-9fe8fd746994"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5dadb3c2-955c-4a2e-998d-5851ce891818"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("66ebb5d7-348a-45d0-9cc0-d629a23b54f6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6765b58d-af11-489a-92f7-bef0d158baba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6daaa1fd-d6aa-466d-b3aa-cc66e3ca053f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("728a7667-e682-4270-9d3b-51daf51b1ca8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7d5f85b5-a15c-4063-9415-0004a22a328c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8f644da6-567a-4351-b6ce-58b128baf202"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9a8c22e6-9e91-46bc-8a87-54e17a294744"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9cafd5c3-31b0-4017-aef3-f4ea372a6d9b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a94f23b2-68a3-452e-ab71-8184f94b7de3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b71da406-f91d-41e1-8d3f-cab57a0aef78"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c5806aa7-32e9-4d77-9c0c-e893aec6be69"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d6e3d1dd-64c6-4c5a-b867-463195fb46c5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d92393ca-657a-4d2c-bf76-1a565d0fe6d9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d9c4279c-d984-4e53-87f0-8c28fca4585f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ded0a612-716d-4049-8865-7434bfd8249a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e5344811-7832-4084-9cc5-ac5ea0764625"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e95a8164-ab02-4a57-88ee-82f7fb2ff17e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f2170d1b-ea33-4be0-881e-9601f87716a8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fed596bd-8c0c-42c7-88ea-1291220e801e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("221a0ea3-0542-453a-8772-a97199520923"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("580bd902-65ae-42c5-befb-b67ffdf90dee"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a6fdd945-b0d3-4044-97ea-b6e9d0e7e736"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b9962258-d864-4f06-bcb5-dcdddea7e067"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d3936d0c-9bca-4b53-9db1-1062e34d8f23"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("329ae3d2-b30f-449e-9960-d4e625bcd199"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("fab62bcd-9cb8-47f6-b9c3-1822f13c6e91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c68b74f-d1dd-46f8-b326-a383e71f3ae7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("721327ab-3702-4365-9b65-6226a3728052"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("743b4523-4c09-40cd-a608-104d24f78433"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a7302bc-6211-4497-a97a-7d767cba01fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a53e0ad8-81b9-4221-8ea8-b18330fbbd5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("effa09fd-ea99-4920-9ac6-2a5bd1f6b36b"));

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
                values: new object[] { new Guid("c4d5eb57-45c4-4c91-9260-bbfc9fd26c96"), new DateTime(2021, 1, 30, 12, 41, 19, 355, DateTimeKind.Local).AddTicks(6061), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("f661ae9d-5bab-4323-83d2-a7659e5331a1"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4879), new DateTime(2021, 1, 30, 13, 41, 19, 356, DateTimeKind.Local).AddTicks(6138), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("33fbfa01-6d0d-4cdb-90ab-311a1f1f540f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(7132), new DateTime(2021, 1, 30, 13, 41, 19, 356, DateTimeKind.Local).AddTicks(7162), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("54a61203-9d6a-4a95-9279-3326ccfa2531"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(7184), new DateTime(2021, 1, 30, 13, 41, 19, 356, DateTimeKind.Local).AddTicks(7188), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("60636dc7-a2aa-4d9d-b6f9-f65f8936a388"), new DateTime(2021, 1, 30, 12, 41, 19, 351, DateTimeKind.Local).AddTicks(6243), true, true, "GTA" },
                    { new Guid("14868005-b6d1-40b7-914f-3f339a2ca1b0"), new DateTime(2021, 1, 30, 12, 41, 19, 354, DateTimeKind.Local).AddTicks(5096), true, true, "Survival" },
                    { new Guid("38ac8f69-f2c1-4123-bc4b-b143b8b5bcd9"), new DateTime(2021, 1, 30, 12, 41, 19, 354, DateTimeKind.Local).AddTicks(5142), true, true, "Skyblock" },
                    { new Guid("c14af257-6720-4715-9069-c7e8517b5753"), new DateTime(2021, 1, 30, 12, 41, 19, 354, DateTimeKind.Local).AddTicks(5148), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("07de4ee2-c5a0-44cf-92f8-40bcdd240ad5"), new DateTime(2020, 12, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1326), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("04e05f8a-4159-4dfa-8867-a79b7cf6d528"), new DateTime(2020, 9, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1335), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9702b871-6c11-40ea-9dab-f7bdcb80559f"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1342), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("358978fd-f440-48a4-8372-27fd4d304c07"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1360), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("39455ed2-d937-4ac2-ba5d-04a07539034b"), new DateTime(2020, 12, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1390), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1030a800-ac25-4555-a504-f6624ff09e41"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1375), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fed0d0d8-bc1a-442c-b2ff-785b4be1c4c4"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1383), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("948648d3-3f06-4532-99bc-f3f3162b2215"), new DateTime(2020, 12, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1319), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b26bb6b7-3515-4a78-a627-7a942dfac34a"), new DateTime(2020, 12, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1398), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5d3eb027-a907-4d1c-967b-c0ffe01dae47"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1368), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("32f69612-e697-4407-bb20-9c41d29969e5"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1311), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("221e7aac-bbea-412f-9204-b2bb1213a6cd"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1350), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9de8c79e-48da-456e-ab3b-39ddee99c2e4"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1296), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a589214b-4101-46fa-8541-f17ee34f4f2b"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1286), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("916f1ccf-4f18-4ddc-a195-f3defa18ad13"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1279), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("84b978c4-b2de-4a51-b84d-409ce308f600"), new DateTime(2020, 9, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1271), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b487e4d2-302e-49a2-8139-86736fe53d86"), new DateTime(2020, 9, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1263), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2cdda6c1-2431-428a-a8df-9944190e376b"), new DateTime(2020, 12, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1255), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5245d713-4227-44bb-a49f-666591709905"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1248), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e221a623-3a49-4f21-b083-0e8e70d0c5f4"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1240), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("70f04978-58d9-410f-bb56-697f0732505b"), new DateTime(2020, 10, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1232), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("70ff7742-bb09-4b96-ae6e-3fda05ec4941"), new DateTime(2020, 9, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1216), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("15830faa-fc75-4ca0-8880-bf64fce70f4b"), new DateTime(2020, 9, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1108), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0fcc9b37-b5e4-4fd0-b4cb-d3f54d58289f"), new DateTime(2020, 11, 30, 12, 41, 19, 358, DateTimeKind.Local).AddTicks(1303), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("c2585adf-719a-436d-a662-a95b8649f2a8"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(8759), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("53693dbd-5509-4141-9796-3a9fd8ae341b"), new DateTime(2021, 1, 30, 12, 39, 39, 357, DateTimeKind.Local).AddTicks(8742), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("d8b19b85-fa2c-4df8-b78f-8daa8e5262ae"), new DateTime(2021, 1, 30, 12, 40, 29, 357, DateTimeKind.Local).AddTicks(8750), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("a46fa2dd-5409-4ed0-bd7d-e8dcc4df3465"), new DateTime(2021, 1, 30, 12, 37, 59, 357, DateTimeKind.Local).AddTicks(8161), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("fede556f-6daa-4c79-9afb-b8371562abc1"), new DateTime(2021, 1, 30, 12, 38, 49, 357, DateTimeKind.Local).AddTicks(8723), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4a75aaca-c8d2-400f-baa1-3ddf3e2d8176"), new Guid("5cc169a5-b82a-4949-8ed2-bff50a727ded"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(4389), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dfc938e8-830c-4add-acea-f72849110cdd"), new Guid("77266dd7-c977-4d80-bb30-fab0488b4975"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(5377), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("a8a93954-fee5-47b0-a46f-320525790768"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(3552), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d261f302-1f3e-4423-9843-ef856319a6bb"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(3648), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e7a283ae-1289-4e08-8aee-1060d7a59c96"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(3655), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("8912402d-86b1-4058-80aa-1d2adf58dc1c"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(3667), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ed891a1c-e709-4b94-bcdb-fd586ee59ea3"), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(9345), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4efc8a90-6ee4-426f-8598-0d7434f3a2f0"), new DateTime(2021, 1, 30, 12, 41, 19, 357, DateTimeKind.Local).AddTicks(3662), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 41, 19, 355, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 41, 19, 355, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 41, 19, 355, DateTimeKind.Local).AddTicks(9630), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(1308), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4161), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4167), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4054), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4108), new DateTime(2021, 1, 30, 12, 41, 19, 356, DateTimeKind.Local).AddTicks(4125) });
        }
    }
}
