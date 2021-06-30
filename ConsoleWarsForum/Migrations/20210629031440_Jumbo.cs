using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleWarsForum.Migrations
{
    public partial class Jumbo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                column: "DateAndTimeStamp",
                value: new DateTime(2021, 6, 28, 20, 14, 39, 557, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                column: "DateAndTimeStamp",
                value: new DateTime(2021, 6, 28, 20, 14, 39, 557, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                column: "DateAndTimeStamp",
                value: new DateTime(2021, 6, 28, 20, 14, 39, 557, DateTimeKind.Local).AddTicks(2830));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                column: "DateAndTimeStamp",
                value: new DateTime(2021, 6, 23, 20, 29, 5, 650, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                column: "DateAndTimeStamp",
                value: new DateTime(2021, 6, 23, 20, 29, 5, 650, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                column: "DateAndTimeStamp",
                value: new DateTime(2021, 6, 23, 20, 29, 5, 650, DateTimeKind.Local).AddTicks(1316));
        }
    }
}
