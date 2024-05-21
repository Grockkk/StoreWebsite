using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class intToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "Comments",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 34, 50, 168, DateTimeKind.Local).AddTicks(3038), 5.0 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ProductId", "UserName", "Value" },
                values: new object[] { 2, "Słaby laptop", new DateTime(2024, 5, 20, 15, 34, 50, 168, DateTimeKind.Local).AddTicks(3103), 2, "Adam", 4.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 21, 58, 449, DateTimeKind.Local).AddTicks(2720), 5 });
        }
    }
}
