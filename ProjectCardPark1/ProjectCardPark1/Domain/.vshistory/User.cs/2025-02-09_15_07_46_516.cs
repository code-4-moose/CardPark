namespace ProjectCardPark1.Domain
{
    public class User : BaseDomainModel
    {
        public string? UserId { get; set; } // PK  
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Contact { get; set; }
        public double Stars { get; set; }
        public int RatingId { get; set; } // FK
        public ICollection<Rating>? Rating { get; set; } // Nav Prop  0..Many

        public int ListingId { get; set; } // FK
        public List<Listing>? Listing { get; set; } // Nav Prop
        public byte[]? ProfileImage { get; set; }
        public string? ProfileImageUrl { get; set; }
        public int? NoRatings { get; set; }

        public List<Report>? Report { get; set; } // Nav Prop 
        
        public Payment? Payment { get; set; }
    }

}
 