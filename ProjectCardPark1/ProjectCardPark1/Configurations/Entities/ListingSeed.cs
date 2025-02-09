using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCardPark1.Components.Pages;
using ProjectCardPark1.Domain;

namespace ProjectCardPark1.Configurations.Entities
{
    public class ListingSeed : IEntityTypeConfiguration<Listing>
    {
        public void Configure(EntityTypeBuilder<Listing> builder)
        {
                builder.HasData(
                new Listing
                {
                    Id = 1,
                    ListingId = 3,
                    Price = 3,
                    Amount = 1,
                    UserId = 3,
                    CategoryId = 3,
                    ListingImageUrl = "/Card_Images/Card_1.png",
                    Name = "Suisei OSR",
                    Description = "Suisei Oshi Card",
                    UserName = "David",
                    CategoryName = "Hololive",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "5181efe8-31de-47f0-860f-e514d04102e5",
                    UpdatedBy = "5181efe8-31de-47f0-860f-e514d04102e5"
                },
                new Listing
                {
                    Id = 2,
                    ListingId = 3,
                    Price = 1,
                    Amount = 3,
                    UserId = 3,
                    CategoryId = 3,
                    ListingImageUrl = "/Card_Images/Card_2.png",
                    Name = "Ina Card",
                    Description = "Ina Card WAH!",
                    UserName = "David",
                    CategoryName = "Hololive",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "5181efe8-31de-47f0-860f-e514d04102e5",
                    UpdatedBy = "5181efe8-31de-47f0-860f-e514d04102e5"
                },
                new Listing
                {
                    Id = 3,
                    ListingId = 3,
                    Price = 350,
                    Amount = 1,
                    UserId = 2,
                    CategoryId = 3,
                    ListingImageUrl = "/Card_Images/Card_3.png",
                    Name = "Kiara Oshi Card",
                    Description = "Kiara Rare Card!!!",
                    UserName = "Amos",
                    CategoryName = "Hololive",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "4181efe7-66dc-47f0-860f-e506d04102e5",
                    UpdatedBy = "4181efe7-66dc-47f0-860f-e506d04102e5"
                },
                new Listing
                {
                    Id = 4,
                    ListingId = 2,
                    Price = 10,
                    Amount = 5,
                    UserId = 2,
                    CategoryId = 2,
                    ListingImageUrl = "/Card_Images/Card_4.png",
                    Name = "Eevee Card",
                    Description = "Its an Eevee",
                    UserName = "Amos",
                    CategoryName = "Pokemon",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "4181efe7-66dc-47f0-860f-e506d04102e5",
                    UpdatedBy = "4181efe7-66dc-47f0-860f-e506d04102e5"
                },
                new Listing
                {
                    Id = 5,
                    ListingId = 5,
                    Price = 30,
                    Amount = 1,
                    UserId = 3,
                    CategoryId = 1,
                    ListingImageUrl = "/Card_Images/Card_5.png",
                    Name = "YOUTHBERK",
                    Description = "YOUTHBERK",
                    UserName = "David",
                    CategoryName = "Vanguard",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "5181efe8-31de-47f0-860f-e514d04102e5",
                    UpdatedBy = "5181efe8-31de-47f0-860f-e514d04102e5"
                },
                new Listing
                {
                    Id = 6,
                    ListingId = 6,
                    Price = 5,
                    Amount = 2,
                    UserId = 2,
                    CategoryId = 1,
                    ListingImageUrl = "/Card_Images/Card_6.png",
                    Name = "Shojodoji",
                    Description = "Shojodoji dojo yo",
                    UserName = "Amos",
                    CategoryName = "Vanguard",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "4181efe7-66dc-47f0-860f-e506d04102e5",
                    UpdatedBy = "4181efe7-66dc-47f0-860f-e506d04102e5"
                }
            );
        }
    }
}
