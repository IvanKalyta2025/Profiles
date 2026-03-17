using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Command.SkillDto;
using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ISkillRepository
    {
        Task<Skill?> GetByIdAsync(int id);
        Task<Skill> CreateAsync(SkillDto skillDto);
        Task<Skill?> UpdateByAsync(int id, UpdateRequestSkillDto updateRequestSkillDto);
    }
}