using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BillingoRefactor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("0790261f-0357-45fb-aa86-42dabb1276ba"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("a0a140eb-cea7-4296-a5fd-69fc5d15838d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("aa4c6870-96bf-4830-8849-5639aa5a4b93"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("42a06c00-48dd-41b8-9ab5-e7ce6841b9dd"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("beae7616-1d64-4104-beb5-8596f499876c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("fa63a211-3cc2-49cd-8ed6-a69c07efb8ec"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("fc2766bc-7813-4f03-80e7-8003aa9dc371"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("09b53fd9-008a-410b-a073-85952d326008"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("11b4bfbc-31e1-46bd-942e-a51bd9b84710"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("133992bb-ba88-4234-bd46-16a9ceced624"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1b8d5875-ee62-495f-a079-e05595cb730d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("1fd26100-4f3c-45e6-a83a-acca426e4f3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2a94045d-bd6d-4b8c-8678-6a6787b3814d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2e4a2687-1574-47ef-b9a7-ca99f11c9dde"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3564161c-c44e-4d28-bf2a-a6013b8b4840"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4be249db-34a8-4ec0-b9d7-61adfe411fdf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4bf745f4-c791-4251-8ef3-a9593d47dced"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("58e06cdf-f9d0-4fb7-ad99-b5ffd01b2c9f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5c4cabd5-8d2b-44e2-9c1b-381af4c8821b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7b990ef5-a790-46eb-866b-35b60545297c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8b69c041-1057-4b87-b96d-cc0f2f97f3b8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8e1441b9-5540-4bfc-9443-64c40423589e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a7b1c91f-eb75-4e6b-a4d2-d6a654c32e7d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("afe4aeda-52a6-4440-8631-178bd410cf75"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c3a02d27-fd88-4812-9009-9059109ad1d1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d6f46293-5e58-4312-afcf-4f5ec8e659ca"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dad7f5a3-2ceb-4d26-8b7f-adbc3cc29fc9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("db283539-3872-4eca-887b-0c6f7773cfc7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e10886d5-4e22-48ad-a419-42a6c7616110"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ed56c8dd-bf03-4787-9beb-e84af158c0a7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f4366fa9-0454-4eac-b226-2e5d87c0f925"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("082a1c20-8b7b-4e4d-af12-b968967d1dd8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5e568d60-99d7-4c37-92c2-28014bcb45d5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("64eddab4-a36c-4b46-b923-f0e4a04ceb8f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b99c7902-38e3-4db7-a7cb-ce10f7ff3d40"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f7e5b1af-d66a-437b-8e19-e964ba4eb289"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("8e95fc7a-1cc7-42de-8285-45e9e7bfd03e"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("b93b8021-dde4-4a6d-827c-ae7fba30b43f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf47f4c-ede4-4b62-982d-641e341831a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15bddacd-6373-4555-ab66-220355d59515"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ee11ead-9f5a-4fad-bded-663472dfb0e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d9fde00-769d-4e78-a6fc-bc11d47b51a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("958b003d-0db7-4805-85db-74eb793bd17e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a657269f-7ec6-4ece-8cff-3296c55884cd"));

            migrationBuilder.DropColumn(
                name: "VevoAdoszam",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoAzonosito",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoCim",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoEmail",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoIrsz",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoMegjegyzes",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoNev",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoOrszagKod",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoPostazasiCim",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoPostazasiIrsz",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoPostazasiNev",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoPostazasiTelepules",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoSendEmail",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoTelefonszam",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "VevoTelepules",
                table: "BillingTransactions");

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
                table: "Notifications",
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientEmail",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Taxnumber",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "BillingTransactions",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoPartners",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoDocuments",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddresses",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBankAccounts",
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

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("52e8f883-a5a2-40d7-adbc-17ff333559cb"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(4422), new DateTime(2021, 2, 19, 11, 4, 3, 979, DateTimeKind.Local).AddTicks(5686), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("e295ec64-a7d0-4532-8ba2-c3dc0f76e9f4"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(6687), new DateTime(2021, 2, 19, 11, 4, 3, 979, DateTimeKind.Local).AddTicks(6715), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("16e28716-b299-456d-aa1e-7302894d57f3"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(6735), new DateTime(2021, 2, 19, 11, 4, 3, 979, DateTimeKind.Local).AddTicks(6738), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("649d0e27-830c-4f8f-b83c-505e1ed1fdde"), new DateTime(2021, 2, 19, 11, 3, 3, 974, DateTimeKind.Local).AddTicks(6335), true, true, "GTA" },
                    { new Guid("4ea69324-8b76-42ba-a672-6877e3406249"), new DateTime(2021, 2, 19, 11, 3, 3, 977, DateTimeKind.Local).AddTicks(4953), true, true, "Survival" },
                    { new Guid("7c658d55-948b-494b-8d5d-304158d90f15"), new DateTime(2021, 2, 19, 11, 3, 3, 977, DateTimeKind.Local).AddTicks(5004), true, true, "Skyblock" },
                    { new Guid("630b471c-1444-42a2-8e5e-9dcf3df3ff93"), new DateTime(2021, 2, 19, 11, 3, 3, 977, DateTimeKind.Local).AddTicks(5010), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d9bd3ed-439d-4653-a75f-abb6592ed163"), new DateTime(2021, 1, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(990), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3cf2e35c-67e0-4120-9f6d-91a3753480dd"), new DateTime(2020, 10, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1001), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2ca1bbe6-acb3-4e26-8bec-5227cf8af637"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1010), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("35543958-527a-4f1f-901a-65dd967f424a"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1017), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d5a93bcc-d844-4cc9-9086-cc43bec7189a"), new DateTime(2021, 1, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1058), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5015ab21-e09e-4292-8f25-c81e6c2e82c0"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1042), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a1a0944e-deb4-4235-b8ac-4161898bef38"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1050), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("59f796e4-8db9-42c4-9ac5-a6ad47436e12"), new DateTime(2021, 1, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(982), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ca5e96f-2678-4f58-9c3c-e68393ed00fe"), new DateTime(2021, 1, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1068), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8c1276f7-2e55-4323-82a8-f37ce12d2ca3"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1034), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("32704bfa-13a9-4b99-9e76-bfc225a5883d"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(975), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9521e3c0-25ec-4e37-8572-94a53c1906ba"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(1026), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("92dbe35e-91fa-467a-a53c-34469e4ab99c"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(957), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a8c3dec3-f4e6-4f8b-b073-1ea9fa46dcb6"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(948), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("33f2d2bd-5b0e-4fd6-916f-5b25033c6add"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(940), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ec6e5c4b-43fc-41f7-9b18-bab6a1e91b98"), new DateTime(2020, 10, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(932), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cf8b045b-51ce-4c17-b2bd-ebafc2d3101d"), new DateTime(2020, 10, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(918), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ad5d8f52-91e8-489a-9a7b-204735ef7cd6"), new DateTime(2021, 1, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(907), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("72aa6284-37c0-403c-805e-f8d55acfe302"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(900), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d514a07d-f7fb-4881-8c1a-8e54e93da203"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(892), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("309078cc-24ab-4102-8412-eb38f164092b"), new DateTime(2020, 11, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(884), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("caaf08f9-73f0-4de3-8922-7bfdf43ec6aa"), new DateTime(2020, 10, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(875), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("75bec938-7315-4fca-ae27-97847790c2b2"), new DateTime(2020, 10, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(769), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("905a0589-fe0c-4b83-87cb-08ced44805b3"), new DateTime(2020, 12, 19, 11, 3, 3, 981, DateTimeKind.Local).AddTicks(965), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("446bfab6-41d6-4125-a601-3ebbe0a4526d"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(8374), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("768ca3ec-8c01-4d65-8910-e4f500fbf3e7"), new DateTime(2021, 2, 19, 11, 1, 23, 980, DateTimeKind.Local).AddTicks(8354), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("5ecf4800-1a32-47e6-96ea-151c536f285f"), new DateTime(2021, 2, 19, 11, 2, 13, 980, DateTimeKind.Local).AddTicks(8361), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("88470f28-e8a3-4c8a-8620-47c4a28fcc5c"), new DateTime(2021, 2, 19, 10, 59, 43, 980, DateTimeKind.Local).AddTicks(7770), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("41a08f05-46db-46ac-8502-65b741456372"), new DateTime(2021, 2, 19, 11, 0, 33, 980, DateTimeKind.Local).AddTicks(8337), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("db5947f3-f563-42af-a2f7-85986d645af0"), new Guid("89746cf3-6266-459c-afdc-c88a3378d720"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(4292), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d10359c5-049a-475b-a819-842f4b3cc338"), new Guid("33d1946c-acb4-4be3-8a5c-26da7a2be8ad"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(5297), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("8ceba81b-071c-4039-ae29-88683d4c398f"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(3408), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6b63b44a-daa8-45d5-b609-96cec07be8c8"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(3511), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("55c12606-584a-4dcc-8d5e-3ccda8e47aab"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(3519), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("5c38c955-39d5-4cbf-9e7b-d8b21620e15c"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(3530), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6d95405b-e247-4226-b387-111fbb3e9c8c"), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(8939), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("b28f8161-44b0-498f-8312-781af0d6ad22"), new DateTime(2021, 2, 19, 11, 3, 3, 980, DateTimeKind.Local).AddTicks(3525), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 11, 3, 3, 978, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 11, 3, 3, 978, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 19, 11, 3, 3, 978, DateTimeKind.Local).AddTicks(9132), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(874), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(3687), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(3692), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(3590), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(3630), new DateTime(2021, 2, 19, 11, 3, 3, 979, DateTimeKind.Local).AddTicks(3646) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("16e28716-b299-456d-aa1e-7302894d57f3"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("52e8f883-a5a2-40d7-adbc-17ff333559cb"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("e295ec64-a7d0-4532-8ba2-c3dc0f76e9f4"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("4ea69324-8b76-42ba-a672-6877e3406249"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("630b471c-1444-42a2-8e5e-9dcf3df3ff93"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("649d0e27-830c-4f8f-b83c-505e1ed1fdde"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7c658d55-948b-494b-8d5d-304158d90f15"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2ca1bbe6-acb3-4e26-8bec-5227cf8af637"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("309078cc-24ab-4102-8412-eb38f164092b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("32704bfa-13a9-4b99-9e76-bfc225a5883d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("33f2d2bd-5b0e-4fd6-916f-5b25033c6add"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("35543958-527a-4f1f-901a-65dd967f424a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3cf2e35c-67e0-4120-9f6d-91a3753480dd"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4ca5e96f-2678-4f58-9c3c-e68393ed00fe"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("5015ab21-e09e-4292-8f25-c81e6c2e82c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("59f796e4-8db9-42c4-9ac5-a6ad47436e12"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("72aa6284-37c0-403c-805e-f8d55acfe302"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("75bec938-7315-4fca-ae27-97847790c2b2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8c1276f7-2e55-4323-82a8-f37ce12d2ca3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8d9bd3ed-439d-4653-a75f-abb6592ed163"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("905a0589-fe0c-4b83-87cb-08ced44805b3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("92dbe35e-91fa-467a-a53c-34469e4ab99c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9521e3c0-25ec-4e37-8572-94a53c1906ba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a1a0944e-deb4-4235-b8ac-4161898bef38"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a8c3dec3-f4e6-4f8b-b073-1ea9fa46dcb6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ad5d8f52-91e8-489a-9a7b-204735ef7cd6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("caaf08f9-73f0-4de3-8922-7bfdf43ec6aa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cf8b045b-51ce-4c17-b2bd-ebafc2d3101d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d514a07d-f7fb-4881-8c1a-8e54e93da203"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d5a93bcc-d844-4cc9-9086-cc43bec7189a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ec6e5c4b-43fc-41f7-9b18-bab6a1e91b98"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("41a08f05-46db-46ac-8502-65b741456372"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("446bfab6-41d6-4125-a601-3ebbe0a4526d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5ecf4800-1a32-47e6-96ea-151c536f285f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("768ca3ec-8c01-4d65-8910-e4f500fbf3e7"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("88470f28-e8a3-4c8a-8620-47c4a28fcc5c"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("d10359c5-049a-475b-a819-842f4b3cc338"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("db5947f3-f563-42af-a2f7-85986d645af0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55c12606-584a-4dcc-8d5e-3ccda8e47aab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c38c955-39d5-4cbf-9e7b-d8b21620e15c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b63b44a-daa8-45d5-b609-96cec07be8c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d95405b-e247-4226-b387-111fbb3e9c8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ceba81b-071c-4039-ae29-88683d4c398f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b28f8161-44b0-498f-8312-781af0d6ad22"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "City",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "ClientEmail",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "Taxnumber",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "Zip",
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
                table: "Notifications",
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

            migrationBuilder.AddColumn<string>(
                name: "VevoAdoszam",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoAzonosito",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoCim",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoEmail",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoIrsz",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoMegjegyzes",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoNev",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoOrszagKod",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoPostazasiCim",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoPostazasiIrsz",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoPostazasiNev",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoPostazasiTelepules",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoSendEmail",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoTelefonszam",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VevoTelepules",
                table: "BillingTransactions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoPartners",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoDocuments",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBillingAddresses",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "BillingoBankAccounts",
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

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("aa4c6870-96bf-4830-8849-5639aa5a4b93"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(425), new DateTime(2021, 2, 19, 10, 28, 2, 806, DateTimeKind.Local).AddTicks(1692), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("0790261f-0357-45fb-aa86-42dabb1276ba"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(2692), new DateTime(2021, 2, 19, 10, 28, 2, 806, DateTimeKind.Local).AddTicks(2724), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("a0a140eb-cea7-4296-a5fd-69fc5d15838d"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(2747), new DateTime(2021, 2, 19, 10, 28, 2, 806, DateTimeKind.Local).AddTicks(2751), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("fa63a211-3cc2-49cd-8ed6-a69c07efb8ec"), new DateTime(2021, 2, 19, 10, 27, 2, 801, DateTimeKind.Local).AddTicks(1079), true, true, "GTA" },
                    { new Guid("42a06c00-48dd-41b8-9ab5-e7ce6841b9dd"), new DateTime(2021, 2, 19, 10, 27, 2, 804, DateTimeKind.Local).AddTicks(1005), true, true, "Survival" },
                    { new Guid("fc2766bc-7813-4f03-80e7-8003aa9dc371"), new DateTime(2021, 2, 19, 10, 27, 2, 804, DateTimeKind.Local).AddTicks(1052), true, true, "Skyblock" },
                    { new Guid("beae7616-1d64-4104-beb5-8596f499876c"), new DateTime(2021, 2, 19, 10, 27, 2, 804, DateTimeKind.Local).AddTicks(1058), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("58e06cdf-f9d0-4fb7-ad99-b5ffd01b2c9f"), new DateTime(2021, 1, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7020), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4be249db-34a8-4ec0-b9d7-61adfe411fdf"), new DateTime(2020, 10, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7027), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("afe4aeda-52a6-4440-8631-178bd410cf75"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7035), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8b69c041-1057-4b87-b96d-cc0f2f97f3b8"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7043), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e10886d5-4e22-48ad-a419-42a6c7616110"), new DateTime(2021, 1, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7081), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("09b53fd9-008a-410b-a073-85952d326008"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7066), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("11b4bfbc-31e1-46bd-942e-a51bd9b84710"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7073), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dad7f5a3-2ceb-4d26-8b7f-adbc3cc29fc9"), new DateTime(2021, 1, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7012), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c3a02d27-fd88-4812-9009-9059109ad1d1"), new DateTime(2021, 1, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7089), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("5c4cabd5-8d2b-44e2-9c1b-381af4c8821b"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7057), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2a94045d-bd6d-4b8c-8678-6a6787b3814d"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7005), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2e4a2687-1574-47ef-b9a7-ca99f11c9dde"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(7050), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1b8d5875-ee62-495f-a079-e05595cb730d"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6986), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("133992bb-ba88-4234-bd46-16a9ceced624"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6978), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d6f46293-5e58-4312-afcf-4f5ec8e659ca"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6969), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7b990ef5-a790-46eb-866b-35b60545297c"), new DateTime(2020, 10, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6959), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ed56c8dd-bf03-4787-9beb-e84af158c0a7"), new DateTime(2020, 10, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6950), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3564161c-c44e-4d28-bf2a-a6013b8b4840"), new DateTime(2021, 1, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6943), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("1fd26100-4f3c-45e6-a83a-acca426e4f3f"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6935), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8e1441b9-5540-4bfc-9443-64c40423589e"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6921), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4bf745f4-c791-4251-8ef3-a9593d47dced"), new DateTime(2020, 11, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6913), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("db283539-3872-4eca-887b-0c6f7773cfc7"), new DateTime(2020, 10, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6904), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f4366fa9-0454-4eac-b226-2e5d87c0f925"), new DateTime(2020, 10, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6802), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a7b1c91f-eb75-4e6b-a4d2-d6a654c32e7d"), new DateTime(2020, 12, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(6994), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("082a1c20-8b7b-4e4d-af12-b968967d1dd8"), new DateTime(2021, 2, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(4383), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("5e568d60-99d7-4c37-92c2-28014bcb45d5"), new DateTime(2021, 2, 19, 10, 25, 22, 807, DateTimeKind.Local).AddTicks(4368), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("64eddab4-a36c-4b46-b923-f0e4a04ceb8f"), new DateTime(2021, 2, 19, 10, 26, 12, 807, DateTimeKind.Local).AddTicks(4375), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("b99c7902-38e3-4db7-a7cb-ce10f7ff3d40"), new DateTime(2021, 2, 19, 10, 23, 42, 807, DateTimeKind.Local).AddTicks(3784), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("f7e5b1af-d66a-437b-8e19-e964ba4eb289"), new DateTime(2021, 2, 19, 10, 24, 32, 807, DateTimeKind.Local).AddTicks(4352), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e95fc7a-1cc7-42de-8285-45e9e7bfd03e"), new Guid("74035771-c3d2-4ec8-bbc6-3f7096cecd56"), new DateTime(2021, 2, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(226), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b93b8021-dde4-4a6d-827c-ae7fba30b43f"), new Guid("c4d31224-2ed1-43e6-a41f-2f6a306d478d"), new DateTime(2021, 2, 19, 10, 27, 2, 807, DateTimeKind.Local).AddTicks(1244), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("0cf47f4c-ede4-4b62-982d-641e341831a7"), new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(9343), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("958b003d-0db7-4805-85db-74eb793bd17e"), new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(9437), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("15bddacd-6373-4555-ab66-220355d59515"), new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(9450), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("a657269f-7ec6-4ece-8cff-3296c55884cd"), new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(9461), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("7d9fde00-769d-4e78-a6fc-bc11d47b51a5"), new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(5028), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("3ee11ead-9f5a-4fad-bded-663472dfb0e2"), new DateTime(2021, 2, 19, 10, 27, 2, 806, DateTimeKind.Local).AddTicks(9455), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(5149), new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(6876), new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(9683), new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(9688), new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(9583), new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(9626), new DateTime(2021, 2, 19, 10, 27, 2, 805, DateTimeKind.Local).AddTicks(9640) });
        }
    }
}
