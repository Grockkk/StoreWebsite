using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Extensions;
using ShopOnline.Api.Repositories;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetItems()
        {
            try
            {
                var users = await this.userRepository.GetUsers();


                if (users == null)
                {
                    return NotFound();
                }
                else
                {
                    var usersDtos = users.ConvertToDto();

                    return Ok(usersDtos);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UserDto>> GetItem(int id)
        {
            try
            {
                var user = await this.userRepository.GetUser(id);

                if (user == null)
                {
                    return BadRequest();
                }
                else
                {

                    var userDto = user.ConvertToDto();

                    return Ok(userDto);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>> PostItem([FromBody] UserDto userToAdd)
        {
            try
            {
                var newUser = await this.userRepository.AddUser(userToAdd);

                if (newUser == null)
                {
                    return NoContent();
                }

                var user = await userRepository.GetUser(newUser.Id);

                if (user == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve product (productId:({newUser.Id})");
                }

                var newUserDto = newUser.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newUserDto.Id }, newUserDto);


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("{id:int}/toggle-authentication")]
        public async Task<IActionResult> ToggleAuthentication(int id)
        {
            try
            {
                var user = await userRepository.GetUser(id);

                if (user == null)
                {
                    return NotFound();
                }

                user.Autentykacja = !user.Autentykacja;

                await userRepository.UpdateUser(user);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var userToDelete = await userRepository.GetUser(id);
                if (userToDelete == null)
                {
                    return NotFound();
                }

                await userRepository.DeleteUser(id);
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
