using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class clientidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("ac5c7bfe-2085-48e7-b257-709a9b4ff31f"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("2f4e42c4-b9c8-4ab8-b4d4-8b411a21fe1d"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("5b41f736-177d-4f86-a410-6eb0a0190a39"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("a13d2278-b146-4bda-9196-42ab13640031"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("be848ec8-e65a-47a7-9d91-61e81094b59f"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("018ffe74-b8cb-41be-b5a0-93d2bd1f0cff"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("01e89114-7e2a-4f53-a14d-3cf37ee49093"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0a6ec799-7f9f-452f-8e72-206e9901cf62"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("25232a10-aba4-4658-adca-88cc85d7c0c6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28ac72f1-5b67-43f8-b405-b006ec3ffee6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("313ea773-6dd3-4daa-86e4-14db2b6136a3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("43d4077a-298c-46ac-beee-678ccbac39a6"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("623e3b76-1e26-4eca-83a8-c6ada757cf2b"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("625575c4-c379-4c95-8d89-0e48c2ea278d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("74a1f92a-3886-47d3-819c-12854934e9d9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7c3c56a5-ee84-48c6-b82b-541c91417a6a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7cc74c3f-3baf-4864-83ee-cd3a498b3a18"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7db08f84-62cf-4429-a21f-2acbcdf55c91"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("903465c6-c76f-41d9-8410-b2ec620a8cd9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("975a558d-2007-4a86-9748-010f674ba3a9"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("9e47630a-bcf5-4966-9f0f-aa32a19d7293"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c08637ce-8132-4542-a89e-1c3c44298f95"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cd2aef01-1671-441f-9dce-69adc3c0711a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("ce6a3e1a-c9ba-492c-9269-780dfe73fc22"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("cfbbb674-308d-4e9f-8423-8b513231b23d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("d3e3efe2-7901-45ff-875b-4b41ac6222b2"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e3f78cbd-7895-4b15-a890-65e9161e07fa"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e6534c6b-6a9b-484a-aed4-2bab010f4054"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("f725080a-73c7-4917-ab87-48e46c1e6bc7"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0cf126f5-38cf-4f42-8726-143a22281fec"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5469ec0c-04d6-4063-b7e9-efafe7aae1c8"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("7fd89664-5038-4083-b05b-8724055f202c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8bb704f9-c841-4114-af88-c9c700b52246"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c668234d-7ad9-4b45-bc0f-d0800d5fa797"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("140d5d13-c5b3-43ac-ae69-7f447d521ac4"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("f161253f-9665-4910-8e57-aa54e792c5e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b2dd3e4-6b65-4dcf-bcf9-b0619ee89f83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74323f61-b48a-4146-85bb-0214dd6c7dca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("790fc405-dcb5-47f7-9efc-7eb15089209b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("831a9efd-1995-4bc8-b0a3-968632418b95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a250bdbc-372b-46e9-bd2f-6de6ff029c54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebc400fd-cab8-4dfa-b774-dce3e6c1f7ef"));

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
                name: "ClientIdentities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BaseValue = table.Column<string>(nullable: true),
                    ValidatorHash = table.Column<string>(nullable: true),
                    ValidatorSalt = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientIdentities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("4face441-0e5d-4c11-a98c-0e4ec3d2c22a"), new DateTime(2021, 1, 17, 12, 44, 13, 944, DateTimeKind.Local).AddTicks(7578), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("578f543a-db8f-4da6-af24-5f3cb8887146"), new DateTime(2021, 1, 17, 12, 44, 13, 940, DateTimeKind.Local).AddTicks(6906), true, true, "GTA" },
                    { new Guid("04514ee7-5d91-40fe-8827-0219bd1f69cc"), new DateTime(2021, 1, 17, 12, 44, 13, 943, DateTimeKind.Local).AddTicks(5609), true, true, "Survival" },
                    { new Guid("476cae6f-f50f-468e-87e7-c4a1762dbc8a"), new DateTime(2021, 1, 17, 12, 44, 13, 943, DateTimeKind.Local).AddTicks(5671), true, true, "Skyblock" },
                    { new Guid("02b4d34d-f815-4038-9558-5fea8649585b"), new DateTime(2021, 1, 17, 12, 44, 13, 943, DateTimeKind.Local).AddTicks(5677), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("e23a525b-b56e-4d96-983e-e4ff4f9d836d"), new DateTime(2020, 12, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(756), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28f3a2c6-305a-40e5-8ae6-ebdc1fd86488"), new DateTime(2020, 12, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(747), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("8171bca7-b9a4-4ccc-87b1-8939d2f8394a"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(738), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e96b1df5-b8e7-401d-b6e9-c938cc92285d"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(728), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("910586d0-2980-44fe-ab90-528cf47de065"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(712), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e9cc06d9-dd4b-4818-b2ed-d9f392999c37"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(705), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6abed97a-25da-4e74-8a53-9e02257ef996"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(696), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("3eeeef26-f053-4975-8f39-a1212a592be1"), new DateTime(2020, 9, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(685), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("83e2135a-6a57-403e-9865-0b85a5e6d391"), new DateTime(2020, 12, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(676), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("2d0c4e7a-63c3-413e-804d-8686f5c6f68d"), new DateTime(2020, 12, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(669), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("6373ff5c-86e7-4c71-a0fd-194d0ee75b51"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(658), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("a13a5de1-e873-4dc6-a6e2-94f8e35f01d3"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(721), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("b156c289-1cba-4bd1-a553-7d2f59ab7743"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(639), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("da202998-1b98-4c35-879c-58847a661dda"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(630), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("32a115b8-34e7-423f-9f33-6ec8c5e32758"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(623), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("38b0916e-310c-42ce-8136-3b8da0e69ae8"), new DateTime(2020, 9, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(615), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("49a0976c-a716-441e-a1e3-d7c9a36c3d19"), new DateTime(2020, 9, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(607), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c266e69a-bf6c-48d8-82b5-1d3a1198c942"), new DateTime(2020, 12, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(599), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0dac1e95-cbf7-43a6-8ea4-1102704124ea"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(586), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("59ae9026-f346-4a47-b49b-81842ab33e78"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(577), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("023024e8-bdc5-4dc1-b49e-550230b89caf"), new DateTime(2020, 10, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(568), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7d5f2db2-3551-4e94-9ead-272d371ed107"), new DateTime(2020, 9, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(510), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("68b70558-f363-49ff-8962-05f147ea93db"), new DateTime(2020, 9, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(406), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("fe1bae7f-3724-44c7-9579-d999a835a346"), new DateTime(2020, 11, 17, 12, 44, 13, 947, DateTimeKind.Local).AddTicks(649), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("5aa2fba3-fb45-413c-81d0-b64e7da6e7f0"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(7840), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("c137b9c5-6a1a-4a4a-a888-3299982380e5"), new DateTime(2021, 1, 17, 12, 42, 33, 946, DateTimeKind.Local).AddTicks(7824), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("00cecabf-a067-46d0-b8a8-00af0f468a47"), new DateTime(2021, 1, 17, 12, 43, 23, 946, DateTimeKind.Local).AddTicks(7832), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("c5c9692b-8728-4cba-8bcb-a82c6264ebd2"), new DateTime(2021, 1, 17, 12, 40, 53, 946, DateTimeKind.Local).AddTicks(7220), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("4703511a-26e9-4f54-9dae-9957402294b3"), new DateTime(2021, 1, 17, 12, 41, 43, 946, DateTimeKind.Local).AddTicks(7801), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("cab0ae6e-0a89-4dbf-8dbd-f41a134d2d19"), new Guid("af0d1549-ccb7-4557-a9de-626434917b32"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(3718), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d41cfac6-e63a-4862-a246-4025d2fe58a5"), new Guid("ba88c9ca-0a5c-4ae7-becc-a85559de0404"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(4760), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("ba1d9539-86a6-4815-af15-e552aaa4ac1c"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(2855), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("003064cf-6e22-4223-ad0e-2236f37221f5"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(2955), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("1943474e-fa90-4176-bb10-94d27b7422a6"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(2964), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("0c6d97cc-5f6f-404a-b058-38818e8ef8a6"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(2982), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("15284377-be3f-4904-8a02-574411020461"), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(8371), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("d1302b12-e5ce-4d63-86d3-b36932a79b70"), new DateTime(2021, 1, 17, 12, 44, 13, 946, DateTimeKind.Local).AddTicks(2976), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 17, 12, 44, 13, 944, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(1415), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(3146), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(6106), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(6112), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(5996), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(6054), new DateTime(2021, 1, 17, 12, 44, 13, 945, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.CreateIndex(
                name: "IX_ClientIdentities_UserId",
                table: "ClientIdentities",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientIdentities");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("4face441-0e5d-4c11-a98c-0e4ec3d2c22a"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("02b4d34d-f815-4038-9558-5fea8649585b"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("04514ee7-5d91-40fe-8827-0219bd1f69cc"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("476cae6f-f50f-468e-87e7-c4a1762dbc8a"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("578f543a-db8f-4da6-af24-5f3cb8887146"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("023024e8-bdc5-4dc1-b49e-550230b89caf"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("0dac1e95-cbf7-43a6-8ea4-1102704124ea"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("28f3a2c6-305a-40e5-8ae6-ebdc1fd86488"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("2d0c4e7a-63c3-413e-804d-8686f5c6f68d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("32a115b8-34e7-423f-9f33-6ec8c5e32758"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("38b0916e-310c-42ce-8136-3b8da0e69ae8"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("3eeeef26-f053-4975-8f39-a1212a592be1"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("49a0976c-a716-441e-a1e3-d7c9a36c3d19"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("59ae9026-f346-4a47-b49b-81842ab33e78"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6373ff5c-86e7-4c71-a0fd-194d0ee75b51"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("68b70558-f363-49ff-8962-05f147ea93db"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("6abed97a-25da-4e74-8a53-9e02257ef996"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("7d5f2db2-3551-4e94-9ead-272d371ed107"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("8171bca7-b9a4-4ccc-87b1-8939d2f8394a"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("83e2135a-6a57-403e-9865-0b85a5e6d391"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("910586d0-2980-44fe-ab90-528cf47de065"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("a13a5de1-e873-4dc6-a6e2-94f8e35f01d3"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("b156c289-1cba-4bd1-a553-7d2f59ab7743"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("c266e69a-bf6c-48d8-82b5-1d3a1198c942"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("da202998-1b98-4c35-879c-58847a661dda"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e23a525b-b56e-4d96-983e-e4ff4f9d836d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e96b1df5-b8e7-401d-b6e9-c938cc92285d"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("e9cc06d9-dd4b-4818-b2ed-d9f392999c37"));

            migrationBuilder.DeleteData(
                table: "KreditPurchases",
                keyColumn: "Id",
                keyValue: new Guid("fe1bae7f-3724-44c7-9579-d999a835a346"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("00cecabf-a067-46d0-b8a8-00af0f468a47"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4703511a-26e9-4f54-9dae-9957402294b3"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5aa2fba3-fb45-413c-81d0-b64e7da6e7f0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c137b9c5-6a1a-4a4a-a888-3299982380e5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("c5c9692b-8728-4cba-8bcb-a82c6264ebd2"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("cab0ae6e-0a89-4dbf-8dbd-f41a134d2d19"));

            migrationBuilder.DeleteData(
                table: "PasswordResetCodes",
                keyColumn: "Id",
                keyValue: new Guid("d41cfac6-e63a-4862-a246-4025d2fe58a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("003064cf-6e22-4223-ad0e-2236f37221f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c6d97cc-5f6f-404a-b058-38818e8ef8a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15284377-be3f-4904-8a02-574411020461"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1943474e-fa90-4176-bb10-94d27b7422a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba1d9539-86a6-4815-af15-e552aaa4ac1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1302b12-e5ce-4d63-86d3-b36932a79b70"));

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
                values: new object[] { new Guid("ac5c7bfe-2085-48e7-b257-709a9b4ff31f"), new DateTime(2021, 1, 7, 21, 43, 58, 691, DateTimeKind.Local).AddTicks(8918), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("2f4e42c4-b9c8-4ab8-b4d4-8b411a21fe1d"), new DateTime(2021, 1, 7, 21, 43, 58, 687, DateTimeKind.Local).AddTicks(7934), true, true, "GTA" },
                    { new Guid("be848ec8-e65a-47a7-9d91-61e81094b59f"), new DateTime(2021, 1, 7, 21, 43, 58, 690, DateTimeKind.Local).AddTicks(7252), true, true, "Survival" },
                    { new Guid("a13d2278-b146-4bda-9196-42ab13640031"), new DateTime(2021, 1, 7, 21, 43, 58, 690, DateTimeKind.Local).AddTicks(7306), true, true, "Skyblock" },
                    { new Guid("5b41f736-177d-4f86-a410-6eb0a0190a39"), new DateTime(2021, 1, 7, 21, 43, 58, 690, DateTimeKind.Local).AddTicks(7312), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "KreditPurchases",
                columns: new[] { "Id", "CreationDate", "CurrencyValue", "IsActive", "KreditValue", "PaymentType", "UserId" },
                values: new object[,]
                {
                    { new Guid("01e89114-7e2a-4f53-a14d-3cf37ee49093"), new DateTime(2020, 12, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(2033), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cfbbb674-308d-4e9f-8423-8b513231b23d"), new DateTime(2020, 12, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(2026), 4000, true, 2000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("0a6ec799-7f9f-452f-8e72-206e9901cf62"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(2018), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("625575c4-c379-4c95-8d89-0e48c2ea278d"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(2010), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7c3c56a5-ee84-48c6-b82b-541c91417a6a"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1994), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("25232a10-aba4-4658-adca-88cc85d7c0c6"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1987), 2000, true, 1000, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("9e47630a-bcf5-4966-9f0f-aa32a19d7293"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1979), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7db08f84-62cf-4429-a21f-2acbcdf55c91"), new DateTime(2020, 9, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1972), 1000, true, 500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("43d4077a-298c-46ac-beee-678ccbac39a6"), new DateTime(2020, 12, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1964), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("623e3b76-1e26-4eca-83a8-c6ada757cf2b"), new DateTime(2020, 12, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1957), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("74a1f92a-3886-47d3-819c-12854934e9d9"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1949), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("7cc74c3f-3baf-4864-83ee-cd3a498b3a18"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(2001), 3000, true, 1500, 2, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e6534c6b-6a9b-484a-aed4-2bab010f4054"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1932), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("313ea773-6dd3-4daa-86e4-14db2b6136a3"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1924), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("28ac72f1-5b67-43f8-b405-b006ec3ffee6"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1917), 2000, true, 2032, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("903465c6-c76f-41d9-8410-b2ec620a8cd9"), new DateTime(2020, 9, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1909), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("f725080a-73c7-4917-ab87-48e46c1e6bc7"), new DateTime(2020, 9, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1902), 330, true, 330, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("ce6a3e1a-c9ba-492c-9269-780dfe73fc22"), new DateTime(2020, 12, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1893), 3000, true, 1500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("975a558d-2007-4a86-9748-010f674ba3a9"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1885), 6000, true, 3000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("018ffe74-b8cb-41be-b5a0-93d2bd1f0cff"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1871), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("e3f78cbd-7895-4b15-a890-65e9161e07fa"), new DateTime(2020, 10, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1864), 1000, true, 500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("cd2aef01-1671-441f-9dce-69adc3c0711a"), new DateTime(2020, 9, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1854), 5000, true, 2500, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("d3e3efe2-7901-45ff-875b-4b41ac6222b2"), new DateTime(2020, 9, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1757), 2000, true, 1000, 1, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("c08637ce-8132-4542-a89e-1c3c44298f95"), new DateTime(2020, 11, 7, 21, 43, 58, 694, DateTimeKind.Local).AddTicks(1939), 500, true, 508, 0, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreationDate", "FormattedNews", "IsActive", "Preview", "PublisherUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("c668234d-7ad9-4b45-bc0f-d0800d5fa797"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(8830), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #5" },
                    { new Guid("0cf126f5-38cf-4f42-8726-143a22281fec"), new DateTime(2021, 1, 7, 21, 42, 18, 693, DateTimeKind.Local).AddTicks(8814), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #3" },
                    { new Guid("8bb704f9-c841-4114-af88-c9c700b52246"), new DateTime(2021, 1, 7, 21, 43, 8, 693, DateTimeKind.Local).AddTicks(8822), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #4" },
                    { new Guid("5469ec0c-04d6-4063-b7e9-efafe7aae1c8"), new DateTime(2021, 1, 7, 21, 40, 38, 693, DateTimeKind.Local).AddTicks(8228), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #1" },
                    { new Guid("7fd89664-5038-4083-b05b-8724055f202c"), new DateTime(2021, 1, 7, 21, 41, 28, 693, DateTimeKind.Local).AddTicks(8799), "Ez itt a hír tartalma.", true, "Ez a hír előnézeti szövege.", new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"), "Teszt Hír #2" }
                });

            migrationBuilder.InsertData(
                table: "PasswordResetCodes",
                columns: new[] { "Id", "Code", "CreationDate", "IsActive", "IsUsed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f161253f-9665-4910-8e57-aa54e792c5e4"), new Guid("f1fbb28d-a74a-4d8a-a99e-946ab09a6331"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(4736), true, false, new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5") },
                    { new Guid("140d5d13-c5b3-43ac-ae69-7f447d521ac4"), new Guid("45672148-4071-4a95-b32c-d2908a57a753"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(5759), true, false, new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698") }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("a250bdbc-372b-46e9-bd2f-6de6ff029c54"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(3809), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ebc400fd-cab8-4dfa-b774-dce3e6c1f7ef"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(3936), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("831a9efd-1995-4bc8-b0a3-968632418b95"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(3948), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("74323f61-b48a-4146-85bb-0214dd6c7dca"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(3960), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("790fc405-dcb5-47f7-9efc-7eb15089209b"), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(9463), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("1b2dd3e4-6b65-4dcf-bcf9-b0619ee89f83"), new DateTime(2021, 1, 7, 21, 43, 58, 693, DateTimeKind.Local).AddTicks(3954), "test description", "http://localhost:4200/assets/img/add-icon.png", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(2716), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(4430), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7262), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7267), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                columns: new[] { "CreationDate", "LastAuthenticationDate", "RegistrationDate" },
                values: new object[] { new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7165), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7218), new DateTime(2021, 1, 7, 21, 43, 58, 692, DateTimeKind.Local).AddTicks(7233) });
        }
    }
}
