using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mktSolution.Data.Migrations
{
    public partial class addIdentitytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SCM_Calendar",
                keyColumn: "IdCalendar",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SCM_Orders",
                keyColumn: "IdOrder",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SCM_Orders",
                keyColumn: "IdOrder",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SCM_Products",
                keyColumns: new[] { "IdOrder", "IdProduct" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SCM_Products",
                keyColumns: new[] { "IdOrder", "IdProduct" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SCM_Products",
                keyColumns: new[] { "IdOrder", "IdProduct" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SCM_Products",
                keyColumns: new[] { "IdOrder", "IdProduct" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SCM_Orders",
                keyColumn: "IdOrder",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SCM_Orders",
                keyColumn: "IdOrder",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 978, DateTimeKind.Local).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 455, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 963, DateTimeKind.Local).AddTicks(3226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 440, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ecode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Dept = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 455, DateTimeKind.Local).AddTicks(9110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 978, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 440, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 963, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.InsertData(
                table: "SCM_Calendar",
                columns: new[] { "IdCalendar", "Date", "Descreiption", "WeekNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 1, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 },
                    { 2, new DateTime(2020, 12, 2, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 },
                    { 3, new DateTime(2020, 12, 3, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 },
                    { 4, new DateTime(2020, 12, 4, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 },
                    { 5, new DateTime(2020, 12, 5, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 },
                    { 6, new DateTime(2020, 12, 6, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 },
                    { 7, new DateTime(2020, 12, 7, 10, 30, 50, 0, DateTimeKind.Unspecified), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "SCM_Orders",
                columns: new[] { "IdOrder", "CreateBy", "DueDate", "ModelName", "Qty", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 12, 1, 10, 30, 50, 0, DateTimeKind.Unspecified), "A", 1000, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 0, new DateTime(2020, 12, 3, 10, 30, 50, 0, DateTimeKind.Unspecified), "B", 2000, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 0, new DateTime(2020, 12, 5, 10, 30, 50, 0, DateTimeKind.Unspecified), "A", 1300, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 0, new DateTime(2020, 12, 7, 10, 30, 50, 0, DateTimeKind.Unspecified), "C", 5000, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SCM_Products",
                columns: new[] { "IdOrder", "IdProduct", "CreateBy", "DateProduct", "Jobname", "ModelName", "Qty", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2020, 12, 2, 10, 30, 50, 0, DateTimeKind.Unspecified), "JN0001", "A", 500, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 3, 0, new DateTime(2020, 12, 3, 10, 30, 50, 0, DateTimeKind.Unspecified), "JN0003", "A", 600, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0, new DateTime(2020, 12, 3, 10, 30, 50, 0, DateTimeKind.Unspecified), "JN0002", "B", 800, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4, 0, new DateTime(2020, 12, 4, 10, 30, 50, 0, DateTimeKind.Unspecified), "JN0004", "B", 1000, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
