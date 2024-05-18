using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IManageUsersLocalStorageService
    {
        Task<IEnumerable<UserDto>> GetCollection();
        Task SaveCollection(List<UserDto> usersDto);
    }
}
