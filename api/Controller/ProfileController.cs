using api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using api.Dtos;
using api.Mappers;


namespace api.Controller
{
    [ApiController]
    [Route("api/profile")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var profile = await _profileRepository.GetByIdAsync(id);

            if (profile == null)
                return NotFound();
            return Ok(profile.ProfileToDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfile([FromBody] ProfileCreateDto profileCreateDto)
        {
            if (profileCreateDto == null)
                return BadRequest();

            var profileModel = profileCreateDto.ToProfileFromCreate();

        }
    }
}