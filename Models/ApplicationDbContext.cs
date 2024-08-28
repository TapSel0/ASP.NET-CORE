using Microsoft.EntityFrameworkCore;

namespace asp_gpt.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)"); // Замените "nvarchar(max)" на "varchar(255)" или "text"

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18,2)");

                entity.HasKey(e => e.Id);

                entity.ToTable("Cars");
            });
        }


    }
}
