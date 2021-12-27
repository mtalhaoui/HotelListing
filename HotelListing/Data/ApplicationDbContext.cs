using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Belgium",
                    ShortName = "BE"
                },
                new Country
                {
                    Id = 2,
                    Name = "Morocco",
                    ShortName = "MA"
                },
                new Country
                {
                    Id = 3,
                    Name = "United Arab Emirates",
                    ShortName = "UAE"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel Ibis Antwerpen Centrum",
                    Address = "Antwerp",
                    CountryId = 1,
                    Rating = 3.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hilton Antwerp Old Town",
                    Address = "Antwerp",
                    CountryId = 1,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel Le Diwan",
                    Address = "Rabat",
                    CountryId = 2,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Four Seasons Hotel",
                    Address = "Casablanca",
                    CountryId = 2,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 5,
                    Name = "InterContinantal",
                    Address = "Abu Dhabi",
                    CountryId = 3,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Four Seasons Hotel",
                    Address = "Harbour",
                    CountryId = 3,
                    Rating = 4.7
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
