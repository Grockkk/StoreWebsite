using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class Kompik24DbContext:DbContext
    {
        public Kompik24DbContext(DbContextOptions<Kompik24DbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			//Products
			//Beauty Category
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "Shoes",
				IconCSS = "fas fa-shoe-prints"
			});


		}

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
