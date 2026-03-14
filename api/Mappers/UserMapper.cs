using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Dtos;
using api.Dtos.UserDto;
namespace api.Mappers
{
    public static class UserMapper
    {
        public static UserDto UserToDto(this User user)

        {
            return new UserDto
            {
                Id = user.Id
            };
        }
    }
}