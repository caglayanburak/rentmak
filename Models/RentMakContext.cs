using Microsoft.EntityFrameworkCore;

namespace rentmakapi.Models
{
    public class RentMakContext : DbContext
    {
        public RentMakContext(DbContextOptions<RentMakContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

    }
}