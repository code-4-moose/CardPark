
using Microsoft.EntityFrameworkCore;

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
        [DeleteBehavior(DeleteBehavior.NoAction)]  // Meaning when parent deleted, this child will not be auto-deleted

        public Category? Category { get; set; } // Nav Prop
        public int AdminId { get; set; } // FK
        [DeleteBehavior(DeleteBehavior.NoAction)]  // Meaning when parent deleted, this child will not be auto-deleted

        public Admin? Admin{ get; set; } // Nav Prop

        public ICollection<Card>? Card { get; set; } // Nav Prop  1..Many

        public byte[]? ListingImage { get; set; }

        public string? ListingImageUrl { get; set; }

        public string? ListingStatus {  get; set; } //Listing if its sold or not

        public string? Name { get; set; }

        public string? Description { get; set; }
        
        public string? UserName { get; set; }

        public string? CategoryName { get; set; }
    }
}
