using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    public class ProductDetailsBase:ComponentBase
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
                await ShoppingCartService.AddItem(cartItemToAddDto);
            }
        }

        private async Task<ProductDto> GetProductById(int id)
        {
            var productDtos = await ManageProductsLocalStorageService.GetCollection();

            if(productDtos!=null)
            {
                return productDtos.SingleOrDefault(p => p.Id == id);
            }
            return null;
        }
        private async Task <int> GetCartId()
        {
            // Zakładamy, że `GetCartIdByUserId` jest metodą w serwisie ShoppingCartService,
            // która zwraca CartId na podstawie UserId
            var cart = await UserService.GetUsers();
            var id = cart.FirstOrDefault(u => u.Autentykacja == true);
            return id.Id;
        }

    }
}
