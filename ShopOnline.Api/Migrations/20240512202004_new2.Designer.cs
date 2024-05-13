﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    [Migration("20240512202004_new2")]
    partial class new2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Laptop biznesowy Dell Vostro, 8GB RAM, Dysk SSD, Windows 11",
                            ImageURL = "dell-1.jpg",
                            Name = "Laptop biznesowy Dell Vostro",
                            Price = 2749m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Laptop biznesowy Lenovo V17 16 GB RAM, Dysk SSD, Windows 11",
                            ImageURL = "lenovo-1.jpg",
                            Name = "Laptop biznesowy Lenovo V17",
                            Price = 4790m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Laptop gamingowy Lenovo Legion Slim 5 Procesor Intel Core 13, Nvidia GeForce RTX",
                            ImageURL = "gaming-1.jpg",
                            Name = "Laptop gamingowy Lenovo Legion Slim 5",
                            Price = 6799m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Laptop gamingowy Lenovo LOQ 15APH8, AMD Ryzen 7000, NVVIDIA GeForce RTX",
                            ImageURL = "gaming-2.jpg",
                            Name = "Laptop gamingowy Lenovo LOQ 15APH8",
                            Price = 4300m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Laptop Apple MacBook Air 2024 13,6,  Czip M3, Bateria 18 godzin",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Laptop Apple MacBook Air 2024 13,6",
                            Price = 5599m,
                            Qty = 100
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-laptop",
                            Name = "Laptopy"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fa-solid fa-window-restore",
                            Name = "Oprogramowanie"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Akcesoria"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-microchip",
                            Name = "Podzespoły"
                        },
                        new
                        {
                            Id = 5,
                            IconCSS = "fas fa-tv",
                            Name = "Monitory"
                        },
                        new
                        {
                            Id = 6,
                            IconCSS = "fa-solid fa-box-archive",
                            Name = "Zestawy"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
