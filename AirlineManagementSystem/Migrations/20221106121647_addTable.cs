using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineManagementSystem.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_AeroPlane",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APlaneName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AeroPlane", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CPassword = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FlightBooking",
                columns: table => new
                {
                    FBId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    To = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DTime = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PlaneId = table.Column<int>(type: "int", nullable: false),
                    PlaneInfoPlaneId = table.Column<int>(type: "int", nullable: true),
                    SeatType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FlightBooking", x => x.FBId);
                    table.ForeignKey(
                        name: "FK_Tbl_FlightBooking_Tbl_AeroPlane_PlaneInfoPlaneId",
                        column: x => x.PlaneInfoPlaneId,
                        principalTable: "Tbl_AeroPlane",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_FlightBooking_PlaneInfoPlaneId",
                table: "Tbl_FlightBooking",
                column: "PlaneInfoPlaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Admin");

            migrationBuilder.DropTable(
                name: "Tbl_FlightBooking");

            migrationBuilder.DropTable(
                name: "Tbl_User");

            migrationBuilder.DropTable(
                name: "Tbl_AeroPlane");
        }
    }
}
