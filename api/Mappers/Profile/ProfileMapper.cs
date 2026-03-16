using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class ProfileMapper
    {
        public static ProfileDto ProfileToDto(this Profile profile)
        {
            return new ProfileDto
            {
                Id = profile.Id,
                Name = profile.Name,
                LastName = profile.LastName,
                Age = profile.Age,
                Skills = profile.Skills,
                Application = profile.Application,
                User = profile.User.UserToDto()
            };
        }
        public static Profile ToProfileFromCreate(this ProfileCreateDto profileCreateDto)
        {
            return new Profile
            {
                Name = profileCreateDto.Name,
                LastName = profileCreateDto.LastName,
                Age = profileCreateDto.Age,
                Skills = profileCreateDto.Skills,
                Application = profileCreateDto.Application,
                Gender = profileCreateDto.Gender,
                UserId = profileCreateDto.UserId
            };
        }
    }
}
