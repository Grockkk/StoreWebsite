using Blazored.LocalStorage;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Services
{
    public class ManageUserLocalStorageService : IManageUsersLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IUserService userStorageServices;

        const string key = "UserCollection";
        public ManageUserLocalStorageService(ILocalStorageService localStorageService,
                                         IUserService userStorageServices)
        {
            this.localStorageService = localStorageService;
            this.userStorageServices = userStorageServices;
        }
        public async Task<IEnumerable<UserDto>> GetCollection()
        {
            return await this.localStorageService.GetItemAsync<List<UserDto>>(key)
                    ?? await AddCollection();
        }

        private async Task<IEnumerable<UserDto>> AddCollection()
        {
            var productCollection = await this.userStorageServices.GetUsers();

            if (productCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, productCollection);
            }

            return productCollection;

        }
        public async Task SaveCollection(List<UserDto> usersDto)
        {
            await this.localStorageService.SetItemAsync(key, usersDto);
        }
    }
}
