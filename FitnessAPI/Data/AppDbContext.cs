using FitnessAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessAPI.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activitys { get; set; }
    }
}
