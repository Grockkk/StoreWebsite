
using Microsoft.EntityFrameworkCore;
using Kompik24.Api.Data;
using Kompik24.Api.Entities;
using Kompik24.Api.Repositories.Contracts;
using Kompik24.Models.Dtos;

namespace Kompik24.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly Kompik24DbContext kompik24DbContext;

        public ShoppingCartRepository(Kompik24DbContext kompik24DbContext)
        {
            this.kompik24DbContext = kompik24DbContext;
        }

        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.kompik24DbContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                     c.ProductId == productId);

        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in this.kompik24DbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.kompik24DbContext.CartItems.AddAsync(item);
                    await this.kompik24DbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;

        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.kompik24DbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                this.kompik24DbContext.CartItems.Remove(item);
                await this.kompik24DbContext.SaveChangesAsync();
            }
            
            return item;

        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.kompik24DbContext.Carts
                          join cartItem in this.kompik24DbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.kompik24DbContext.Carts
                          join cartItem in this.kompik24DbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await this.kompik24DbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await this.kompik24DbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }
    }
}
