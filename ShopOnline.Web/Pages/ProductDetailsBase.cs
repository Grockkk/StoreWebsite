using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public ICommentService CommentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ProductDto Product { get; set; }
        public UserDto User { get; set; }
        public string ErrorMessage { get; set; }

        private List<CartItemDto> ShoppingCartItems { get; set; }
        public List<CommentDto> Comments { get; set; }
        public CommentDto NewComment { get; set; } = new CommentDto();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var users = await UserService.GetUsers();
                User = users.FirstOrDefault(x => x.Autentykacja == true);
                Product = await ProductService.GetItem(Id);
                ShoppingCartItems = await ManageCartItemsLocalStorageService.GetCollection();
                await LoadComments();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var users = await UserService.GetUsers();
                User = users.FirstOrDefault(x => x.Autentykacja == true);

                if (User != null)
                {
                    cartItemToAddDto.CartId = User.Id;
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
                else
                {
                    NavigationManager.NavigateTo("/login");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        private async Task LoadComments()
        {
            try
            {
                Comments = await CommentService.GetCommentsByProduct(Product.Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
