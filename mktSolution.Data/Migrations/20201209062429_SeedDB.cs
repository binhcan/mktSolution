using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mktSolution.Data.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 455, DateTimeKind.Local).AddTicks(9110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 9, 12, 10, 58, 63, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 440, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 9, 12, 10, 58, 41, DateTimeKind.Local).AddTicks(8095));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2020, 12, 9, 12, 10, 58, 63, DateTimeKind.Local).AddTicks(8351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 455, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SCM_Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 9, 12, 10, 58, 41, DateTimeKind.Local).AddTicks(8095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 9, 13, 24, 28, 440, DateTimeKind.Local).AddTicks(1711));
        }
    }
}
