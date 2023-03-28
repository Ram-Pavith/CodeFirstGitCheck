using Microsoft.EntityFrameworkCore;

namespace CodeFirstGitCheck.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LJOJLTJ\\SQLEXPRESS;Database=CodeFirstSample;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                new User { Id = 1, Name = "Pavith", Age = 10 },
                new User { Id = 2, Name = "Avinash", Age = 20 },
                new User { Id = 3, Name = "Bhavesh", Age = 10 },
                new User { Id = 4, Name = "Mohana", Age = 10 },
                new User { Id = 5, Name = "Aran", Age = 10 }

                );
            modelBuilder.Entity<Location>()
                .HasData(
                new Location { Id = 1, LocationName = "Chennai"},
                new Location { Id = 2, LocationName = "Chennai" },
                new Location { Id = 3, LocationName = "Chennai" },
                new Location { Id = 4, LocationName = "Chennai" }
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }  
    }
}
