using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Data;
using api.Interfaces;
using api.Mappers;
using api.Command;

namespace api.Controller
{
    [ApiController]
    [Route("/api/skills")]
    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _skillRepo;


        public SkillController(ISkillRepository skillRepository)
        {
            _skillRepo = skillRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetIdAsync([FromRoute] int id)
        {
            var skillBlock = await _skillRepo.GetByIdAsync(id);
            if (skillBlock == null)
                return NotFound();

            return Ok(skillBlock.SkillToDto());
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateSkillAsync([FromBody] CreateRequestSkillDto createRequestSkillDto)

        {
            if (createRequestSkillDto == null)
                return NotFound();

            var skillBlock = createRequestSkillDto.ToSkillFromCreate();
            await _skillRepo.CreateAsync(skillBlock);

            return CreatedAtAction(nameof(GetIdAsync), new { id = skillBlock.Id }, skillBlock.SkillToDto());
        }
    }
}