using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectCardPark1.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserId = "1",
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 889988123,
                    Stars = 9.5,
                    RatingId = 3,
                    ListingId = 1
                },
                new User
                {
                    Id = 2,
                    UserId = "2",
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 889966000,
                    Stars = 9.5,
                    RatingId = 3,
                    ListingId = 2
                },
                new User
                {
                    Id = 3,
                    UserId = "3",
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 779966111,
                    Stars = 8.5,
                    RatingId = 4,
                    ListingId = 3
                },
                new User
                {
                    Id = 4,
                    UserId = "4",
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 339968881,
                    Stars = 5.5,
                    RatingId = 2,
                    ListingId = 4
                }
            );
        }
    }
}
