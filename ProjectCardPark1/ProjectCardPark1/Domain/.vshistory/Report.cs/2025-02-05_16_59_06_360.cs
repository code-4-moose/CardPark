using Microsoft.EntityFrameworkCore;

namespace ProjectCardPark1.Domain
{
    public class Report : BaseDomainModel
    {
        public string Description { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public User User { get; set; } //Nav 

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Listing Listing { get; set; } //Nav 

        public int ListingId { get; set; } //FK

        public int UserId { get; set; } //FK 

    }
}
