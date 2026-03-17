using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Interfaces;
using api.Data;
using api.Models;
using api.Mappers;
using Microsoft.AspNetCore.Http.HttpResults;
using api.Command.UserDto;

namespace api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContex;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContex = applicationDbContext;
        }
        public async Task<User?> GetIdAsync(Guid id)
        {
            var userModel = await _applicationDbContex.Users.FirstOrDefaultAsync(i => i.Id == id);
            if (userModel == null)
                return null;

            return userModel;
        }
        public async Task<User> CreateAsync(User user)
        {
            await _applicationDbContex.Users.AddAsync(user);
            await _applicationDbContex.SaveChangesAsync();
            return user;
        }
        public async Task<User?> UpdateAsync(Guid id, UpdateRequestDtoUser updateRequestDtoUser)
        {
            var userModel = await _applicationDbContex.Users.FirstOrDefaultAsync(i => i.Id == id);
            if (userModel == null)
            {
                return null;
            }

            userModel.Login = updateRequestDtoUser.Login;
            userModel.Password = updateRequestDtoUser.Password;

            await _applicationDbContex.SaveChangesAsync();
            return userModel;
        }
        public async Task<User?> DeleteAsync(Guid id)
        {
            var userModel = await _applicationDbContex.Users.FirstOrDefaultAsync(i => i.Id == id);
            if (userModel == null)
                return null;
            _applicationDbContex.Users.Remove(userModel);
            await _applicationDbContex.SaveChangesAsync();
            return userModel;
        }
    }
}