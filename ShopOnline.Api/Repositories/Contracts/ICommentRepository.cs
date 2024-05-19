using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsByProduct(int productId);
        Task<Comment> AddComment(Comment comment);
    }
}
