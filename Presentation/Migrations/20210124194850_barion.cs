using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class barion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("40b83c71-b09c-4e62-9b61-f769482cc8f9"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("2e2a8adb-ce5a-41f3-91cb-bc1ed678d0fc"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("9c7635e6-0aaa-4c30-9c5f-d7dba155c747"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bf13a895-496a-4613-8dd3-6567105ff924"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("9351f3c6-957c-43ef-817f-3ce5da0edaa1"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("984f04de-5a46-4ad1-bcf7-216b7380ab39"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a8cad085-5abc-43e0-ba60-82792a9af380"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("b3c66986-0027-4eae-ada7-a950a6ac9cb2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("079960c5-f3c7-4c38-8da0-f696e024cd0a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b73995d-ac73-42dc-abe0-a99afa56582e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b77ac46-9b3a-4ca8-a895-4d67f14f790e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("14ca3976-28fe-4948-bbe1-0da6710bdbe6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1ace8adb-cdcd-4aa3-9edd-d7ff0348292b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("228113f8-cad5-4a14-9dc1-f137160ed68a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2d0bc217-408b-44ba-899f-d917a3ccfa9e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3d6bc7c2-f270-4462-9f92-b0396775d68e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3fee8af2-d227-48ab-91d8-919a23362843"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4dfdf6f5-a438-4983-8241-d025b0c22a09"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5707c6de-d681-468a-aeda-6998120ffddf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7307ff00-811a-4baa-b31d-8adca7138773"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("82a1c119-b759-486c-929d-b00abbb7dff2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b98f4b0-f51e-473f-9467-f8ee0d544dc3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("96c3045e-d425-4a56-af10-b393b77a0aa7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9cb3f786-e805-4975-9c2a-810eb2f7be93"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a50112f7-15ce-49f4-bd8b-b1c68367ca3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b8a7b005-5402-4583-8aab-b9413f8a320f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d6e92924-b502-41d2-b3c6-1e3a4820fa60"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d9a98637-6317-4419-b890-a11c3981f4d4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dde7519b-efa7-4b36-8c4f-4f1046dadd27"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f3980ca7-04c8-4169-933b-985b0727ff45"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f717dc6a-b8f9-4f8c-b79a-11f0e88a7f45"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("feb284a0-0915-4d12-8789-527aa5f4f17b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9307abd3-35fc-468f-baa6-e560883b6edf"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9d9a4340-fd66-4e1b-9c29-583074fdb75e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a23bd6be-53e0-4359-8714-2e13a95ba9c1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("df0af38d-d5a4-49e9-b267-f154205406ee"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("eabea0aa-1ba9-4866-83a5-2450ef867b2d"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("164ef4b5-c9f4-4833-b987-86099ba0b11e"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("c4f8d52d-5587-4947-8755-42ff005b28cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fd153c-a5a4-4ea9-b0a9-285d72d81842"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6180f6c5-b39c-4a7c-9105-390ccbf7a4de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("923fd496-897e-43c1-91db-7b31acb60ae8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a74579f7-7ea2-4d00-9784-8868954b67b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be32afde-8514-4097-95fc-558053a33c2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb617fe9-8db3-4df6-b516-f4ff8092d731"));

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
                table: "ActualValueOfOneKredit",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.CreateTable(
                name: "BarionTransactionStarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    PaymentId = table.Column<string>(nullable: true),
                    IsFinished = table.Column<bool>(nullable: false),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarionTransactionStarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarionTransactionStarts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("3137209b-0772-4068-a8e6-bacd55ca1028"), new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(4404), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("3748bdfb-9d79-4256-aa44-417245ac2b53"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 1, 24, 21, 48, 49, 549, DateTimeKind.Local).AddTicks(4375), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("df26c675-fd74-4ca0-b153-3821361cf5fd"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(5393), new DateTime(2021, 1, 24, 21, 48, 49, 549, DateTimeKind.Local).AddTicks(5421), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("c31fca7c-e77e-4239-9cc0-be9dc6696f2d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(5441), new DateTime(2021, 1, 24, 21, 48, 49, 549, DateTimeKind.Local).AddTicks(5444), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("fb49ba7b-c9b4-4c2a-a3c4-5e4c32366de3"), new DateTime(2021, 1, 24, 20, 48, 49, 544, DateTimeKind.Local).AddTicks(4462), true, true, "GTA" },
                    { new Guid("591a266f-4b6d-4c9c-85c3-750915582954"), new DateTime(2021, 1, 24, 20, 48, 49, 547, DateTimeKind.Local).AddTicks(3394), true, true, "Survival" },
                    { new Guid("9b25ce60-7615-4c40-bb92-68882f0ffdda"), new DateTime(2021, 1, 24, 20, 48, 49, 547, DateTimeKind.Local).AddTicks(3441), true, true, "Skyblock" },
                    { new Guid("a8bb96fa-a51f-453d-8390-88a9db9bdb2c"), new DateTime(2021, 1, 24, 20, 48, 49, 547, DateTimeKind.Local).AddTicks(3447), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("19625c2d-eeef-4779-98d6-4abfa7871c36"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3941), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d7ba575d-e8e5-4a2b-bfc9-0ebeca38ffee"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3949), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("17a1a1c5-bd0c-43bc-9971-b2c5cd8a2dd9"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3956), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("47354b72-1e1e-4be6-a493-05e9e7807640"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3972), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cc2ea486-9b2a-4795-badb-c36a8e03f92e"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(4003), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4428b5cc-228f-4a54-9a05-24176dd43975"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3988), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2d1e77f9-a065-44d7-9ebd-d279b43f082f"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3995), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("76549e57-4d37-46b4-b543-e3560b22a6da"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3934), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d19a0649-b59d-49b4-9ccc-6ca80dee0141"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(4013), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b0cb9095-298b-4d4e-9478-b026634d1e0a"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3980), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7a9076c9-d87d-4ae4-830a-a8228590381d"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3927), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0177f2cd-dd35-46a4-a05d-707773b29032"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3963), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bd86f74b-b0cd-474e-a244-ab576502c11b"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3912), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c4d68a30-9b23-4fad-b44d-d31fc98fe96d"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3902), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a7ea57f1-81d0-43c8-a91a-5e698dbf93ba"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3895), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("53d3d680-3349-48e3-b7ea-291931f683e4"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3888), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5855428a-2715-46c3-b78d-7b7f736e76d6"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3881), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5c3bf336-ef39-4dcc-8286-e23d3f2786bd"), new DateTime(2020, 12, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3873), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b4708cad-5b07-4a82-9430-707896c00187"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3865), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("efa22164-6309-47d0-b40b-0407bcdd51a9"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3857), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9862778f-a54b-4ff8-a154-51d4fcc99786"), new DateTime(2020, 10, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3848), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("37b330bc-7dd6-4031-ba5f-6be23a7c5556"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3834), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f94e13fa-7167-42bf-ade1-9f2e7161333e"), new DateTime(2020, 9, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3733), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0030ab33-9beb-4c73-b9d4-ba24f1771464"), new DateTime(2020, 11, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(3919), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("413d24bb-6301-4dd7-9f00-e9c06cd740d0"), new DateTime(2021, 1, 24, 20, 48, 49, 551, DateTimeKind.Local).AddTicks(1254), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("f27440ce-2815-404c-82e5-b0eb59869d24"), new DateTime(2021, 1, 24, 20, 47, 9, 551, DateTimeKind.Local).AddTicks(1239), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("f2678baf-3351-46dc-ae45-61bc78ab80ee"), new DateTime(2021, 1, 24, 20, 47, 59, 551, DateTimeKind.Local).AddTicks(1247), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("fcf62f0f-7df3-44f3-8533-053b06922712"), new DateTime(2021, 1, 24, 20, 45, 29, 551, DateTimeKind.Local).AddTicks(659), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("8ecc4b7f-f42a-4ddd-821d-b5e0e87e8824"), new DateTime(2021, 1, 24, 20, 46, 19, 551, DateTimeKind.Local).AddTicks(1224), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e6348157-73b6-4852-90f2-2f4f1f1f6d93"), new Guid("6fb04cdf-af87-42da-9729-12cf260ea456"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(7119), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("408e9fa7-9d65-4bc7-ab5c-eaa70098df09"), new Guid("f11e8541-5455-40dd-9348-d52c70d9b0ba"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(8183), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("bde96e49-0ca1-4959-ae57-a5464cf29a16"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6185), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7e0248d4-410b-475a-a2c4-6d54adffce83"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6294), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f2c4b770-39fb-440d-894b-5a87476694ca"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6303), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a900b649-2165-4f08-94dc-73eecbb7bef4"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6314), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4c2f3fc7-bb9f-44a2-8f7d-e8729d84bff8"), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(7581), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a0f970f9-0bd5-4da2-893a-bc752afd662c"), new DateTime(2021, 1, 24, 20, 48, 49, 550, DateTimeKind.Local).AddTicks(6308), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(7916), new DateTime(2021, 1, 24, 20, 48, 49, 548, DateTimeKind.Local).AddTicks(9585), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2412), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2417), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2312), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2360), new DateTime(2021, 1, 24, 20, 48, 49, 549, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.CreateIndex(
                name: "IX_BarionTransactionStarts_UserId",
                table: "BarionTransactionStarts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarionTransactionStarts");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("3137209b-0772-4068-a8e6-bacd55ca1028"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("3748bdfb-9d79-4256-aa44-417245ac2b53"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("c31fca7c-e77e-4239-9cc0-be9dc6696f2d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("df26c675-fd74-4ca0-b153-3821361cf5fd"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("591a266f-4b6d-4c9c-85c3-750915582954"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("9b25ce60-7615-4c40-bb92-68882f0ffdda"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a8bb96fa-a51f-453d-8390-88a9db9bdb2c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("fb49ba7b-c9b4-4c2a-a3c4-5e4c32366de3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0030ab33-9beb-4c73-b9d4-ba24f1771464"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0177f2cd-dd35-46a4-a05d-707773b29032"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("17a1a1c5-bd0c-43bc-9971-b2c5cd8a2dd9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("19625c2d-eeef-4779-98d6-4abfa7871c36"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2d1e77f9-a065-44d7-9ebd-d279b43f082f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("37b330bc-7dd6-4031-ba5f-6be23a7c5556"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4428b5cc-228f-4a54-9a05-24176dd43975"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("47354b72-1e1e-4be6-a493-05e9e7807640"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("53d3d680-3349-48e3-b7ea-291931f683e4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5855428a-2715-46c3-b78d-7b7f736e76d6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5c3bf336-ef39-4dcc-8286-e23d3f2786bd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("76549e57-4d37-46b4-b543-e3560b22a6da"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7a9076c9-d87d-4ae4-830a-a8228590381d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9862778f-a54b-4ff8-a154-51d4fcc99786"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a7ea57f1-81d0-43c8-a91a-5e698dbf93ba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b0cb9095-298b-4d4e-9478-b026634d1e0a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b4708cad-5b07-4a82-9430-707896c00187"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bd86f74b-b0cd-474e-a244-ab576502c11b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c4d68a30-9b23-4fad-b44d-d31fc98fe96d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cc2ea486-9b2a-4795-badb-c36a8e03f92e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d19a0649-b59d-49b4-9ccc-6ca80dee0141"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d7ba575d-e8e5-4a2b-bfc9-0ebeca38ffee"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("efa22164-6309-47d0-b40b-0407bcdd51a9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f94e13fa-7167-42bf-ade1-9f2e7161333e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("413d24bb-6301-4dd7-9f00-e9c06cd740d0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8ecc4b7f-f42a-4ddd-821d-b5e0e87e8824"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f2678baf-3351-46dc-ae45-61bc78ab80ee"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f27440ce-2815-404c-82e5-b0eb59869d24"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("fcf62f0f-7df3-44f3-8533-053b06922712"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("408e9fa7-9d65-4bc7-ab5c-eaa70098df09"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("e6348157-73b6-4852-90f2-2f4f1f1f6d93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c2f3fc7-bb9f-44a2-8f7d-e8729d84bff8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0248d4-410b-475a-a2c4-6d54adffce83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0f970f9-0bd5-4da2-893a-bc752afd662c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a900b649-2165-4f08-94dc-73eecbb7bef4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bde96e49-0ca1-4959-ae57-a5464cf29a16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2c4b770-39fb-440d-894b-5a87476694ca"));

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
                values: new object[] { new Guid("40b83c71-b09c-4e62-9b61-f769482cc8f9"), new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(202), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("2e2a8adb-ce5a-41f3-91cb-bc1ed678d0fc"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(4663), new DateTime(2021, 1, 22, 20, 56, 48, 119, DateTimeKind.Local).AddTicks(7652), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bf13a895-496a-4613-8dd3-6567105ff924"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(932), new DateTime(2021, 1, 22, 20, 56, 48, 120, DateTimeKind.Local).AddTicks(989), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("9c7635e6-0aaa-4c30-9c5f-d7dba155c747"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(1023), new DateTime(2021, 1, 22, 20, 56, 48, 120, DateTimeKind.Local).AddTicks(1026), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("b3c66986-0027-4eae-ada7-a950a6ac9cb2"), new DateTime(2021, 1, 22, 19, 56, 48, 112, DateTimeKind.Local).AddTicks(762), true, true, "GTA" },
                    { new Guid("984f04de-5a46-4ad1-bcf7-216b7380ab39"), new DateTime(2021, 1, 22, 19, 56, 48, 115, DateTimeKind.Local).AddTicks(7091), true, true, "Survival" },
                    { new Guid("a8cad085-5abc-43e0-ba60-82792a9af380"), new DateTime(2021, 1, 22, 19, 56, 48, 115, DateTimeKind.Local).AddTicks(7183), true, true, "Skyblock" },
                    { new Guid("9351f3c6-957c-43ef-817f-3ce5da0edaa1"), new DateTime(2021, 1, 22, 19, 56, 48, 115, DateTimeKind.Local).AddTicks(7192), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("f3980ca7-04c8-4169-933b-985b0727ff45"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4413), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b77ac46-9b3a-4ca8-a895-4d67f14f790e"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4423), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3fee8af2-d227-48ab-91d8-919a23362843"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4431), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a50112f7-15ce-49f4-bd8b-b1c68367ca3f"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4446), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b8a7b005-5402-4583-8aab-b9413f8a320f"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4477), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("96c3045e-d425-4a56-af10-b393b77a0aa7"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4462), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7307ff00-811a-4baa-b31d-8adca7138773"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4470), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("228113f8-cad5-4a14-9dc1-f137160ed68a"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4405), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d9a98637-6317-4419-b890-a11c3981f4d4"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4487), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b98f4b0-f51e-473f-9467-f8ee0d544dc3"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4454), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("82a1c119-b759-486c-929d-b00abbb7dff2"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4397), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4dfdf6f5-a438-4983-8241-d025b0c22a09"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4439), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f717dc6a-b8f9-4f8c-b79a-11f0e88a7f45"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4382), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("feb284a0-0915-4d12-8789-527aa5f4f17b"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4374), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1ace8adb-cdcd-4aa3-9edd-d7ff0348292b"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4366), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5707c6de-d681-468a-aeda-6998120ffddf"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4359), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3d6bc7c2-f270-4462-9f92-b0396775d68e"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4343), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("14ca3976-28fe-4948-bbe1-0da6710bdbe6"), new DateTime(2020, 12, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4335), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2d0bc217-408b-44ba-899f-d917a3ccfa9e"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4328), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("079960c5-f3c7-4c38-8da0-f696e024cd0a"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4319), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dde7519b-efa7-4b36-8c4f-4f1046dadd27"), new DateTime(2020, 10, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4310), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b73995d-ac73-42dc-abe0-a99afa56582e"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4299), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9cb3f786-e805-4975-9c2a-810eb2f7be93"), new DateTime(2020, 9, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4091), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d6e92924-b502-41d2-b3c6-1e3a4820fa60"), new DateTime(2020, 11, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(4390), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("df0af38d-d5a4-49e9-b267-f154205406ee"), new DateTime(2021, 1, 22, 19, 56, 48, 122, DateTimeKind.Local).AddTicks(842), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("9307abd3-35fc-468f-baa6-e560883b6edf"), new DateTime(2021, 1, 22, 19, 55, 8, 122, DateTimeKind.Local).AddTicks(817), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("a23bd6be-53e0-4359-8714-2e13a95ba9c1"), new DateTime(2021, 1, 22, 19, 55, 58, 122, DateTimeKind.Local).AddTicks(834), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("eabea0aa-1ba9-4866-83a5-2450ef867b2d"), new DateTime(2021, 1, 22, 19, 53, 28, 122, DateTimeKind.Local).AddTicks(153), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("9d9a4340-fd66-4e1b-9c29-583074fdb75e"), new DateTime(2021, 1, 22, 19, 54, 18, 122, DateTimeKind.Local).AddTicks(799), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("164ef4b5-c9f4-4833-b987-86099ba0b11e"), new Guid("497d03c6-26ac-4648-9b9d-e27855ee596d"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(5986), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c4f8d52d-5587-4947-8755-42ff005b28cf"), new Guid("98b2e827-6f2e-43f7-847a-83bec0749d24"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(7321), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("fb617fe9-8db3-4df6-b516-f4ff8092d731"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4197), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6180f6c5-b39c-4a7c-9105-390ccbf7a4de"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4360), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("923fd496-897e-43c1-91db-7b31acb60ae8"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4370), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("be32afde-8514-4097-95fc-558053a33c2e"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4393), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a74579f7-7ea2-4d00-9784-8868954b67b1"), new DateTime(2021, 1, 22, 19, 56, 48, 120, DateTimeKind.Local).AddTicks(4777), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("26fd153c-a5a4-4ea9-b0a9-285d72d81842"), new DateTime(2021, 1, 22, 19, 56, 48, 121, DateTimeKind.Local).AddTicks(4386), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(4945), new DateTime(2021, 1, 22, 19, 56, 48, 117, DateTimeKind.Local).AddTicks(7851), new DateTime(2021, 1, 22, 19, 56, 48, 118, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(996), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(780), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(915), new DateTime(2021, 1, 22, 19, 56, 48, 119, DateTimeKind.Local).AddTicks(932) });
        }
    }
}
