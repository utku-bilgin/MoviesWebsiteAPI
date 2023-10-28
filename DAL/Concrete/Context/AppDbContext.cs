using DAL.Concrete.Context.EntityTypeConfiguration;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MovieTypeConfiguration())
                        .ApplyConfiguration(new CategoryTypeConfiguration());
        }
    }
}
