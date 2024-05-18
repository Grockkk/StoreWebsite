using Blazored.LocalStorage;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Services
{
    public class ManageCartItemsLocalStorageService : IManageCartItemsLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IShoppingCartService shoppingCartService;
        private readonly IUserService userService;

        const string key = "CartItemCollection";

        public ManageCartItemsLocalStorageService(ILocalStorageService localStorageService,
                                                  IShoppingCartService shoppingCartService,
                                                  IUserService userService)
        {
            this.localStorageService = localStorageService;
            this.shoppingCartService = shoppingCartService;
            this.userService = userService;
        }

        public async Task<List<CartItemDto>> GetCollection()
        {
            return await this.localStorageService.GetItemAsync<List<CartItemDto>>(key)
                    ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
            await this.localStorageService.RemoveItemAsync(key);
        }

        public async Task SaveCollection(List<CartItemDto> cartItemDtos)
        {
            await this.localStorageService.SetItemAsync(key, cartItemDtos);
        }

        private async Task<List<CartItemDto>> AddCollection()
        {
            // Pobierz użytkownika z polem Autentykacja ustawionym na true
            var userId = await GetAuthenticatedUserId();
            if (userId == 0)
            {
                return new List<CartItemDto>();
            }

            var shoppingCartCollection = await this.shoppingCartService.GetItems(userId);

            if (shoppingCartCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, shoppingCartCollection);
            }

            return shoppingCartCollection;
        }

        private async Task<int> GetAuthenticatedUserId()
        {
            var users = await userService.GetUsers();
            var user = users.FirstOrDefault(u => u.Autentykacja);
            return user?.Id ?? 0; // 0 może oznaczać brak użytkownika
        }
    }
}
