using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Interfaces;
using api.Data;
using api.Models;

namespace api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContex;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContex = applicationDbContext;
        }

        public async Task<User> CreateAsync(User user)
        {
            await _applicationDbContex.Users.AddAsync(user);
            await _applicationDbContex.SaveChangesAsync();
            return user;
        }
    }
}