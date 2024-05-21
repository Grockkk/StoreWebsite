using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System;
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
    }
}
