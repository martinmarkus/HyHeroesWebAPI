using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "InvoiceIssuers");

            migrationBuilder.DropTable(
                name: "InvoiceRequesters");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.CreateTable(
                name: "BillingTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IsBilled = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    VevoAdoszam = table.Column<string>(nullable: true),
                    VevoSendEmail = table.Column<string>(nullable: true),
                    VevoAzonosito = table.Column<string>(nullable: true),
                    VevoEmail = table.Column<string>(nullable: true),
                    VevoMegjegyzes = table.Column<string>(nullable: true),
                    VevoTelefonszam = table.Column<string>(nullable: true),
                    VevoNev = table.Column<string>(nullable: true),
                    VevoIrsz = table.Column<string>(nullable: true),
                    VevoTelepules = table.Column<string>(nullable: true),
                    VevoCim = table.Column<string>(nullable: true),
                    VevoPostazasiNev = table.Column<string>(nullable: true),
                    VevoPostazasiIrsz = table.Column<string>(nullable: true),
                    VevoPostazasiTelepules = table.Column<string>(nullable: true),
                    VevoPostazasiCim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingTransactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingTransactions");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    AddressLine = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CityName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceIssuers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    AddressId = table.Column<Guid>(type: "char(36)", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EuTaxNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TaxNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceIssuers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceIssuers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceRequesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    AddressId = table.Column<Guid>(type: "char(36)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TaxNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceRequesters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceRequesters_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InvoiceIssuerId = table.Column<Guid>(type: "char(36)", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    InvoiceRequesterId = table.Column<Guid>(type: "char(36)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PaymentDeadlineDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_InvoiceIssuers_InvoiceIssuerId",
                        column: x => x.InvoiceIssuerId,
                        principalTable: "InvoiceIssuers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_InvoiceRequesters_InvoiceRequesterId",
                        column: x => x.InvoiceRequesterId,
                        principalTable: "InvoiceRequesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    GrossPrice = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NetUnitPrice = table.Column<int>(type: "int", nullable: false),
                    VtszSzjTeszor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceIssuers_AddressId",
                table: "InvoiceIssuers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceRequesters_AddressId",
                table: "InvoiceRequesters",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceIssuerId",
                table: "Invoices",
                column: "InvoiceIssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceRequesterId",
                table: "Invoices",
                column: "InvoiceRequesterId");
        }
    }
}
