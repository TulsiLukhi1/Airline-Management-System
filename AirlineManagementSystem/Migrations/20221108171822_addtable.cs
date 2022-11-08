using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineManagementSystem.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdName = table.Column<string>(maxLength: 10, nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_AeroPlane",
                columns: table => new
                {
                    PlaneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APlaneName = table.Column<string>(maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AeroPlane", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Username = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 11, nullable: false),
                    CNIC = table.Column<string>(maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FlightDetails",
                columns: table => new
                {
                    ResID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResFrom = table.Column<string>(nullable: false),
                    ResTo = table.Column<string>(nullable: false),
                    ResDepDate = table.Column<string>(nullable: false),
                    ResTime = table.Column<string>(nullable: false),
                    PlaneId = table.Column<int>(nullable: false),
                    plane_tblsPlaneId = table.Column<int>(nullable: true),
                    PlaneSeat = table.Column<int>(nullable: false),
                    ResTicketPrice = table.Column<float>(nullable: false),
                    ResPlaneType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FlightDetails", x => x.ResID);
                    table.ForeignKey(
                        name: "FK_Tbl_FlightDetails_Tbl_AeroPlane_plane_tblsPlaneId",
                        column: x => x.plane_tblsPlaneId,
                        principalTable: "Tbl_AeroPlane",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FlightBooking",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bCusName = table.Column<string>(nullable: false),
                    bCusAddress = table.Column<string>(nullable: false),
                    bCusEmail = table.Column<string>(nullable: false),
                    bCusSeats = table.Column<string>(nullable: false),
                    bCusPhoneNum = table.Column<string>(nullable: false),
                    bCusCnic = table.Column<string>(nullable: false),
                    ResId = table.Column<int>(nullable: false),
                    fligthDetailsModelResID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FlightBooking", x => x.Bid);
                    table.ForeignKey(
                        name: "FK_Tbl_FlightBooking_Tbl_FlightDetails_fligthDetailsModelResID",
                        column: x => x.fligthDetailsModelResID,
                        principalTable: "Tbl_FlightDetails",
                        principalColumn: "ResID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_FlightBooking_fligthDetailsModelResID",
                table: "Tbl_FlightBooking",
                column: "fligthDetailsModelResID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_FlightDetails_plane_tblsPlaneId",
                table: "Tbl_FlightDetails",
                column: "plane_tblsPlaneId");
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
                name: "Tbl_FlightDetails");

            migrationBuilder.DropTable(
                name: "Tbl_AeroPlane");
        }
    }
}
