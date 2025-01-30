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
                    ListingId = 1
                }
            );
        }
    }
}
