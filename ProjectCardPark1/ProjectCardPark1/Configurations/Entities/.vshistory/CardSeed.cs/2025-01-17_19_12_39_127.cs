using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectKard.Configurations.Entities
{
    public class CardSeed : IEntityTypeConfiguration<Card>
    {
        //public int CardId { get; set; } // PK
        //public string? Condition { get; set; }
        //public string? Name { get; set; }
        //public int ListingId { get; set; } // FK
        //public Listing? Listing { get; set; } // Nav Prop
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
                new Card
                {
                    CardId = 1,
                    Condition = "New",
                    Name = "Pokemon",
                    ListingId = 1
                },
                new Card
                {
                    CardId = 2,
                    Condition = "Old",
                    Name = "Ultraman",
                    ListingId = 1
                },
                new Card
                {
                    CardId = 3,
                    Condition = "Broken",
                    Name = "Wonderwoman",
                    ListingId = 2
                },
                new Card
                {
                    CardId = 4,
                    Condition = "New",
                    ListingId = 3
                },
                new Card
                {
                    CardId = 5,
                    Condition = "Stolen",
                    Name = "Aquaman",
                    ListingId = 3
                }
            );
        }
    }
}
