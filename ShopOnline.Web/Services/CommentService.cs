using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopOnline.Web.Services
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient _httpClient;

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CommentDto>> GetCommentsByProduct(int productId)
        {
            var response = await _httpClient.GetAsync($"api/Comment/{productId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<CommentDto>>();
        }

        public async Task<CommentDto> AddComment(CommentDto commentDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Comment", commentDto);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<CommentDto>();
        }

        // Nowa metoda do pobierania ocen dla danego produktu
        public async Task<double> GetAverageRatingByProduct(int productId)
        {
            var comments = await GetCommentsByProduct(productId);
            if (comments == null || comments.Count == 0)
            {
                // Jeśli brak komentarzy, zwróć 0 jako domyślną ocenę
                return 0;
            }
            else
            {
                // Oblicz średnią ocenę na podstawie komentarzy
                var averageRating = comments.Select(c => c.Value).Average();
                return averageRating;
            }
        }
    }
}