using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;

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
            return await _applicationDbContex.Profiles.FindAsync(id);
        }

        public async Task<Profile> CreateAsync(Profile profile)
        {
            await _applicationDbContex.Profiles.AddAsync(profile);
            await _applicationDbContex.SaveChangesAsync();
            return profile;

        }
    }
}