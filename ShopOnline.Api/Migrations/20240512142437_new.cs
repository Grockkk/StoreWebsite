using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.themakijaz.pl%2Fmakijaz-okazjonalny%2F&psig=AOvVaw20CZCY6igvNkMg4kGHQIus&ust=1715609962918000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIC_1qWniIYDFQAAAAAdAAAAABAE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty1.png");
        }
    }
}
