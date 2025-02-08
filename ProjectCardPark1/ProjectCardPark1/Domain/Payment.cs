using Microsoft.EntityFrameworkCore;

namespace ProjectCardPark1.Domain
{
    public class Payment : BaseDomainModel
    {
        public Listing? Listing { get; set; } // Nav prop

        public int ListingId { get; set; } // FK

        public User? User { get; set; }

        public int? UserId { get; set; }

        public string? BuyerId { get; set; }

        public string? PaymentType { get; set; }

    }
}
