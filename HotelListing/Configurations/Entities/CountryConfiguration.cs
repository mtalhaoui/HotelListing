using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
