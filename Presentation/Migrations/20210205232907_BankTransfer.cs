using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BankTransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "BankTransfers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    KreditValue = table.Column<int>(nullable: false),
                    TransferCode = table.Column<string>(nullable: true),
                    CurrencyValue = table.Column<int>(nullable: false),
                    IsActivated = table.Column<bool>(nullable: false),
                    BillingEmail = table.Column<string>(nullable: true),
                    BillingName = table.Column<string>(nullable: true),
                    TaxNumber = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTransfers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankTransferBillingAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    BankTransferId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransferBillingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTransferBillingAddresses_BankTransfers_BankTransferId",
                        column: x => x.BankTransferId,
                        principalTable: "BankTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("5f49ad6d-cddf-4166-af5a-d25500d14584"), new DateTime(2021, 2, 6, 0, 29, 7, 169, DateTimeKind.Local).AddTicks(8604), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("56bc3cf4-c7cd-4c9e-8581-fdbf932122c4"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(7549), new DateTime(2021, 2, 6, 1, 29, 7, 170, DateTimeKind.Local).AddTicks(8909), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0dc69d5d-af49-4092-b855-ffd6fa6c9f02"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(9905), new DateTime(2021, 2, 6, 1, 29, 7, 170, DateTimeKind.Local).AddTicks(9937), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("90fc5912-e00d-4697-aee0-47d42f3f3ed5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(9957), new DateTime(2021, 2, 6, 1, 29, 7, 170, DateTimeKind.Local).AddTicks(9961), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("1e32710c-a91b-450c-bb6f-55687e5d936e"), new DateTime(2021, 2, 6, 0, 29, 7, 165, DateTimeKind.Local).AddTicks(7375), true, true, "GTA" },
                    { new Guid("4c1d9cab-d6e1-448f-8a8e-8ac20f787442"), new DateTime(2021, 2, 6, 0, 29, 7, 168, DateTimeKind.Local).AddTicks(7352), true, true, "Survival" },
                    { new Guid("5908e7da-8ac7-4413-8933-d66daa8bd62f"), new DateTime(2021, 2, 6, 0, 29, 7, 168, DateTimeKind.Local).AddTicks(7398), true, true, "Skyblock" },
                    { new Guid("bcb6535c-5f6f-47d9-b504-6d9686e92db7"), new DateTime(2021, 2, 6, 0, 29, 7, 168, DateTimeKind.Local).AddTicks(7405), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("9dc3418b-3917-4bf3-b56f-6d415f8c1038"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3852), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ef99d1d9-39a4-4f0e-9689-c54378a131be"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3860), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a481e90f-8a69-4b2e-ae08-f3da94aa6fb8"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3869), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("947c27c2-b91b-440d-ae83-a2d9baf4df15"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3885), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3a1ff17b-36b4-4cab-b13a-35bdaa3e6d20"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3914), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb4183f7-db81-4ede-bfcd-ef6a8b00d318"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3900), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3df8b0ff-9c9a-4027-922c-b9b58525aafd"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3907), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a73bcd96-d20e-4040-b6ec-eb4c12ffc72b"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3845), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ab8f84d2-a76d-445b-8674-e5c3e4d19b55"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3922), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a9663510-221c-4e19-925d-8959e5c1ec7f"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3892), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("03b58319-0cac-4aca-b9eb-aec6b08122ed"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3838), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("21165887-736a-41f8-bd91-93c692f74ce1"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3877), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("84813171-71f3-4df4-95e5-ab459227434f"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3823), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("11c753fb-ab5f-4cff-afe1-bf6a08482def"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3815), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3ea5cae9-3033-4b40-a593-88a32499e805"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3808), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b485629-bfc6-48c7-9bea-f5733d26afa9"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3795), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eac2525d-2433-43de-9584-a93081fa2b70"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3786), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e7e34358-cc6b-4089-9da6-8e89e528a306"), new DateTime(2021, 1, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3778), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f090cfaa-b4e9-4154-a92a-89f43d7838ff"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3771), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0bd9ba5d-945f-46c5-8eee-62765ca10e3c"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3763), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2c7bbf6a-63db-403a-a8d8-a396c0e42a00"), new DateTime(2020, 11, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3756), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("71a712cc-1b56-4760-8673-fdbab37217d8"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3745), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("53bae153-f10c-475e-813b-ba082d3d84ac"), new DateTime(2020, 10, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3634), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8d2a0acc-9142-4d52-a66f-12696d4c567f"), new DateTime(2020, 12, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(3830), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("1d9cedd9-0adb-4ea3-bd5e-32c4e08d84fd"), new DateTime(2021, 2, 6, 0, 29, 7, 172, DateTimeKind.Local).AddTicks(1219), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("4f249271-451c-45d4-a04d-5225db53d5d5"), new DateTime(2021, 2, 6, 0, 27, 27, 172, DateTimeKind.Local).AddTicks(1202), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("4195b836-f58f-41aa-88a5-15b376f3a2d0"), new DateTime(2021, 2, 6, 0, 28, 17, 172, DateTimeKind.Local).AddTicks(1209), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("61ea59aa-4bb1-47c9-b474-ba8385d1f58f"), new DateTime(2021, 2, 6, 0, 25, 47, 172, DateTimeKind.Local).AddTicks(629), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("fac070f5-2717-49b5-a6d2-b59b8937a820"), new DateTime(2021, 2, 6, 0, 26, 37, 172, DateTimeKind.Local).AddTicks(1186), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9f91bf27-5c9f-4c8b-ac0e-25089b83b87b"), new Guid("91f580a5-8eb2-471f-bd73-e74616de9157"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(7252), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7ffcf7e9-64a2-4255-b204-4cc32f0ece35"), new Guid("2735330a-8ae8-46cb-819f-f45293ba90dd"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(8252), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("af4348ac-9022-471e-81fe-ce5e9a1b19a8"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6344), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("dcbf4f76-1737-4945-becd-b3aded9c4ded"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6541), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f908d762-d770-49cc-a2d1-0706e88b6311"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6551), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2ed18ec8-464b-4d06-95d2-d63d10166886"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6563), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4748568f-0074-4a95-8586-a0f2eb4cc9c9"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(2105), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d6c35eee-d153-41cd-a5a2-bfa1e360864b"), new DateTime(2021, 2, 6, 0, 29, 7, 171, DateTimeKind.Local).AddTicks(6557), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 6, 0, 29, 7, 169, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(2273), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(4066), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6848), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6854), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6743), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6795), new DateTime(2021, 2, 6, 0, 29, 7, 170, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.CreateIndex(
                name: "IX_BankTransferBillingAddresses_BankTransferId",
                table: "BankTransferBillingAddresses",
                column: "BankTransferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankTransfers_UserId",
                table: "BankTransfers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankTransferBillingAddresses");

            migrationBuilder.DropTable(
                name: "BankTransfers");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("5f49ad6d-cddf-4166-af5a-d25500d14584"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("0dc69d5d-af49-4092-b855-ffd6fa6c9f02"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("56bc3cf4-c7cd-4c9e-8581-fdbf932122c4"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("90fc5912-e00d-4697-aee0-47d42f3f3ed5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("1e32710c-a91b-450c-bb6f-55687e5d936e"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("4c1d9cab-d6e1-448f-8a8e-8ac20f787442"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("5908e7da-8ac7-4413-8933-d66daa8bd62f"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("bcb6535c-5f6f-47d9-b504-6d9686e92db7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("03b58319-0cac-4aca-b9eb-aec6b08122ed"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b485629-bfc6-48c7-9bea-f5733d26afa9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0bd9ba5d-945f-46c5-8eee-62765ca10e3c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("11c753fb-ab5f-4cff-afe1-bf6a08482def"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("21165887-736a-41f8-bd91-93c692f74ce1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2c7bbf6a-63db-403a-a8d8-a396c0e42a00"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3a1ff17b-36b4-4cab-b13a-35bdaa3e6d20"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3df8b0ff-9c9a-4027-922c-b9b58525aafd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3ea5cae9-3033-4b40-a593-88a32499e805"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("53bae153-f10c-475e-813b-ba082d3d84ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("71a712cc-1b56-4760-8673-fdbab37217d8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("84813171-71f3-4df4-95e5-ab459227434f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8d2a0acc-9142-4d52-a66f-12696d4c567f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("947c27c2-b91b-440d-ae83-a2d9baf4df15"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9dc3418b-3917-4bf3-b56f-6d415f8c1038"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a481e90f-8a69-4b2e-ae08-f3da94aa6fb8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a73bcd96-d20e-4040-b6ec-eb4c12ffc72b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a9663510-221c-4e19-925d-8959e5c1ec7f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ab8f84d2-a76d-445b-8674-e5c3e4d19b55"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e7e34358-cc6b-4089-9da6-8e89e528a306"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eac2525d-2433-43de-9584-a93081fa2b70"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eb4183f7-db81-4ede-bfcd-ef6a8b00d318"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ef99d1d9-39a4-4f0e-9689-c54378a131be"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f090cfaa-b4e9-4154-a92a-89f43d7838ff"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1d9cedd9-0adb-4ea3-bd5e-32c4e08d84fd"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4195b836-f58f-41aa-88a5-15b376f3a2d0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4f249271-451c-45d4-a04d-5225db53d5d5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("61ea59aa-4bb1-47c9-b474-ba8385d1f58f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("fac070f5-2717-49b5-a6d2-b59b8937a820"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("7ffcf7e9-64a2-4255-b204-4cc32f0ece35"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("9f91bf27-5c9f-4c8b-ac0e-25089b83b87b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ed18ec8-464b-4d06-95d2-d63d10166886"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4748568f-0074-4a95-8586-a0f2eb4cc9c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af4348ac-9022-471e-81fe-ce5e9a1b19a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6c35eee-d153-41cd-a5a2-bfa1e360864b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcbf4f76-1737-4945-becd-b3aded9c4ded"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f908d762-d770-49cc-a2d1-0706e88b6311"));

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
    }
}
