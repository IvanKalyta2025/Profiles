using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Data;
using api.Interfaces;

namespace api.Controller
{
    [ApiController]
    [Route("/api/skill")]
    public class SkillConrtoller : ControllerBase
    {
        private readonly IUserRepository _userRepo;


        public UserController(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

    }
}