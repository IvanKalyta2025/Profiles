using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public enum Gender
    {
        Man,
        Woman
    }
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Skills { get; set; } = string.Empty;
        public string Application { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public List<Vacancy> Vacancies { get; set; } = new();
        public Gender Gender { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;
        public Guid UserId { get; set; }

    }
}
