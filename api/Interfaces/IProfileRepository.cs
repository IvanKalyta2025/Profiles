using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Dtos;

namespace api.Interfaces
{
    public interface IProfileRepository
    {
        Task<Profile?> GetByIdAsync(int id);
        Task<Profile> CreateAsync(Profile profile);
    }
}