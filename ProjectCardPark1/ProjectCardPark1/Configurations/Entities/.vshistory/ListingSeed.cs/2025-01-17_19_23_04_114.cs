using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectCardPark1.Configurations.Entities
{
    public class ListingSeed : IEntityTypeConfiguration<Listing>
    {


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
                    AdminId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Listing
                {
                    ListingId = 2,
                    Price = 1000.1,
                    Amount = 20,
                    UserId = 1,
                    CategoryId = 2,
                    AdminId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Listing
                {
                    ListingId = 3,
                    Price = 55.6,
                    Amount = 10,
                    UserId = 1,
                    CategoryId = 3,
                    AdminId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Listing
                {
                    ListingId = 4,
                    Price = 23.4,
                    Amount = 8,
                    UserId = 2,
                    CategoryId = 2,
                    AdminId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
