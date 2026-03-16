using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Command.UserDto
{
    public class UserCreateDto
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}