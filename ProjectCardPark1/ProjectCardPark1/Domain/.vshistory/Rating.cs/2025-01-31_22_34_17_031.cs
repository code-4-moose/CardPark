namespace ProjectCardPark1.Domain
{
    public class Rating : BaseDomainModel
    {
        public int RatingId { get; set; } // PK 
        public string? Description { get; set; }        
        public double Stars { get; set; }
        public int UserId { get; set; } // FK
        public User? User { get; set; } // Nav Prop

        public string ReviewerName { get; set; }
    }
}
