using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectKard.Configurations.Entities
{
    public class ListingSeed : IEntityTypeConfiguration<Listing>
    {
        //public int ListingId { get; set; } // PK
        //public double Price { get; set; }
        //public int Amount { get; set; }
        //public int UserId { get; set; } // FK
        //public User User { get; set; } // Nav Prop
        //public int CategoryId { get; set; } // FK
        //[DeleteBehavior(DeleteBehavior.NoAction)]  // Meaning when parent deleted, this child will not be auto-deleted
        //public Category Category { get; set; } // Nav Prop
        //public int AdminId { get; set; } // FK
        //[DeleteBehavior(DeleteBehavior.NoAction)]  // Meaning when parent deleted, this child will not be auto-deleted
        //public Admin Admin { get; set; } // Nav Prop

        //public ICollection<Card> Card { get; set; } // Nav Prop  1..Many

        public void Configure(EntityTypeBuilder<Listing> builder)
        {
            builder.HasData(
                new Listing
                {
                    ListingId = 1,
                    Price = 5.21,
                    Amount = 100,
                    UserId = 1,
                    CategoryId = 1,
                    AdminId = 1
                },
                new Listing
                {
                    ListingId = 2,
                    Price = 1000.1,
                    Amount = 20,
                    UserId = 1,
                    CategoryId = 2,
                    AdminId = 1
                },
                new Listing
                {
                    ListingId = 3,
                    Price = 55.6,
                    Amount = 10,
                    UserId = 1,
                    CategoryId = 3,
                    AdminId = 1
                },
                new Listing
                {
                    ListingId = 4,
                    Price = 23.4,
                    Amount = 8,
                    UserId = 2,
                    CategoryId = 2,
                    AdminId = 1
                }
            );
        }
    }
}
