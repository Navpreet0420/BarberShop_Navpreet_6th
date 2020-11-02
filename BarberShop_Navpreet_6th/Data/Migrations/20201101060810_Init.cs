using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop_Navpreet_6th.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarberStaffs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarberStaffs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarberStaffID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    BookingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bookings_BarberStaffs_BarberStaffID",
                        column: x => x.BarberStaffID,
                        principalTable: "BarberStaffs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BarberStaffID",
                table: "Bookings",
                column: "BarberStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerID",
                table: "Bookings",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "BarberStaffs");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
