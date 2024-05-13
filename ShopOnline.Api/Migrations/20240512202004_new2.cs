using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Laptop biznesowy Dell Vostro, 8GB RAM, Dysk SSD, Windows 11", "dell-1.jpg", "Laptop biznesowy Dell Vostro", 2749m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 1, "Laptop biznesowy Lenovo V17 16 GB RAM, Dysk SSD, Windows 11", "lenovo-1.jpg", "Laptop biznesowy Lenovo V17", 4790m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 1, "Laptop gamingowy Lenovo Legion Slim 5 Procesor Intel Core 13, Nvidia GeForce RTX", "gaming-1.jpg", "Laptop gamingowy Lenovo Legion Slim 5", 6799m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 1, "Laptop gamingowy Lenovo LOQ 15APH8, AMD Ryzen 7000, NVVIDIA GeForce RTX", "gaming-2.jpg", "Laptop gamingowy Lenovo LOQ 15APH8", 4300m, 4300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 1, "Laptop Apple MacBook Air 2024 13,6,  Czip M3, Bateria 18 godzin", "Laptop Apple MacBook Air 2024 13,6", 5599m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 5, "A kit provided by Glossier, containing skin care, hair care and makeup products", "Glossier - Beauty Kit", 100m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 6, 6, "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, 100 });
        }
    }
}
