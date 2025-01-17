using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark1.Data;

namespace ProjectCardPark1.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<ProjectCardPark1User>(options)
    {
    }
}
