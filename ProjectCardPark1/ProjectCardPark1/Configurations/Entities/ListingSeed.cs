//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using ProjectCardPark1.Components.Pages;
//using ProjectCardPark1.Domain;

//namespace ProjectCardPark1.Configurations.Entities
//{
//    public class ListingSeed : IEntityTypeConfiguration<Listing>
//    {
//        public void Configure(EntityTypeBuilder<Listing> builder)
//        {
//                builder.HasData(
//                new Listing
//                {
//                    Id = 1,
//                    ListingId = 3,
//                    Price = 3,
//                    Amount = 1,
//                    UserId = 3,
//                    CategoryId = 3,
//                    Name = "Suisei OSR",
//                    Description = "Suisei Oshi Card",
//                    UserName = "David Lee",
//                    CategoryName = "Hololive",
//                    DateCreated = DateTime.Now,
//                    DateUpdated = DateTime.Now,
//                    CreatedBy = "5181efe8-31de-47f0-860f-e514d04102e5",
//                    UpdatedBy = "5181efe8-31de-47f0-860f-e514d04102e5"
//                }
//            );
//        }
//    }
//}
