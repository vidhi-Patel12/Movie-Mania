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
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieCinema> MovieCinema { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<MovieLanguage> MovieLanguage { get; set; }
        public DbSet<MovieFormat> MovieFormat { get; set; }
        public DbSet<Screen> Screen { get; set; }
        public DbSet<SeatType> SeatType { get; set; }
        public DbSet<ScreenSeats> ScreenSeats { get; set; }
        public DbSet<MovieScreen> MovieScreen { get; set; }

        //public DbSet<Price> Prices { get; set; }
    }
}
