using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http;
using System.Net.Http.Json;


namespace ShopOnline.Web.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<UserDto> AddUser(UserDto user)
        {
            try
            {
                // Wywołaj metodę API do dodawania użytkownika
                var response = await httpClient.PostAsJsonAsync("api/User", user);

                // Sprawdź, czy odpowiedź jest poprawna
                response.EnsureSuccessStatusCode();

                // Odczytaj dodanego użytkownika z odpowiedzi
                return await response.Content.ReadFromJsonAsync <UserDto>();
            }
            catch (Exception ex)
            {
                // Obsłuż wyjątek
                throw new Exception("Failed to add user to the database.", ex);
            }
        }
        private async Task <int> GetHighestUserId()
        {
            var users = await GetUsers();
            if (users.Any())
            {
                return users.Max(u => u.Id);
            }
            else
            {
                return 0; // Jeśli nie ma żadnych użytkowników, zwróć 0 jako początkowe Id
            }
        }

        public async Task<UserDto> GetUser(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/User/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(UserDto);
                    }

                    return await response.Content.ReadFromJsonAsync<UserDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/User");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<UserDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<UserDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }

            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
        public async Task DeleteUser(int userId)
        {
            await httpClient.DeleteAsync($"api/User/{userId}");
        }

    }
}
