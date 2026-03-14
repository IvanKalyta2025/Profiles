using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Dtos;

namespace api.Interfaces
{
    public class IProfileRepository
    {
        Task<Profile> GetbyAsync(int id);
        Task<Profile> CreateAsync(Profile profile);
    }
}