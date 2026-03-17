using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}