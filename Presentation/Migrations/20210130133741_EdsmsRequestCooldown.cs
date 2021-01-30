using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class EdsmsRequestCooldown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "JatekfizetesRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ClientIP = table.Column<string>(nullable: false),
                    CallDate = table.Column<DateTime>(nullable: false),
                    IsActivationSuccessful = table.Column<bool>(nullable: false),
                    CallerUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JatekfizetesRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JatekfizetesRequests_Users_CallerUserId",
                        column: x => x.CallerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("ed15c4b2-e9bc-4e89-ad77-cda2793278e5"), new DateTime(2021, 1, 30, 14, 37, 40, 816, DateTimeKind.Local).AddTicks(7393), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("37cf392f-6681-410e-b1e5-8674472d9d6d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(6431), new DateTime(2021, 1, 30, 15, 37, 40, 817, DateTimeKind.Local).AddTicks(7711), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("ca1c172d-30bd-4813-a374-ea6e70416387"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(8725), new DateTime(2021, 1, 30, 15, 37, 40, 817, DateTimeKind.Local).AddTicks(8769), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("813a6344-53d6-4818-b05a-bdc66794e01f"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(8791), new DateTime(2021, 1, 30, 15, 37, 40, 817, DateTimeKind.Local).AddTicks(8794), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("3d7af1ec-503a-4d4d-a8d2-4fd36afc7bc9"), new DateTime(2021, 1, 30, 14, 37, 40, 812, DateTimeKind.Local).AddTicks(6074), true, true, "GTA" },
                    { new Guid("c03a6241-eaa2-4e02-a28c-f2ea195e3d2c"), new DateTime(2021, 1, 30, 14, 37, 40, 815, DateTimeKind.Local).AddTicks(5582), true, true, "Survival" },
                    { new Guid("9c16379c-d84a-439a-b626-e4df9833729d"), new DateTime(2021, 1, 30, 14, 37, 40, 815, DateTimeKind.Local).AddTicks(5633), true, true, "Skyblock" },
                    { new Guid("7acebdda-879d-4294-8387-5495fc8e9fc8"), new DateTime(2021, 1, 30, 14, 37, 40, 815, DateTimeKind.Local).AddTicks(5639), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("aea8df4b-7954-490c-a0a5-25baffee56c4"), new DateTime(2020, 12, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3001), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("adac06ba-5ed1-4d95-8b10-ec8a74dc28d6"), new DateTime(2020, 9, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3009), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d589f2f2-5d2e-4a7b-8636-d1b1feb5c5cb"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3016), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd2d5071-0486-43f5-aafe-4ba5f9ab770f"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3033), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3e8af8d8-5556-4a56-bd45-94cc6337ce2f"), new DateTime(2020, 12, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3063), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3067464c-4fb4-40b3-9f65-650fa1f82bdb"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3048), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("efacfd61-88cb-4c00-85ad-e8a475a7b763"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3056), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e79cd9bc-b363-4787-ba39-4ac53e221e49"), new DateTime(2020, 12, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2994), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6cfc386b-224b-4865-8f2d-30a70e870dd5"), new DateTime(2020, 12, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3071), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0a37f0f7-418a-40b0-8ca7-6e3ecb90c233"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3041), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("91071812-446e-48dd-b37f-dd3504ca0cb4"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2987), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("989ea933-bea1-4dbb-9a2b-ee40f5b691fa"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(3024), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("da75c546-4f4b-43c8-88ee-2069674311d2"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2972), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5a5e69c6-8e51-4315-8515-c466a9758421"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2962), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0a31bc2d-f6d9-406e-98af-0b144d4f9574"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2955), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cad70061-292a-45de-ad54-1d33df313c6c"), new DateTime(2020, 9, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2947), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("91c13a84-077d-4f40-b77d-1efe153f1e2a"), new DateTime(2020, 9, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2939), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("73428da6-76e4-4dba-b0df-4216867b38b5"), new DateTime(2020, 12, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2932), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dd892cda-e1a7-459e-8e6e-0a5a2c0c6696"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2924), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fdd65315-19d3-4510-a2a4-b049e5adc76c"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2917), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b2861633-eecb-4629-87a6-b977fb00af85"), new DateTime(2020, 10, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2908), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e925c8fe-945e-45e7-ae03-7b886b31c45a"), new DateTime(2020, 9, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2894), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("97a1393f-ba76-4945-a673-faa12a270a63"), new DateTime(2020, 9, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2785), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("324d9763-76e3-47c5-a9f3-15843de46b36"), new DateTime(2020, 11, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(2979), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("be43a406-701a-4a52-94ed-aceab482e534"), new DateTime(2021, 1, 30, 14, 37, 40, 819, DateTimeKind.Local).AddTicks(389), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("0c0dc174-465a-40d3-8baa-4f3ee21a3224"), new DateTime(2021, 1, 30, 14, 36, 0, 819, DateTimeKind.Local).AddTicks(374), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("21445d66-8a25-49ad-9619-14a70aceb8ad"), new DateTime(2021, 1, 30, 14, 36, 50, 819, DateTimeKind.Local).AddTicks(381), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("2ae0ca66-ff78-4572-8bb9-4d2b79965980"), new DateTime(2021, 1, 30, 14, 34, 20, 818, DateTimeKind.Local).AddTicks(9790), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("5060ca3b-941e-4d43-af29-2f3d37c7b7a3"), new DateTime(2021, 1, 30, 14, 35, 10, 819, DateTimeKind.Local).AddTicks(356), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c8fd1d08-f7ec-4587-8105-fda33d5cc97e"), new Guid("309f1fad-f3ba-4924-a401-5de509d6ae27"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(6323), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("669b9c18-2d8f-45cf-8710-b19692e2cdce"), new Guid("ef2fbc7a-33c0-4162-939b-c2a32c41153c"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(7336), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("67ef9139-9d51-48b9-baee-5eb06108949f"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(5434), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6de974e7-f321-4686-b301-5d716c55aba0"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(5542), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("3bbf1afa-9e59-4aec-a58a-75948db2e771"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(5549), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e9501d0e-8c73-4851-802e-e813018fcfe1"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(5606), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0a7642b3-7d07-4751-8a86-ad5fec0d9c04"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(967), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6c5dbb53-f3d0-41a6-a772-aa2fed96840e"), new DateTime(2021, 1, 30, 14, 37, 40, 818, DateTimeKind.Local).AddTicks(5600), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 14, 37, 40, 816, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(1142), new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(2857), new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(5716), new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(5721), new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(5599), new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(5661), new DateTime(2021, 1, 30, 14, 37, 40, 817, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.CreateIndex(
                name: "IX_JatekfizetesRequests_CallerUserId",
                table: "JatekfizetesRequests",
                column: "CallerUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JatekfizetesRequests");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("ed15c4b2-e9bc-4e89-ad77-cda2793278e5"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("37cf392f-6681-410e-b1e5-8674472d9d6d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("813a6344-53d6-4818-b05a-bdc66794e01f"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("ca1c172d-30bd-4813-a374-ea6e70416387"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("3d7af1ec-503a-4d4d-a8d2-4fd36afc7bc9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7acebdda-879d-4294-8387-5495fc8e9fc8"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("9c16379c-d84a-439a-b626-e4df9833729d"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("c03a6241-eaa2-4e02-a28c-f2ea195e3d2c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0a31bc2d-f6d9-406e-98af-0b144d4f9574"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0a37f0f7-418a-40b0-8ca7-6e3ecb90c233"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3067464c-4fb4-40b3-9f65-650fa1f82bdb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("324d9763-76e3-47c5-a9f3-15843de46b36"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3e8af8d8-5556-4a56-bd45-94cc6337ce2f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5a5e69c6-8e51-4315-8515-c466a9758421"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6cfc386b-224b-4865-8f2d-30a70e870dd5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("73428da6-76e4-4dba-b0df-4216867b38b5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("91071812-446e-48dd-b37f-dd3504ca0cb4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("91c13a84-077d-4f40-b77d-1efe153f1e2a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("97a1393f-ba76-4945-a673-faa12a270a63"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("989ea933-bea1-4dbb-9a2b-ee40f5b691fa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("adac06ba-5ed1-4d95-8b10-ec8a74dc28d6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aea8df4b-7954-490c-a0a5-25baffee56c4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b2861633-eecb-4629-87a6-b977fb00af85"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cad70061-292a-45de-ad54-1d33df313c6c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd2d5071-0486-43f5-aafe-4ba5f9ab770f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d589f2f2-5d2e-4a7b-8636-d1b1feb5c5cb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("da75c546-4f4b-43c8-88ee-2069674311d2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dd892cda-e1a7-459e-8e6e-0a5a2c0c6696"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e79cd9bc-b363-4787-ba39-4ac53e221e49"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e925c8fe-945e-45e7-ae03-7b886b31c45a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("efacfd61-88cb-4c00-85ad-e8a475a7b763"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fdd65315-19d3-4510-a2a4-b049e5adc76c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0c0dc174-465a-40d3-8baa-4f3ee21a3224"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("21445d66-8a25-49ad-9619-14a70aceb8ad"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("2ae0ca66-ff78-4572-8bb9-4d2b79965980"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5060ca3b-941e-4d43-af29-2f3d37c7b7a3"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("be43a406-701a-4a52-94ed-aceab482e534"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("669b9c18-2d8f-45cf-8710-b19692e2cdce"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("c8fd1d08-f7ec-4587-8105-fda33d5cc97e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a7642b3-7d07-4751-8a86-ad5fec0d9c04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bbf1afa-9e59-4aec-a58a-75948db2e771"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67ef9139-9d51-48b9-baee-5eb06108949f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c5dbb53-f3d0-41a6-a772-aa2fed96840e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6de974e7-f321-4686-b301-5d716c55aba0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9501d0e-8c73-4851-802e-e813018fcfe1"));

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
    }
}
