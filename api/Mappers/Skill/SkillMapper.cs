
using api.Command;
using api.Command.SkillDto;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class SkillMapper
    {
        public static SkillDto SkillToDto(this Skill skill)
        {
            return new SkillDto
            {
                Id = skill.Id,
                Title = skill.Title,
                Description = skill.Description,
                User = skill.User.UserToDto()
            };
        }
        public static Skill ToSkillFromCreate(this CreateRequestSkillDto createRequestSkillDto)
        {
            return new Skill
            {
                Id = createRequestSkillDto.Id,
                Title = createRequestSkillDto.Title,
                Description = createRequestSkillDto.Description,
                MarkerForLevel = createRequestSkillDto.MarkerForLevel,
                UserId = createRequestSkillDto.UserId
            };
        }

    }
}