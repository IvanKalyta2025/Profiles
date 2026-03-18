using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public enum Level
    {
        Low,
        Medium,
        Hight
    }
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Level MarkerForLevel { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;
        public Guid UserId { get; set; }
    }
}
