using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ProjectCardPark1.Domain
{
    public class Category : BaseDomainModel
    {
        public int CategoryId { get; set; } // PK
        public string? Name { get; set; }
        public string? Type { get; set; }

        public ICollection<Listing>? Listing { get; set; } // Nav Prop

    }
}
