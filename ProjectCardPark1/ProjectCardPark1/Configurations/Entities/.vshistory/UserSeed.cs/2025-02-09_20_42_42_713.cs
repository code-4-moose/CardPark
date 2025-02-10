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
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Name = "Admin",
                    Address = "Nil",
                    Contact = 889988123,
                    Stars = 0,
                    RatingId = 3,
                    ListingId = 1,
                    NoRatings = 0
                },
                new User
                {
                    Id = 2,
                    UserId = "4181efe7-66dc-47f0-860f-e506d04102e5",
                    Name = "Amos",
                    Address = "Nil",
                    Contact = 889988124,
                    Stars = 0,
                    RatingId = 4,
                    ListingId = 2,
                    NoRatings = 0
                },
                new User
                {
                    Id = 3,
                    UserId = "5181efe8-31de-47f0-860f-e514d04102e5",
                    Name = "David",
                    Address = "Nil",
                    Contact = 889988125,
                    Stars = 0,
                    RatingId = 5,
                    ListingId = 3,
                    NoRatings = 0
                }
            );
        }
    }
}
