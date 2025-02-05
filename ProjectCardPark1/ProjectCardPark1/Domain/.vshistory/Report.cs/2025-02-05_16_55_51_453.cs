using Microsoft.EntityFrameworkCore;

namespace ProjectCardPark1.Domain
{
    public class Report : BaseDomainModel
    {
        public string Description { get; set; }
        public User User { get; set; } //Nav 
        public Listing Listing { get; set; } //Nav 

        public int ListingId { get; set; } //FK
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public int UserId { get; set; } //FK 
        [DeleteBehavior(DeleteBehavior.NoAction)]

    }
}
