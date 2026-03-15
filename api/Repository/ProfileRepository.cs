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
    public class ProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext _applicationDbContex;

        public ProfileRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContex = applicationDbContext;
        }

        public async Task<Profile?> GetByIdAsync(int id) //профиль в базе должен быть, так что он не может быть ноль.
        {
            return await _applicationDbContex.Profiles
            .Include(p => p.User)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Profile> CreateAsync(Profile profile)
        {
            await _applicationDbContex.Profiles.AddAsync(profile);
            await _applicationDbContex.SaveChangesAsync();
            return profile;
        }
    }
}