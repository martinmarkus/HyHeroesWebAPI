using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class edsmsupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("d305ee76-f080-4a79-ac35-3d0d9f04117d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("01335e9f-43d0-42cb-b92e-bb2c29560e24"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("315007d2-f9da-4920-8cae-74a88b538bc6"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bffc1bb5-b2a2-486c-92ad-54fbd268397d"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("533a445e-5e37-49a4-aee3-951683c1ec7a"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("68a9f1d2-d935-41c6-9758-2ffc5e5a7424"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("cf4608d3-0b9d-475f-961c-cc4ee5eb8081"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d33cc6d3-9ad7-4ff8-9bc0-ea047c616a5f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("08eb4bff-8103-41ef-a014-2abc061e7583"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0924befa-eb01-4862-9ca8-4ee7488d9691"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("18cd576d-3bb5-4d62-9174-ca2324f43dfd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1d030e70-c213-456e-8b75-bfca3c7b5dc2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("29c78304-80b8-4d4e-9400-bcf0fc88ae8d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2fcba9d6-070b-4b7e-85c0-7ce7f007ccfa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("36b8e506-3c8c-4486-9ffa-c4186a09a7d3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("394067de-3eea-4e73-9f29-a659c49b4c92"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3e80b8cd-991e-49ac-a58b-cde9191de2c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("406e3b93-b0c1-4324-867a-77b33298adf9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4f253bbc-f505-42b9-bb15-4a7f85c650ac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("50d036b2-dc1f-4040-a171-758b70918d07"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5817dc13-c871-4ef4-93b4-5d36577fd597"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("687c83fe-b710-45ee-b6c8-b418e440ef43"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6c0f829c-95e1-4b48-b298-5d10d6132644"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6d6f9c67-ce6a-46c2-b071-1b7f46cc6b3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("83344f22-4fd6-4154-a955-24661b67b210"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b651e0db-4395-4874-9a07-26d6252afb7e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c181281c-c554-4d17-989b-a9ae4ae61232"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cca19aed-5586-43f7-a6b3-b2b981a2069f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd30132b-f2b6-4328-b9bf-223e25210e4f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f52430d7-26b5-4c6e-a933-e3b4937f5e00"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f5585a47-7b95-4ab9-8ca3-0ebbe5780812"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f561b462-65ff-408f-b67f-219e8f7f081d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1a7f759e-a84f-4cf1-940f-d18415973fa1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("95b6bf6c-88f0-49ee-9b3c-35753bf6a4a8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9ba9edc3-5785-4da7-986a-e2f6468a8ef1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e5d08294-84de-4373-b187-e4f4975c5085"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f4bf01ee-7eb1-4bdc-ab8d-357b403444d3"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("bf4c3928-f96f-48b3-870d-91d1310be838"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("e9838a29-1b80-4538-9f1f-5ab1857ac496"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("697f7f3d-45c1-4023-9c93-7252f4e6ff22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81955be4-be11-438d-b1ea-1fe8ca3728dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91dc868a-ecef-42d7-b21a-8bb475af3b99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1c532d7-91fe-4908-ba87-213c1aaedbdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb09cd43-9ba5-4fe1-99cb-ba56e214e73e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f77adf85-26a4-409b-b716-9e41ee0bad6d"));

            migrationBuilder.DropColumn(
                name: "CustomerPhoneNumber",
                table: "EDSMSPurchases");

            migrationBuilder.DropColumn(
                name: "IsTest",
                table: "EDSMSPurchases");

            migrationBuilder.DropColumn(
                name: "JatekFizetesId",
                table: "EDSMSPurchases");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "EDSMSPurchases");

            migrationBuilder.DropColumn(
                name: "Prefix",
                table: "EDSMSPurchases");

            migrationBuilder.DropColumn(
                name: "ReceiverPhoneNumber",
                table: "EDSMSPurchases");

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

            migrationBuilder.AlterColumn<int>(
                name: "GrossPrice",
                table: "EDSMSPurchases",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivationCode",
                table: "EDSMSPurchases",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("780a45d3-da89-4aa8-9d88-838d2613d65b"), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(1271), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("bfc1a1c6-d800-48df-8e7b-5317ec494e38"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(114), new DateTime(2021, 1, 30, 13, 24, 42, 531, DateTimeKind.Local).AddTicks(1377), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("46ee5da0-1516-48ec-8f6e-d3a629160b20"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 1, 30, 13, 24, 42, 531, DateTimeKind.Local).AddTicks(2404), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("a84fdd0a-2963-4b4c-993b-d8fb4667e319"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 1, 30, 13, 24, 42, 531, DateTimeKind.Local).AddTicks(2428), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("8bbb1113-cd22-4495-8ff7-f50f4c489d65"), new DateTime(2021, 1, 30, 12, 24, 42, 526, DateTimeKind.Local).AddTicks(1206), true, true, "GTA" },
                    { new Guid("d0d84fc5-829a-4082-8429-d64d5d58c18e"), new DateTime(2021, 1, 30, 12, 24, 42, 528, DateTimeKind.Local).AddTicks(9600), true, true, "Survival" },
                    { new Guid("26e6ed1a-d70e-41a4-b921-af14dd71f63e"), new DateTime(2021, 1, 30, 12, 24, 42, 528, DateTimeKind.Local).AddTicks(9645), true, true, "Skyblock" },
                    { new Guid("f51870ab-6592-4ae3-adfe-69d0ead426cc"), new DateTime(2021, 1, 30, 12, 24, 42, 528, DateTimeKind.Local).AddTicks(9651), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("6fbd51c1-baa8-4c8e-9400-e5b136760483"), new DateTime(2020, 12, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6504), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2c50df04-9691-4145-a318-36cfbad07ee4"), new DateTime(2020, 9, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6511), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9d8cdf06-26f1-47af-9ebe-459575eccf28"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6521), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cb3fb0c1-06d8-4a21-8032-65bec17670a1"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6536), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("97fc077e-89bf-4ea7-b131-11fb3326ed37"), new DateTime(2020, 12, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6567), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f0f5f5ef-d8de-4f89-856e-6054412544c4"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6552), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9ad0ced8-6869-4cf8-b780-19578045b580"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6559), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9a342b88-6a96-44ee-a443-de1972fa1c51"), new DateTime(2020, 12, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6496), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("df584cd0-9803-425e-81c1-53060c30909d"), new DateTime(2020, 12, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6574), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aff88aa5-1b62-4dad-b14f-7287d244c66b"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6544), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("56130034-61e9-4f7b-a9ed-ac1416e6d6ef"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6489), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9d9dfb27-4eb0-4e75-ab39-07e64847496c"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6529), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a01828f2-969b-4359-a690-05b64bf6d682"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6472), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("97a3fd91-fbf8-4ebb-ac5d-52033cd9b2c4"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6421), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e8389659-30ae-4fe5-95b9-647a29b47da4"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6412), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("daf9bb84-3506-4393-8e06-9c77b1e200f2"), new DateTime(2020, 9, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6400), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("912b0868-87f5-4d8d-8900-592a5aa57cdc"), new DateTime(2020, 9, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6392), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ba7ed486-79c6-4ed6-a941-8d136bc10540"), new DateTime(2020, 12, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6384), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("57fbc940-e120-4a60-8e18-febff200ebf9"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6376), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("39d8bbae-433b-42c9-b70d-741af0c78a23"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6367), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4b047c24-d59f-4964-a2f8-e0d7b9aeaa21"), new DateTime(2020, 10, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6359), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6b48a54d-d504-48d4-ab13-719b0149faac"), new DateTime(2020, 9, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6349), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5cb4a5cf-51fc-4b33-b8a8-571595da0b1d"), new DateTime(2020, 9, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6238), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a6935441-6172-4c4d-8500-4fbdb7ad1f04"), new DateTime(2020, 11, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(6480), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("513ed8c1-2095-4cf6-bed1-c04111e6ef01"), new DateTime(2021, 1, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(3799), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("6997d9c6-82d5-4682-a9eb-87dd81958777"), new DateTime(2021, 1, 30, 12, 23, 2, 532, DateTimeKind.Local).AddTicks(3784), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("79cda250-bfde-43bc-a57b-9a2dd5e0c26f"), new DateTime(2021, 1, 30, 12, 23, 52, 532, DateTimeKind.Local).AddTicks(3792), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("89f7de36-df93-417f-bdb0-95f3f07cf7b8"), new DateTime(2021, 1, 30, 12, 21, 22, 532, DateTimeKind.Local).AddTicks(3209), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("716a74ba-165a-4337-8846-d9ec0df88f5a"), new DateTime(2021, 1, 30, 12, 22, 12, 532, DateTimeKind.Local).AddTicks(3770), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ee16eea1-a7c2-4859-bc73-2e8af78a4e36"), new Guid("23047dda-5625-43a9-8f11-1a7c549c6e95"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(9811), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("15a724dd-f628-4beb-84a9-9757d1177a44"), new Guid("5d9690f6-baff-4c0e-9673-64b46f12a78b"), new DateTime(2021, 1, 30, 12, 24, 42, 532, DateTimeKind.Local).AddTicks(823), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("7c2c1f2c-029f-4a88-a858-f5e50765d437"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(8989), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ad96c416-1004-426b-b21f-df47632e1ac4"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(9084), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7930064f-0a12-411e-805f-b032b5fd65f1"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(9092), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("22756bf5-76ce-4f61-b564-65a3cc999fa9"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(9105), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("69221eec-4436-40e4-a6bd-acde5c1d7f67"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(4611), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7256aaf2-438e-44e1-b8e7-3cb5d516ae91"), new DateTime(2021, 1, 30, 12, 24, 42, 531, DateTimeKind.Local).AddTicks(9099), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(4890), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(6597), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(9408), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(9413), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(9301), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(9356), new DateTime(2021, 1, 30, 12, 24, 42, 530, DateTimeKind.Local).AddTicks(9372) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("780a45d3-da89-4aa8-9d88-838d2613d65b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("46ee5da0-1516-48ec-8f6e-d3a629160b20"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a84fdd0a-2963-4b4c-993b-d8fb4667e319"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("bfc1a1c6-d800-48df-8e7b-5317ec494e38"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("26e6ed1a-d70e-41a4-b921-af14dd71f63e"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("8bbb1113-cd22-4495-8ff7-f50f4c489d65"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d0d84fc5-829a-4082-8429-d64d5d58c18e"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("f51870ab-6592-4ae3-adfe-69d0ead426cc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2c50df04-9691-4145-a318-36cfbad07ee4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("39d8bbae-433b-42c9-b70d-741af0c78a23"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4b047c24-d59f-4964-a2f8-e0d7b9aeaa21"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("56130034-61e9-4f7b-a9ed-ac1416e6d6ef"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("57fbc940-e120-4a60-8e18-febff200ebf9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5cb4a5cf-51fc-4b33-b8a8-571595da0b1d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6b48a54d-d504-48d4-ab13-719b0149faac"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6fbd51c1-baa8-4c8e-9400-e5b136760483"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("912b0868-87f5-4d8d-8900-592a5aa57cdc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("97a3fd91-fbf8-4ebb-ac5d-52033cd9b2c4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("97fc077e-89bf-4ea7-b131-11fb3326ed37"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9a342b88-6a96-44ee-a443-de1972fa1c51"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9ad0ced8-6869-4cf8-b780-19578045b580"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9d8cdf06-26f1-47af-9ebe-459575eccf28"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9d9dfb27-4eb0-4e75-ab39-07e64847496c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a01828f2-969b-4359-a690-05b64bf6d682"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a6935441-6172-4c4d-8500-4fbdb7ad1f04"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aff88aa5-1b62-4dad-b14f-7287d244c66b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ba7ed486-79c6-4ed6-a941-8d136bc10540"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cb3fb0c1-06d8-4a21-8032-65bec17670a1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("daf9bb84-3506-4393-8e06-9c77b1e200f2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("df584cd0-9803-425e-81c1-53060c30909d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e8389659-30ae-4fe5-95b9-647a29b47da4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f0f5f5ef-d8de-4f89-856e-6054412544c4"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("513ed8c1-2095-4cf6-bed1-c04111e6ef01"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("6997d9c6-82d5-4682-a9eb-87dd81958777"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("716a74ba-165a-4337-8846-d9ec0df88f5a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("79cda250-bfde-43bc-a57b-9a2dd5e0c26f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("89f7de36-df93-417f-bdb0-95f3f07cf7b8"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("15a724dd-f628-4beb-84a9-9757d1177a44"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("ee16eea1-a7c2-4859-bc73-2e8af78a4e36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22756bf5-76ce-4f61-b564-65a3cc999fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69221eec-4436-40e4-a6bd-acde5c1d7f67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7256aaf2-438e-44e1-b8e7-3cb5d516ae91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7930064f-0a12-411e-805f-b032b5fd65f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c2c1f2c-029f-4a88-a858-f5e50765d437"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad96c416-1004-426b-b21f-df47632e1ac4"));

            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "EDSMSPurchases");

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

            migrationBuilder.AlterColumn<string>(
                name: "GrossPrice",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "CustomerPhoneNumber",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsTest",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JatekFizetesId",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prefix",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverPhoneNumber",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

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
                values: new object[] { new Guid("d305ee76-f080-4a79-ac35-3d0d9f04117d"), new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(2095), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("315007d2-f9da-4920-8cae-74a88b538bc6"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(1500), new DateTime(2021, 1, 29, 23, 41, 26, 477, DateTimeKind.Local).AddTicks(2728), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("bffc1bb5-b2a2-486c-92ad-54fbd268397d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(3697), new DateTime(2021, 1, 29, 23, 41, 26, 477, DateTimeKind.Local).AddTicks(3732), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("01335e9f-43d0-42cb-b92e-bb2c29560e24"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(3755), new DateTime(2021, 1, 29, 23, 41, 26, 477, DateTimeKind.Local).AddTicks(3758), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("cf4608d3-0b9d-475f-961c-cc4ee5eb8081"), new DateTime(2021, 1, 29, 22, 41, 26, 472, DateTimeKind.Local).AddTicks(720), true, true, "GTA" },
                    { new Guid("d33cc6d3-9ad7-4ff8-9bc0-ea047c616a5f"), new DateTime(2021, 1, 29, 22, 41, 26, 475, DateTimeKind.Local).AddTicks(777), true, true, "Survival" },
                    { new Guid("68a9f1d2-d935-41c6-9758-2ffc5e5a7424"), new DateTime(2021, 1, 29, 22, 41, 26, 475, DateTimeKind.Local).AddTicks(830), true, true, "Skyblock" },
                    { new Guid("533a445e-5e37-49a4-aee3-951683c1ec7a"), new DateTime(2021, 1, 29, 22, 41, 26, 475, DateTimeKind.Local).AddTicks(836), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("cca19aed-5586-43f7-a6b3-b2b981a2069f"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9600), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6c0f829c-95e1-4b48-b298-5d10d6132644"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9607), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b651e0db-4395-4874-9a07-26d6252afb7e"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9618), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f52430d7-26b5-4c6e-a933-e3b4937f5e00"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9632), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4f253bbc-f505-42b9-bb15-4a7f85c650ac"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9661), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("406e3b93-b0c1-4324-867a-77b33298adf9"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9647), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2fcba9d6-070b-4b7e-85c0-7ce7f007ccfa"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9654), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0924befa-eb01-4862-9ca8-4ee7488d9691"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9592), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("18cd576d-3bb5-4d62-9174-ca2324f43dfd"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9669), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5817dc13-c871-4ef4-93b4-5d36577fd597"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9639), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3e80b8cd-991e-49ac-a58b-cde9191de2c0"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9585), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("29c78304-80b8-4d4e-9400-bcf0fc88ae8d"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9625), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f5585a47-7b95-4ab9-8ca3-0ebbe5780812"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9570), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("687c83fe-b710-45ee-b6c8-b418e440ef43"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9562), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("83344f22-4fd6-4154-a955-24661b67b210"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9554), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("50d036b2-dc1f-4040-a171-758b70918d07"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9540), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1d030e70-c213-456e-8b75-bfca3c7b5dc2"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9533), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6d6f9c67-ce6a-46c2-b071-1b7f46cc6b3f"), new DateTime(2020, 12, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9526), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("08eb4bff-8103-41ef-a014-2abc061e7583"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9518), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f561b462-65ff-408f-b67f-219e8f7f081d"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9510), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd30132b-f2b6-4328-b9bf-223e25210e4f"), new DateTime(2020, 10, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9501), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("394067de-3eea-4e73-9f29-a659c49b4c92"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9490), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c181281c-c554-4d17-989b-a9ae4ae61232"), new DateTime(2020, 9, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9365), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("36b8e506-3c8c-4486-9ffa-c4186a09a7d3"), new DateTime(2020, 11, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(9577), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("95b6bf6c-88f0-49ee-9b3c-35753bf6a4a8"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(6771), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("1a7f759e-a84f-4cf1-940f-d18415973fa1"), new DateTime(2021, 1, 29, 22, 39, 46, 478, DateTimeKind.Local).AddTicks(6754), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("9ba9edc3-5785-4da7-986a-e2f6468a8ef1"), new DateTime(2021, 1, 29, 22, 40, 36, 478, DateTimeKind.Local).AddTicks(6761), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("f4bf01ee-7eb1-4bdc-ab8d-357b403444d3"), new DateTime(2021, 1, 29, 22, 38, 6, 478, DateTimeKind.Local).AddTicks(6104), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("e5d08294-84de-4373-b187-e4f4975c5085"), new DateTime(2021, 1, 29, 22, 38, 56, 478, DateTimeKind.Local).AddTicks(6736), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("bf4c3928-f96f-48b3-870d-91d1310be838"), new Guid("11fbb629-0472-4b52-8cbc-e4b6a3377f10"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(1672), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e9838a29-1b80-4538-9f1f-5ab1857ac496"), new Guid("5b7a2add-bc94-4f27-9452-4f9800b4bc92"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(3267), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("91dc868a-ecef-42d7-b21a-8bb475af3b99"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(810), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("c1c532d7-91fe-4908-ba87-213c1aaedbdd"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(918), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("697f7f3d-45c1-4023-9c93-7252f4e6ff22"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(927), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("cb09cd43-9ba5-4fe1-99cb-ba56e214e73e"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(983), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("81955be4-be11-438d-b1ea-1fe8ca3728dc"), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(5866), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("f77adf85-26a4-409b-b716-9e41ee0bad6d"), new DateTime(2021, 1, 29, 22, 41, 26, 478, DateTimeKind.Local).AddTicks(977), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(6369), new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(8072), new DateTime(2021, 1, 29, 22, 41, 26, 476, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(817), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(821), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(703), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(756), new DateTime(2021, 1, 29, 22, 41, 26, 477, DateTimeKind.Local).AddTicks(774) });
        }
    }
}
