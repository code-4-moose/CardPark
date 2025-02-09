using ProjectCardPark1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectCardPark1.Configurations.Entities
{
    public class UserLoginSeed : IEntityTypeConfiguration<ProjectCardPark1User>
    {
        public void Configure(EntityTypeBuilder<ProjectCardPark1User> builder)
        {
            var hasher = new PasswordHasher<ProjectCardPark1User>();
            builder.HasData(
            new ProjectCardPark1User
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new ProjectCardPark1User
            {
                Id = "4181efe7-66dc-47f0-860f-e506d04102e5",
                Email = "amostan@gmail.com",
                NormalizedEmail = "AMOSTAN@GMAIL.COM",
                FirstName = "Amos",
                LastName = "Tan",
                UserName = "amostan@gmail.com",
                NormalizedUserName = "AMOSTAN@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new ProjectCardPark1User
            {
                Id = "5181efe8-31de-47f0-860f-e514d04102e5",
                Email = "davidlee@gmail.com",
                NormalizedEmail = "DAVIDLEE@GMAIL.COM",
                FirstName = "David",
                LastName = "Lee",
                UserName = "davidlee@gmail.com",
                NormalizedUserName = "DAVIDLEE@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}