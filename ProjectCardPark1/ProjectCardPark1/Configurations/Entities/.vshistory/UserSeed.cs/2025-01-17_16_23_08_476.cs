using ProjectKard.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectKard.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        //public int UserId { get; set; } // PK  
        //public string? Name { get; set; }
        //public string? Address { get; set; }
        //public int Contact { get; set; }
        //public double Stars { get; set; }
        //public int RatingId { get; set; } // FK
        //public ICollection<Rating> Rating { get; set; } // Nav Prop  0..Many
        //public int ListingId { get; set; } // FK
        //public ICollection<Listing> Listing { get; set; } // Nav Prop

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    UserId = 1,
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 889988123,
                    Stars = 9.5,
                    RatingId = 3,
                    ListingId = 1
                },
                new User
                {
                    UserId = 2,
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 889966000,
                    Stars = 9.5,
                    RatingId = 3,
                    ListingId = 2
                },
                new User
                {
                    UserId = 3,
                    Name = "Beautify Card!",
                    Address = "Beautify Card!",
                    Contact = 779966111,
                    Stars = 8.5,
                    RatingId = 4,
                    ListingId = 3
                },
                new User
                {
                    UserId = 4,
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
