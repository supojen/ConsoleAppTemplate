using Microsoft.EntityFrameworkCore;

namespace Plantsist.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts): base(opts){}

        public DbSet<User> Users { get; set; }

    }
}