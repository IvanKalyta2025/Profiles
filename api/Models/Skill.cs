using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public Guid IdForProfile { get; set; }

        [ForeignKey(nameof(IdForProfile))]
        public User User { get; set; } = null!;

    }
}