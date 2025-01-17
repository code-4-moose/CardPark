using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark1.Domain;

namespace ProjectCardPark1.Data
{
    public class ProjectCardPark1Context : DbContext
    {
        public ProjectCardPark1Context (DbContextOptions<ProjectCardPark1Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectCardPark1.Domain.Admin> Admin { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Card> Card { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Category> Category { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Listing> Listing { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.Rating> Rating { get; set; } = default!;
        public DbSet<ProjectCardPark1.Domain.User> User { get; set; } = default!;
    }
}
