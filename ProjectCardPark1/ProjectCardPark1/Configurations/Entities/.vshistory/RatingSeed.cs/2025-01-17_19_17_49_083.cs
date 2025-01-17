using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectCardPark1.Configurations.Entities
{
    public class RatingSeed : IEntityTypeConfiguration<Rating>
    {


        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
                new Rating
                {
                    RatingId = 1,
                    Description = "Beautify Card!",
                    Stars = 9.5,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Rating
                {
                    RatingId = 2,
                    Description = "Cards are damaged! Dishonesty!",
                    Stars =3.0,
                    UserId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Rating
                {
                    RatingId = 3,
                    Description = "Will Trade again!",
                    Stars = 8.0,
                    UserId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Rating
                {
                    RatingId = 4,
                    Description = "Will NOT Trade again! Shame!",
                    Stars = 1.0,
                    UserId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Rating
                {
                    RatingId = 5,
                    Description = "Great! Never been so good!",
                    Stars = 8.9,
                    UserId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Rating
                {
                    RatingId = 6,
                    Description = "Scary Trader!",
                    Stars = 0.0,
                    UserId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
