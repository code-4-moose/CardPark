using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ProjectKard.Domain
{
    public class Category : BaseDomainModel
    {
        public int CategoryId { get; set; } // PK
        public string? Name { get; set; }
        public string? Type { get; set; }

        public int AdminId { get; set; } // FK
        [DeleteBehavior(DeleteBehavior.NoAction)]  // Meaning when parent deleted, this child will not be auto-deleted
        public Admin? Admin { get; set; } // Nav Prop


        public ICollection<Listing>? Listing { get; set; } // Nav Prop

    }
}
