using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Collections.Generic;
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

        public async Task<IEnumerable<CommentDto>> GetCommentsByProduct(int productId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CommentDto>>($"api/comment/{productId}");
        }

        public async Task<CommentDto> AddComment(CommentDto commentDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/comment", commentDto);
            return await response.Content.ReadFromJsonAsync<CommentDto>();
        }
    }
}
