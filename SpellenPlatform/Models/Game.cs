using Microsoft.EntityFrameworkCore;
using System;
namespace SpellenPlatform.Models
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }

}
