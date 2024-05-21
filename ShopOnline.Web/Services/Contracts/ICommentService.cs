using ShopOnline.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopOnline.Web.Services.Contracts
{
    public interface ICommentService
    {
        Task<List<CommentDto>> GetCommentsByProduct(int productId);
        Task<CommentDto> AddComment(CommentDto commentDto);
    }
}