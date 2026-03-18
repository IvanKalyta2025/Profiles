using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Command;
using api.Command.SkillDto;
using api.Data;
using api.Dtos;
using api.Interfaces;
using api.Models;
using api.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace api.Repository
{
    public class SkiillRepository : ISkillRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SkiillRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Skill?> GetByIdAsync(int id)
        {
            return await _applicationDbContext.Skills
            .Include(i => i.User)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Skill> CreateAsync(Skill skill)
        {
            await _applicationDbContext.Skills.AddAsync(skill);
            await _applicationDbContext.SaveChangesAsync();

            await _applicationDbContext.Entry(skill)
                .Reference(i => i.User)
                .LoadAsync();
            return skill;
        }

        public async Task<Skill?> UpdateAsync(int id, UpdateRequestSkillDto updateRequestSkillDto)
        {
            var skillModel = await _applicationDbContext.Skills.FirstOrDefaultAsync(i => i.Id == id);
            if (skillModel == null)
                return null;

            skillModel.Title = updateRequestSkillDto.Title;
            skillModel.Description = updateRequestSkillDto.Description;

            await _applicationDbContext.SaveChangesAsync();
            return skillModel;

        }

    }
}