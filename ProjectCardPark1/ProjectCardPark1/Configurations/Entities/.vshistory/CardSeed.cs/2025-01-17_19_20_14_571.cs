using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectCardPark1.Configurations.Entities
{
    public class CardSeed : IEntityTypeConfiguration<Card>
    {

        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
                new Card
                {
                    Id = 1,
                    CardId = 1,
                    Condition = "New",
                    Name = "Pokemon",
                    ListingId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Card
                {
                    Id = 2,
                    CardId = 2,
                    Condition = "Old",
                    Name = "Ultraman",
                    ListingId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Card
                {
                    Id = 3,
                    CardId = 3,
                    Condition = "Broken",
                    Name = "Wonderwoman",
                    ListingId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Card
                {
                    Id = 4,
                    CardId = 4,
                    Condition = "New",
                    ListingId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Card
                {Id = 5,
                    CardId = 5,
                    Condition = "Stolen",
                    Name = "Aquaman",
                    ListingId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
