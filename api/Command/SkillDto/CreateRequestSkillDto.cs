using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Command
{
    public class CreateRequestSkillDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Level MarkerForLevel { get; set; }
        public Guid UserId { get; set; }
    }
}