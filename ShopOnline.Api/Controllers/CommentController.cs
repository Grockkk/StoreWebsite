using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsByProduct(int productId)
        {
            var comments = await _commentRepository.GetCommentsByProduct(productId);

            var commentDtos = comments.Select(c => new CommentDto
            {
                Id = c.Id,
                Content = c.Content,
                CreatedAt = c.CreatedAt,
                ProductId = c.ProductId,
                UserId = c.UserId
            });

            return Ok(commentDtos);
        }

        [HttpPost]
        public async Task<ActionResult<CommentDto>> AddComment(CommentDto commentDto)
        {
            var comment = new Comment
            {
                Content = commentDto.Content,
                CreatedAt = DateTime.UtcNow,
                ProductId = commentDto.ProductId,
                UserId = commentDto.UserId
            };

            var addedComment = await _commentRepository.AddComment(comment);

            commentDto.Id = addedComment.Id;
            commentDto.CreatedAt = addedComment.CreatedAt;

            return CreatedAtAction(nameof(GetCommentsByProduct), new { productId = commentDto.ProductId }, commentDto);
        }
    }
}
