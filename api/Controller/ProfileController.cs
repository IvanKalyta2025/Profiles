using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Dtos;
using api.Mappers;
using api.Models;
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
        public async Task<IActionResult> CreateProfile([FromBody] ProfileDto profileDto)
        {
            if (profileDto == null)
            {
                return BadRequest();
            }

        }
    }
}