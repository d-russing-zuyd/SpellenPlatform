using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpellenPlatform.Models;

namespace SpellenPlatform.Data
{
    public class SpellenPlatformDbContext : IdentityDbContext
    {
        public SpellenPlatformDbContext(DbContextOptions<SpellenPlatformDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}