using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class newToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "photos/laptopy/dell-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "photos/laptopy/lenovo-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "photos/laptopy/gaming-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "photos/laptopy/gaming-2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "photos/laptopy/macbook.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 6, 2, "Kod aktywacyjny do programu Microsoft Windows 11 Home", "photos/Oprogramowanie/Windows11Home.jpg", "Windows 11 Home", 679m, 20 },
                    { 7, 2, "Kod aktywacyjny do programu Microsoft Windows 11 Pro", "photos/Oprogramowanie/Windows11Pro.jpg", "Program Microsoft Windows 11 Pro", 1419m, 100 },
                    { 8, 2, "Kod aktywacyjny do programu Microsoft Windows 10 Home", "photos/Oprogramowanie/Windows10Home.jpg", "Program Microsoft Windows 10 Home", 299m, 100 },
                    { 9, 2, "Kod aktywacyjny do programu Microsoft Windows 10 Pro", "photos/Oprogramowanie/Windows10Pro.jpg", "Program Microsoft Windows 10 Pro", 700m, 4300 },
                    { 10, 3, "Słuchawki bezprzewodowe - 2,4 GHz, nauszne, zamknięte, PC/laptop, PlayStation 4", "photos/akcesoria/SteelSeries-7.jpg", "Słuchawki bezprzewodowe z mikrofonem SteelSeries Arctis 7", 589m, 4300 },
                    { 11, 3, "Myszka bezprzewodowa", "photos/akcesoria/hp-920.jpg", "Myszka HP 920 Ergo Vertical", 249m, 4300 },
                    { 12, 3, "Myszka optyczna przewodowa", "photos/akcesoria/SteelSeries-myszka.jpg", "Myszka gamingowa SteelSeries Rival 3", 149m, 4300 },
                    { 13, 3, "Myszka laserowa bezprzewodowa", "photos/akcesoria/myszka-mac.jpg", "Myszka Apple Magic Mouse", 333m, 4300 },
                    { 14, 3, "Klawiatura mechaniczna Genesis Thor 303", "photos/akcesoria/klawiatura-genesis.jpg", "Genesis Thor 303", 249m, 4300 },
                    { 15, 3, "Klawiatura membranowa SteelSeries Apex 3", "photos/akcesoria/klawiatura-steelseries.jpg", "SteelSeries Apex 3", 249m, 4300 },
                    { 16, 3, "Klawiatura membranowa Logitech G213 Prodigy", "photos/akcesoria/klawiatura-logitech.jpg", "Logitech G213", 116m, 4300 },
                    { 17, 3, "Słuchawki bezprzewodowe z mikrofonem Corsair HS55", "photos/akcesoria/sluchawki-logitech.jpg", "Corsair HS55", 309m, 4300 },
                    { 18, 3, "Słuchawki przewodowe z mikrofonem Trust GXT 408 Cobra", "photos/akcesoria/trust-Gtx.jpg", "Trust GXT", 309m, 4300 },
                    { 19, 4, "Karta graficzna Gigabyte Radeon RX 6600 EAGLE 8GB GDDR6 128bit FSR", "photos/podzespoły/kartyGraficzne-RX6600.jpg", "Gigabyte Radeon RX 6600 EAGLE 8GB", 949m, 4300 },
                    { 20, 4, "Karta graficzna Inno3D GeForce RTX 4080 Super X3 OC 16GB GDDR6X 256bit DLSS 3", "photos/podzespoły/kartyGraficzne-Inno3D.jpg", "Inno3D GeForce RTX 4080", 5600m, 4300 },
                    { 21, 4, "Procesor AMD Ryzen 5 5600G BOX", "photos/podzespoły/Procesor-Ryzen5.jpg", "AMD Ryzen 5 5600G", 599m, 4300 },
                    { 22, 4, "Procesor Intel® Core™ i5-12400F BOX", "photos/podzespoły/Procesor-Intel.jpg", "Intel® Core™ i5-12400F", 579m, 4300 },
                    { 23, 4, "Dysk GoodRam CX400 Gen.2 512GB", "photos/podzespoły/Dysk-GoodRam.jpg", "Dysk GoodRam CX400", 149m, 4300 },
                    { 24, 4, "Płyta główna ASUS PRIME B660M-K D4 DDR4", "photos/podzespoły/płytaGłówna-Asus.jpg", "ASUS PRIME B660M-K", 369m, 4300 },
                    { 25, 5, "Monitor Samsung Odyssey OLED G8 S34BG850SU 34\" UWQHD OLED 175Hz 0,03ms Zakrzywiony Gamingowy", "photos/monitory/samsung-Odyssey.jpg", "Monitor Samsung Odyssey OLED", 4339m, 4300 },
                    { 26, 5, "Monitor HP X32c 32\" Full HD VA 165Hz 1ms Zakrzywiony Gamingowy", "photos/monitory/hp-X32c.jpg", "Monitor HP X32c", 799m, 4300 },
                    { 27, 5, "Monitor Philips 272E1GAJ/00 27\" Full HD VA 144Hz 1ms Gamingowy", "photos/monitory/philips-27.jpg", "Monitor Philips 272E1GAJ/00", 679m, 4300 },
                    { 28, 5, "Monitor ASUS ZenScreen MB16AHG 16\" Full HD IPS 144Hz 3ms Przenośny", "photos/monitory/asus-mb.jpg", "Monitor ASUS ZenScreen MB16AHG", 899m, 4300 },
                    { 29, 5, "Monitor ASUS VY249HGE 24\" Full HD IPS 144Hz 1ms Gamingowy", "photos/monitory/asus-vy.jpg", "Monitor ASUS VY249HGE", 1259m, 4300 },
                    { 30, 6, "Komputer gamingowy HP OMEN 40L GT21-0094nw R5 5600G 16GB RAM 1TB Dysk SSD RTX3060 Win11", "photos/zestawy/HP-omen.jpg", "Komputer gamingowy HP OMEN", 4999m, 4300 },
                    { 31, 6, "Komputer Dell Vostro 3710 SFF i5-12400 8GB RAM 512GB Dysk SSD Win11 Pro", "photos/zestawy/Dell-vostro.jpg", "Komputer Dell Vostro 3710", 2369m, 4300 },
                    { 32, 6, "Komputer gamingowy Optimus E-Sport GB660T-CR5 i5-12400F 16GB RAM 1TB Dysk SSD RTX3060 Win11", "photos/zestawy/Optimus.jpg", "Komputer gamingowy Optimus", 2369m, 4300 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "photos/dell-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "photos/lenovo-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "photos/gaming-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "photos/gaming-2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty1.png");
        }
    }
}
