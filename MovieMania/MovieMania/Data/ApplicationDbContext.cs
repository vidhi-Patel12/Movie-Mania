using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieMania.Models;

namespace MovieMania.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Languages> Languages { get; set; } 
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Formats> Formats { get; set; }
        public DbSet<Country> Country { get; set; } 
        public DbSet<State> State { get; set; } 
        public DbSet<City> City { get; set; } 
    }
}
