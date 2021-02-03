using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class OneTimeCommandUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("066154fa-2533-497f-891c-223f7e84670d"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("05a4d121-f48b-4929-a958-23a41d74ef92"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7108880c-6a8e-49bb-aad3-d3fcdcf1805b"));

            migrationBuilder.DeleteData(
                table: "ClientIdentities",
                keyColumn: "Id",
                keyValue: new Guid("7bcf7634-2a71-4200-a724-0b1960881cac"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("514fc5ef-c3d5-4cc4-a36a-e5c0e7578921"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("8d878e78-a68c-4ab8-892b-c4af5e58b3ca"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a410b6c5-3cda-47a8-bef5-6bddcddef325"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("eada129e-f282-4542-8972-1d3347ce0f0c"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0b7bc6aa-0855-4090-9758-49a737e63641"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("284eaa16-aec5-42b3-8b18-0d48b3b8f0ec"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3ed33b27-9445-4df8-b2a4-e4705d9fddad"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("442f30fe-b578-4f36-b96d-39b1f5da4bf6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("47a3a379-0527-4070-8eea-610691bf2ae6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4fba50c4-f7ad-4fe5-b9d5-fcd180bba705"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("4ff13b0e-ab47-446a-802b-f90354da9db6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("612f0676-50ca-4c28-992e-7d148331fbdc"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("64963684-8c33-4c92-875a-bd726584d1b4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("715be4fb-9d46-4cb1-945d-b5e991a30d70"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("71c0f1a7-47ca-4320-b3cc-54107c69005e"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7be7b568-0482-4a71-9917-2d0e3998e5c0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8a30ae44-1ad0-48b1-9dbc-0b39b289f7f5"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8bc98922-ca90-4d90-b27c-24ec93a577f1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("aedc3565-6bae-4133-a89d-010bbc189733"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b27ead1a-b682-4c2b-a0ad-d5e0c799fbc0"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d45c23e6-318f-45e2-93a5-01f08009e048"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e7b94ffd-3742-4866-8b81-be2fa2bee6b2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e84d95b6-aa55-41ff-b607-61b73962d8e1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ec762300-c19e-4fc5-af81-43b03874232d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ecf08288-dd78-44d1-acc3-20a12ae891a9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f137ff74-de56-403d-b647-ed15fca8ef9f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f93f6d00-7bae-47c8-9a57-770f1d3cf8a4"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f9f5b815-8da5-46dc-913b-021260307562"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4f816993-055d-4d9c-8715-a0173448eaa8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5ee0c8b2-376e-4266-b112-cbc7c83260f8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8f07dc60-6305-4969-990e-9103106a67f8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("967b927f-0b80-4c90-88ec-508af178930b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("b6a8d536-ef2d-4140-a3a6-5d74811f856b"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("840ec630-199a-468b-94ec-fdf547799f12"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("d2b8fc31-bc62-40ac-890e-383f8e762822"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10b694c7-d87a-4b70-b55d-c853524ed07b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("262dc35f-4181-49ef-8065-1e2b31b7e6b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b62743e-93ff-4003-b731-f8563b9d1298"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cfa46af-e1a4-49ac-ab13-e6e51d2a8699"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("951a6ee1-d7b8-4ba5-a46a-c46bb21d163d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e6b7d96-968c-4fea-9a1a-ce5a2833f06d"));

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

            migrationBuilder.AddColumn<bool>(
                name: "IsOneTimeCommandRan",
                table: "PurchasedProducts",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsOneTimeCommandRan",
                table: "PurchasedProducts");

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
                values: new object[] { new Guid("066154fa-2533-497f-891c-223f7e84670d"), new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(4963), true, 2m });

            migrationBuilder.InsertData(
                table: "ClientIdentities",
                columns: new[] { "Id", "BaseValue", "CreationDate", "ExpirationDate", "IsActive", "UserId", "ValidatorHash", "ValidatorSalt" },
                values: new object[,]
                {
                    { new Guid("7bcf7634-2a71-4200-a724-0b1960881cac"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(4228), new DateTime(2021, 2, 3, 15, 54, 53, 382, DateTimeKind.Local).AddTicks(5588), true, new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("7108880c-6a8e-49bb-aad3-d3fcdcf1805b"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(6625), new DateTime(2021, 2, 3, 15, 54, 53, 382, DateTimeKind.Local).AddTicks(6660), true, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" },
                    { new Guid("05a4d121-f48b-4929-a958-23a41d74ef92"), "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N", new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(6690), new DateTime(2021, 2, 3, 15, 54, 53, 382, DateTimeKind.Local).AddTicks(6693), true, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"), "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N" }
                });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("eada129e-f282-4542-8972-1d3347ce0f0c"), new DateTime(2021, 2, 3, 14, 54, 53, 377, DateTimeKind.Local).AddTicks(2691), true, true, "GTA" },
                    { new Guid("a410b6c5-3cda-47a8-bef5-6bddcddef325"), new DateTime(2021, 2, 3, 14, 54, 53, 380, DateTimeKind.Local).AddTicks(2919), true, true, "Survival" },
                    { new Guid("8d878e78-a68c-4ab8-892b-c4af5e58b3ca"), new DateTime(2021, 2, 3, 14, 54, 53, 380, DateTimeKind.Local).AddTicks(2972), true, true, "Skyblock" },
                    { new Guid("514fc5ef-c3d5-4cc4-a36a-e5c0e7578921"), new DateTime(2021, 2, 3, 14, 54, 53, 380, DateTimeKind.Local).AddTicks(2978), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("d45c23e6-318f-45e2-93a5-01f08009e048"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1459), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8a30ae44-1ad0-48b1-9dbc-0b39b289f7f5"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1468), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ec762300-c19e-4fc5-af81-43b03874232d"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1476), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e7b94ffd-3742-4866-8b81-be2fa2bee6b2"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1491), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ecf08288-dd78-44d1-acc3-20a12ae891a9"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1526), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0b7bc6aa-0855-4090-9758-49a737e63641"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1507), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("47a3a379-0527-4070-8eea-610691bf2ae6"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1515), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f93f6d00-7bae-47c8-9a57-770f1d3cf8a4"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1446), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("715be4fb-9d46-4cb1-945d-b5e991a30d70"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1534), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f9f5b815-8da5-46dc-913b-021260307562"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1499), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b27ead1a-b682-4c2b-a0ad-d5e0c799fbc0"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1438), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("284eaa16-aec5-42b3-8b18-0d48b3b8f0ec"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1484), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("aedc3565-6bae-4133-a89d-010bbc189733"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1421), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7be7b568-0482-4a71-9917-2d0e3998e5c0"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1413), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("71c0f1a7-47ca-4320-b3cc-54107c69005e"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1405), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3ed33b27-9445-4df8-b2a4-e4705d9fddad"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1397), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("442f30fe-b578-4f36-b96d-39b1f5da4bf6"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1388), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e84d95b6-aa55-41ff-b607-61b73962d8e1"), new DateTime(2021, 1, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1375), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4ff13b0e-ab47-446a-802b-f90354da9db6"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1366), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f137ff74-de56-403d-b647-ed15fca8ef9f"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1358), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("612f0676-50ca-4c28-992e-7d148331fbdc"), new DateTime(2020, 11, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1350), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("64963684-8c33-4c92-875a-bd726584d1b4"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1339), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8bc98922-ca90-4d90-b27c-24ec93a577f1"), new DateTime(2020, 10, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1228), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("4fba50c4-f7ad-4fe5-b9d5-fcd180bba705"), new DateTime(2020, 12, 3, 14, 54, 53, 384, DateTimeKind.Local).AddTicks(1429), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("5ee0c8b2-376e-4266-b112-cbc7c83260f8"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(8730), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("b6a8d536-ef2d-4140-a3a6-5d74811f856b"), new DateTime(2021, 2, 3, 14, 53, 13, 383, DateTimeKind.Local).AddTicks(8709), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("4f816993-055d-4d9c-8715-a0173448eaa8"), new DateTime(2021, 2, 3, 14, 54, 3, 383, DateTimeKind.Local).AddTicks(8723), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("967b927f-0b80-4c90-88ec-508af178930b"), new DateTime(2021, 2, 3, 14, 51, 33, 383, DateTimeKind.Local).AddTicks(8108), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("8f07dc60-6305-4969-990e-9103106a67f8"), new DateTime(2021, 2, 3, 14, 52, 23, 383, DateTimeKind.Local).AddTicks(8692), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("840ec630-199a-468b-94ec-fdf547799f12"), new Guid("15a48d5d-5187-4934-a1b7-98429b5366ac"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(4558), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d2b8fc31-bc62-40ac-890e-383f8e762822"), new Guid("ca822a11-ab43-40e7-a250-ca3552966fe6"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(5609), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("10b694c7-d87a-4b70-b55d-c853524ed07b"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3647), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4cfa46af-e1a4-49ac-ab13-e6e51d2a8699"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3746), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("262dc35f-4181-49ef-8065-1e2b31b7e6b3"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3754), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("2b62743e-93ff-4003-b731-f8563b9d1298"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3769), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("951a6ee1-d7b8-4ba5-a46a-c46bb21d163d"), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(8963), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("9e6b7d96-968c-4fea-9a1a-ce5a2833f06d"), new DateTime(2021, 2, 3, 14, 54, 53, 383, DateTimeKind.Local).AddTicks(3759), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 54, 53, 381, DateTimeKind.Local).AddTicks(8731), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(504), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3492), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3497), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3381), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3438), new DateTime(2021, 2, 3, 14, 54, 53, 382, DateTimeKind.Local).AddTicks(3455) });
        }
    }
}
