using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectKard.Configurations.Entities
{
    public class AdminSeed : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(
                new Admin
                {
                    AdminId = 1,
                    Name = "SuperBoss",
                    Contact = 12345678
                } 
            );
        }
    }
}
