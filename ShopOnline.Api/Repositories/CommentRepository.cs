using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopOnline.Api.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ShopOnlineDbContext _dbContext;

        public CommentRepository(ShopOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Comment> AddComment(Comment comment)
        {
            await _dbContext.SaveChangesAsync();
            return comment;
        }

        public Task<IEnumerable<Comment>> GetCommentsByProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
