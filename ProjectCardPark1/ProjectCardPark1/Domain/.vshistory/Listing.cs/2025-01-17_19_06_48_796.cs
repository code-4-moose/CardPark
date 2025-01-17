
namespace ProjectCardPark1.Domain
{
    public class Listing : BaseDomainModel
    {
        public int ListingId { get; set; } // PK
        public double Price { get; set; }
        public int Amount { get; set; }
        
        public int UserId { get; set; } // FK
        public User? User { get; set; } // Nav Prop

        public int CategoryId { get; set; } // FK
        public Category? Category { get; set; } // Nav Prop
        public int AdminId { get; set; } // FK
        public Admin? Admin{ get; set; } // Nav Prop

        public ICollection<Card>? Card { get; set; } // Nav Prop  1..Many
    }
}
