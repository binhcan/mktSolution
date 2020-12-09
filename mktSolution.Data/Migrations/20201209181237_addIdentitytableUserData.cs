using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mktSolution.Data.Migrations
{
    public partial class addIdentitytableUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 1, 12, 36, 546, DateTimeKind.Local).AddTicks(3842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 978, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 1, 12, 36, 531, DateTimeKind.Local).AddTicks(1288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 963, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "334d98e7-d8b2-491c-bd32-56c61de5784d", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dept", "Ecode", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "52844af0-1fac-4828-a55d-5120343cbbd3", "SE", "110176", "MKV.international@gmail.com", true, false, null, "MKV.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEG2N1QKDupqAhbEtvnTQhK+/XT2jpxtDG53FBUZ7dEeAXiQfePbFQJLp301fBtJIqA==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 978, DateTimeKind.Local).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 1, 12, 36, 546, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 1, 11, 30, 963, DateTimeKind.Local).AddTicks(3226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 1, 12, 36, 531, DateTimeKind.Local).AddTicks(1288));
        }
    }
}
