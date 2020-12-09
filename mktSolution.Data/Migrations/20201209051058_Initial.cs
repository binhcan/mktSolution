using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mktSolution.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SCM_Calendar",
                columns: table => new
                {
                    IdCalendar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descreiption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCM_Calendar", x => x.IdCalendar);
                });

            migrationBuilder.CreateTable(
                name: "SCM_Orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Order"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 9, 12, 10, 58, 41, DateTimeKind.Local).AddTicks(8095)),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCM_Orders", x => x.IdOrder);
                });

            migrationBuilder.CreateTable(
                name: "SCM_Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    IdOrder = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Jobname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    DateProduct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Plan"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 9, 12, 10, 58, 63, DateTimeKind.Local).AddTicks(8351)),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCM_Products", x => new { x.IdOrder, x.IdProduct });
                    table.ForeignKey(
                        name: "FK_SCM_Products_SCM_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "SCM_Orders",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCM_Calendar");

            migrationBuilder.DropTable(
                name: "SCM_Products");

            migrationBuilder.DropTable(
                name: "SCM_Orders");
        }
    }
}
