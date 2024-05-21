using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Products
            // laptopy
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Laptop biznesowy Dell Vostro",
                Description = "Laptop biznesowy Dell Vostro, 8GB RAM, Dysk SSD, Windows 11",
                ImageURL = "photos/laptopy/dell-1.jpg",
                Price = 2749,
                Qty = 20,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Laptop biznesowy Lenovo V17",
                Description = "Laptop biznesowy Lenovo V17 16 GB RAM, Dysk SSD, Windows 11",
                ImageURL = "photos/laptopy/lenovo-1.jpg",
                Price = 4790,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Laptop gamingowy Lenovo Legion Slim 5",
                Description = "Laptop gamingowy Lenovo Legion Slim 5 Procesor Intel Core 13, Nvidia GeForce RTX",
                ImageURL = "photos/laptopy/gaming-1.jpg",
                Price = 6799,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Laptop gamingowy Lenovo LOQ 15APH8",
                Description = "Laptop gamingowy Lenovo LOQ 15APH8, AMD Ryzen 7000, NVVIDIA GeForce RTX",
                ImageURL = "photos/laptopy/gaming-2.jpg",
                Price = 4300,
                Qty = 4300,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Laptop Apple MacBook Air 2024 13,6",
                Description = "Laptop Apple MacBook Air 2024 13,6,  Czip M3, Bateria 18 godzin",
                ImageURL = "photos/laptopy/macbook.jpg",
                Price = 5599,
                Qty = 100,
                CategoryId = 1

            });

            // Oprogramowanie
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Windows 11 Home",
                Description = "Kod aktywacyjny do programu Microsoft Windows 11 Home",
                ImageURL = "photos/Oprogramowanie/Windows11Home.jpg",
                Price = 679,
                Qty = 20,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Program Microsoft Windows 11 Pro",
                Description = "Kod aktywacyjny do programu Microsoft Windows 11 Pro",
                ImageURL = "photos/Oprogramowanie/Windows11Pro.jpg",
                Price = 1419,
                Qty = 100,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Program Microsoft Windows 10 Home",
                Description = "Kod aktywacyjny do programu Microsoft Windows 10 Home",
                ImageURL = "photos/Oprogramowanie/Windows10Home.jpg",
                Price = 299,
                Qty = 100,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Program Microsoft Windows 10 Pro",
                Description = "Kod aktywacyjny do programu Microsoft Windows 10 Pro",
                ImageURL = "photos/Oprogramowanie/Windows10Pro.jpg",
                Price = 700,
                Qty = 4300,
                CategoryId = 2

            });

            // akcesoria
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Słuchawki bezprzewodowe z mikrofonem SteelSeries Arctis 7",
                Description = "Słuchawki bezprzewodowe - 2,4 GHz, nauszne, zamknięte, PC/laptop, PlayStation 4",
                ImageURL = "photos/akcesoria/SteelSeries-7.jpg",
                Price = 589,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Myszka HP 920 Ergo Vertical",
                Description = "Myszka bezprzewodowa",
                ImageURL = "photos/akcesoria/hp-920.jpg",
                Price = 249,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Myszka gamingowa SteelSeries Rival 3",
                Description = "Myszka optyczna przewodowa",
                ImageURL = "photos/akcesoria/SteelSeries-myszka.jpg",
                Price = 149,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Myszka Apple Magic Mouse",
                Description = "Myszka laserowa bezprzewodowa",
                ImageURL = "photos/akcesoria/myszka-mac.jpg",
                Price = 333,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Genesis Thor 303",
                Description = "Klawiatura mechaniczna Genesis Thor 303",
                ImageURL = "photos/akcesoria/klawiatura-genesis.jpg",
                Price = 249,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "SteelSeries Apex 3",
                Description = "Klawiatura membranowa SteelSeries Apex 3",
                ImageURL = "photos/akcesoria/klawiatura-steelseries.jpg",
                Price = 249,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Logitech G213",
                Description = "Klawiatura membranowa Logitech G213 Prodigy",
                ImageURL = "photos/akcesoria/klawiatura-logitech.jpg",
                Price = 116,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Corsair HS55",
                Description = "Słuchawki bezprzewodowe z mikrofonem Corsair HS55",
                ImageURL = "photos/akcesoria/sluchawki-logitech.jpg",
                Price = 309,
                Qty = 4300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Trust GXT",
                Description = "Słuchawki przewodowe z mikrofonem Trust GXT 408 Cobra",
                ImageURL = "photos/akcesoria/trust-Gtx.jpg",
                Price = 309,
                Qty = 4300,
                CategoryId = 3

            });

            // Podzespoły
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Gigabyte Radeon RX 6600 EAGLE 8GB",
                Description = "Karta graficzna Gigabyte Radeon RX 6600 EAGLE 8GB GDDR6 128bit FSR",
                ImageURL = "photos/podzespoły/kartyGraficzne-RX6600.jpg",
                Price = 949,
                Qty = 4300,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Inno3D GeForce RTX 4080",
                Description = "Karta graficzna Inno3D GeForce RTX 4080 Super X3 OC 16GB GDDR6X 256bit DLSS 3",
                ImageURL = "photos/podzespoły/kartyGraficzne-Inno3D.jpg",
                Price = 5600,
                Qty = 4300,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "AMD Ryzen 5 5600G",
                Description = "Procesor AMD Ryzen 5 5600G BOX",
                ImageURL = "photos/podzespoły/Procesor-Ryzen5.jpg",
                Price = 599,
                Qty = 4300,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Intel® Core™ i5-12400F",
                Description = "Procesor Intel® Core™ i5-12400F BOX",
                ImageURL = "photos/podzespoły/Procesor-Intel.jpg",
                Price = 579,
                Qty = 4300,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Dysk GoodRam CX400",
                Description = "Dysk GoodRam CX400 Gen.2 512GB",
                ImageURL = "photos/podzespoły/Dysk-GoodRam.jpg",
                Price = 149,
                Qty = 4300,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "ASUS PRIME B660M-K",
                Description = "Płyta główna ASUS PRIME B660M-K D4 DDR4",
                ImageURL = "photos/podzespoły/płytaGłówna-Asus.jpg",
                Price = 369,
                Qty = 4300,
                CategoryId = 4

            });

            // monitory
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = "Monitor Samsung Odyssey OLED",
                Description = "Monitor Samsung Odyssey OLED G8 S34BG850SU 34\" UWQHD OLED 175Hz 0,03ms Zakrzywiony Gamingowy",
                ImageURL = "photos/monitory/samsung-Odyssey.jpg",
                Price = 4339,
                Qty = 4300,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = "Monitor HP X32c",
                Description = "Monitor HP X32c 32\" Full HD VA 165Hz 1ms Zakrzywiony Gamingowy",
                ImageURL = "photos/monitory/hp-X32c.jpg",
                Price = 799,
                Qty = 4300,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = "Monitor Philips 272E1GAJ/00",
                Description = "Monitor Philips 272E1GAJ/00 27\" Full HD VA 144Hz 1ms Gamingowy",
                ImageURL = "photos/monitory/philips-27.jpg",
                Price = 679,
                Qty = 4300,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = "Monitor ASUS ZenScreen MB16AHG",
                Description = "Monitor ASUS ZenScreen MB16AHG 16\" Full HD IPS 144Hz 3ms Przenośny",
                ImageURL = "photos/monitory/asus-mb.jpg",
                Price = 899,
                Qty = 4300,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 29,
                Name = "Monitor ASUS VY249HGE",
                Description = "Monitor ASUS VY249HGE 24\" Full HD IPS 144Hz 1ms Gamingowy",
                ImageURL = "photos/monitory/asus-vy.jpg",
                Price = 1259,
                Qty = 4300,
                CategoryId = 5

            });

            // zestawy
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 30,
                Name = "Komputer gamingowy HP OMEN",
                Description = "Komputer gamingowy HP OMEN 40L GT21-0094nw R5 5600G 16GB RAM 1TB Dysk SSD RTX3060 Win11",
                ImageURL = "photos/zestawy/HP-omen.jpg",
                Price = 4999,
                Qty = 4300,
                CategoryId = 6

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 31,
                Name = "Komputer Dell Vostro 3710",
                Description = "Komputer Dell Vostro 3710 SFF i5-12400 8GB RAM 512GB Dysk SSD Win11 Pro",
                ImageURL = "photos/zestawy/Dell-vostro.jpg",
                Price = 2369,
                Qty = 4300,
                CategoryId = 6

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 32,
                Name = "Komputer gamingowy Optimus",
                Description = "Komputer gamingowy Optimus E-Sport GB660T-CR5 i5-12400F 16GB RAM 1TB Dysk SSD RTX3060 Win11",
                ImageURL = "photos/zestawy/Optimus.jpg",
                Price = 2369,
                Qty = 4300,
                CategoryId = 6

            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob",
                Password = "1234",
                Autentykacja = false,
                Email = "Bob@kompik.pl",
                Miasto = "Kraków",
                Ulica = "Boczna",
                NumerDomu = "15"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Adam",
                Password = "1234",
                Autentykacja = false,
                Email = "Adam@kompik.pl",
                Miasto = "Kraków",
                Ulica = "Pawia",
                NumerDomu = "5"

            });

            //Create Shopping Cart for  every Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 3,
                UserId = 3

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 4,
                UserId = 4

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 5,
                UserId = 5

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 6,
                UserId = 6

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 7,
                UserId = 7

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 8,
                UserId = 8

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 9,
                UserId = 9

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 10,
                UserId = 10

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 11,
                UserId = 11

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 12,
                UserId = 12

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 13,
                UserId = 13

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 14,
                UserId = 14

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 15,
                UserId = 15

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 16,
                UserId = 16

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 17,
                UserId = 17

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 18,
                UserId = 18

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 19,
                UserId = 19

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Laptopy",
                IconCSS = "fas fa-laptop"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Oprogramowanie",
                IconCSS = "fa-solid fa-window-restore"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Akcesoria",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Podzespoły",
                IconCSS = "fas fa-microchip"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 5,
                Name = "Monitory",
                IconCSS = "fas fa-tv"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 6,
                Name = "Zestawy",
                IconCSS = "fa-solid fa-box-archive"
            });

            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                Id = 1,
                UserName = "Bob1",
                Content = "Bardzo dobry laptop",
                CreatedAt = DateTime.Now,
                ProductId = 1,
                Value = 5.0
            });
            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                Id = 2,
                UserName = "Adam",
                Content = "Słaby laptop",
                CreatedAt = DateTime.Now,
                ProductId = 2,
                Value = 1.5
            });
        }

public DbSet<Cart> Carts { get; set; }
public DbSet<CartItem> CartItems { get; set; }
public DbSet<Product> Products { get; set; }
public DbSet<ProductCategory> ProductCategories { get; set; }
public DbSet<User> Users { get; set; }
public DbSet<Comment> Comments { get; set; }


    }
}
