using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class ProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("b1b412c2-6971-4989-ab0f-8182e5471a18"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("1fe6d96a-17b3-4572-83c8-af8a60f20c61"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("88c8aeea-2551-4549-8462-4fc67dd312be"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("9eddd55d-3542-4dac-8a09-ee43aab76a2b"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("dc25f543-e5d2-4053-b754-9e5a6d5e66f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6be0be6a-35a2-433a-b8e5-e18661e4f1cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dd188c7-fce2-4040-be1c-a14ef005ef35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ae0bc2e-2996-494f-abd7-62939b117191"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("984cfe7b-f08f-4d90-ba3e-3c3e823de5f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2990b2f-010e-4e35-b927-0444c54a8380"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdeabc03-53c3-4993-b9e7-985442c88d64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("061d883b-a550-4bdd-8774-d52852c62c3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a7b4396-f924-4acd-9022-01bf8005a6eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("879408f3-bc9a-44e5-b75f-1d42444b4c47"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "ProductCategoryId",
                table: "Products",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<DateTime>(rowVersion: true, nullable: true)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("781447e3-729f-48a9-ad99-9323d2a6cefc"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(985), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("7d5aa25a-d8e2-4274-9575-0f5e44113254"), new DateTime(2020, 12, 27, 20, 35, 38, 662, DateTimeKind.Local).AddTicks(1399), true, true, "GTA" },
                    { new Guid("972dc718-7923-4f35-96eb-7b8a1021113c"), new DateTime(2020, 12, 27, 20, 35, 38, 664, DateTimeKind.Local).AddTicks(1959), true, true, "Survival" },
                    { new Guid("b725c784-8d5c-48ce-894d-937d3de19191"), new DateTime(2020, 12, 27, 20, 35, 38, 664, DateTimeKind.Local).AddTicks(2001), true, true, "Skyblock" },
                    { new Guid("09a43a93-5d73-4d86-aabd-f83087f9ad54"), new DateTime(2020, 12, 27, 20, 35, 38, 664, DateTimeKind.Local).AddTicks(2007), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreationDate", "IsActive", "Priority" },
                values: new object[,]
                {
                    { new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"), "Rangok", new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5757), true, 1 },
                    { new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"), "Other", new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(6187), true, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("5ed17d47-fa16-4c37-8f61-1cd353349f46"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(3163), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(3953), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(4395), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("7336d34e-7d0e-450f-9e05-770bc50fe229"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5272), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5316), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5332), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" },
                    { new Guid("ade9cb46-57f6-4b13-8d02-2826a244f23a"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5365), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5368), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5371), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("ede98ed4-19ab-40a3-a0e8-bafde62e64a2"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(6576), "test description", "test url", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("138ff873-f29a-4a25-9640-75bc39dea57f"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8504), "test description", "test url", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4078e50e-b269-41bb-99c6-7518ed16ed33"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8588), "test description", "test url", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("16aac963-a741-4937-983d-6cb259901b83"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8595), "test description", "test url", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("31f5926e-eb42-4fb0-875b-a705a2a4b3c3"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8600), "test description", "test url", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("b8710cfe-aa63-4688-a1d3-03f22a3bccf9"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8605), "test description", "test url", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("781447e3-729f-48a9-ad99-9323d2a6cefc"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("09a43a93-5d73-4d86-aabd-f83087f9ad54"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("7d5aa25a-d8e2-4274-9575-0f5e44113254"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("972dc718-7923-4f35-96eb-7b8a1021113c"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("b725c784-8d5c-48ce-894d-937d3de19191"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("138ff873-f29a-4a25-9640-75bc39dea57f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16aac963-a741-4937-983d-6cb259901b83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31f5926e-eb42-4fb0-875b-a705a2a4b3c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4078e50e-b269-41bb-99c6-7518ed16ed33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8710cfe-aa63-4688-a1d3-03f22a3bccf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ede98ed4-19ab-40a3-a0e8-bafde62e64a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ed17d47-fa16-4c37-8f61-1cd353349f46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7336d34e-7d0e-450f-9e05-770bc50fe229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ade9cb46-57f6-4b13-8d02-2826a244f23a"));

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Products");

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
                values: new object[] { new Guid("b1b412c2-6971-4989-ab0f-8182e5471a18"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(330), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("9eddd55d-3542-4dac-8a09-ee43aab76a2b"), new DateTime(2020, 12, 27, 20, 8, 30, 658, DateTimeKind.Local).AddTicks(146), true, true, "GTA" },
                    { new Guid("dc25f543-e5d2-4053-b754-9e5a6d5e66f4"), new DateTime(2020, 12, 27, 20, 8, 30, 660, DateTimeKind.Local).AddTicks(1844), true, true, "Survival" },
                    { new Guid("88c8aeea-2551-4549-8462-4fc67dd312be"), new DateTime(2020, 12, 27, 20, 8, 30, 660, DateTimeKind.Local).AddTicks(1885), true, true, "Skyblock" },
                    { new Guid("1fe6d96a-17b3-4572-83c8-af8a60f20c61"), new DateTime(2020, 12, 27, 20, 8, 30, 660, DateTimeKind.Local).AddTicks(1891), true, false, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth" },
                values: new object[,]
                {
                    { new Guid("7ae0bc2e-2996-494f-abd7-62939b117191"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5605), "test description", "test url", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000 },
                    { new Guid("984cfe7b-f08f-4d90-ba3e-3c3e823de5f4"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(7295), "test description", "test url", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000 },
                    { new Guid("6dd188c7-fce2-4040-be1c-a14ef005ef35"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(7359), "test description", "test url", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000 },
                    { new Guid("6be0be6a-35a2-433a-b8e5-e18661e4f1cb"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(7364), "test description", "test url", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000 },
                    { new Guid("cdeabc03-53c3-4993-b9e7-985442c88d64"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(7374), "test description", "test url", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000 },
                    { new Guid("b2990b2f-010e-4e35-b927-0444c54a8380"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(7379), "test description", "test url", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("879408f3-bc9a-44e5-b75f-1d42444b4c47"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(2946), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(3760), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(4210), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("4a7b4396-f924-4acd-9022-01bf8005a6eb"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5107), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5150), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5165), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" },
                    { new Guid("061d883b-a550-4bdd-8774-d52852c62c3c"), new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5197), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5200), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 20, 8, 30, 661, DateTimeKind.Local).AddTicks(5203), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" }
                });
        }
    }
}
