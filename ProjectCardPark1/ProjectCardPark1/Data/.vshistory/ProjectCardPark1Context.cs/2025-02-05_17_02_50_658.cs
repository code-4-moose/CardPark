using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark1.Configurations.Entities;
using ProjectCardPark1.Data;
using ProjectCardPark1.Domain;
using System.Reflection.Emit;

namespace ProjectCardPark1.Data
{
    public class ProjectCardPark1Context(DbContextOptions<ProjectCardPark1Context> options) : IdentityDbContext<ProjectCardPark1User>(options)
    {
        public DbSet<ProjectCardPark1.Domain.Category> Category { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Listing> Listing { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Rating> Rating { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.User> User { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Report> Report { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // For LocalDB
            // optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarRentalManagementConsoleapp_DB;Trusted_Connection=True;MultipleActiveResultSets=True;");

            // For SSMS: 
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-JPNVKAR5\SQLEXPRESS;Database=ProjectCardPark1;Trusted_Connection=True;TrustServerCertificate=True;");
            // Note
            // Any changes of database name, u need to do migration again.
            // THAT-MATSURI-PC\SQLEXPRESS

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserLoginSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

            builder.Entity<Report>()
           .HasOne(r => r.User)
           .WithMany() // Assuming User has no navigation property back to Report
           .HasForeignKey(r => r.UserId)
           .OnDelete(DeleteBehavior.NoAction); // Configure delete behavior

            // Configure the relationship between Report and Listing
            builder.Entity<Report>()
                .HasOne(r => r.Listing)
                .WithMany() // Assuming Listing has no navigation property back to Report
                .HasForeignKey(r => r.ListingId)
                .OnDelete(DeleteBehavior.NoAction); // Configure delete behavior
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
