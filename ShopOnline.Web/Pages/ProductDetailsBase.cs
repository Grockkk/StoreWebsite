﻿using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public IManageProductsLocalStorageService ManageProductsLocalStorageService { get; set; }

        [Inject]
        public IManageCartItemsLocalStorageService ManageCartItemsLocalStorageService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ProductDto Product { get; set; }

        public string ErrorMessage { get; set; }

        private List<CartItemDto> ShoppingCartItems { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductService.GetItem(Id);
                ShoppingCartItems = await ManageCartItemsLocalStorageService.GetCollection();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
        {
            var users = await UserService.GetUsers();
            var user = users.SingleOrDefault(u => u.Autentykacja);

            if (user != null)
            {
                cartItemToAddDto.CartId = user.Id;
                var existingItem = ShoppingCartItems.FirstOrDefault(item => item.ProductId == cartItemToAddDto.ProductId);

                if (existingItem != null)
                {
                    existingItem.Qty += cartItemToAddDto.Qty;
                    existingItem.TotalPrice = existingItem.Price * existingItem.Qty;
                    await ShoppingCartService.UpdateQty(new CartItemQtyUpdateDto
                    {
                        CartItemId = existingItem.Id,
                        Qty = existingItem.Qty
                    });
                }
                else
                {
                    var addedItem = await ShoppingCartService.AddItem(cartItemToAddDto);
                    ShoppingCartItems.Add(new CartItemDto
                    {
                        Id = addedItem.Id,
                        ProductId = addedItem.ProductId,
                        ProductName = Product.Name,
                        ProductImageURL = Product.ImageURL,
                        Price = Product.Price,
                        Qty = cartItemToAddDto.Qty,
                        TotalPrice = Product.Price * cartItemToAddDto.Qty
                    });
                }

                await ManageCartItemsLocalStorageService.SaveCollection(ShoppingCartItems);

                ShoppingCartService.RaiseEventOnShoppingCartChanged(ShoppingCartItems.Sum(i => i.Qty));
            }
        }
    }
}
