using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories;
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
        private readonly IUserRepository _userRepository;


        public CommentController(ICommentRepository commentRepository, IUserRepository userRepository)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
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
                Value = c.Value,
                UserName = c.UserName
            });

            return Ok(commentDtos);
        }

        [HttpPost]
        public async Task<ActionResult<CommentDto>> AddComment(CommentDto commentDto)
        {
            var users = await this._userRepository.GetUsers();
            var user = users.FirstOrDefault(x => x.Autentykacja == true);

            var comment = new Comment
            {
                Content = commentDto.Content,
                CreatedAt = DateTime.UtcNow,
                ProductId = commentDto.ProductId,
                UserName = user.UserName,
                Value = commentDto.Value,
            };

            var addedComment = await _commentRepository.AddComment(comment);

            commentDto.Id = addedComment.Id;
            commentDto.CreatedAt = addedComment.CreatedAt;

            return CreatedAtAction(nameof(GetCommentsByProduct), new { productId = commentDto.ProductId }, commentDto);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var userToDelete = await _commentRepository.GetCommentsByProduct(id);
                if (userToDelete == null)
                {
                    return NotFound();
                }

                await _commentRepository.DeleteComment(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
