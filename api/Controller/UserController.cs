
using api.Interfaces;
using api.Command.UserDto;
using Microsoft.AspNetCore.Mvc;
using api.Mappers;
using api.Repository;

namespace api.Controller
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;


        public UserController(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            var userAccaunt = await _userRepo.GetIdAsync(id);
            if (userAccaunt == null)
                return NotFound();

            return Ok(userAccaunt.UserToDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserCreateDto userCreateDto)
        {
            if (userCreateDto == null)
                return BadRequest();

            var userAccaunt = userCreateDto.ToUserFromCreate();
            await _userRepo.CreateAsync(userAccaunt);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = userAccaunt.Id }, userAccaunt.UserToDto());
        }
        [HttpDelete]
        [Route("{id}:{guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            var userModel = _userRepo.DeleteAsync(id);
            if (userModel == null)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}