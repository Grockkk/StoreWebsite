using Kompik24.Api.Data;
using Kompik24.Api.Entities;
using Kompik24.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Kompik24.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Kompik24DbContext kompik24DbContext;

        public ProductRepository(Kompik24DbContext kompik24DbContext)
        {
            this.kompik24DbContext = kompik24DbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.kompik24DbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await kompik24DbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await kompik24DbContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.kompik24DbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;

        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.kompik24DbContext.Products
                                     .Include(p => p.ProductCategory)
                                     .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}
