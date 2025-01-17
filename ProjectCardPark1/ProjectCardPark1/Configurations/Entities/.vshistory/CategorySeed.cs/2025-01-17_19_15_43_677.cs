using ProjectCardPark1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjectCardPark1.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "PG",
                    Type = "unknown",
                    AdminId = 1
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "PG",
                    Type = "unknown",
                    AdminId = 1
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "R18",
                    Type = "WhoKnows",
                    AdminId = 1
                }
            );
        }
    }
}
