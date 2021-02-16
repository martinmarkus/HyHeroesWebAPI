using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class Notfication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("063c08ea-d64f-46a8-88db-92857cce011e"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7eeb5534-1479-4228-a68b-78201170827d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("9e98f1e8-c93a-4079-bf12-6ca1aa8cdd34"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("d6032798-1573-42c1-baf3-bfa1730d6818"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("0b3db5a1-41cb-4a79-a826-d0342a41cfd5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("40ef2b11-6295-448d-a853-737dcbf55af5"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("6b29e9af-820d-45b2-9c8d-25d103377b6a"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7fc82764-def8-410c-a2bd-db92b3e9facf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("04793bc4-3802-4254-bccd-38a41083fc43"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0f1a79e5-3daa-4e8f-bf74-6ff8158225d2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("13d7c203-b6f3-4817-a395-702797bf8646"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1ffabc7e-9530-43e7-9af4-a216f5995ae3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("211f8c0c-5ba2-4eef-91b2-5521e8090ea0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28aaee62-f2fa-43d2-8a18-fac8e66cc8e9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("29ca66a5-114b-421a-95e7-0e5e66146233"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2de2145e-0e7e-47dc-a063-9af4bdb95131"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("40763ab5-f691-4425-b245-eb6ed6a1c547"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("468cdf61-5221-46a2-92a0-1dff677581b7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4ef5d7ec-3b7e-42b5-8f4d-66fd9f1b81ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("60dcb2e1-f4b7-49f3-b497-53d1aa1628b5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("65cfaa80-c075-4acd-a9c5-44b623a30470"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("88224dce-0f91-461a-a56b-d489691d28eb"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9aa23d46-8ca2-4304-b6cf-040f917c775d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9b255ddd-5beb-454e-8ea4-9e2b9c68f300"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9bdf8b75-6d8b-4d35-92b4-e61666758087"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9bee088b-6a0f-4bc8-a714-1ce9474e6669"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ae3e0752-a236-4a73-a520-c82145dcb51e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b81abd95-6d86-47ca-a541-99c400623262"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d5780007-a337-445b-bc51-be0e02509914"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("eb6ed58d-c12b-4d92-ab23-c25c1c6d2ab7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("efce2569-13a6-4f1f-9e13-fc07a5893780"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fcb055e7-87df-4007-bac0-87198304e22c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("46debc89-7360-4b78-b43f-114763c1b73b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("695c549e-33fe-4681-9ac3-1f96a1e3ebea"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("95f1c3e5-88ca-473e-a032-85e96d58b887"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("98c01085-883c-44d7-b5bd-13204b717079"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f34bde09-46fa-4934-bef2-6b99eb6e437d"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("083d5b40-b214-4ed3-858e-eae87e491dc0"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("f824b540-66fb-495d-960e-a3078cb06574"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ed39aa6-cf39-4621-b49a-20d2564d055a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cd160a5-fa98-4206-84cf-e3921b21b4b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f2736b4-50b6-4ed4-a670-f103257d4940"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e0336b6-3914-480c-9256-69a06a517214"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d8ba587-c2f3-40dc-9ead-45b4b4701e50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7612b1ba-2d25-43ca-a834-cdfc2cd4f296"));

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
                table: "RefreshTokens",
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
                table: "BillingoClients",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddressed",
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
                table: "BankTransfers",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BankTransferBillingAddresses",
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
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    Message = table.Column<string>(nullable: false),
                    IsOpened = table.Column<bool>(nullable: false),
                    ReceiverId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("59c568ee-c119-4928-8bb5-43c6f49cb9fd"), new DateTime(2021, 2, 16, 14, 26, 43, 925, DateTimeKind.Local).AddTicks(6322), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("4b639f52-a12f-4bf3-936d-4b6b12e30e0b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5853), new DateTime(2021, 2, 16, 14, 27, 43, 926, DateTimeKind.Local).AddTicks(7182), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0689e551-d628-44ec-aa2e-8468f83cc1a5"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(8209), new DateTime(2021, 2, 16, 14, 27, 43, 926, DateTimeKind.Local).AddTicks(8248), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("ea1f00fc-2c01-4cd5-91e6-79e9f40ffceb"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 2, 16, 14, 27, 43, 926, DateTimeKind.Local).AddTicks(8275), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("d5f95782-f1c0-48a4-ae59-bf43e11bb778"), new DateTime(2021, 2, 16, 14, 26, 43, 921, DateTimeKind.Local).AddTicks(5996), true, true, "GTA" },
                    { new Guid("44c9c3bd-edba-4f7c-9375-9b49a9a32a84"), new DateTime(2021, 2, 16, 14, 26, 43, 924, DateTimeKind.Local).AddTicks(5088), true, true, "Survival" },
                    { new Guid("ea8255f3-13a2-4678-9193-bedd7b76fdca"), new DateTime(2021, 2, 16, 14, 26, 43, 924, DateTimeKind.Local).AddTicks(5135), true, true, "Skyblock" },
                    { new Guid("4764b46c-c53f-46b1-9fe2-a957c6e9f9d9"), new DateTime(2021, 2, 16, 14, 26, 43, 924, DateTimeKind.Local).AddTicks(5141), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("353f6e8c-d702-45ba-9122-4bb15c93f03e"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2490), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f306dd6a-8dff-42ff-9e8a-cd27ada79db1"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2498), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f2cacfe2-21c0-4891-9edd-b9f47db42079"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2506), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fa13a9c5-cd5c-4814-93ff-44c51169490d"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2523), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("833d5909-9473-44fd-ba01-1b77b3453d46"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2553), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c06450f7-e217-4b2b-91b4-eac34335d22a"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2538), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9273261a-dc88-43bc-9bf4-81a69eeb0f7b"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2546), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2226d447-7eda-4ddb-a60e-e5a08e6cd72d"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2483), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4e28be67-9a7f-46dc-8033-a8e80f72e1cf"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2561), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("843d18ab-4d93-4313-8705-24acaae7068b"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2531), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5a28e0e4-a704-419f-ab16-a03dca2e7a0b"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2475), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6b08458a-f3b9-40b0-a418-4508210ce614"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2513), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("46fd3b67-7550-4d5d-99f0-10cdc766dd46"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2460), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae6a7a95-367b-4f7e-8d31-3b46f81028ac"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2450), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("09c9a984-986d-4cd3-8e3f-1c1d8371799f"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2442), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("506cf7a2-4459-4cc1-8498-c94d1a42fccc"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2435), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("acdfb88d-4023-4f36-b4eb-843ed6901f39"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2427), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c6bd7909-c45b-42d3-b7b9-a22ab6111773"), new DateTime(2021, 1, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2419), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5dd812d2-454e-46fd-9c17-ce85dc554fa7"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2411), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2ac0badb-9869-49dc-a25f-befce818737f"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2404), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("65892bad-b675-4fb9-a425-3fa71804f3fc"), new DateTime(2020, 11, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2396), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1b3220f1-55fd-4751-ad84-0112094a84c5"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2380), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("84960fcf-a4d6-45b1-a44b-793ff75664a0"), new DateTime(2020, 10, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2272), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6c834214-2489-4988-aea0-0bd224a5b136"), new DateTime(2020, 12, 16, 14, 26, 43, 928, DateTimeKind.Local).AddTicks(2467), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("aae8e37b-9720-4d9e-9d2b-48900cfbaa56"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(9768), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("678e43b7-496d-407d-a0ca-031dee1a6dd4"), new DateTime(2021, 2, 16, 14, 25, 3, 927, DateTimeKind.Local).AddTicks(9753), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("26664e22-16d0-4c6b-bb70-fd1979a6f8b2"), new DateTime(2021, 2, 16, 14, 25, 53, 927, DateTimeKind.Local).AddTicks(9761), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("70fa8cfb-a1b2-42c7-ad06-05aab9c77870"), new DateTime(2021, 2, 16, 14, 23, 23, 927, DateTimeKind.Local).AddTicks(9173), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("1fcb43d4-60f3-4d1e-9a1c-d075280dbb53"), new DateTime(2021, 2, 16, 14, 24, 13, 927, DateTimeKind.Local).AddTicks(9738), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("434b4df3-c180-4439-a9f6-f524db43d471"), new Guid("79f9a880-5a9a-49cb-8d7e-b705051002fc"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5722), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c9ffff02-d874-4e11-8caa-50ea7617a938"), new Guid("a87f472b-fb72-49a5-a64c-9b9dfb43d7c0"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(6722), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("a24fc238-4970-4467-8a43-29dc1a613e02"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(4905), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ddcf5478-686c-490f-9edd-398dd8237282"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5004), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cd832b02-7f27-4a0d-8de5-139c2d14bf39"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5012), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e895af9c-95ea-437f-87e0-7d1e6d614a51"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5022), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("729ec07d-ae57-4dfc-9dcc-e0a6d967d169"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(569), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("3dce9a97-565b-40b7-9ac7-b96a1cda92f9"), new DateTime(2021, 2, 16, 14, 26, 43, 927, DateTimeKind.Local).AddTicks(5017), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 925, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 16, 14, 26, 43, 925, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(436), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(2194), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5033), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5038), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(4930), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(4973), new DateTime(2021, 2, 16, 14, 26, 43, 926, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("59c568ee-c119-4928-8bb5-43c6f49cb9fd"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("0689e551-d628-44ec-aa2e-8468f83cc1a5"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("4b639f52-a12f-4bf3-936d-4b6b12e30e0b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("ea1f00fc-2c01-4cd5-91e6-79e9f40ffceb"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("44c9c3bd-edba-4f7c-9375-9b49a9a32a84"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("4764b46c-c53f-46b1-9fe2-a957c6e9f9d9"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d5f95782-f1c0-48a4-ae59-bf43e11bb778"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ea8255f3-13a2-4678-9193-bedd7b76fdca"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("09c9a984-986d-4cd3-8e3f-1c1d8371799f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1b3220f1-55fd-4751-ad84-0112094a84c5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2226d447-7eda-4ddb-a60e-e5a08e6cd72d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2ac0badb-9869-49dc-a25f-befce818737f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("353f6e8c-d702-45ba-9122-4bb15c93f03e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("46fd3b67-7550-4d5d-99f0-10cdc766dd46"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4e28be67-9a7f-46dc-8033-a8e80f72e1cf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("506cf7a2-4459-4cc1-8498-c94d1a42fccc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5a28e0e4-a704-419f-ab16-a03dca2e7a0b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5dd812d2-454e-46fd-9c17-ce85dc554fa7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("65892bad-b675-4fb9-a425-3fa71804f3fc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6b08458a-f3b9-40b0-a418-4508210ce614"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6c834214-2489-4988-aea0-0bd224a5b136"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("833d5909-9473-44fd-ba01-1b77b3453d46"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("843d18ab-4d93-4313-8705-24acaae7068b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("84960fcf-a4d6-45b1-a44b-793ff75664a0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9273261a-dc88-43bc-9bf4-81a69eeb0f7b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("acdfb88d-4023-4f36-b4eb-843ed6901f39"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ae6a7a95-367b-4f7e-8d31-3b46f81028ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c06450f7-e217-4b2b-91b4-eac34335d22a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c6bd7909-c45b-42d3-b7b9-a22ab6111773"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f2cacfe2-21c0-4891-9edd-b9f47db42079"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f306dd6a-8dff-42ff-9e8a-cd27ada79db1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fa13a9c5-cd5c-4814-93ff-44c51169490d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1fcb43d4-60f3-4d1e-9a1c-d075280dbb53"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("26664e22-16d0-4c6b-bb70-fd1979a6f8b2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("678e43b7-496d-407d-a0ca-031dee1a6dd4"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("70fa8cfb-a1b2-42c7-ad06-05aab9c77870"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("aae8e37b-9720-4d9e-9d2b-48900cfbaa56"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("434b4df3-c180-4439-a9f6-f524db43d471"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("c9ffff02-d874-4e11-8caa-50ea7617a938"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dce9a97-565b-40b7-9ac7-b96a1cda92f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("729ec07d-ae57-4dfc-9dcc-e0a6d967d169"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a24fc238-4970-4467-8a43-29dc1a613e02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd832b02-7f27-4a0d-8de5-139c2d14bf39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddcf5478-686c-490f-9edd-398dd8237282"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e895af9c-95ea-437f-87e0-7d1e6d614a51"));

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
                table: "RefreshTokens",
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
                table: "BillingoClients",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddressed",
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
                table: "BankTransfers",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BankTransferBillingAddresses",
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
                values: new object[] { new Guid("063c08ea-d64f-46a8-88db-92857cce011e"), new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(3947), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("7eeb5534-1479-4228-a68b-78201170827d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(3068), new DateTime(2021, 2, 15, 22, 31, 12, 746, DateTimeKind.Local).AddTicks(4310), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("d6032798-1573-42c1-baf3-bfa1730d6818"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(5277), new DateTime(2021, 2, 15, 22, 31, 12, 746, DateTimeKind.Local).AddTicks(5306), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("9e98f1e8-c93a-4079-bf12-6ca1aa8cdd34"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(5327), new DateTime(2021, 2, 15, 22, 31, 12, 746, DateTimeKind.Local).AddTicks(5330), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("6b29e9af-820d-45b2-9c8d-25d103377b6a"), new DateTime(2021, 2, 15, 22, 30, 12, 741, DateTimeKind.Local).AddTicks(3457), true, true, "GTA" },
                    { new Guid("7fc82764-def8-410c-a2bd-db92b3e9facf"), new DateTime(2021, 2, 15, 22, 30, 12, 744, DateTimeKind.Local).AddTicks(2595), true, true, "Survival" },
                    { new Guid("40ef2b11-6295-448d-a853-737dcbf55af5"), new DateTime(2021, 2, 15, 22, 30, 12, 744, DateTimeKind.Local).AddTicks(2642), true, true, "Skyblock" },
                    { new Guid("0b3db5a1-41cb-4a79-a826-d0342a41cfd5"), new DateTime(2021, 2, 15, 22, 30, 12, 744, DateTimeKind.Local).AddTicks(2649), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("40763ab5-f691-4425-b245-eb6ed6a1c547"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8918), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("468cdf61-5221-46a2-92a0-1dff677581b7"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8925), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1ffabc7e-9530-43e7-9af4-a216f5995ae3"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8933), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2de2145e-0e7e-47dc-a063-9af4bdb95131"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8949), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("04793bc4-3802-4254-bccd-38a41083fc43"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8979), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("efce2569-13a6-4f1f-9e13-fc07a5893780"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8964), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9bee088b-6a0f-4bc8-a714-1ce9474e6669"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8972), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("13d7c203-b6f3-4817-a395-702797bf8646"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8910), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("29ca66a5-114b-421a-95e7-0e5e66146233"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8987), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9b255ddd-5beb-454e-8ea4-9e2b9c68f300"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8957), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("211f8c0c-5ba2-4eef-91b2-5521e8090ea0"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8902), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0f1a79e5-3daa-4e8f-bf74-6ff8158225d2"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8940), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("88224dce-0f91-461a-a56b-d489691d28eb"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8887), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fcb055e7-87df-4007-bac0-87198304e22c"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8877), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ef5d7ec-3b7e-42b5-8f4d-66fd9f1b81ac"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8870), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ae3e0752-a236-4a73-a520-c82145dcb51e"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8863), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("60dcb2e1-f4b7-49f3-b497-53d1aa1628b5"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8855), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b81abd95-6d86-47ca-a541-99c400623262"), new DateTime(2021, 1, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8847), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d5780007-a337-445b-bc51-be0e02509914"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8839), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("eb6ed58d-c12b-4d92-ab23-c25c1c6d2ab7"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8831), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9bdf8b75-6d8b-4d35-92b4-e61666758087"), new DateTime(2020, 11, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8823), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("65cfaa80-c075-4acd-a9c5-44b623a30470"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8808), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28aaee62-f2fa-43d2-8a18-fac8e66cc8e9"), new DateTime(2020, 10, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8711), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9aa23d46-8ca2-4304-b6cf-040f917c775d"), new DateTime(2020, 12, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(8895), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("98c01085-883c-44d7-b5bd-13204b717079"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(6419), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("46debc89-7360-4b78-b43f-114763c1b73b"), new DateTime(2021, 2, 15, 22, 28, 32, 747, DateTimeKind.Local).AddTicks(6405), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("f34bde09-46fa-4934-bef2-6b99eb6e437d"), new DateTime(2021, 2, 15, 22, 29, 22, 747, DateTimeKind.Local).AddTicks(6412), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("95f1c3e5-88ca-473e-a032-85e96d58b887"), new DateTime(2021, 2, 15, 22, 26, 52, 747, DateTimeKind.Local).AddTicks(5852), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("695c549e-33fe-4681-9ac3-1f96a1e3ebea"), new DateTime(2021, 2, 15, 22, 27, 42, 747, DateTimeKind.Local).AddTicks(6390), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f824b540-66fb-495d-960e-a3078cb06574"), new Guid("ac610d79-2109-421a-806e-0fea9c5ebef6"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(2550), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("083d5b40-b214-4ed3-858e-eae87e491dc0"), new Guid("4813e356-c057-42d8-8ae4-c61683c69074"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(3515), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("2cd160a5-fa98-4206-84cf-e3921b21b4b2"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1752), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6d8ba587-c2f3-40dc-9ead-45b4b4701e50"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1849), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0ed39aa6-cf39-4621-b49a-20d2564d055a"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1855), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7612b1ba-2d25-43ca-a834-cdfc2cd4f296"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1866), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5e0336b6-3914-480c-9256-69a06a517214"), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(7477), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4f2736b4-50b6-4ed4-a670-f103257d4940"), new DateTime(2021, 2, 15, 22, 30, 12, 747, DateTimeKind.Local).AddTicks(1861), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(7951), new DateTime(2021, 2, 15, 22, 30, 12, 745, DateTimeKind.Local).AddTicks(9623), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2371), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2376), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2273), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2315), new DateTime(2021, 2, 15, 22, 30, 12, 746, DateTimeKind.Local).AddTicks(2329) });
        }
    }
}
