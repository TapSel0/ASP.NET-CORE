using Microsoft.EntityFrameworkCore;

namespace asp_gpt.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cars> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
