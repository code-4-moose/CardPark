namespace ProjectCardPark1.Domain
{
    public class Report : BaseDomainModel
    {
        public string Description { get; set; }
        public List<User>? User { get; set; } //Nav 
        public List<Listing>? Listing { get; set; } //Nav 

        public int ListingId { get; set; } //FK

        public int UserId { get; set; } //FK 
    }
}
