using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class ProductCategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "ProductCategories",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.InsertData(
                table: "ActualValueOfOneKredit",
                columns: new[] { "Id", "CreationDate", "IsActive", "Value" },
                values: new object[] { new Guid("c6f933c7-a11a-4aa3-857b-088aceb14d13"), new DateTime(2020, 12, 27, 21, 7, 2, 777, DateTimeKind.Local).AddTicks(9993), true, 2m });

            migrationBuilder.InsertData(
                table: "GameServers",
                columns: new[] { "Id", "CreationDate", "IsActive", "IsServerRunning", "ServerName" },
                values: new object[,]
                {
                    { new Guid("f810b229-3160-4c74-a173-c73f96728239"), new DateTime(2020, 12, 27, 21, 7, 2, 775, DateTimeKind.Local).AddTicks(3317), true, true, "GTA" },
                    { new Guid("cf5ff68d-08fe-44bc-9f84-134205f36c13"), new DateTime(2020, 12, 27, 21, 7, 2, 777, DateTimeKind.Local).AddTicks(1975), true, true, "Survival" },
                    { new Guid("22af5358-e9eb-433e-a02f-1b8207efdadc"), new DateTime(2020, 12, 27, 21, 7, 2, 777, DateTimeKind.Local).AddTicks(2014), true, true, "Skyblock" },
                    { new Guid("0f9909a4-75f2-412d-bc21-0839aaa29e95"), new DateTime(2020, 12, 27, 21, 7, 2, 777, DateTimeKind.Local).AddTicks(2020), true, false, "RPG" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("53d3761b-2ae9-407f-be84-b42848c2ec98"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(7430), "test description", "test url", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e8b3692c-597c-42ae-801b-12c823fca6b6"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(7500), "test description", "test url", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("e325f360-5fcc-42ee-9134-7df1ebbd0693"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(7517), "test description", "test url", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4153d42e-9dea-4ba3-91ae-50864ed70f8d"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(7522), "test description", "test url", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4a2db96e-f5a0-4912-a389-47a9af35b902"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(5563), "test description", "test url", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("73cbb62d-f635-44ff-a66c-cd9e100736e8"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(7512), "test description", "test url", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Currency", "Email", "HyCoin", "IsActive", "IsBanned", "LastAuthenticationDate", "LastAuthenticationIp", "PasswordHash", "PasswordSalt", "RegistrationDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("797a8443-2193-4900-8680-cdc927375c3e"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(2197), 1000000, "martinmarkus0@gmail.com", 10000, true, false, new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(2974), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(3407), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic" },
                    { new Guid("6819d008-dd5b-4bfd-8fea-61a76a4fc8b2"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4263), 50000, "birdemic2@gmail.com", 4000, true, false, new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4304), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4321), new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"), "birdemic2" },
                    { new Guid("3c571497-d775-4ed2-a259-a2b5792c5ac9"), new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4353), 40000, "hatoska@gmail.com", 3000, true, false, new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4356), "localhost", "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N", "6yuhyavedvvwufmjpln1cjuqrm6agpvh", new DateTime(2020, 12, 27, 21, 7, 2, 778, DateTimeKind.Local).AddTicks(4359), new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"), "hatoska" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActualValueOfOneKredit",
                keyColumn: "Id",
                keyValue: new Guid("c6f933c7-a11a-4aa3-857b-088aceb14d13"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("0f9909a4-75f2-412d-bc21-0839aaa29e95"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("22af5358-e9eb-433e-a02f-1b8207efdadc"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("cf5ff68d-08fe-44bc-9f84-134205f36c13"));

            migrationBuilder.DeleteData(
                table: "GameServers",
                keyColumn: "Id",
                keyValue: new Guid("f810b229-3160-4c74-a173-c73f96728239"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4153d42e-9dea-4ba3-91ae-50864ed70f8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a2db96e-f5a0-4912-a389-47a9af35b902"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53d3761b-2ae9-407f-be84-b42848c2ec98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73cbb62d-f635-44ff-a66c-cd9e100736e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e325f360-5fcc-42ee-9134-7df1ebbd0693"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8b3692c-597c-42ae-801b-12c823fca6b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c571497-d775-4ed2-a259-a2b5792c5ac9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6819d008-dd5b-4bfd-8fea-61a76a4fc8b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("797a8443-2193-4900-8680-cdc927375c3e"));

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "ProductCategories");

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

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                column: "CreationDate",
                value: new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ImageUrl", "InGameActivatorCommand", "InGameDeactivatorCommand", "IsActive", "IsRank", "Name", "OneTimeCommand", "PermanentPrice", "PricePerMonth", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("138ff873-f29a-4a25-9640-75bc39dea57f"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8504), "test description", "test url", "activate", "deactivate", true, true, "Bajnok rang", "onetime command", 6000, 3000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("4078e50e-b269-41bb-99c6-7518ed16ed33"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8588), "test description", "test url", "activate", "deactivate", true, true, "Elit rang", "onetime command", 10000, 5000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("31f5926e-eb42-4fb0-875b-a705a2a4b3c3"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8600), "test description", "test url", "activate", "deactivate", true, true, "HiperSzuperElit rang", "onetime command", 16000, 10000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("b8710cfe-aa63-4688-a1d3-03f22a3bccf9"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8605), "test description", "test url", "activate", "deactivate", true, true, "ExtraSzuperElit rang", "onetime command", 20000, 16000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("ede98ed4-19ab-40a3-a0e8-bafde62e64a2"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(6576), "test description", "test url", "activate", "deactivate", true, true, "VIP rang", "onetime command", 2000, 1000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") },
                    { new Guid("16aac963-a741-4937-983d-6cb259901b83"), new DateTime(2020, 12, 27, 20, 35, 38, 665, DateTimeKind.Local).AddTicks(8595), "test description", "test url", "activate", "deactivate", true, true, "SzuperElit rang", "onetime command", 14000, 8000, new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0") }
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
        }
    }
}
