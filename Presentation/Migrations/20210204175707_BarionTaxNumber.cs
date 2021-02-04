using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class BarionTaxNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("de9f9bc1-57e9-4f12-ab42-1eebf8d79ee5"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("27eb067f-fa8c-404a-9b2e-841261760c16"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("40c27bfa-2224-4f1b-a873-b6631c092c64"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("b7dbf6f6-aa3f-45f0-ac09-f42dc92ae92c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("067b9d5e-57a1-4c24-b7cf-9ffacff67749"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("c3bd8022-ae1f-48a0-96bc-b61915ab75ff"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("d2c7630c-a2dc-4729-8b63-e0afd2386a09"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("ed6103e8-0811-488f-9205-8520eba0dcaa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("055b4417-df7e-452d-980f-709175fabe3f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("10f7541c-30f7-43c7-983d-8d327071b665"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("148bf558-9e94-4454-bd2a-5f2fe1d141df"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3c554f3b-345c-49f0-9b63-9de38a358f5a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("431e3870-8ffa-47c4-a5e0-65aec0ab2ea0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4b30f0aa-9510-4d62-a782-9e2c29877ee7"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("50f29dd0-d869-4f8d-9282-c13bd3b293f6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("630e3aa6-1896-4402-aa4d-b199f0170009"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6a216817-a7a5-4c9c-9be5-732ed78323de"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("72d49926-9492-4c87-b74c-cd216603ed07"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("769bcdaa-f7f8-4f95-bdb3-95a2a736c15c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("784c5bb7-6567-4c50-a5d7-240e6113e733"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7a670991-0f7c-4333-ba42-75ab3faa2aba"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7d965869-5264-4d6a-bf66-8febed38dd36"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a759d82a-bb49-4be7-aa1e-f26df1277f37"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b42fcb27-6171-477d-ace9-bfa8e1756d9d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b8b8c015-ce8a-47ec-b585-995b37132f5a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b925a27e-686f-4f84-9089-d5118836dc32"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cc4797a0-2957-4c65-a153-c7b13babb67e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ce4bd170-8e7a-4424-ac93-72360442c0e3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d794c85b-a2d0-4ba9-996e-59119bdb619e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("da1bdd17-5740-426f-b724-e743fb5cdfd5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("dc6a60a2-37f6-45bb-9482-dedc3dfdb248"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f65b8ff6-49b0-4de7-a1a5-953475a0a75d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("394825a7-9198-4e12-9785-58b66ff0f977"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("42f4ee52-03e1-4072-9414-d5da3e131828"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("70279ca8-e0b0-4417-8b35-4fc659114b0b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b9b2f674-cb94-4bbf-bd88-2c282cb656b5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e8c82e71-b70d-4388-bdce-fb667ea2514a"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("5ccc6016-37cd-4b44-bbf0-7a7ec1e78386"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("b27e367c-78bb-488c-a3f3-d7d56ec193df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("119c7d25-c7de-4cba-9701-bf799f415a39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d1f30a7-1815-46ef-8c66-e0ba405e2dbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c0f949a-f694-48d9-a9ac-757d48ce1b66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1f2b4aa-bd6d-45e4-8302-cc95502df8b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddd0f063-a11b-48b6-a649-d1b661b1ecf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbad5eaf-c129-4ee7-9dbc-eb63d99922d7"));

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
                name: "TaxNumber",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TaxNumber",
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
                values: new object[] { new Guid("de9f9bc1-57e9-4f12-ab42-1eebf8d79ee5"), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(208), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("b7dbf6f6-aa3f-45f0-ac09-f42dc92ae92c"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8917), new DateTime(2021, 2, 3, 20, 49, 38, 813, DateTimeKind.Local).AddTicks(150), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("27eb067f-fa8c-404a-9b2e-841261760c16"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(1126), new DateTime(2021, 2, 3, 20, 49, 38, 813, DateTimeKind.Local).AddTicks(1158), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("40c27bfa-2224-4f1b-a873-b6631c092c64"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(1180), new DateTime(2021, 2, 3, 20, 49, 38, 813, DateTimeKind.Local).AddTicks(1183), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("d2c7630c-a2dc-4729-8b63-e0afd2386a09"), new DateTime(2021, 2, 3, 19, 49, 38, 807, DateTimeKind.Local).AddTicks(9359), true, true, "GTA" },
                    { new Guid("c3bd8022-ae1f-48a0-96bc-b61915ab75ff"), new DateTime(2021, 2, 3, 19, 49, 38, 810, DateTimeKind.Local).AddTicks(8556), true, true, "Survival" },
                    { new Guid("ed6103e8-0811-488f-9205-8520eba0dcaa"), new DateTime(2021, 2, 3, 19, 49, 38, 810, DateTimeKind.Local).AddTicks(8605), true, true, "Skyblock" },
                    { new Guid("067b9d5e-57a1-4c24-b7cf-9ffacff67749"), new DateTime(2021, 2, 3, 19, 49, 38, 810, DateTimeKind.Local).AddTicks(8611), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("cc4797a0-2957-4c65-a153-c7b13babb67e"), new DateTime(2021, 1, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5044), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7a670991-0f7c-4333-ba42-75ab3faa2aba"), new DateTime(2020, 10, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5051), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("769bcdaa-f7f8-4f95-bdb3-95a2a736c15c"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5059), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("148bf558-9e94-4454-bd2a-5f2fe1d141df"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5077), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b42fcb27-6171-477d-ace9-bfa8e1756d9d"), new DateTime(2021, 1, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5107), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ce4bd170-8e7a-4424-ac93-72360442c0e3"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5092), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("630e3aa6-1896-4402-aa4d-b199f0170009"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5100), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b925a27e-686f-4f84-9089-d5118836dc32"), new DateTime(2021, 1, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5036), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("da1bdd17-5740-426f-b724-e743fb5cdfd5"), new DateTime(2021, 1, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5115), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("431e3870-8ffa-47c4-a5e0-65aec0ab2ea0"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5084), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b8b8c015-ce8a-47ec-b585-995b37132f5a"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5029), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6a216817-a7a5-4c9c-9be5-732ed78323de"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5067), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("50f29dd0-d869-4f8d-9282-c13bd3b293f6"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5013), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("dc6a60a2-37f6-45bb-9482-dedc3dfdb248"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5003), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("784c5bb7-6567-4c50-a5d7-240e6113e733"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4995), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d965869-5264-4d6a-bf66-8febed38dd36"), new DateTime(2020, 10, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4987), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4b30f0aa-9510-4d62-a782-9e2c29877ee7"), new DateTime(2020, 10, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4979), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("055b4417-df7e-452d-980f-709175fabe3f"), new DateTime(2021, 1, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4972), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("72d49926-9492-4c87-b74c-cd216603ed07"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4964), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d794c85b-a2d0-4ba9-996e-59119bdb619e"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4956), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3c554f3b-345c-49f0-9b63-9de38a358f5a"), new DateTime(2020, 11, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4947), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a759d82a-bb49-4be7-aa1e-f26df1277f37"), new DateTime(2020, 10, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4933), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f65b8ff6-49b0-4de7-a1a5-953475a0a75d"), new DateTime(2020, 10, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(4824), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("10f7541c-30f7-43c7-983d-8d327071b665"), new DateTime(2020, 12, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(5021), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("e8c82e71-b70d-4388-bdce-fb667ea2514a"), new DateTime(2021, 2, 3, 19, 49, 38, 814, DateTimeKind.Local).AddTicks(2470), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("394825a7-9198-4e12-9785-58b66ff0f977"), new DateTime(2021, 2, 3, 19, 47, 58, 814, DateTimeKind.Local).AddTicks(2454), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("70279ca8-e0b0-4417-8b35-4fc659114b0b"), new DateTime(2021, 2, 3, 19, 48, 48, 814, DateTimeKind.Local).AddTicks(2462), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("b9b2f674-cb94-4bbf-bd88-2c282cb656b5"), new DateTime(2021, 2, 3, 19, 46, 18, 814, DateTimeKind.Local).AddTicks(1883), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("42f4ee52-03e1-4072-9414-d5da3e131828"), new DateTime(2021, 2, 3, 19, 47, 8, 814, DateTimeKind.Local).AddTicks(2439), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ccc6016-37cd-4b44-bbf0-7a7ec1e78386"), new Guid("9424002e-89f1-4b59-8f0a-efd669120768"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(8514), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b27e367c-78bb-488c-a3f3-d7d56ec193df"), new Guid("e84082d9-e175-46c2-afb3-d91c3310f305"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(9505), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("1d1f30a7-1815-46ef-8c66-e0ba405e2dbd"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(7688), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("fbad5eaf-c129-4ee7-9dbc-eb63d99922d7"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(7787), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d1f2b4aa-bd6d-45e4-8302-cc95502df8b0"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(7794), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("119c7d25-c7de-4cba-9701-bf799f415a39"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(7805), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("6c0f949a-f694-48d9-a9ac-757d48ce1b66"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(3293), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ddd0f063-a11b-48b6-a649-d1b661b1ecf6"), new DateTime(2021, 2, 3, 19, 49, 38, 813, DateTimeKind.Local).AddTicks(7799), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(3764), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(5436), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8212), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8218), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8104), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8157), new DateTime(2021, 2, 3, 19, 49, 38, 812, DateTimeKind.Local).AddTicks(8176) });
        }
    }
}
