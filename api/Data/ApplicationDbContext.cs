
using api.Models;
using Microsoft.EntityFrameworkCore;


namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

    }
}
