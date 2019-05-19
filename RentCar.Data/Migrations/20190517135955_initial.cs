using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CarCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarName = table.Column<string>(nullable: true),
                    CarModel = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    InputDate = table.Column<DateTime>(nullable: false),
                    OutputDate = table.Column<DateTime>(nullable: false),
                    SaveTime = table.Column<DateTime>(nullable: false),
                    isRent = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    WorkerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkerName = table.Column<string>(nullable: true),
                    WorkerSurname = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Password = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    SaveTime = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_Workers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForRents",
                columns: table => new
                {
                    ForRentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentDate = table.Column<DateTime>(nullable: false),
                    FisrtKm = table.Column<int>(nullable: false),
                    LastKm = table.Column<int>(nullable: false),
                    ReceivedFee = table.Column<int>(nullable: false),
                    SaveTime = table.Column<DateTime>(nullable: false),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForRents", x => x.ForRentId);
                    table.ForeignKey(
                        name: "FK_ForRents_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerSurname = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Password = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    SaveTime = table.Column<DateTime>(nullable: false),
                    ForRentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_ForRents_ForRentId",
                        column: x => x.ForRentId,
                        principalTable: "ForRents",
                        principalColumn: "ForRentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CompanyId",
                table: "Cars",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ForRentId",
                table: "Customers",
                column: "ForRentId");

            migrationBuilder.CreateIndex(
                name: "IX_ForRents_CarId",
                table: "ForRents",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_CompanyId",
                table: "Workers",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "ForRents");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
