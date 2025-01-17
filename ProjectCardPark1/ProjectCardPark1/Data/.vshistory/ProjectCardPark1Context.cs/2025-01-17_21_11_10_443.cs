using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark1.Configurations.Entities;
using ProjectCardPark1.Data;

namespace ProjectCardPark1.Data
{
    public class ProjectCardPark1Context(DbContextOptions<ProjectCardPark1Context> options) : IdentityDbContext<ProjectCardPark1User>(options)
    {
        public DbSet<ProjectCardPark1.Domain.Admin> Admin { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Card> Card { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Category> Category { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Listing> Listing { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Rating> Rating { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AdminSeed());
            builder.ApplyConfiguration(new CardSeed());
            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new ListingSeed());
            builder.ApplyConfiguration(new RatingSeed());

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserLoginSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
