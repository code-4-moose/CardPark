using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark1.Configurations.Entities;
using ProjectCardPark1.Data;
using ProjectCardPark1.Domain;

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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // For LocalDB
            // optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarRentalManagementConsoleapp_DB;Trusted_Connection=True;MultipleActiveResultSets=True;");

            // For SSMS: 
            optionsBuilder.UseSqlServer(@"Server=THAT-MATSURI-PC\SQLEXPRESS ;Database=ProjectCardPark1;Trusted_Connection=True;TrustServerCertificate=True;");
            // Note
            // Any changes of database name, u need to do migration again.

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AdminSeed());
            builder.ApplyConfiguration(new CardSeed());
            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new ListingSeed());
            builder.ApplyConfiguration(new RatingSeed());

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<User>()
                .Where(e => e.State == EntityState.Added)
                .ToList();

            // Save changes to generate the Id
            var result = await base.SaveChangesAsync(cancellationToken);

            // Save changes again to update UserId
            if (entries.Any())
            {
                await base.SaveChangesAsync(cancellationToken);
            }

            return result;
        }
    }
}
