namespace ProjectCardPark1.Domain
{
    public class Admin : BaseDomainModel
    {
        public int AdminId { get; set; } // PK
        public string? Name { get; set; }
        public int Contact { get; set; }
        public ICollection<Category>? Category { get; set; } // Nav Prop
        public ICollection<Listing>? Listing { get; set; } // Nav Prop

    } 
}
