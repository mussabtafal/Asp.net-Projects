using DOTNET_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_RPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        
        public DbSet<Skill> Skills { get; set; }
    }
}