using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class kreditgift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("8dc6fa73-861f-436a-b3f9-779636eb1a6f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("04b4d599-008f-4df0-9546-99514d976ebe"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("407bea8f-aecb-454c-8580-056bd51d152e"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("cdaa9dc5-99d3-48d7-bf89-99ce62d61cad"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("922134d3-2c21-4c31-8420-b60e98ec0a68"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("cb8b2ab6-8563-4e0b-89ef-da0e202c9f59"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("de566637-c69b-4d8a-be62-bd2bf198ab82"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("e01986b2-c7c4-4b0b-8d19-2facb68a170d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("022629ba-3e4a-47eb-a3a1-184f75ac531f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("04a4ddd2-149c-4b1f-a2d8-f54aa516dac6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("15cf0190-211b-42f6-9b5b-e468609b44cc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("30cc6b93-a410-48b4-bf2a-470252368f05"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("341e3ccf-bc0a-45eb-9a54-4862de8efe6e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3f471cb1-bb6b-4d51-912b-a4a0f5676e5d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4a787864-40a6-4434-a4ed-9faff8636604"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("58fd7e6e-3c83-43ca-8ac0-357dc9d067c9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("66d010d0-8197-4c50-8faa-36ff59cfcf60"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("696d75f0-cc55-49f1-bf4d-c5c51093c408"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6e104621-88bd-4cd7-a672-32732cd17fd8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("721ac6ad-19dd-477a-865b-e9f1694f2852"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8ee6da2d-1602-4945-b0a3-8c9bfd8edeb0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a8242bf5-96db-415b-9d61-2ff6760ef348"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a9e6be5e-0386-48f6-9977-77f901a85223"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("acf326a4-6ad0-49ca-9f5e-a97371cea7c4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b70a4cb6-6871-4dd3-8888-7ae8c1155c45"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("bf71a4ac-3311-49ad-ae9d-4e37d6a1b297"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ca982694-a909-4c0a-9938-1469bf7495d4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d5114cc7-e609-47a7-bf6a-5f1e17ab05bf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e19e66ff-ca17-4d09-98e5-671f0bfc1482"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e85ac996-17ac-4822-a0cf-a44316c3ccd7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eb0d658f-ac39-4b11-8db8-efe06ff139e8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f643eb5b-8c46-461d-9150-7d556a6eac11"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("3819f28e-ed62-4d36-b04b-d21451dc76e1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("944c7b49-4e09-4f9b-a71d-ae211a1661d2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("a4705ccf-0bbb-4c89-abf2-032653484e7a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d171004a-9382-4a97-b8cf-6d7283946069"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e4f8acdf-1b96-4efd-a9e8-882195391093"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("24d04f79-5e7b-4bb7-af5b-1c25d95ee1f5"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("3d590a46-9720-40b4-a259-478891885f86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34a46814-0f4b-4dff-b8d5-228a2ce1f341"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b51fe44-472d-441a-8127-97244b9adaa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78755a26-0f7f-40eb-aba5-9c57b30524ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adca74a8-0941-413a-9660-04a7525d4f04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd9da299-b38b-4edc-930c-71bcc54967c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5ee7a8c-3d0a-44bf-a1ff-1d488f61a5d9"));

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

            migrationBuilder.CreateTable(
                name: "KreditGifts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    KreditGiftAmount = table.Column<int>(nullable: false),
                    SenderUserId = table.Column<Guid>(nullable: false),
                    ReceiverUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KreditGifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KreditGifts_Users_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KreditGifts_Users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_KreditGifts_ReceiverUserId",
                table: "KreditGifts",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KreditGifts_SenderUserId",
                table: "KreditGifts",
                column: "SenderUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KreditGifts");

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
                values: new object[] { new Guid("8dc6fa73-861f-436a-b3f9-779636eb1a6f"), new DateTime(2021, 1, 25, 19, 13, 15, 56, DateTimeKind.Local).AddTicks(7359), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("407bea8f-aecb-454c-8580-056bd51d152e"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(6318), new DateTime(2021, 1, 25, 20, 13, 15, 57, DateTimeKind.Local).AddTicks(7598), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("cdaa9dc5-99d3-48d7-bf89-99ce62d61cad"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(8603), new DateTime(2021, 1, 25, 20, 13, 15, 57, DateTimeKind.Local).AddTicks(8635), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("04b4d599-008f-4df0-9546-99514d976ebe"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(8658), new DateTime(2021, 1, 25, 20, 13, 15, 57, DateTimeKind.Local).AddTicks(8661), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("922134d3-2c21-4c31-8420-b60e98ec0a68"), new DateTime(2021, 1, 25, 19, 13, 15, 52, DateTimeKind.Local).AddTicks(6176), true, true, "GTA" },
                    { new Guid("e01986b2-c7c4-4b0b-8d19-2facb68a170d"), new DateTime(2021, 1, 25, 19, 13, 15, 55, DateTimeKind.Local).AddTicks(5842), true, true, "Survival" },
                    { new Guid("de566637-c69b-4d8a-be62-bd2bf198ab82"), new DateTime(2021, 1, 25, 19, 13, 15, 55, DateTimeKind.Local).AddTicks(5891), true, true, "Skyblock" },
                    { new Guid("cb8b2ab6-8563-4e0b-89ef-da0e202c9f59"), new DateTime(2021, 1, 25, 19, 13, 15, 55, DateTimeKind.Local).AddTicks(5897), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("30cc6b93-a410-48b4-bf2a-470252368f05"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2879), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b70a4cb6-6871-4dd3-8888-7ae8c1155c45"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2887), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3f471cb1-bb6b-4d51-912b-a4a0f5676e5d"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2895), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d5114cc7-e609-47a7-bf6a-5f1e17ab05bf"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2912), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ca982694-a909-4c0a-9938-1469bf7495d4"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2943), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f643eb5b-8c46-461d-9150-7d556a6eac11"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2928), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e85ac996-17ac-4822-a0cf-a44316c3ccd7"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2935), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("721ac6ad-19dd-477a-865b-e9f1694f2852"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2870), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb0d658f-ac39-4b11-8db8-efe06ff139e8"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2951), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8ee6da2d-1602-4945-b0a3-8c9bfd8edeb0"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2920), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("66d010d0-8197-4c50-8faa-36ff59cfcf60"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2863), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("58fd7e6e-3c83-43ca-8ac0-357dc9d067c9"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2903), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("acf326a4-6ad0-49ca-9f5e-a97371cea7c4"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2848), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4a787864-40a6-4434-a4ed-9faff8636604"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2838), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6e104621-88bd-4cd7-a672-32732cd17fd8"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2830), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a8242bf5-96db-415b-9d61-2ff6760ef348"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2823), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("022629ba-3e4a-47eb-a3a1-184f75ac531f"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2816), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("15cf0190-211b-42f6-9b5b-e468609b44cc"), new DateTime(2020, 12, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2808), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("696d75f0-cc55-49f1-bf4d-c5c51093c408"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2799), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("bf71a4ac-3311-49ad-ae9d-4e37d6a1b297"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2791), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("04a4ddd2-149c-4b1f-a2d8-f54aa516dac6"), new DateTime(2020, 10, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2783), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e19e66ff-ca17-4d09-98e5-671f0bfc1482"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2767), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("341e3ccf-bc0a-45eb-9a54-4862de8efe6e"), new DateTime(2020, 9, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2660), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a9e6be5e-0386-48f6-9977-77f901a85223"), new DateTime(2020, 11, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(2855), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("3819f28e-ed62-4d36-b04b-d21451dc76e1"), new DateTime(2021, 1, 25, 19, 13, 15, 59, DateTimeKind.Local).AddTicks(233), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("944c7b49-4e09-4f9b-a71d-ae211a1661d2"), new DateTime(2021, 1, 25, 19, 11, 35, 59, DateTimeKind.Local).AddTicks(217), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("e4f8acdf-1b96-4efd-a9e8-882195391093"), new DateTime(2021, 1, 25, 19, 12, 25, 59, DateTimeKind.Local).AddTicks(225), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("a4705ccf-0bbb-4c89-abf2-032653484e7a"), new DateTime(2021, 1, 25, 19, 9, 55, 58, DateTimeKind.Local).AddTicks(9632), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("d171004a-9382-4a97-b8cf-6d7283946069"), new DateTime(2021, 1, 25, 19, 10, 45, 59, DateTimeKind.Local).AddTicks(201), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d590a46-9720-40b4-a259-478891885f86"), new Guid("a663cc2c-27ab-4734-8d83-a1bca6f2468a"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(6172), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("24d04f79-5e7b-4bb7-af5b-1c25d95ee1f5"), new Guid("438a0a7b-7400-4413-8178-739eb78d7630"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(7189), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("f5ee7a8c-3d0a-44bf-a1ff-1d488f61a5d9"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5339), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cd9da299-b38b-4edc-930c-71bcc54967c2"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5440), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("34a46814-0f4b-4dff-b8d5-228a2ce1f341"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5448), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("78755a26-0f7f-40eb-aba5-9c57b30524ce"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5458), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5b51fe44-472d-441a-8127-97244b9adaa6"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(864), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("adca74a8-0941-413a-9660-04a7525d4f04"), new DateTime(2021, 1, 25, 19, 13, 15, 58, DateTimeKind.Local).AddTicks(5453), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 25, 19, 13, 15, 56, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(989), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(2713), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5545), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5550), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5438), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5492), new DateTime(2021, 1, 25, 19, 13, 15, 57, DateTimeKind.Local).AddTicks(5509) });
        }
    }
}
