using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsers();
        Task<UserDto> GetUser(int id);
        Task<UserDto> AddUser(UserDto user);
        Task DeleteUser(int userId); // Nowa metoda

    }
}
