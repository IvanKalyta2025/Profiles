
using api.Interfaces;
using api.Command.UserDto;
using Microsoft.AspNetCore.Mvc;
using api.Mappers;

namespace api.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;


        public UserController(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        [HttpPost("/createuser")]
        public async Task<IActionResult> CreateAsync([FromBody] UserCreateDto userCreateDto)
        {
            if (userCreateDto == null)
                return BadRequest();

            var userAccaunt = userCreateDto.ToUserFromCreate();
            await _userRepo.CreateAsync(userAccaunt);
            return CreatedAtAction(nameof(CreateAsync), new { id = userAccaunt.Id }, userAccaunt.UserToDto());
        }
    }
}