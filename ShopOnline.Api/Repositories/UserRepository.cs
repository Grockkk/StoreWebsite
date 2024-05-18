using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public UserRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
        private async Task<bool> UserNameExists(UserDto user)
        {
            return await this.shopOnlineDbContext.Users.AnyAsync(c => c.Email == user.Email &&
                                                                     c.Id == user.Id);
        }

        public async Task<User> AddUser(UserDto userToAdd)
        {
            
            var user = new User
            {
                UserName = userToAdd.UserName,
                Password = userToAdd.Password,
                Autentykacja = false,
                Email = userToAdd.Email,
                Id= userToAdd.Id,
                Miasto= userToAdd.Miasto,
                Ulica = userToAdd.Ulica,
                NumerDomu = userToAdd.NumerDomu,
            };

            this.shopOnlineDbContext.Users.Add(user);

            await this.shopOnlineDbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await shopOnlineDbContext.Users.FirstOrDefaultAsync(p => p.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await this.shopOnlineDbContext.Users.ToListAsync();

            return users;
        }

        public async Task<User> UpdateUser(User user)
        {
            try
            {
                // Zaktualizuj encję użytkownika
                shopOnlineDbContext.Entry(user).State = EntityState.Modified;
                await shopOnlineDbContext.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user", ex);
            }
        }
        public async Task DeleteUser(int id)
        {
            var user = await GetUser(id);
            if (user != null)
            {
                shopOnlineDbContext.Users.Remove(user);
                await shopOnlineDbContext.SaveChangesAsync();
            }
        }
    }
}
