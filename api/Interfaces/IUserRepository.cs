using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Command.UserDto;
using api.Models;

namespace api.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetIdAsync(Guid id);
        Task<User> CreateAsync(User user);
        Task<User?> DeleteAsync(Guid id);
        Task<User?> UpdateAsync(Guid id, UpdateRequestDtoUser updateRequestDtoUser);

    }
}