namespace ProjectKard.Domain
{
    public class Card :BaseDomainModel // Changed to Card instead of Cards
    {
        public int CardId { get; set; } // PK
        public string? Condition { get; set; }
        public string? Name { get; set; }
        public int ListingId { get; set; } // FK
        public Listing? Listing { get; set; } // Nav Prop

    }
}
