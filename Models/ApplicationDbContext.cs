using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstGitCheck.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() {}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QA4KGN2\\SQLEXPRESS;Database=CodeFirstSample;Trusted_Connection=True;");
            }
        }

        public DbSet<Employee> employees { get; set; }
    }
}
