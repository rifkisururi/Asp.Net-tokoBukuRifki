using Microsoft.EntityFrameworkCore;
using tokoBukuRifki.Models;

namespace tokoBukuRifki.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Category> Categories { get; set; }
    }
}
